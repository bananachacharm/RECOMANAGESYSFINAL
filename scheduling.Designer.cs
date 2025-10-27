namespace RECOMANAGESYS
{
    partial class scheduling
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scheduling));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab1Events = new System.Windows.Forms.TabPage();
            this.DGVEvents = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.DeleteEventbtn = new System.Windows.Forms.Button();
            this.EditEvent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbApprovedBy = new System.Windows.Forms.ComboBox();
            this.Venuecmb = new System.Windows.Forms.ComboBox();
            this.DTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPEventTime = new System.Windows.Forms.DateTimePicker();
            this.EventSave = new System.Windows.Forms.Button();
            this.DTPEventDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tab2GarbageSched = new System.Windows.Forms.TabPage();
            this.DGVGarbageSched = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.txtTruckCompany = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DTPGarbageSchedTime = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.DTPGarbageSchedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Tab1Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEvents)).BeginInit();
            this.panel5.SuspendLayout();
            this.Tab2GarbageSched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGarbageSched)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Tab1Events);
            this.tabControl1.Controls.Add(this.Tab2GarbageSched);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(31, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 690);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab1Events
            // 
            this.Tab1Events.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Tab1Events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab1Events.Controls.Add(this.DGVEvents);
            this.Tab1Events.Controls.Add(this.panel5);
            this.Tab1Events.Location = new System.Drawing.Point(4, 43);
            this.Tab1Events.Name = "Tab1Events";
            this.Tab1Events.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1Events.Size = new System.Drawing.Size(1034, 643);
            this.Tab1Events.TabIndex = 0;
            this.Tab1Events.Text = "Events";
            this.Tab1Events.Click += new System.EventHandler(this.Tab1Events_Click);
            // 
            // DGVEvents
            // 
            this.DGVEvents.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEvents.Location = new System.Drawing.Point(18, 234);
            this.DGVEvents.Name = "DGVEvents";
            this.DGVEvents.RowHeadersWidth = 51;
            this.DGVEvents.RowTemplate.Height = 24;
            this.DGVEvents.Size = new System.Drawing.Size(996, 383);
            this.DGVEvents.TabIndex = 5;
            this.DGVEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEvents_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmbEventType);
            this.panel5.Controls.Add(this.DeleteEventbtn);
            this.panel5.Controls.Add(this.EditEvent);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cmbApprovedBy);
            this.panel5.Controls.Add(this.Venuecmb);
            this.panel5.Controls.Add(this.DTPEndTime);
            this.panel5.Controls.Add(this.DTPEndDate);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.DTPEventTime);
            this.panel5.Controls.Add(this.EventSave);
            this.panel5.Controls.Add(this.DTPEventDate);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(19, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(996, 201);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cmbEventType
            // 
            this.cmbEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(176, 17);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(286, 33);
            this.cmbEventType.TabIndex = 30;
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // DeleteEventbtn
            // 
            this.DeleteEventbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteEventbtn.FlatAppearance.BorderSize = 0;
            this.DeleteEventbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEventbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEventbtn.ForeColor = System.Drawing.Color.White;
            this.DeleteEventbtn.Location = new System.Drawing.Point(883, 33);
            this.DeleteEventbtn.Name = "DeleteEventbtn";
            this.DeleteEventbtn.Size = new System.Drawing.Size(96, 40);
            this.DeleteEventbtn.TabIndex = 29;
            this.DeleteEventbtn.Text = "Delete";
            this.DeleteEventbtn.UseVisualStyleBackColor = false;
            this.DeleteEventbtn.Click += new System.EventHandler(this.DeleteEventbtn_Click);
            // 
            // EditEvent
            // 
            this.EditEvent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EditEvent.FlatAppearance.BorderSize = 0;
            this.EditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.EditEvent.ForeColor = System.Drawing.Color.White;
            this.EditEvent.Location = new System.Drawing.Point(883, 77);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(96, 40);
            this.EditEvent.TabIndex = 28;
            this.EditEvent.Text = "Edit";
            this.EditEvent.UseVisualStyleBackColor = false;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(473, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 27);
            this.label8.TabIndex = 26;
            this.label8.Text = "Approved By";
            // 
            // cmbApprovedBy
            // 
            this.cmbApprovedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbApprovedBy.FormattingEnabled = true;
            this.cmbApprovedBy.Location = new System.Drawing.Point(621, 15);
            this.cmbApprovedBy.Name = "cmbApprovedBy";
            this.cmbApprovedBy.Size = new System.Drawing.Size(247, 33);
            this.cmbApprovedBy.TabIndex = 25;
            // 
            // Venuecmb
            // 
            this.Venuecmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Venuecmb.FormattingEnabled = true;
            this.Venuecmb.Location = new System.Drawing.Point(176, 64);
            this.Venuecmb.Name = "Venuecmb";
            this.Venuecmb.Size = new System.Drawing.Size(286, 33);
            this.Venuecmb.TabIndex = 24;
            // 
            // DTPEndTime
            // 
            this.DTPEndTime.CustomFormat = "hh:mm tt";
            this.DTPEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPEndTime.Location = new System.Drawing.Point(563, 154);
            this.DTPEndTime.Name = "DTPEndTime";
            this.DTPEndTime.ShowUpDown = true;
            this.DTPEndTime.Size = new System.Drawing.Size(127, 27);
            this.DTPEndTime.TabIndex = 23;
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEndDate.Location = new System.Drawing.Point(145, 152);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(286, 27);
            this.DTPEndDate.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(453, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "End Time";
            // 
            // DTPEventTime
            // 
            this.DTPEventTime.CustomFormat = "hh:mm tt";
            this.DTPEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPEventTime.Location = new System.Drawing.Point(563, 114);
            this.DTPEventTime.Name = "DTPEventTime";
            this.DTPEventTime.ShowUpDown = true;
            this.DTPEventTime.Size = new System.Drawing.Size(127, 27);
            this.DTPEventTime.TabIndex = 20;
            // 
            // EventSave
            // 
            this.EventSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EventSave.FlatAppearance.BorderSize = 0;
            this.EventSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.EventSave.ForeColor = System.Drawing.Color.White;
            this.EventSave.Location = new System.Drawing.Point(883, 121);
            this.EventSave.Name = "EventSave";
            this.EventSave.Size = new System.Drawing.Size(96, 40);
            this.EventSave.TabIndex = 4;
            this.EventSave.Text = "Save";
            this.EventSave.UseVisualStyleBackColor = false;
            this.EventSave.Click += new System.EventHandler(this.EventSave_Click);
            // 
            // DTPEventDate
            // 
            this.DTPEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEventDate.Location = new System.Drawing.Point(145, 114);
            this.DTPEventDate.Name = "DTPEventDate";
            this.DTPEventDate.Size = new System.Drawing.Size(286, 27);
            this.DTPEventDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(453, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Event Name";
            // 
            // Tab2GarbageSched
            // 
            this.Tab2GarbageSched.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Tab2GarbageSched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab2GarbageSched.Controls.Add(this.DGVGarbageSched);
            this.Tab2GarbageSched.Controls.Add(this.panel2);
            this.Tab2GarbageSched.Location = new System.Drawing.Point(4, 43);
            this.Tab2GarbageSched.Name = "Tab2GarbageSched";
            this.Tab2GarbageSched.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2GarbageSched.Size = new System.Drawing.Size(1034, 643);
            this.Tab2GarbageSched.TabIndex = 1;
            this.Tab2GarbageSched.Text = "Garbage Scheduling";
            this.Tab2GarbageSched.Click += new System.EventHandler(this.Tab2GarbageSched_Click);
            // 
            // DGVGarbageSched
            // 
            this.DGVGarbageSched.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVGarbageSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGarbageSched.Location = new System.Drawing.Point(31, 182);
            this.DGVGarbageSched.Name = "DGVGarbageSched";
            this.DGVGarbageSched.RowHeadersWidth = 51;
            this.DGVGarbageSched.RowTemplate.Height = 24;
            this.DGVGarbageSched.Size = new System.Drawing.Size(973, 424);
            this.DGVGarbageSched.TabIndex = 6;
            this.DGVGarbageSched.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGarbageSched_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.cmbDay);
            this.panel2.Controls.Add(this.txtTruckCompany);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.DTPGarbageSchedTime);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.DTPGarbageSchedDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(32, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 135);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(487, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 27);
            this.label12.TabIndex = 30;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(389, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 27);
            this.label11.TabIndex = 29;
            this.label11.Text = "Day";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(568, 27);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(194, 33);
            this.cmbStatus.TabIndex = 28;
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(441, 72);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(123, 33);
            this.cmbDay.TabIndex = 27;
            // 
            // txtTruckCompany
            // 
            this.txtTruckCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTruckCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTruckCompany.Location = new System.Drawing.Point(196, 31);
            this.txtTruckCompany.Name = "txtTruckCompany";
            this.txtTruckCompany.Size = new System.Drawing.Size(265, 30);
            this.txtTruckCompany.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(21, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Truck Company";
            // 
            // DTPGarbageSchedTime
            // 
            this.DTPGarbageSchedTime.CustomFormat = "hh:mm tt";
            this.DTPGarbageSchedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPGarbageSchedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPGarbageSchedTime.Location = new System.Drawing.Point(642, 74);
            this.DTPGarbageSchedTime.Name = "DTPGarbageSchedTime";
            this.DTPGarbageSchedTime.ShowUpDown = true;
            this.DTPGarbageSchedTime.Size = new System.Drawing.Size(127, 27);
            this.DTPGarbageSchedTime.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(815, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(815, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // DTPGarbageSchedDate
            // 
            this.DTPGarbageSchedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPGarbageSchedDate.Location = new System.Drawing.Point(87, 76);
            this.DTPGarbageSchedDate.Name = "DTPGarbageSchedDate";
            this.DTPGarbageSchedDate.Size = new System.Drawing.Size(291, 27);
            this.DTPGarbageSchedDate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(578, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date";
            // 
            // scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tabControl1);
            this.Name = "scheduling";
            this.Size = new System.Drawing.Size(1110, 736);
            this.Load += new System.EventHandler(this.scheduling_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab1Events.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEvents)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Tab2GarbageSched.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGarbageSched)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab1Events;
        private System.Windows.Forms.TabPage Tab2GarbageSched;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button EventSave;
        private System.Windows.Forms.DateTimePicker DTPEventDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGVEvents;
        private System.Windows.Forms.DataGridView DGVGarbageSched;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker DTPGarbageSchedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbApprovedBy;
        private System.Windows.Forms.ComboBox Venuecmb;
        private System.Windows.Forms.DateTimePicker DTPEndTime;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPEventTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteEventbtn;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTPGarbageSchedTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.TextBox txtTruckCompany;
        private System.Windows.Forms.ComboBox cmbEventType;
    }
}
