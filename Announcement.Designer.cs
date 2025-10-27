namespace RECOMANAGESYS
{
    partial class Announcement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelAnnouncement = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPostAnnouncement = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(26, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelAnnouncement);
            this.panel2.Controls.Add(this.btnPostAnnouncement);
            this.panel2.Location = new System.Drawing.Point(26, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 612);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelAnnouncement
            // 
            this.panelAnnouncement.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnnouncement.Location = new System.Drawing.Point(50, 94);
            this.panelAnnouncement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAnnouncement.Name = "panelAnnouncement";
            this.panelAnnouncement.Size = new System.Drawing.Size(961, 477);
            this.panelAnnouncement.TabIndex = 9;
            this.panelAnnouncement.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelAnnouncement_Paint);
            // 
            // btnPostAnnouncement
            // 
            this.btnPostAnnouncement.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPostAnnouncement.FlatAppearance.BorderSize = 0;
            this.btnPostAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostAnnouncement.ForeColor = System.Drawing.Color.White;
            this.btnPostAnnouncement.Location = new System.Drawing.Point(811, 26);
            this.btnPostAnnouncement.Name = "btnPostAnnouncement";
            this.btnPostAnnouncement.Size = new System.Drawing.Size(200, 45);
            this.btnPostAnnouncement.TabIndex = 8;
            this.btnPostAnnouncement.Text = "Post Announcement";
            this.btnPostAnnouncement.UseVisualStyleBackColor = false;
            this.btnPostAnnouncement.Click += new System.EventHandler(this.button3_Click);
            // 
            // Announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Announcement";
            this.Size = new System.Drawing.Size(1110, 736);
            this.Load += new System.EventHandler(this.LoadAnnouncement);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPostAnnouncement;
        private System.Windows.Forms.FlowLayoutPanel panelAnnouncement;
    }
}
