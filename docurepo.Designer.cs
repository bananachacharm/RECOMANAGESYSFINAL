namespace RECOMANAGESYS
{
    partial class docurepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docurepo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModified = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.lblResetFilter = new System.Windows.Forms.Label();
            this.flowBreadcrumb = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.searchbtn = new FontAwesome.Sharp.IconButton();
            this.searchDocu = new System.Windows.Forms.TextBox();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.btnSafeguard = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(26, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnModified);
            this.panel2.Controls.Add(this.btnType);
            this.panel2.Controls.Add(this.btnDate);
            this.panel2.Controls.Add(this.lblResetFilter);
            this.panel2.Controls.Add(this.flowBreadcrumb);
            this.panel2.Controls.Add(this.panelDesktop);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.searchDocu);
            this.panel2.Controls.Add(this.buttonAddFolder);
            this.panel2.Controls.Add(this.buttonAddFile);
            this.panel2.Controls.Add(this.btnSafeguard);
            this.panel2.Location = new System.Drawing.Point(26, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 608);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnModified
            // 
            this.btnModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModified.Location = new System.Drawing.Point(123, 102);
            this.btnModified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModified.Name = "btnModified";
            this.btnModified.Size = new System.Drawing.Size(140, 33);
            this.btnModified.TabIndex = 16;
            this.btnModified.Text = "Last Modified";
            this.btnModified.UseVisualStyleBackColor = true;
            // 
            // btnType
            // 
            this.btnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Location = new System.Drawing.Point(32, 102);
            this.btnType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(85, 33);
            this.btnType.TabIndex = 15;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            // 
            // btnDate
            // 
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.Location = new System.Drawing.Point(268, 102);
            this.btnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(125, 33);
            this.btnDate.TabIndex = 17;
            this.btnDate.Text = "Date Added";
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // lblResetFilter
            // 
            this.lblResetFilter.AutoSize = true;
            this.lblResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResetFilter.Location = new System.Drawing.Point(399, 109);
            this.lblResetFilter.Name = "lblResetFilter";
            this.lblResetFilter.Size = new System.Drawing.Size(96, 20);
            this.lblResetFilter.TabIndex = 16;
            this.lblResetFilter.Text = "Reset Filter";
            // 
            // flowBreadcrumb
            // 
            this.flowBreadcrumb.BackColor = System.Drawing.Color.Transparent;
            this.flowBreadcrumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowBreadcrumb.Location = new System.Drawing.Point(32, 75);
            this.flowBreadcrumb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowBreadcrumb.Name = "flowBreadcrumb";
            this.flowBreadcrumb.Size = new System.Drawing.Size(514, 22);
            this.flowBreadcrumb.TabIndex = 15;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Location = new System.Drawing.Point(24, 143);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1008, 443);
            this.panelDesktop.TabIndex = 12;
            // 
            // searchbtn
            // 
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchbtn.IconColor = System.Drawing.Color.Black;
            this.searchbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchbtn.IconSize = 28;
            this.searchbtn.Location = new System.Drawing.Point(980, 27);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(50, 38);
            this.searchbtn.TabIndex = 11;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchDocu
            // 
            this.searchDocu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchDocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDocu.Location = new System.Drawing.Point(677, 27);
            this.searchDocu.Multiline = true;
            this.searchDocu.Name = "searchDocu";
            this.searchDocu.Size = new System.Drawing.Size(353, 38);
            this.searchDocu.TabIndex = 10;
            this.searchDocu.TextChanged += new System.EventHandler(this.searchDocu_TextChanged);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddFolder.FlatAppearance.BorderSize = 0;
            this.buttonAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFolder.ForeColor = System.Drawing.Color.White;
            this.buttonAddFolder.Location = new System.Drawing.Point(188, 26);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(150, 40);
            this.buttonAddFolder.TabIndex = 9;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = false;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddFile.FlatAppearance.BorderSize = 0;
            this.buttonAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFile.ForeColor = System.Drawing.Color.White;
            this.buttonAddFile.Location = new System.Drawing.Point(32, 26);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(150, 40);
            this.buttonAddFile.TabIndex = 7;
            this.buttonAddFile.Text = "Add File";
            this.buttonAddFile.UseVisualStyleBackColor = false;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // btnSafeguard
            // 
            this.btnSafeguard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSafeguard.FlatAppearance.BorderSize = 0;
            this.btnSafeguard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSafeguard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSafeguard.ForeColor = System.Drawing.Color.White;
            this.btnSafeguard.Location = new System.Drawing.Point(772, 81);
            this.btnSafeguard.Name = "btnSafeguard";
            this.btnSafeguard.Size = new System.Drawing.Size(254, 45);
            this.btnSafeguard.TabIndex = 5;
            this.btnSafeguard.Text = "Backup Restore Manager";
            this.btnSafeguard.UseVisualStyleBackColor = false;
            this.btnSafeguard.Click += new System.EventHandler(this.btnSafeguard_Click);
            // 
            // docurepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "docurepo";
            this.Size = new System.Drawing.Size(1110, 736);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSafeguard;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.TextBox searchDocu;
        private FontAwesome.Sharp.IconButton searchbtn;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnModified;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.FlowLayoutPanel flowBreadcrumb;
        private System.Windows.Forms.Label lblResetFilter;
    }
}
