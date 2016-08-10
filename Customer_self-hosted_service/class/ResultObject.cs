/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */


namespace Customers_self_hosted_service
{
    /// <summary>
    /// Class contains informations about results from service methods.
    /// Contains informations about returned objects and errors
    /// </summary>
    public class ResultObject
    {

        #region Private properties

        bool containsErrors;
        string errorMessage;
        Customer customer;
        CustomerList customers;

        #endregion

        #region Public properties

        /// <summary>
        /// Whether the result contains errors
        /// </summary>
        public bool ContainsErrors
        {
            get
            {
                return containsErrors;
            }

            set
            {
                containsErrors = value;
            }
        }

        /// <summary>
        /// Error message (if ContainsErrors == true)
        /// </summary>
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }

            set
            {
                errorMessage = value;
            }
        }

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
        /// An object of type 'CustomerList'
        /// </summary>
        public CustomerList Customers
        {
            get
            {
                return customers;
            }

            set
            {
                customers = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public ResultObject()
        {

        }

        /// <summary>
        /// Creates object with error message
        /// </summary>
        /// <param name="errorMsg">Error message</param>
        public ResultObject(string errorMsg)
        {
            this.containsErrors = true;
            this.errorMessage = errorMsg;
        }

        /// <summary>
        /// It creates an object and fills it with the object of 'Customer'
        /// </summary>
        /// <param name="result">An object of type 'Customer'</param>
        public ResultObject(Customer result)
        {
            this.customer = result;
        }

        /// <summary>
        /// It creates an object and fills it with the object of 'CustomerList'
        /// </summary>
        /// <param name="result">An object of type 'CustomerList'</param>
        public ResultObject(CustomerList result)
        {
            this.customers = result;
        }

        #endregion

    }
}
