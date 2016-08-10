/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */

using System.ServiceModel;

namespace Customers_self_hosted_service
{
    /// <summary>
    /// The interface defines the operation contracts
    /// </summary>
    [ServiceContract]
    public interface ICustomersService
    {
        [OperationContract]
        ResultObject GetCustomer(int customerID);

        [OperationContract]
        ResultObject GetCustomerList();

        [OperationContract]
        ResultObject GetCustomerListByFilter(CustomerListFilter filter);

        [OperationContract]
        ResultObject SaveCustomer(Customer customer);

        [OperationContract]
        ResultObject DeleteCustomer(int customerID);
    }

    /// <summary>
    /// Class that implements the interface ICustomersService
    /// </summary>
    public class CustomersService : ICustomersService
    {
        /// <summary>
        /// Gets customer data from storage
        /// </summary>
        /// <param name="customerID">Customer identifier</param>
        /// <returns>ResultObject contains object of 'Customer' or informations about errors</returns>
        public ResultObject GetCustomer(int customerID)
        {
            try
            {
                Customer customer = new Customer(customerID);
                return new ResultObject(customer);
            }
            catch (System.Exception ex)
            {
                return new ResultObject(ex.Message);
            }

        }

        /// <summary>
        /// Gets customers data from storage
        /// </summary>
        /// <returns>ResultObject contains object of 'CustomerList' or informations about errors</returns>
        public ResultObject GetCustomerList()
        {
            try
            {
                CustomerList customers = new CustomerList();
                customers.GetAllItems();
                return new ResultObject(customers);
            }
            catch (System.Exception ex)
            {
                return new ResultObject(ex.Message);
            }
        }

        /// <summary>
        /// Gets filtered customers data from storage
        /// </summary>
        /// <param name="filter">The 'CustomerListFilter' type object , which contains information on how to filter data</param>
        /// <returns>ResultObject contains object of 'CustomerList' or informations about errors</returns>
        public ResultObject GetCustomerListByFilter(CustomerListFilter filter)
        {
            try
            {
                CustomerList customers = new CustomerList();
                customers.GetItemsByFilter(filter);
                return new ResultObject(customers);
            }
            catch (System.Exception ex)
            {
                return new ResultObject(ex.Message);
            }
        }

        /// <summary>
        /// Save customer data to storage
        /// </summary>
        /// <param name="customer">The 'Customer' type object </param>
        /// <returns>ResultObject contains informations about errors (if exist)</returns>
        public ResultObject SaveCustomer(Customer customer)
        {
            try
            {
                customer.Save();
                return new ResultObject();
            }
            catch(System.Exception ex)
            {
                return new ResultObject(ex.Message);
            }
        }

        /// <summary>
        /// Save customer data from storage
        /// </summary>
        /// <param name="customerID">Customer identifier</param>
        /// <returns>ResultObject contains informations about errors (if exist)</returns>
        public ResultObject DeleteCustomer(int customerID)
        {
            try
            {
                Customer customer = new Customer(customerID);
                customer.Delete();
                return new ResultObject();
            }
            catch (System.Exception ex)
            {
                return new ResultObject(ex.Message);
            }
        }
    }

}
