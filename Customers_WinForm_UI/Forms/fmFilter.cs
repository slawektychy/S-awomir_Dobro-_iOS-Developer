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
    /// Delegate for event handler
    /// </summary>
    public delegate void myEventHandler();

    /// <summary>
    /// Form to define customers list filter
    /// </summary>
    public partial class fmFilter : Form
    {
        #region Public properties

        /// <summary>
        /// Event handler fired when filter parameters changed
        /// </summary>
        public event myEventHandler FilterChanged;

        /// <summary>
        /// Instance of CustomerListFilter
        /// </summary>
        public CustomerListFilter Filter;

        #endregion

        #region The class constructor

        /// <summary>
        /// The default constructor
        /// </summary>
        public fmFilter()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        #region Events of controls 

        /// <summary>
        /// Reaction to the event: check box 'Enabled' changed
        /// </summary>
        private void chbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Filter.IsEnabled = cbConditions.Enabled = cbField.Enabled = tbValue.Enabled = chbEnabled.Checked;
            FilterChanged();
        }

        /// <summary>
        /// Reaction to the event: field name changed
        /// </summary>
        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter.FieldName = (FilterFieldsNames)cbField.SelectedIndex;
            FilterChanged();
        }

        /// <summary>
        /// Reaction to the event: condition changed
        /// </summary>
        private void cbConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter.Condition = (FilterConditions)cbConditions.SelectedIndex;
            FilterChanged();
        }

        /// <summary>
        /// Reaction to the event: field value changed
        /// </summary>
        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            Filter.FieldValue = tbValue.Text;
            FilterChanged();
        }

        #endregion

        #region Form methods

        /// <summary>
        /// Fired when the form is load
        /// </summary>
        private void fmFilter_Load(object sender, EventArgs e)
        {
            chbEnabled.Checked = Filter.IsEnabled;
            cbField.SelectedIndex = (int)Filter.FieldName;
            cbConditions.SelectedIndex = (int)Filter.Condition;
            tbValue.Text = Filter.FieldValue;

            chbEnabled_CheckedChanged(null, null);
        }

        /// <summary>
        /// Keyboard actions
        /// </summary>
        private void fmFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.btCancel_Click(null, null);
            if (e.KeyCode == Keys.Enter) this.btSearch_Click(null, null);
        }

        #endregion

        #region Buttons

        /// <summary>
        /// When the user clicks the button, closes the form
        /// </summary>
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When the user clicks the button, saves filter parameters and closes the form
        /// </summary>
        private void btSearch_Click(object sender, EventArgs e)
        {
            Filter.FieldName = (FilterFieldsNames)cbField.SelectedIndex;
            Filter.Condition = (FilterConditions)cbConditions.SelectedIndex;
            Filter.FieldValue = tbValue.Text;
            this.Close();
        }


        #endregion

    }

    #endregion
}
