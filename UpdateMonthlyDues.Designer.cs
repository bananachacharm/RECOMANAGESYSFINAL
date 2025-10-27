namespace RECOMANAGESYS
{
    partial class UpdateMonthlyDues
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMonthlyDues));
            this.lblUnitAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cancelvisitor = new System.Windows.Forms.Button();
            this.lblRemainingDebt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblResidentName = new System.Windows.Forms.Label();
            this.clbMissedMonths = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnSelectHomeowner = new System.Windows.Forms.Button();
            this.txtHomeownerIDDisplay = new System.Windows.Forms.TextBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.cmbResidency = new System.Windows.Forms.ComboBox();
            this.cmbRemarks = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnToggleSelectAll = new System.Windows.Forms.Button();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUnitAddress
            // 
            this.lblUnitAddress.AutoSize = true;
            this.lblUnitAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUnitAddress.Location = new System.Drawing.Point(232, 352);
            this.lblUnitAddress.Name = "lblUnitAddress";
            this.lblUnitAddress.Size = new System.Drawing.Size(120, 25);
            this.lblUnitAddress.TabIndex = 2;
            this.lblUnitAddress.Text = "[ADDRESS]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(114, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Payment Date:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(984, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.savevisitor_Click);
            // 
            // cancelvisitor
            // 
            this.cancelvisitor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelvisitor.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.cancelvisitor.FlatAppearance.BorderSize = 0;
            this.cancelvisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelvisitor.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelvisitor.ForeColor = System.Drawing.Color.Black;
            this.cancelvisitor.Location = new System.Drawing.Point(864, 611);
            this.cancelvisitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelvisitor.Name = "cancelvisitor";
            this.cancelvisitor.Size = new System.Drawing.Size(100, 42);
            this.cancelvisitor.TabIndex = 15;
            this.cancelvisitor.Text = "Cancel";
            this.cancelvisitor.UseVisualStyleBackColor = false;
            this.cancelvisitor.Click += new System.EventHandler(this.cancelvisitor_Click);
            // 
            // lblRemainingDebt
            // 
            this.lblRemainingDebt.AutoSize = true;
            this.lblRemainingDebt.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingDebt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblRemainingDebt.Location = new System.Drawing.Point(232, 388);
            this.lblRemainingDebt.Name = "lblRemainingDebt";
            this.lblRemainingDebt.Size = new System.Drawing.Size(117, 27);
            this.lblRemainingDebt.TabIndex = 13;
            this.lblRemainingDebt.Text = "[BALANCE]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(112, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Resident ID:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpPaymentDate.Location = new System.Drawing.Point(281, 598);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(321, 28);
            this.dtpPaymentDate.TabIndex = 11;
            // 
            // lblResidentName
            // 
            this.lblResidentName.AutoSize = true;
            this.lblResidentName.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResidentName.Location = new System.Drawing.Point(232, 312);
            this.lblResidentName.Name = "lblResidentName";
            this.lblResidentName.Size = new System.Drawing.Size(157, 25);
            this.lblResidentName.TabIndex = 17;
            this.lblResidentName.Text = "[Resident Name]";
            // 
            // clbMissedMonths
            // 
            this.clbMissedMonths.BackColor = System.Drawing.SystemColors.Window;
            this.clbMissedMonths.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.clbMissedMonths.FormattingEnabled = true;
            this.clbMissedMonths.Location = new System.Drawing.Point(237, 426);
            this.clbMissedMonths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbMissedMonths.Name = "clbMissedMonths";
            this.clbMissedMonths.Size = new System.Drawing.Size(260, 116);
            this.clbMissedMonths.TabIndex = 18;
            this.clbMissedMonths.SelectedIndexChanged += new System.EventHandler(this.clbMissedMonths_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(114, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Balance:";
            // 
            // cmbUnits
            // 
            this.cmbUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(198, 260);
            this.cmbUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(329, 33);
            this.cmbUnits.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(112, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Unit #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(114, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Unpaid:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(112, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblTotalAmount.Location = new System.Drawing.Point(232, 554);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(149, 27);
            this.lblTotalAmount.TabIndex = 25;
            this.lblTotalAmount.Text = "[total amount]";
            // 
            // btnSelectHomeowner
            // 
            this.btnSelectHomeowner.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectHomeowner.FlatAppearance.BorderSize = 0;
            this.btnSelectHomeowner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectHomeowner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSelectHomeowner.ForeColor = System.Drawing.Color.White;
            this.btnSelectHomeowner.Location = new System.Drawing.Point(533, 166);
            this.btnSelectHomeowner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectHomeowner.Name = "btnSelectHomeowner";
            this.btnSelectHomeowner.Size = new System.Drawing.Size(192, 34);
            this.btnSelectHomeowner.TabIndex = 26;
            this.btnSelectHomeowner.Text = "Select Homeowner";
            this.btnSelectHomeowner.UseVisualStyleBackColor = false;
            // 
            // txtHomeownerIDDisplay
            // 
            this.txtHomeownerIDDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.txtHomeownerIDDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHomeownerIDDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHomeownerIDDisplay.Location = new System.Drawing.Point(248, 167);
            this.txtHomeownerIDDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHomeownerIDDisplay.Multiline = true;
            this.txtHomeownerIDDisplay.Name = "txtHomeownerIDDisplay";
            this.txtHomeownerIDDisplay.ReadOnly = true;
            this.txtHomeownerIDDisplay.Size = new System.Drawing.Size(279, 33);
            this.txtHomeownerIDDisplay.TabIndex = 27;
            this.txtHomeownerIDDisplay.TabStop = false;
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.BackColor = System.Drawing.Color.Transparent;
            this.lblNames.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNames.Location = new System.Drawing.Point(551, 215);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(145, 27);
            this.lblNames.TabIndex = 55;
            this.lblNames.Text = "Select Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(112, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 27);
            this.label13.TabIndex = 54;
            this.label13.Text = "Residency:";
            // 
            // cmbNames
            // 
            this.cmbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(701, 213);
            this.cmbNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(274, 33);
            this.cmbNames.TabIndex = 53;
            // 
            // cmbResidency
            // 
            this.cmbResidency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbResidency.FormattingEnabled = true;
            this.cmbResidency.Location = new System.Drawing.Point(233, 213);
            this.cmbResidency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbResidency.Name = "cmbResidency";
            this.cmbResidency.Size = new System.Drawing.Size(294, 33);
            this.cmbResidency.TabIndex = 52;
            // 
            // cmbRemarks
            // 
            this.cmbRemarks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cmbRemarks.FormattingEnabled = true;
            this.cmbRemarks.Location = new System.Drawing.Point(844, 511);
            this.cmbRemarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRemarks.Name = "cmbRemarks";
            this.cmbRemarks.Size = new System.Drawing.Size(233, 35);
            this.cmbRemarks.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(680, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 27);
            this.label11.TabIndex = 58;
            this.label11.Text = "Remarks:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(680, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 27);
            this.label10.TabIndex = 57;
            this.label10.Text = "Change given:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(680, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 27);
            this.label8.TabIndex = 56;
            this.label8.Text = "Amount Paid:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(112, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 62;
            this.label9.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(112, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 27);
            this.label12.TabIndex = 63;
            this.label12.Text = "Address:";
            // 
            // btnToggleSelectAll
            // 
            this.btnToggleSelectAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnToggleSelectAll.Location = new System.Drawing.Point(503, 426);
            this.btnToggleSelectAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToggleSelectAll.Name = "btnToggleSelectAll";
            this.btnToggleSelectAll.Size = new System.Drawing.Size(114, 33);
            this.btnToggleSelectAll.TabIndex = 64;
            this.btnToggleSelectAll.Text = "Select All";
            this.btnToggleSelectAll.UseVisualStyleBackColor = true;
            // 
            // txtPaid
            // 
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txtPaid.Location = new System.Drawing.Point(844, 419);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(233, 33);
            this.txtPaid.TabIndex = 65;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtChange
            // 
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txtChange.Location = new System.Drawing.Point(844, 465);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(233, 33);
            this.txtChange.TabIndex = 67;
            // 
            // UpdateMonthlyDues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 744);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.btnToggleSelectAll);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.cmbResidency);
            this.Controls.Add(this.txtHomeownerIDDisplay);
            this.Controls.Add(this.btnSelectHomeowner);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbMissedMonths);
            this.Controls.Add(this.lblResidentName);
            this.Controls.Add(this.cancelvisitor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRemainingDebt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUnitAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateMonthlyDues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateMonthlyDues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUnitAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button cancelvisitor;
        private System.Windows.Forms.Label lblRemainingDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblResidentName;
        private System.Windows.Forms.CheckedListBox clbMissedMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnSelectHomeowner;
        private System.Windows.Forms.TextBox txtHomeownerIDDisplay;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.ComboBox cmbResidency;
        private System.Windows.Forms.ComboBox cmbRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnToggleSelectAll;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtChange;
    }
}