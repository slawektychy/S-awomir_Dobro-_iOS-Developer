namespace Customers_WinForm_UI
{
    partial class fmFilter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbConditions = new System.Windows.Forms.ComboBox();
            this.cbField = new System.Windows.Forms.ComboBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.chbEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbEnabled);
            this.groupBox1.Controls.Add(this.cbConditions);
            this.groupBox1.Controls.Add(this.cbField);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbSurname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbConditions
            // 
            this.cbConditions.FormattingEnabled = true;
            this.cbConditions.Items.AddRange(new object[] {
            "Is Equal",
            "Contains"});
            this.cbConditions.Location = new System.Drawing.Point(76, 62);
            this.cbConditions.Name = "cbConditions";
            this.cbConditions.Size = new System.Drawing.Size(183, 21);
            this.cbConditions.TabIndex = 9;
            this.cbConditions.SelectedIndexChanged += new System.EventHandler(this.cbConditions_SelectedIndexChanged);
            // 
            // cbField
            // 
            this.cbField.FormattingEnabled = true;
            this.cbField.Items.AddRange(new object[] {
            "Name",
            "Surname",
            "Phone number",
            "City",
            "Street",
            "Postcode"});
            this.cbField.Location = new System.Drawing.Point(76, 36);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(183, 21);
            this.cbField.TabIndex = 8;
            this.cbField.SelectedIndexChanged += new System.EventHandler(this.cbField_SelectedIndexChanged);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(76, 88);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(183, 20);
            this.tbValue.TabIndex = 7;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Condition:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(9, 39);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(32, 13);
            this.lbSurname.TabIndex = 2;
            this.lbSurname.Text = "Field:";
            // 
            // btSearch
            // 
            this.btSearch.Image = global::Customers_WinForm_UI.Properties.Resources.searchIcon;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.Location = new System.Drawing.Point(93, 131);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(93, 32);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // chbEnabled
            // 
            this.chbEnabled.AutoSize = true;
            this.chbEnabled.Location = new System.Drawing.Point(76, 13);
            this.chbEnabled.Name = "chbEnabled";
            this.chbEnabled.Size = new System.Drawing.Size(65, 17);
            this.chbEnabled.TabIndex = 10;
            this.chbEnabled.Text = "Enabled";
            this.chbEnabled.UseVisualStyleBackColor = true;
            this.chbEnabled.CheckedChanged += new System.EventHandler(this.chbEnabled_CheckedChanged);
            // 
            // fmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(280, 171);
            this.ControlBox = false;
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(296, 210);
            this.MinimumSize = new System.Drawing.Size(296, 195);
            this.Name = "fmFilter";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.fmFilter_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fmFilter_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbField;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ComboBox cbConditions;
        private System.Windows.Forms.CheckBox chbEnabled;
    }
}