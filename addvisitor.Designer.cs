﻿namespace RECOMANAGESYS
{
    partial class addvisitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addvisitor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VisitorNametxt = new System.Windows.Forms.TextBox();
            this.ContactNumtxt = new System.Windows.Forms.TextBox();
            this.VisitorDTP = new System.Windows.Forms.DateTimePicker();
            this.savevisitorbtn = new System.Windows.Forms.Button();
            this.cancelvisitorbtn = new System.Windows.Forms.Button();
            this.Purposetxt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(84, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(419, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purpose of Visit:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(419, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Number:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // VisitorNametxt
            // 
            this.VisitorNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisitorNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VisitorNametxt.Location = new System.Drawing.Point(89, 154);
            this.VisitorNametxt.Multiline = true;
            this.VisitorNametxt.Name = "VisitorNametxt";
            this.VisitorNametxt.Size = new System.Drawing.Size(307, 38);
            this.VisitorNametxt.TabIndex = 6;
            // 
            // ContactNumtxt
            // 
            this.ContactNumtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactNumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ContactNumtxt.Location = new System.Drawing.Point(424, 240);
            this.ContactNumtxt.Multiline = true;
            this.ContactNumtxt.Name = "ContactNumtxt";
            this.ContactNumtxt.Size = new System.Drawing.Size(307, 38);
            this.ContactNumtxt.TabIndex = 7;
            // 
            // VisitorDTP
            // 
            this.VisitorDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorDTP.Location = new System.Drawing.Point(89, 240);
            this.VisitorDTP.Name = "VisitorDTP";
            this.VisitorDTP.Size = new System.Drawing.Size(307, 28);
            this.VisitorDTP.TabIndex = 10;
            // 
            // savevisitorbtn
            // 
            this.savevisitorbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.savevisitorbtn.FlatAppearance.BorderSize = 0;
            this.savevisitorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savevisitorbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.savevisitorbtn.ForeColor = System.Drawing.Color.White;
            this.savevisitorbtn.Location = new System.Drawing.Point(426, 328);
            this.savevisitorbtn.Name = "savevisitorbtn";
            this.savevisitorbtn.Size = new System.Drawing.Size(120, 42);
            this.savevisitorbtn.TabIndex = 11;
            this.savevisitorbtn.Text = "Save";
            this.savevisitorbtn.UseVisualStyleBackColor = false;
            this.savevisitorbtn.Click += new System.EventHandler(this.savevisitorbtn_Click);
            // 
            // cancelvisitorbtn
            // 
            this.cancelvisitorbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelvisitorbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.cancelvisitorbtn.FlatAppearance.BorderSize = 0;
            this.cancelvisitorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelvisitorbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelvisitorbtn.ForeColor = System.Drawing.Color.Black;
            this.cancelvisitorbtn.Location = new System.Drawing.Point(279, 328);
            this.cancelvisitorbtn.Name = "cancelvisitorbtn";
            this.cancelvisitorbtn.Size = new System.Drawing.Size(120, 42);
            this.cancelvisitorbtn.TabIndex = 12;
            this.cancelvisitorbtn.Text = "Cancel";
            this.cancelvisitorbtn.UseVisualStyleBackColor = false;
            this.cancelvisitorbtn.Click += new System.EventHandler(this.cancelvisitorbtn_Click);
            // 
            // Purposetxt
            // 
            this.Purposetxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Purposetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Purposetxt.FormattingEnabled = true;
            this.Purposetxt.Location = new System.Drawing.Point(424, 155);
            this.Purposetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Purposetxt.Name = "Purposetxt";
            this.Purposetxt.Size = new System.Drawing.Size(307, 33);
            this.Purposetxt.TabIndex = 13;
            // 
            // addvisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 442);
            this.Controls.Add(this.Purposetxt);
            this.Controls.Add(this.cancelvisitorbtn);
            this.Controls.Add(this.savevisitorbtn);
            this.Controls.Add(this.VisitorDTP);
            this.Controls.Add(this.ContactNumtxt);
            this.Controls.Add(this.VisitorNametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addvisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addvisitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VisitorNametxt;
        private System.Windows.Forms.TextBox ContactNumtxt;
        private System.Windows.Forms.DateTimePicker VisitorDTP;
        private System.Windows.Forms.Button savevisitorbtn;
        private System.Windows.Forms.Button cancelvisitorbtn;
        private System.Windows.Forms.ComboBox Purposetxt;
    }
}