using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RECOMANAGESYS.loginform;

namespace RECOMANAGESYS
{
    public partial class OfficerInfo : Form
    {
        private DataTable originalDataTable;
        private bool isInEditMode = false;
        private bool isLoadingData = false;
        private bool isSavingViaEnter = false;

        public OfficerInfo()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            SetupDataGridView();
            LoadOfficers();
            this.DGVOfficers.CellClick += DGVOfficers_CellClick;
            this.DGVOfficers.SelectionChanged += new System.EventHandler(this.DGVOfficers_SelectionChanged);

            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (originalDataTable == null) return;

            string searchText = txtSearch.Text.Trim();
            DataView dv = originalDataTable.DefaultView;

            if (string.IsNullOrEmpty(searchText))
            {
                dv.RowFilter = string.Empty;
            }
            else
            {
                string safeSearchText = searchText.Replace("'", "''");

                try
                {
                    dv.RowFilter = string.Format(
                        "FullName LIKE '%{0}%' OR " +
                        "CompleteAddress LIKE '%{0}%' OR " +
                        "ContactNumber LIKE '%{0}%' OR " +
                        "EmailAddress LIKE '%{0}%' OR " +
                        "PositionInHOA LIKE '%{0}%' OR " +
                        "DisplayID LIKE '%{0}%'",
                        safeSearchText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Filter Error: " + ex.Message);
                    dv.RowFilter = string.Empty;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isInEditMode && keyData == Keys.Enter && this.DGVOfficers.IsCurrentCellInEditMode)
            {
                this.Editbtn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SetupDataGridView()
        {
            DGVOfficers.AutoGenerateColumns = false;
            DGVOfficers.AllowUserToAddRows = false;
            DGVOfficers.AllowUserToDeleteRows = false;
            DGVOfficers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVOfficers.MultiSelect = false;
            DGVOfficers.RowTemplate.Height = 110;

            DGVOfficers.Columns.Clear();

            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DisplayID",
                HeaderText = "ID",
                Name = "DisplayID",
                Width = 50
            });

            var imgCol = new DataGridViewImageColumn
            {
                DataPropertyName = "ProfileImage",
                Name = "ProfilePicture",
                HeaderText = "Profile",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100,
                ReadOnly = true
            };
            DGVOfficers.Columns.Add(imgCol);

            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Name", Name = "FullName", Width = 150 });
            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CompleteAddress", HeaderText = "Complete Address", Name = "CompleteAddress", Width = 200 });
            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ContactNumber", HeaderText = "Contact Number", Name = "ContactNumber", Width = 120 });
            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EmailAddress", HeaderText = "Email Address", Name = "EmailAddress", Width = 180 });
            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MemberSince", HeaderText = "Member Since", Name = "MemberSince", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" } });
            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PositionInHOA", HeaderText = "Position in HOA", Name = "PositionInHOA", Width = 200 });
            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusText", HeaderText = "Status", Name = "Status", Width = 100 });
            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OfficerID", HeaderText = "Officer ID", Name = "OfficerID", Visible = false });

