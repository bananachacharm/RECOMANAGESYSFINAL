namespace RECOMANAGESYS
{
    partial class UnlockAccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnlockAccountsForm));
            this.dgvLockedAccounts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogInHistorybtn = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.searchbtn = new FontAwesome.Sharp.IconButton();
            this.searchLock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLockedAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLockedAccounts
            // 
            this.dgvLockedAccounts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLockedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLockedAccounts.Location = new System.Drawing.Point(17, 125);
            this.dgvLockedAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLockedAccounts.Name = "dgvLockedAccounts";
            this.dgvLockedAccounts.RowHeadersWidth = 62;
            this.dgvLockedAccounts.RowTemplate.Height = 28;
            this.dgvLockedAccounts.Size = new System.Drawing.Size(1007, 399);
            this.dgvLockedAccounts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LogInHistorybtn);
            this.panel1.Controls.Add(this.btnUnlock);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.searchLock);
            this.panel1.Controls.Add(this.dgvLockedAccounts);
            this.panel1.Location = new System.Drawing.Point(23, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 547);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogInHistorybtn
            // 
            this.LogInHistorybtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.LogInHistorybtn.Location = new System.Drawing.Point(17, 74);
            this.LogInHistorybtn.Name = "LogInHistorybtn";
            this.LogInHistorybtn.Size = new System.Drawing.Size(232, 40);
            this.LogInHistorybtn.TabIndex = 14;
            this.LogInHistorybtn.Text = "View Access History";
            this.LogInHistorybtn.UseVisualStyleBackColor = true;
            this.LogInHistorybtn.Click += new System.EventHandler(this.LogInHistorybtn_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUnlock.FlatAppearance.BorderSize = 0;
            this.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnUnlock.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.Location = new System.Drawing.Point(673, 76);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(351, 38);
            this.btnUnlock.TabIndex = 13;
            this.btnUnlock.Text = "Unlock Account";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchbtn.IconColor = System.Drawing.Color.Black;
            this.searchbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchbtn.IconSize = 28;
            this.searchbtn.Location = new System.Drawing.Point(976, 28);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(50, 38);
            this.searchbtn.TabIndex = 12;
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // searchLock
            // 
            this.searchLock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLock.Location = new System.Drawing.Point(673, 28);
            this.searchLock.Multiline = true;
            this.searchLock.Name = "searchLock";
            this.searchLock.Size = new System.Drawing.Size(353, 38);
            this.searchLock.TabIndex = 11;
            this.searchLock.TextChanged += new System.EventHandler(this.searchLock_TextChanged);
            // 
            // UnlockAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 627);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UnlockAccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvLockedAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLockedAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchLock;
        private FontAwesome.Sharp.IconButton searchbtn;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button LogInHistorybtn;
    }
}