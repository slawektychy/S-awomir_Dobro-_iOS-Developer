/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Customers_WinForm_UI.CustomersService;

namespace Customers_WinForm_UI
{
    /// <summary>
    /// Form to display and manage a list of clients
    /// </summary>
    public partial class fmCustomers : Form
    {

        #region Private properties

        bool isGridFormated = false;
        Customer[] customers;
        int selectedID;
        CustomerListFilter filter;

        #endregion

        #region The class constructor

        /// <summary>
        /// The default constructor
        /// </summary>
        public fmCustomers()
        {
            InitializeComponent();
            filter = new CustomerListFilter();
        }

        #endregion

        #region Private methods

        #region Form methods

        /// <summary>
        /// Fired when the form is load
        /// </summary>
        private void fmCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                GetCustomersFromService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Keyboard (buttons actions)
        /// </summary>
        private void fmCustomers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control) addToolStripButton_Click(null, null);
            if (e.KeyCode == Keys.E && e.Control) EditToolStripButton_Click(null, null);
            if (e.KeyCode == Keys.D && e.Control) DeleteStripButton_Click(null, null);
            if (e.KeyCode == Keys.S && e.Control) SearchStripButton_Click(null, null);
        }

        #endregion

        #region ToolStripButtons

        /// <summary>
        /// Starts new customer form
        /// </summary>
        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            fmCustomer fm = new fmCustomer();
            fm.ShowDialog();
            if (fm.IsSaved) GetCustomersFromService();
        }

        /// <summary>
        /// Starts edit customer form
        /// </summary>
        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        /// <summary>
        /// Starts search customers form
        /// </summary>
        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            fmFilter fm = new fmFilter();
            fm.Filter = this.filter;
            fm.FilterChanged += Fm_FilterChanged;
            fm.ShowDialog();

            GetCustomersFromService();

        }

        /// <summary>
        /// Reaction to the event filter changes
        /// </summary>
        private void Fm_FilterChanged()
        {
            lbFilterStripStatus.Visible = filter.IsEnabled;
            
            string activeFilter = string.Format("Active filter: [{0}]  [{1}]  ['{2}']"
                , filter.FieldName.ToString()
                , filter.Condition.ToString()
                , filter.FieldValue
                );
            lbFilterStripStatus.Text = activeFilter;
        }

        /// <summary>
        /// Starts delete customer process
        /// </summary>
        private void DeleteStripButton_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count == 0) return;
            DeleteCustomer();
        }

        #endregion

        #region DataGridView actions

        /// <summary>
        /// Reaction to the event: grid selection changed
        /// </summary>
        private void dgvCustomerList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count == 0) return;
            selectedID = (int)dgvCustomerList.SelectedRows[0].Cells["id"].Value;
        }

        /// <summary>
        /// Reaction to the event: grid cell double click
        /// </summary>
        private void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedID = (int)dgvCustomerList.Rows[e.RowIndex].Cells["id"].Value;
            EditCustomer();
        }

        /// <summary>
        /// Decides how is grid look like
        /// </summary>
        private void FormatDataGridView()
        {
            DataGridViewColumn col = dgvCustomerList.Columns["Id"];
            col.Visible = false;

            col = dgvCustomerList.Columns["Name"];
            col.Width = 140;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            col = dgvCustomerList.Columns["Surname"];
            col.Width = 140;

            col = dgvCustomerList.Columns["PhoneNumber"];
            col.Width = 90;
            col.HeaderText = "Phone number";

            col = dgvCustomerList.Columns["PostalAddressCity"];
            col.Width = 190;
            col.HeaderText = "City";

            col = dgvCustomerList.Columns["PostalAddressCode"];
            col.Width = 60;
            col.HeaderText = "Postal Code";

            col = dgvCustomerList.Columns["PostalAddressStreet"];
            col.Width = 170;
            col.HeaderText = "Street";

            isGridFormated = true;
        }


        #endregion

        #region Operations on customers objects
       
        /// <summary>
        /// Move data from objects to datagidview
        /// </summary>
        private void CustomersToDataGridView()
        {
            int tmpSelectedID = selectedID;

            var result = from c in this.customers
                         select new
                         {
                             c.Id,
                             c.Surname,
                             c.Name,
                             c.PhoneNumber,
                             c.PostalAddressCity,
                             c.PostalAddressCode,
                             c.PostalAddressStreet
                         };

            dgvCustomerList.DataSource = result.ToList();
            selectedID = tmpSelectedID;
            SetSelectedRow();

            if (!isGridFormated) FormatDataGridView();
        }

        /// <summary>
        /// Set selected rows in datagidview
        /// </summary>
        private void SetSelectedRow()
        {
            foreach (DataGridViewRow row in dgvCustomerList.Rows)
            {
                if ((int)row.Cells["id"].Value == selectedID)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        /// <summary>
        /// Edit customer action
        /// </summary>
        private void EditCustomer()
        {
            if (selectedID > 0)
            {
                CustomersServiceClient client = new CustomersServiceClient();
                ResultObject result = client.GetCustomer(selectedID);
                if (!result.ContainsErrors)
                {
                    fmCustomer fm = new fmCustomer();
                    fm.Customer = result.Customer;
                    fm.ShowDialog();
                    if (fm.IsSaved) GetCustomersFromService();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Delete customer action
        /// </summary>
        private void DeleteCustomer()
        {
            DialogResult dlgRes = MessageBox.Show("Are you sure you want delete selected customers?", "Confirm to remove"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgRes == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvCustomerList.SelectedRows)
                {
                    selectedID = (int)row.Cells["Id"].Value;
                    CustomersServiceClient client = new CustomersServiceClient();
                    ResultObject result = client.DeleteCustomer(selectedID);
                    if (result.ContainsErrors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                GetCustomersFromService();
            }
        }

        /// <summary>
        /// Gets customers data from service
        /// </summary>
        private void GetCustomersFromService()
        {
            CustomersServiceClient client = new CustomersServiceClient();
            ResultObject result = null;

            if (filter.IsEnabled) { result = client.GetCustomerListByFilter(filter); }
            else { result = client.GetCustomerList(); }

            if (!result.ContainsErrors)
            {
                customers = result.Customers;
                CustomersToDataGridView();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

    }
}
