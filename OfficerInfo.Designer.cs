namespace RECOMANAGESYS
{
    partial class OfficerInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficerInfo));
            this.officerPanel = new System.Windows.Forms.Panel();
            this.Reactivatebtn = new System.Windows.Forms.Button();
            this.viewLockAccounts = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.searchbtn = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Unregisterbtn = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.DGVOfficers = new System.Windows.Forms.DataGridView();
            this.officerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOfficers)).BeginInit();
            this.SuspendLayout();
            // 
            // officerPanel
            // 
            this.officerPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.officerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.officerPanel.Controls.Add(this.Reactivatebtn);
            this.officerPanel.Controls.Add(this.registerbtn);
            this.officerPanel.Controls.Add(this.DGVOfficers);
            this.officerPanel.Controls.Add(this.viewLockAccounts);
            this.officerPanel.Controls.Add(this.Editbtn);
            this.officerPanel.Controls.Add(this.searchbtn);
            this.officerPanel.Controls.Add(this.txtSearch);
            this.officerPanel.Controls.Add(this.Unregisterbtn);
            this.officerPanel.Controls.Add(this.Refreshbtn);
            this.officerPanel.Location = new System.Drawing.Point(28, 31);
            this.officerPanel.Name = "officerPanel";
            this.officerPanel.Size = new System.Drawing.Size(1079, 618);
            this.officerPanel.TabIndex = 4;
            this.officerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.officerPanel_Paint);
            // 
            // Reactivatebtn
            // 
            this.Reactivatebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.Reactivatebtn.Location = new System.Drawing.Point(26, 87);
            this.Reactivatebtn.Name = "Reactivatebtn";
            this.Reactivatebtn.Size = new System.Drawing.Size(203, 40);
            this.Reactivatebtn.TabIndex = 15;
            this.Reactivatebtn.Text = "Reactivate Account";
            this.Reactivatebtn.UseVisualStyleBackColor = true;
            this.Reactivatebtn.Click += new System.EventHandler(this.Reactivatebtn_Click);
            // 
            // viewLockAccounts
            // 
            this.viewLockAccounts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.viewLockAccounts.Location = new System.Drawing.Point(579, 26);
            this.viewLockAccounts.Name = "viewLockAccounts";
            this.viewLockAccounts.Size = new System.Drawing.Size(218, 40);
            this.viewLockAccounts.TabIndex = 14;
            this.viewLockAccounts.Text = "Lock Accounts";
            this.viewLockAccounts.UseVisualStyleBackColor = true;
            this.viewLockAccounts.Click += new System.EventHandler(this.viewLockAccounts_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.Editbtn.Location = new System.Drawing.Point(351, 87);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(65, 40);
            this.Editbtn.TabIndex = 13;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.registerbtn.Location = new System.Drawing.Point(803, 26);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(245, 40);
            this.registerbtn.TabIndex = 12;
            this.registerbtn.Text = "Register Officer Account";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchbtn.IconColor = System.Drawing.Color.Black;
            this.searchbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchbtn.IconSize = 28;
            this.searchbtn.Location = new System.Drawing.Point(998, 87);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(50, 38);
            this.searchbtn.TabIndex = 11;
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(695, 87);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(353, 38);
            this.txtSearch.TabIndex = 10;
            // 
            // Unregisterbtn
            // 
            this.Unregisterbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.Unregisterbtn.Location = new System.Drawing.Point(235, 87);
            this.Unregisterbtn.Name = "Unregisterbtn";
            this.Unregisterbtn.Size = new System.Drawing.Size(110, 40);
            this.Unregisterbtn.TabIndex = 1;
            this.Unregisterbtn.Text = "Unregister";
            this.Unregisterbtn.UseVisualStyleBackColor = true;
            this.Unregisterbtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.Refreshbtn.Location = new System.Drawing.Point(588, 87);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(101, 40);
            this.Refreshbtn.TabIndex = 0;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // DGVOfficers
            // 
            this.DGVOfficers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVOfficers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOfficers.Location = new System.Drawing.Point(27, 142);
            this.DGVOfficers.Name = "DGVOfficers";
            this.DGVOfficers.RowHeadersWidth = 51;
            this.DGVOfficers.RowTemplate.Height = 24;
            this.DGVOfficers.Size = new System.Drawing.Size(1021, 447);
            this.DGVOfficers.TabIndex = 8;
            // 
            // OfficerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 673);
            this.Controls.Add(this.officerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OfficerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OfficerInfo_Load);
            this.officerPanel.ResumeLayout(false);
            this.officerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOfficers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel officerPanel;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button registerbtn;
        private FontAwesome.Sharp.IconButton searchbtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Unregisterbtn;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.DataGridView DGVOfficers;
        private System.Windows.Forms.Button viewLockAccounts;
        private System.Windows.Forms.Button Reactivatebtn;
    }
}