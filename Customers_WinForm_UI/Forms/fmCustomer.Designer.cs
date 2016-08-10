namespace Customers_WinForm_UI
{
    partial class fmCustomer
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
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.lbPostalCode = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lbStreet = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.lbPhoneNumber);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.lbSurname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(107, 67);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(183, 20);
            this.tbPhoneNumber.TabIndex = 5;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(7, 70);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lbPhoneNumber.TabIndex = 4;
            this.lbPhoneNumber.Text = "PhoneNumber:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(183, 20);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(7, 44);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(107, 15);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(183, 20);
            this.tbSurname.TabIndex = 1;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(6, 18);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(52, 13);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Surname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPostalCode);
            this.groupBox2.Controls.Add(this.lbPostalCode);
            this.groupBox2.Controls.Add(this.tbStreet);
            this.groupBox2.Controls.Add(this.lbStreet);
            this.groupBox2.Controls.Add(this.tbCity);
            this.groupBox2.Controls.Add(this.lbCity);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(107, 77);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(183, 20);
            this.tbPostalCode.TabIndex = 11;
            // 
            // lbPostalCode
            // 
            this.lbPostalCode.AutoSize = true;
            this.lbPostalCode.Location = new System.Drawing.Point(7, 80);
            this.lbPostalCode.Name = "lbPostalCode";
            this.lbPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lbPostalCode.TabIndex = 10;
            this.lbPostalCode.Text = "Postal Code:";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(107, 51);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(183, 20);
            this.tbStreet.TabIndex = 9;
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(7, 54);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(38, 13);
            this.lbStreet.TabIndex = 8;
            this.lbStreet.Text = "Street:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(107, 25);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(183, 20);
            this.tbCity.TabIndex = 7;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(7, 28);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(27, 13);
            this.lbCity.TabIndex = 6;
            this.lbCity.Text = "City:";
            // 
            // btSave
            // 
            this.btSave.Image = global::Customers_WinForm_UI.Properties.Resources.saveIcon;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(4, 216);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(86, 32);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = global::Customers_WinForm_UI.Properties.Resources.cancelIcon;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(96, 216);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(85, 32);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(312, 257);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(328, 296);
            this.MinimumSize = new System.Drawing.Size(328, 296);
            this.Name = "fmCustomer";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New customer";
            this.Load += new System.EventHandler(this.fmCustomer_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fmCustomer_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Label lbPostalCode;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Button btCancel;
    }
}