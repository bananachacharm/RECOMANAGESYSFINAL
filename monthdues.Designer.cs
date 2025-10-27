namespace RECOMANAGESYS
{
    partial class monthdues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monthdues));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToggleSelect = new System.Windows.Forms.Button();
            this.cmbResidentFilter = new System.Windows.Forms.ComboBox();
            this.lvResidents = new System.Windows.Forms.ListView();
            this.lvMonths = new System.Windows.Forms.ListView();
            this.btnProcess = new System.Windows.Forms.Button();
            this.searchbtn = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.updatePayment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addPayment = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.updatePayment);
            this.panel1.Controls.Add(this.addPayment);
            this.panel1.Controls.Add(this.btnToggleSelect);
            this.panel1.Controls.Add(this.cmbResidentFilter);
            this.panel1.Controls.Add(this.lvResidents);
            this.panel1.Controls.Add(this.lvMonths);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(26, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 626);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnToggleSelect
            // 
            this.btnToggleSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnToggleSelect.Location = new System.Drawing.Point(294, 98);
            this.btnToggleSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToggleSelect.Name = "btnToggleSelect";
            this.btnToggleSelect.Size = new System.Drawing.Size(114, 33);
            this.btnToggleSelect.TabIndex = 10;
            this.btnToggleSelect.Text = "Select all";
            this.btnToggleSelect.UseVisualStyleBackColor = true;
            // 
            // cmbResidentFilter
            // 
            this.cmbResidentFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbResidentFilter.FormattingEnabled = true;
            this.cmbResidentFilter.Location = new System.Drawing.Point(59, 101);
            this.cmbResidentFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbResidentFilter.Name = "cmbResidentFilter";
            this.cmbResidentFilter.Size = new System.Drawing.Size(230, 28);
            this.cmbResidentFilter.TabIndex = 9;
            this.cmbResidentFilter.Text = "Resident Filter";
            this.cmbResidentFilter.SelectedIndexChanged += new System.EventHandler(this.cmbResidentFilter_SelectedIndexChanged);
            // 
            // lvResidents
            // 
            this.lvResidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvResidents.CheckBoxes = true;
            this.lvResidents.GridLines = true;
            this.lvResidents.HideSelection = false;
            this.lvResidents.Location = new System.Drawing.Point(59, 137);
            this.lvResidents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvResidents.Name = "lvResidents";
            this.lvResidents.Size = new System.Drawing.Size(935, 226);
            this.lvResidents.TabIndex = 8;
            this.lvResidents.UseCompatibleStateImageBehavior = false;
            this.lvResidents.View = System.Windows.Forms.View.Details;
            // 
            // lvMonths
            // 
            this.lvMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMonths.GridLines = true;
            this.lvMonths.HideSelection = false;
            this.lvMonths.Location = new System.Drawing.Point(59, 375);
            this.lvMonths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMonths.Name = "lvMonths";
            this.lvMonths.Size = new System.Drawing.Size(935, 217);
            this.lvMonths.TabIndex = 7;
            this.lvMonths.UseCompatibleStateImageBehavior = false;
            this.lvMonths.View = System.Windows.Forms.View.Details;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(837, 82);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(157, 41);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Generate SOA";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchbtn.IconColor = System.Drawing.Color.Black;
            this.searchbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchbtn.IconSize = 28;
            this.searchbtn.Location = new System.Drawing.Point(944, 29);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(50, 38);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(641, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(353, 38);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // updatePayment
            // 
            this.updatePayment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.updatePayment.FlatAppearance.BorderSize = 0;
            this.updatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.updatePayment.ForeColor = System.Drawing.Color.White;
            this.updatePayment.Location = new System.Drawing.Point(59, 31);
            this.updatePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePayment.Name = "updatePayment";
            this.updatePayment.Size = new System.Drawing.Size(157, 41);
            this.updatePayment.TabIndex = 5;
            this.updatePayment.Text = "Update Payment";
            this.updatePayment.UseVisualStyleBackColor = false;
            this.updatePayment.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(27, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 65);
            this.panel2.TabIndex = 2;
            // 
            // addPayment
            // 
            this.addPayment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addPayment.FlatAppearance.BorderSize = 0;
            this.addPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.addPayment.ForeColor = System.Drawing.Color.White;
            this.addPayment.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addPayment.IconColor = System.Drawing.Color.White;
            this.addPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addPayment.IconSize = 25;
            this.addPayment.Location = new System.Drawing.Point(234, 31);
            this.addPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPayment.Name = "addPayment";
            this.addPayment.Size = new System.Drawing.Size(157, 41);
            this.addPayment.TabIndex = 5;
            this.addPayment.Text = "Add Payment";
            this.addPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPayment.UseVisualStyleBackColor = false;
            this.addPayment.Click += new System.EventHandler(this.addvisitor_Click);
            // 
            // monthdues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "monthdues";
            this.Size = new System.Drawing.Size(1110, 736);
            this.Load += new System.EventHandler(this.monthdues_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton searchbtn;
        private System.Windows.Forms.Button btnProcess;
        private FontAwesome.Sharp.IconButton addPayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updatePayment;
        private System.Windows.Forms.ListView lvMonths;
        private System.Windows.Forms.ListView lvResidents;
        private System.Windows.Forms.ComboBox cmbResidentFilter;
        private System.Windows.Forms.Button btnToggleSelect;
    }
}
