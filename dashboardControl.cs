﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RECOMANAGESYS.loginform;

namespace RECOMANAGESYS
{
    public partial class dashboardControl : UserControl
    {
        public dashboardControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            lvVisitor.ItemActivate -= lvVisitor_ItemActivate;
            lvVisitor.ItemActivate += lvVisitor_ItemActivate;
            NotificationManager.NotificationsUpdated += () =>
            {
                lblNotifCount.Text = NotificationManager.Notifications.Count(n => n.IsUnread).ToString();
                lblNotifCount.Visible = NotificationManager.Notifications.Any(n => n.IsUnread);
            };
            lblNotifCount.BackColor = Color.Red;
            lblNotifCount.ForeColor = Color.White;
            lblNotifCount.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lblNotifCount.TextAlign = ContentAlignment.MiddleCenter;
            lblNotifCount.AutoSize = false;
            lblNotifCount.Width = 18;
            lblNotifCount.Height = 18;
            lblNotifCount.Visible = false;
            ToolTip tip = new ToolTip();
            tip.SetToolTip(lblNextDay1, "View Garbage Collection Schedule");
            tip.SetToolTip(lblNextDay2, "View Garbage Collection Schedule");
        }

        private ToolTip lvToolTip = new ToolTip();
        public void RefreshData()
        {
            LoadDashboardAnnouncements();
            UpdateVisitorDashboard();
            LoadScheduledEvents();
            LoadNextGarbageSchedules();
            NotificationManager.Reload();
        }

