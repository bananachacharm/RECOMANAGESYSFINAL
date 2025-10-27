namespace RECOMANAGESYS
{
    partial class UnitsForm
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
            this.btnUnregisterSelected = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.DGVUnits = new System.Windows.Forms.DataGridView();
            this.DGVTCunregister = new System.Windows.Forms.DataGridView();
            this.btnUnregisterTC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTCunregister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnregisterSelected
            // 
            this.btnUnregisterSelected.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btnUnregisterSelected.Location = new System.Drawing.Point(12, 19);
            this.btnUnregisterSelected.Name = "btnUnregisterSelected";
            this.btnUnregisterSelected.Size = new System.Drawing.Size(218, 40);
            this.btnUnregisterSelected.TabIndex = 1;
            this.btnUnregisterSelected.Text = "Unregister Units";
            this.btnUnregisterSelected.UseVisualStyleBackColor = true;
            this.btnUnregisterSelected.Click += new System.EventHandler(this.btnUnregisterSelected_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btnCancel.Location = new System.Drawing.Point(977, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGVUnits
            // 
            this.DGVUnits.AllowUserToAddRows = false;
            this.DGVUnits.AllowUserToDeleteRows = false;
            this.DGVUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUnits.Location = new System.Drawing.Point(12, 65);
            this.DGVUnits.MultiSelect = false;
            this.DGVUnits.Name = "DGVUnits";
            this.DGVUnits.RowHeadersWidth = 51;
            this.DGVUnits.RowTemplate.Height = 24;
            this.DGVUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUnits.Size = new System.Drawing.Size(1072, 242);
            this.DGVUnits.TabIndex = 3;
            // 
            // DGVTCunregister
            // 
            this.DGVTCunregister.AllowUserToAddRows = false;
            this.DGVTCunregister.AllowUserToDeleteRows = false;
            this.DGVTCunregister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTCunregister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTCunregister.Location = new System.Drawing.Point(12, 372);
            this.DGVTCunregister.MultiSelect = false;
            this.DGVTCunregister.Name = "DGVTCunregister";
            this.DGVTCunregister.RowHeadersWidth = 51;
            this.DGVTCunregister.RowTemplate.Height = 24;
            this.DGVTCunregister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTCunregister.Size = new System.Drawing.Size(1072, 242);
            this.DGVTCunregister.TabIndex = 4;
            // 
            // btnUnregisterTC
            // 
            this.btnUnregisterTC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btnUnregisterTC.Location = new System.Drawing.Point(12, 326);
            this.btnUnregisterTC.Name = "btnUnregisterTC";
            this.btnUnregisterTC.Size = new System.Drawing.Size(286, 40);
            this.btnUnregisterTC.TabIndex = 5;
            this.btnUnregisterTC.Text = "Unregister Tenant/Caretaker";
            this.btnUnregisterTC.UseVisualStyleBackColor = true;
            this.btnUnregisterTC.Click += new System.EventHandler(this.btnUnregisterTC_Click);
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1099, 636);
            this.Controls.Add(this.btnUnregisterTC);
            this.Controls.Add(this.DGVTCunregister);
            this.Controls.Add(this.DGVUnits);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnregisterSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UnitsForm";
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTCunregister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnregisterSelected;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView DGVUnits;
        private System.Windows.Forms.DataGridView DGVTCunregister;
        private System.Windows.Forms.Button btnUnregisterTC;
    }
}