            DGVOfficers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Spacer",
                HeaderText = "",
                Width = 80
            });

            foreach (DataGridViewColumn col in DGVOfficers.Columns)
                col.ReadOnly = true;

            DGVOfficers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGVOfficers.ScrollBars = ScrollBars.Both;

            DGVOfficers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            if (DGVOfficers.Parent is Panel panel)
                panel.AutoScroll = true;
        }
        public void LoadOfficers()
        {
            isLoadingData = true;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                u.UserID AS OfficerID,
                                CONCAT_WS(' ', u.Firstname, u.MiddleName, u.Lastname) AS FullName,
                                ISNULL(u.CompleteAddress, 'Not Specified') AS CompleteAddress,
                                ISNULL(u.ContactNumber, 'Not Specified') AS ContactNumber,
                                ISNULL(u.EmailAddress, 'Not Specified') AS EmailAddress,
                                u.MemberSince,
                                r.RoleName AS PositionInHOA,
                                u.ProfilePicture,
                                u.IsActive
                              FROM Users u
                              LEFT JOIN TBL_Roles r ON u.RoleId = r.RoleId";

                    if (CurrentUser.Role != "Developer")
                    {
                        query += " WHERE r.RoleName <> 'Developer'";
                    }
                    query += " ORDER BY u.IsActive DESC, u.Lastname, u.Firstname";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (!dt.Columns.Contains("DisplayID"))
                            dt.Columns.Add("DisplayID", typeof(string));

                        foreach (DataRow row in dt.Rows)
                        {
                            row["DisplayID"] = row["OfficerID"].ToString().PadLeft(3, '0');
                        }

                        if (dt.Columns.Contains("ProfileImage"))
                            dt.Columns.Remove("ProfileImage");
                        dt.Columns.Add("ProfileImage", typeof(Image));

                        // Convert byte[] -> Image (resized)
                        foreach (DataRow row in dt.Rows)
                        {
                            try
                            {
                                if (row["ProfilePicture"] != DBNull.Value)
                                {
                                    byte[] imgBytes = (byte[])row["ProfilePicture"];
                                    using (var ms = new MemoryStream(imgBytes))
                                    {
                                        using (Image src = Image.FromStream(ms))
                                        {
                                            Image thumb = ResizeImage(src, 100, 100);
                                            row["ProfileImage"] = thumb;
                                        }
                                    }
                                }
                                else
                                {
                                    // leave as null (or create programmatic placeholder)
                                    row["ProfileImage"] = DBNull.Value;
                                }
                            }
                            catch (Exception imgEx)
                            {
                                Console.WriteLine("Image conversion error: " + imgEx.Message);
                                row["ProfileImage"] = DBNull.Value;
                            }
                        }

                        originalDataTable = dt;
                        originalDataTable.AcceptChanges();

                        if (!dt.Columns.Contains("StatusText"))
                            dt.Columns.Add("StatusText", typeof(string));

                        foreach (DataRow row in dt.Rows)
                        {
                            bool active = row["IsActive"] != DBNull.Value && Convert.ToBoolean(row["IsActive"]);
                            row["StatusText"] = active ? "Active" : "Inactive";
                        }
                        DGVOfficers.DataSource = originalDataTable.DefaultView;
                        foreach (DataGridViewRow row in DGVOfficers.Rows)
                        {
                            string status = row.Cells["Status"].Value?.ToString();
                            if (status == "Inactive")
                            {
                                row.DefaultCellStyle.ForeColor = Color.DarkGray;
                                row.DefaultCellStyle.Font = new Font(DGVOfficers.Font, FontStyle.Italic);
                            }
                        }
                        if (DGVOfficers.Columns.Contains("DisplayID"))
                            DGVOfficers.Columns["DisplayID"].Visible = false;
                        if (DGVOfficers.Columns.Contains("OfficerID"))
                            DGVOfficers.Columns["OfficerID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profiles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoadingData = false;
            }
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }
        private void DGVOfficers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGVOfficers.Columns["ProfilePicture"].Index)
            {
                var img = DGVOfficers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Image;
                if (img != null)
                {
                    Form preview = new Form
                    {
                        Text = "Profile Picture",
                        Size = new Size(400, 400),
                        StartPosition = FormStartPosition.CenterParent
                    };

                    PictureBox pb = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Image = img,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    preview.Controls.Add(pb);
                    preview.ShowDialog();
                }
            }
        }
        private void OfficerInfo_Load(object sender, EventArgs e)
        {
            var allowedRoles = new List<string> { "Developer", "President", "Vice President", "Secretary" };
            bool canEdit = allowedRoles.Contains(CurrentUser.Role);

            Editbtn.Visible = canEdit;
            Reactivatebtn.Visible = canEdit;
            viewLockAccounts.Visible = CurrentUser.Role == "President" || CurrentUser.Role == "Developer";
        }

        private void ToggleEditMode(bool editing)
        {
            isInEditMode = editing;
            Editbtn.Text = editing ? "Save" : "Edit";

            DGVOfficers.Columns["CompleteAddress"].ReadOnly = !editing;
            DGVOfficers.Columns["ContactNumber"].ReadOnly = !editing;
            DGVOfficers.Columns["EmailAddress"].ReadOnly = !editing;

            Color cellColor = editing ? Color.LightYellow : SystemColors.Window;
            DGVOfficers.Columns["CompleteAddress"].DefaultCellStyle.BackColor = cellColor;
            DGVOfficers.Columns["ContactNumber"].DefaultCellStyle.BackColor = cellColor;
            DGVOfficers.Columns["EmailAddress"].DefaultCellStyle.BackColor = cellColor;

            registerbtn.Enabled = !editing;
            Unregisterbtn.Enabled = !editing;
            Reactivatebtn.Enabled = !editing;
            Refreshbtn.Enabled = !editing;
            if (viewLockAccounts.Visible)
                viewLockAccounts.Enabled = !editing;

            DGVOfficers.Refresh();
        }

        private void SaveChanges()
        {
            this.DGVOfficers.SelectionChanged -= DGVOfficers_SelectionChanged;

            DGVOfficers.EndEdit();
            DGVOfficers.CurrentCell = null;

            DataTable changes = originalDataTable.GetChanges(DataRowState.Modified);

            if (changes == null || changes.Rows.Count == 0)
            {
                MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToggleEditMode(false);
                return;
            }

            int updatedCount = 0;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    foreach (DataRow row in changes.Rows)
                    {
                        if (string.IsNullOrWhiteSpace(row["ContactNumber"].ToString()) ||
                            row["ContactNumber"].ToString() == "Not Specified")
                        {
                            MessageBox.Show("Contact Number cannot be empty.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LoadOfficers();
                            ToggleEditMode(false);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(row["EmailAddress"].ToString()) ||
                            row["EmailAddress"].ToString() == "Not Specified")
                        {
                            MessageBox.Show("Email Address cannot be empty.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LoadOfficers();
                            ToggleEditMode(false);
                            return;
                        }


                        string email = row["EmailAddress"].ToString();
                        if (!email.Contains("@") || !email.Contains("."))
                        {
                            MessageBox.Show("Please enter a valid email address.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LoadOfficers();
                            ToggleEditMode(false);
                            return;
                        }

                        string updateQuery = @"UPDATE Users SET 
                                                    CompleteAddress = @CompleteAddress, 
                                                    ContactNumber = @ContactNumber,
                                                    EmailAddress = @EmailAddress
                                                WHERE UserID = @OfficerID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CompleteAddress", row["CompleteAddress"]);
                            cmd.Parameters.AddWithValue("@ContactNumber", row["ContactNumber"]);
                            cmd.Parameters.AddWithValue("@EmailAddress", row["EmailAddress"]);
                            cmd.Parameters.AddWithValue("@OfficerID", row["OfficerID"]);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                updatedCount++;
                            }
                        }
                    }
                }

                MessageBox.Show($"{updatedCount} officer record(s) updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving changes: " + ex.Message, "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadOfficers();
                txtSearch.Clear();
                ToggleEditMode(false);
            }
        }

        private void DGVOfficers_SelectionChanged(object sender, EventArgs e)
        {
            if (isSavingViaEnter)
            {
                isSavingViaEnter = false;
                return;
            }

            if (isLoadingData || !isInEditMode)
            {
                return;
            }

            var result = MessageBox.Show(
                "You have unsaved changes. Do you want to discard them?",
                "Unsaved Changes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.DGVOfficers.SelectionChanged -= DGVOfficers_SelectionChanged;
                LoadOfficers();
                ToggleEditMode(false);
                this.DGVOfficers.SelectionChanged += DGVOfficers_SelectionChanged;
            }
            else
            {
                this.DGVOfficers.SelectionChanged -= DGVOfficers_SelectionChanged;
                if (DGVOfficers.Rows.Count > 0 && DGVOfficers.CurrentRow != null)
                {
                    DGVOfficers.CurrentRow.Selected = true;
                }
                this.DGVOfficers.SelectionChanged += DGVOfficers_SelectionChanged;
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (DGVOfficers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an officer to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isInEditMode)
            {
                string position = DGVOfficers.SelectedRows[0].Cells["PositionInHOA"].Value?.ToString() ?? "";

                if (position == "Developer" && CurrentUser.Role != "Developer")
                {
                    MessageBox.Show(
                        "You don't have permission to edit Developer accounts.",
                        "Permission Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                ToggleEditMode(true);
            }
            else
            {
                SaveChanges();
            }
        }

        private void officerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            var regform = new registerform();
            regform.RegistrationSuccess += (s, args) =>
            {
                LoadOfficers();
                DGVOfficers.Refresh();
                Application.DoEvents();
                txtSearch.Clear();
            };
            regform.Show();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (DGVOfficers.SelectedRows.Count == 0 || DGVOfficers.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select an officer to unregister.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = DGVOfficers.SelectedRows[0];
            string officerID = selectedRow.Cells["OfficerID"].Value?.ToString();
            string position = selectedRow.Cells["PositionInHOA"].Value?.ToString() ?? "";
            string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(officerID))
            {
                MessageBox.Show("Could not find the officer ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent unregistering inactive officers
            if (status == "Inactive")
            {
                MessageBox.Show("This officer is already unregistered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (position == "Developer" && CurrentUser.Role != "Developer")
            {
                MessageBox.Show("You don't have permission to unregister Developer accounts.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to unregister officer '{selectedRow.Cells["FullName"].Value}'?",
                "Confirm Unregister",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE Users SET IsActive = 0 WHERE UserID = @OfficerID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@OfficerID", officerID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Officer successfully unregistered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOfficers();
                            txtSearch.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to unregister officer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while unregistering officer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            if (isInEditMode)
            {
                var result = MessageBox.Show("You are currently in edit mode. Refreshing will discard any unsaved changes. Continue?",
                    "Confirm Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            txtSearch.Clear();
            ToggleEditMode(false);
            LoadOfficers();
            MessageBox.Show("Officers list refreshed!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewLockAccounts_Click(object sender, EventArgs e)
        {
            UnlockAccountsForm unlockAcct = new UnlockAccountsForm();
            unlockAcct.ShowDialog();
        }

        private void Reactivatebtn_Click(object sender, EventArgs e)
        {
            if (DGVOfficers.SelectedRows.Count == 0 || DGVOfficers.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select an officer to reactivate.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = DGVOfficers.SelectedRows[0];
            string officerID = selectedRow.Cells["OfficerID"].Value?.ToString();
            string position = selectedRow.Cells["PositionInHOA"].Value?.ToString() ?? "";
            string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(officerID))
            {
                MessageBox.Show("Could not find the officer ID. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (status == "Active")
            {
                MessageBox.Show("This officer is already active.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Skip validation if Member or Developer (both can have multiple)
            bool skipValidation = position.Equals("Member", StringComparison.OrdinalIgnoreCase) ||
                                  position.Equals("Developer", StringComparison.OrdinalIgnoreCase);

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    if (!skipValidation)
                    {
                        string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM Users u
                    INNER JOIN TBL_Roles r ON u.RoleId = r.RoleId
                    WHERE r.RoleName = @RoleName AND u.IsActive = 1 AND u.UserID <> @OfficerID";

                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@RoleName", position);
                            checkCmd.Parameters.AddWithValue("@OfficerID", officerID);

                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show(
                                    $"You cannot reactivate this officer because there is already an active {position}.",
                                    "Duplicate Role Detected",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    string updateQuery = "UPDATE Users SET IsActive = 1 WHERE UserID = @OfficerID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@OfficerID", officerID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{position} successfully reactivated.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOfficers();
                            txtSearch.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to reactivate officer. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while reactivating officer: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}