        private void dashboardControl_Load(object sender, EventArgs e)
        {
            // Date and Time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMM dd yyyy | hh:mm tt");

            // Dynamic Greeting
            int hour = DateTime.Now.Hour;
            string greeting;

            if (hour < 12)
                greeting = "Good Morning";
            else if (hour < 18)
                greeting = "Good Afternoon";
            else
                greeting = "Good Evening";

            string firstName = CurrentUser.FullName.Split(' ')[0];
            lblGreeting.Text = $"{greeting}, {firstName}!";
            LoadDashboardAnnouncements();
            UpdateVisitorDashboard();
            LoadScheduledEvents();
            LoadNextGarbageSchedules();
            NotificationManager.Reload();
            lblNextDay1.Click += lblNextDay_Click;
            lblNextDay2.Click += lblNextDay_Click;
            lblNextDay1.Cursor = Cursors.Hand;
            lblNextDay2.Cursor = Cursors.Hand;
        }
        private void LoadDashboardAnnouncements()
        {
            panelQuickAnnouncements.Controls.Clear();
            Random rnd = new Random(); // for slight rotation

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT TOP 8 Id, Title, Message, DatePosted, IsImportant
            FROM Announcements
            WHERE ExpirationDate IS NULL OR ExpirationDate >= GETDATE()
            ORDER BY 
                CASE WHEN IsImportant = 1 THEN 0 ELSE 1 END,
                DatePosted DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int x = 10;
                    int y = 10;
                    int count = 0;
                    int noteSize = 235;
                    int spacing = 20;

                    while (reader.Read())
                    {
                        bool isImportant = reader["IsImportant"] != DBNull.Value && Convert.ToBoolean(reader["IsImportant"]);

                        // Store values before attaching events
                        string noteTitle = reader["Title"].ToString();
                        string noteMessage = reader["Message"].ToString();

                        Panel note = new Panel();
                        note.Width = noteSize;
                        note.Height = noteSize;
                        note.Left = x;
                        note.Top = y;
                        note.BackColor = isImportant ? Color.FromArgb(255, 250, 210) : Color.FromArgb(204, 229, 255);
                        note.BorderStyle = BorderStyle.FixedSingle;

                        // Rounded corners
                        note.Region = System.Drawing.Region.FromHrgn(
                            CreateRoundRectRgn(0, 0, note.Width, note.Height, 15, 15)
                        );

                        // Slight random rotation
                        float angle = rnd.Next(-5, 6);
                        note.Paint += (s, e) =>
                        {
                            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            e.Graphics.TranslateTransform(note.Width / 2, note.Height / 2);
                            e.Graphics.RotateTransform(angle);
                            e.Graphics.TranslateTransform(-note.Width / 2, -note.Height / 2);
                        };

                        // Labels
                        Label lblTitle = new Label();
                        lblTitle.Text = (isImportant ? "⚠️ " : "") + noteTitle;
                        lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        lblTitle.AutoSize = false;
                        lblTitle.Width = note.Width - 20;
                        lblTitle.Height = 35;
                        lblTitle.Location = new Point(10, 10);
                        lblTitle.ForeColor = isImportant ? Color.Red : Color.Black;

                        Label lblMsg = new Label();
                        lblMsg.Text = noteMessage;
                        lblMsg.Font = new Font("Segoe UI", 9);
                        lblMsg.AutoSize = false;
                        lblMsg.Width = note.Width - 20;
                        lblMsg.Height = 130;
                        lblMsg.Location = new Point(10, 50);
                        lblMsg.ForeColor = Color.FromArgb(60, 60, 60);

                        note.Controls.Add(lblTitle);
                        note.Controls.Add(lblMsg);
                        panelQuickAnnouncements.Controls.Add(note);

                        // Tooltip for important notes
                        if (isImportant)
                        {
                            ToolTip noteToolTip = new ToolTip();
                            noteToolTip.AutoPopDelay = 5000;
                            noteToolTip.InitialDelay = 500;
                            noteToolTip.ReshowDelay = 200;
                            noteToolTip.ShowAlways = true;

                            noteToolTip.SetToolTip(note, "Important Announcement!");
                            foreach (Control ctrl in note.Controls)
                                noteToolTip.SetToolTip(ctrl, "Important Announcement!");
                        }

                        // Click events
                        note.Cursor = Cursors.Hand;
                        note.Click += (s, e) =>
                        {
                            AnnouncementViewForm viewForm = new AnnouncementViewForm(
                                noteTitle,
                                noteMessage,
                                isImportant
                            );
                            viewForm.StartPosition = FormStartPosition.CenterScreen;
                            viewForm.ShowDialog();
                        };

                        foreach (Control ctrl in note.Controls)
                        {
                            ctrl.Cursor = Cursors.Hand;
                            ctrl.Click += (s, e) =>
                            {
                                AnnouncementViewForm viewForm = new AnnouncementViewForm(
                                    noteTitle,
                                    noteMessage,
                                    isImportant
                                );
                                viewForm.StartPosition = FormStartPosition.CenterScreen;
                                viewForm.ShowDialog();
                            };
                        }

                        // Positioning
                        count++;
                        if (count % 4 == 0)
                        {
                            x = 10;
                            y += note.Height + spacing;
                        }
                        else
                        {
                            x += note.Width + spacing;
                        }
                    }
                }
            }
        }
        public void RefreshAnnouncements()
        {
            LoadDashboardAnnouncements();
            NotificationManager.Reload();
        }

        // Helper for rounded corners
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        private void UpdateVisitorDashboard()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string countQuery = "SELECT COUNT(*) FROM TBL_VisitorsLog WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE)";
                int todayCount = (int)new SqlCommand(countQuery, conn).ExecuteScalar();

                lblTodayVisitors.Text = todayCount > 0 ? todayCount.ToString() : "0";
                lvVisitor.Items.Clear();
                lvVisitor.Columns.Clear();

                if (todayCount > 0)
                {
                    string latestQuery = @"
                SELECT TOP 2 VisitorName, VisitPurpose
                FROM TBL_VisitorsLog
                WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE)
                ORDER BY VisitorID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(latestQuery, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lvVisitor.View = View.Details;
                    lvVisitor.FullRowSelect = true;
                    lvVisitor.GridLines = true;
                    lvVisitor.Columns.Add("Name", 150);
                    lvVisitor.Columns.Add("Purpose", 200);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(row["VisitorName"]));
                        item.SubItems.Add(Convert.ToString(row["VisitPurpose"]));
                        lvVisitor.Items.Add(item);
                    }
                    lvVisitor.MouseMove -= LvVisitor_MouseMove;
                    lvVisitor.MouseMove += LvVisitor_MouseMove;
                }
            }
        }
        private void LvVisitor_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvVisitor.HitTest(e.Location);
            if (info.Item != null)
            {
                for (int i = 0; i < info.Item.SubItems.Count; i++)
                {
                    Rectangle cellBounds = info.Item.SubItems[i].Bounds;
                    string text = info.Item.SubItems[i].Text;
                    Size textSize = TextRenderer.MeasureText(text, lvVisitor.Font);

                    if (textSize.Width > cellBounds.Width)
                    {
                        lvToolTip.SetToolTip(lvVisitor, text);
                        return;
                    }
                }
            }
            lvToolTip.Hide(lvVisitor);
        }

        private void lvVisitor_ItemActivate(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm is dashboard dash)
            {
                dash.btnVisitorlog_Click(this, EventArgs.Empty);
            }
        }
        private void addvisitor_Click(object sender, EventArgs e)
        {
            addvisitor visitorForm = new addvisitor();

            visitorForm.VisitorAdded += (s, args) =>
            {
                UpdateVisitorDashboard(); // refresh listview automatically
            };

            visitorForm.ShowDialog();
        }
        private void LoadScheduledEvents(int maxEvents = 4)
        {
            panelSchedule.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(8, 5, 8, 8)
            };
            panelSchedule.Controls.Add(flow);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = $@"
            SELECT TOP {maxEvents} EventId, EventName, Venue, StartDateTime, EndDateTime
            FROM Events
            WHERE CAST(StartDateTime AS DATE) >= CAST(GETDATE() AS DATE)
            ORDER BY StartDateTime";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Label noEvent = new Label
                        {
                            Text = "No upcoming events",
                            Font = new Font("Segoe UI", 9, FontStyle.Italic),
                            ForeColor = Color.Gray,
                            AutoSize = true
                        };
                        flow.Controls.Add(noEvent);
                        return;
                    }

                    DateTime today = DateTime.Today;
                    bool todayShown = false, tomorrowShown = false, upcomingShown = false;

                    while (reader.Read())
                    {
                        int eventId = Convert.ToInt32(reader["EventId"]);
                        string title = reader["EventName"].ToString();
                        string location = reader["Venue"].ToString();
                        DateTime start = Convert.ToDateTime(reader["StartDateTime"]);
                        DateTime end = Convert.ToDateTime(reader["EndDateTime"]);
                        string timeRange = $"{start:hh:mm tt}–{end:hh:mm tt}";
                        DateTime date = start.Date;

                        // Category header
                        if (date == today && !todayShown)
                        {
                            flow.Controls.Add(CreateCategoryLabel("Today"));
                            todayShown = true;
                        }
                        else if (date == today.AddDays(1) && !tomorrowShown)
                        {
                            flow.Controls.Add(CreateCategoryLabel("Tomorrow"));
                            tomorrowShown = true;
                        }
                        else if (date > today.AddDays(1) && !upcomingShown)
                        {
                            flow.Controls.Add(CreateCategoryLabel("Upcoming"));
                            upcomingShown = true;
                        }

                        // Event panel
                        Panel eventPanel = new Panel
                        {
                            AutoSize = true,
                            BackColor = Color.FromArgb(240, 248, 255),
                            Padding = new Padding(8),
                            Margin = new Padding(5, 2, 5, 2),
                            Cursor = Cursors.Hand,
                            Tag = eventId
                        };

                        Label lblEvent = new Label
                        {
                            Text = $"- {title} ({location}, {timeRange})",
                            Font = new Font("Segoe UI", 9),
                            ForeColor = Color.FromArgb(50, 50, 50),
                            AutoSize = true,
                            Cursor = Cursors.Hand
                        };

                        // ✅ Add tooltip for event label
                        ToolTip eventTip = new ToolTip();
                        eventTip.AutoPopDelay = 5000;
                        eventTip.InitialDelay = 500;
                        eventTip.ReshowDelay = 200;
                        eventTip.ShowAlways = true;
                        eventTip.SetToolTip(lblEvent, "View Event Schedule");

                        int capturedEventId = eventId;

                        EventHandler clickHandler = (s, e) =>
                        {
                            Form parentForm = this.FindForm();
                            if (parentForm is dashboard dash)
                            {
                                dash.btnScheduling_Click(this, EventArgs.Empty);

                                var schedulingControl = dash.Controls
                                    .OfType<scheduling>()
                                    .FirstOrDefault();

                                if (schedulingControl != null)
                                {
                                    schedulingControl.ShowEventsTab();
                                }
                                else
                                {
                                    foreach (Control c in dash.Controls)
                                    {
                                        var sched = c.Controls.OfType<scheduling>().FirstOrDefault();
                                        if (sched != null)
                                        {
                                            sched.ShowEventsTab();
                                            break;
                                        }
                                    }
                                }
                            }
                        };

                        eventPanel.Click += clickHandler;
                        lblEvent.Click += clickHandler;
                        eventPanel.MouseEnter += (s, e) => eventPanel.BackColor = Color.FromArgb(220, 235, 255);
                        eventPanel.MouseLeave += (s, e) => eventPanel.BackColor = Color.FromArgb(240, 248, 255);

                        eventPanel.Controls.Add(lblEvent);
                        flow.Controls.Add(eventPanel);
                    }
                }
            }
        }

        public void RefreshScheduledEvents()
        {
            LoadScheduledEvents(); // auto refresh
            NotificationManager.Reload();
        }

        // Helper for category headers
        private Label CreateCategoryLabel(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Padding = new Padding(3),
                Margin = new Padding(3, 8, 3, 2)
            };
        }
        private void LoadNextGarbageSchedules()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT CollectionDay, CAST(CollectionTime AS time) AS CollectionTime
                FROM GarbageCollectionSchedules
                WHERE Status = 1";

                    List<Tuple<string, TimeSpan, DateTime>> upcomingSchedules = new List<Tuple<string, TimeSpan, DateTime>>();
                    DateTime now = DateTime.Now;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string day = reader["CollectionDay"].ToString();
                                TimeSpan time = (TimeSpan)reader["CollectionTime"];

                                DayOfWeek scheduleDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                                int daysUntil = ((int)scheduleDay - (int)now.DayOfWeek + 7) % 7;
                                DateTime nextSchedule = now.Date.AddDays(daysUntil).Add(time);

                                if (nextSchedule < now)
                                    nextSchedule = nextSchedule.AddDays(7);

                                upcomingSchedules.Add(Tuple.Create(day, time, nextSchedule));
                            }
                        }
                    }

                    var sorted = upcomingSchedules.OrderBy(s => s.Item3).Take(2).ToList();

                    if (sorted.Count > 0)
                    {
                        lblNextDay1.Text = sorted[0].Item1;
                        lblNextTime1.Text = "Time: " + DateTime.Today.Add(sorted[0].Item2).ToString("hh:mm tt");
                    }
                    else
                    {
                        lblNextDay1.Text = "No upcoming";
                        lblNextTime1.Text = "collection";
                    }

                    if (sorted.Count > 1)
                    {
                        lblNextDay2.Text = sorted[1].Item1;
                        lblNextTime2.Text = "Time: " + DateTime.Today.Add(sorted[1].Item2).ToString("hh:mm tt");
                    }
                    else
                    {
                        lblNextDay2.Text = "No following";
                        lblNextTime2.Text = "collection";
                    }
                }
            }
            catch (Exception ex)
            {
                lblNextDay1.Text = "Error loading";
                lblNextTime1.Text = ex.Message;
                lblNextDay2.Text = "";
                lblNextTime2.Text = "";
            }
        }
        public void RefreshGarbageSchedule()
        {
            LoadNextGarbageSchedules(); // auto refresh
            NotificationManager.Reload();
        }

        private Form notifForm = null;

        private void btnNotif_Click(object sender, EventArgs e)
        {
            var notificationList = NotificationManager.Notifications;

            if (notificationList.Count == 0)
            {
                MessageBox.Show("No new notifications.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (notifForm != null && !notifForm.IsDisposed)
            {
                notifForm.Close();
                notifForm = null;
                return;
            }

            notifForm = new Form
            {
                Size = new Size(398, 400),
                StartPosition = FormStartPosition.Manual,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                BackColor = Color.LightSteelBlue,
                ControlBox = false
            };

            int offsetX = -350;
            notifForm.Location = btnNotif.PointToScreen(new Point(offsetX, btnNotif.Height));
            notifForm.Deactivate += (s, ev) =>
            {
                if (notifForm != null && !notifForm.IsDisposed)
                {
                    notifForm.FormClosed -= null;
                    notifForm.Close();
                    notifForm = null;
                }
            };

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(5)
            };

            foreach (var notif in notificationList)
            {
                Panel notifPanel = new Panel
                {
                    Size = new Size(350, 70),
                    BackColor = Color.FromArgb(245, 245, 245),
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand,
                    Tag = notif
                };

                PictureBox icon = new PictureBox
                {
                    Size = new Size(40, 40),
                    Location = new Point(10, 16),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                if (notif.type == "Announcement")
                    icon.Image = Properties.Resources.announcement_icon;
                else if (notif.type == "Event")
                    icon.Image = Properties.Resources.event_icon;
                else if (notif.type == "Garbage")
                    icon.Image = Properties.Resources.garbage_icon;
                else if (notif.type == "Backup")
                    icon.Image = Properties.Resources.backup_icon;
                else
                    icon.Image = Properties.Resources.default_icon;

                Label lblText = new Label
                {
                    Text = notif.message,
                    AutoSize = false,
                    Width = 300,
                    Height = 60,
                    Location = new Point(50, 0),
                    Font = new Font("Segoe UI", 9),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                notifPanel.Controls.Add(icon);
                notifPanel.Controls.Add(lblText);

                notifPanel.Click += (s, ev) =>
                {
                    NotificationManager.MarkAsRead(notif);

                    // Close the notification form safely
                    if (notifForm != null && !notifForm.IsDisposed)
                    {
                        notifForm.Close();
                        notifForm = null;
                    }

                    Form parentForm = this.FindForm();
                    if (parentForm is dashboard dash)
                    {
                        switch (notif.type)
                        {
                            case "Announcement":
                                dash.ShowAnnouncementForm();
                                break;

                            case "Event":
                                dash.OpenSchedulingTab("Event");
                                break;
                            case "Garbage":
                                dash.OpenSchedulingTab("Garbage");
                                break;
                        }
                    }

                    //Update red counter
                    int current = int.Parse(lblNotifCount.Text);
                    current = Math.Max(0, current - 1);
                    lblNotifCount.Text = current.ToString();
                    lblNotifCount.Visible = current > 0;
                };

                notifPanel.Tag = notif;
                // Click label/icon to trigger panel click
                lblText.Click += (s, ev) => NotifyPanel_ClickHandler(notifPanel);
                icon.Click += (s, ev) => NotifyPanel_ClickHandler(notifPanel);

                notifPanel.MouseEnter += (s, ev) => notifPanel.BackColor = Color.FromArgb(230, 240, 255);
                notifPanel.MouseLeave += (s, ev) => notifPanel.BackColor = Color.FromArgb(245, 245, 245);

                panel.Controls.Add(notifPanel);
            }

            notifForm.Controls.Add(panel);
            notifForm.FormClosed += (s, ev) => notifForm = null;
            notifForm.Show();
        }
        private void NotifyPanel_ClickHandler(Panel notifPanel)
        {
            var notif = (Notification)notifPanel.Tag;

            notifForm.Close();
            notifForm = null;

            Form parentForm = this.FindForm();
            if (parentForm is dashboard dash)
            {
                switch (notif.type)
                {
                    case "Announcement":
                        dash.ShowAnnouncementForm();
                        break;

                    case "Event":
                        dash.OpenSchedulingTab("Event");
                        break;
                    case "Garbage":
                        dash.OpenSchedulingTab("Garbage");
                        break;
                }
                NotificationManager.MarkAsRead(notif);
                int current = NotificationManager.Notifications.Count(n => n.IsUnread);
                lblNotifCount.Text = current.ToString();
                lblNotifCount.Visible = current > 0;
            }
        }



        private void lblNextDay_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm is dashboard dash)
            {
                dash.btnScheduling_Click(this, EventArgs.Empty);

                var schedulingControl = dash.Controls
                    .OfType<scheduling>()
                    .FirstOrDefault();

                if (schedulingControl != null)
                {
                    schedulingControl.ShowGarbageScheduleTab();
                }
                else
                {
                    foreach (Control c in dash.Controls)
                    {
                        var sched = c.Controls.OfType<scheduling>().FirstOrDefault();
                        if (sched != null)
                        {
                            sched.ShowGarbageScheduleTab();
                            break;
                        }
                    }
                }
            }
        }
    }
}
