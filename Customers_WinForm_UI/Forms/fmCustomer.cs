/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */

using System;
using System.Windows.Forms;
using Customers_WinForm_UI.CustomersService;

namespace Customers_WinForm_UI
{
    /// <summary>
    /// Form for the entry of a new client or editing an existing
    /// </summary>
    public partial class fmCustomer : Form
    {

        #region Private properties

        Customer customer;
        bool isSaved;

        #endregion

        #region Public properties

        /// <summary>
        /// An object of type 'Customer'
        /// </summary>
        public Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        /// <summary>
        /// Whether the user has written data on form
        /// </summary>
        public bool IsSaved
        {
            get
            {
                return isSaved;
            }

            set
            {
                isSaved = value;
            }
        }

        #endregion

        #region The class constructor

        /// <summary>
        /// The default constructor
        /// </summary>
        public fmCustomer()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        #region Form buttons

        /// <summary>
        /// When the user clicks the button, saves data to the storage and closes the form
        /// </summary>
        private void btSave_Click(object sender, EventArgs e)
        {
            this.customer.Name = tbName.Text;
            this.customer.Surname = tbSurname.Text;
            this.customer.PhoneNumber = tbPhoneNumber.Text;
            this.customer.PostalAddressCity = tbCity.Text;
            this.customer.PostalAddressStreet = tbStreet.Text;
            this.customer.PostalAddressCode = tbPostalCode.Text;

            using (CustomersService.CustomersServiceClient client = new CustomersService.CustomersServiceClient())
            {
                ResultObject result = client.SaveCustomer(this.customer);
                if (!result.ContainsErrors)
                {
                    this.isSaved = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// When the user clicks the button, closes the form
        /// </summary>
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.isSaved = false;
            this.Close();
        }

        #endregion

        #region Form methods

        /// <summary>
        /// Fired when the form is load
        /// </summary>
        private void fmCustomer_Load(object sender, EventArgs e)
        {
            if(this.customer == null)
            {
                this.customer = new Customer();
            }
            else
            {
                CustomerDataToControls();
            }
        }

        /// <summary>
        /// Copies data from 'Customer' object to controls on the form
        /// </summary>
        private void CustomerDataToControls()
        {
            tbName.Text = this.customer.Name;
            tbSurname.Text = this.customer.Surname;
            tbPhoneNumber.Text = this.customer.PhoneNumber;
            tbCity.Text = this.customer.PostalAddressCity;
            tbStreet.Text = this.customer.PostalAddressStreet;
            tbPostalCode.Text = this.customer.PostalAddressCode;

            this.Text = string.Format("{0} {1}", this.customer.Name, this.customer.Surname);
        }

        /// <summary>
        /// Keyboard (save and exit operations)
        /// </summary>
        private void fmCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.btCancel_Click(null, null);
            if (e.KeyCode == Keys.Enter) this.btSave_Click(null, null);
        }

        #endregion

        #endregion
    }
}
