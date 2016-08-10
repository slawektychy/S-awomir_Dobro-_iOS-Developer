namespace Customers_WinForm_UI
{
    partial class fmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbFilterStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.EditToolStripButton,
            this.DeleteStripButton,
            this.toolStripSeparator1,
            this.SearchStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.ToolTipText = "Add new customer [CTRL + A]";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton.Image")));
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.EditToolStripButton.Text = "Edit";
            this.EditToolStripButton.ToolTipText = "Edit selected customer [CTRL + E]";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // DeleteStripButton
            // 
            this.DeleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteStripButton.Image")));
            this.DeleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteStripButton.Name = "DeleteStripButton";
            this.DeleteStripButton.Size = new System.Drawing.Size(60, 22);
            this.DeleteStripButton.Text = "Delete";
            this.DeleteStripButton.ToolTipText = "Edit selected customers [CTRL + D]";
            this.DeleteStripButton.Click += new System.EventHandler(this.DeleteStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SearchStripButton
            // 
            this.SearchStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchStripButton.Image")));
            this.SearchStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchStripButton.Name = "SearchStripButton";
            this.SearchStripButton.Size = new System.Drawing.Size(62, 22);
            this.SearchStripButton.Text = "Search";
            this.SearchStripButton.ToolTipText = "Search [CTRL + S]";
            this.SearchStripButton.Click += new System.EventHandler(this.SearchStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbFilterStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbFilterStripStatus
            // 
            this.lbFilterStripStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbFilterStripStatus.Name = "lbFilterStripStatus";
            this.lbFilterStripStatus.Size = new System.Drawing.Size(70, 17);
            this.lbFilterStripStatus.Text = "Active filter:";
            this.lbFilterStripStatus.Visible = false;
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerList.Location = new System.Drawing.Point(5, 5);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersWidth = 20;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(867, 387);
            this.dgvCustomerList.TabIndex = 2;
            this.dgvCustomerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellDoubleClick);
            this.dgvCustomerList.SelectionChanged += new System.EventHandler(this.dgvCustomerList_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCustomerList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(877, 397);
            this.panel1.TabIndex = 3;
            // 
            // fmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(877, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "fmCustomers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer list";
            this.Load += new System.EventHandler(this.fmCustomers_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fmCustomers_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton DeleteStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SearchStripButton;
        private System.Windows.Forms.ToolStripStatusLabel lbFilterStripStatus;
    }
}

