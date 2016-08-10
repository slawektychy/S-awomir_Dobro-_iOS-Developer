/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace Customers_self_hosted_service
{
    /// <summary>
    /// Class contains list of Customer objects (List<Customer>)
    /// </summary>
    public class CustomerList:List<Customer>
    {
        #region Private properties

        /// <summary>
        /// Stores contents of a database query
        /// </summary>
        string query;

        #endregion

        #region Private methods

        /// <summary>
        /// Dynamically adds conditions to the sql query
        /// </summary>
        /// <param name="filter">The 'CustomerListFilter' type object , which contains information on how to filter data</param>
        private void AddConditions(CustomerListFilter filter)
        {
#if (SQL_DATA)

            string fieldNameDB = "";
            switch (filter.FieldName)
            {
                case FilterFieldsNames.NAME:
                    fieldNameDB = "name";
                    break;
                case FilterFieldsNames.SURNAME:
                    fieldNameDB = "surname";
                    break;

                case FilterFieldsNames.PHONE:
                    fieldNameDB = "phoneNumber";
                    break;

                case FilterFieldsNames.CITY:
                    fieldNameDB = "AddressCity";
                    break;

                case FilterFieldsNames.STREET:
                    fieldNameDB = "AddressStreet";
                    break;

                case FilterFieldsNames.POSTCODE:
                    fieldNameDB = "AddressCode";
                    break;

            }

            switch (filter.Condition)
            {
                case FilterConditions.IS_EQUAL:
                    query += string.Format(" WHERE {0} = '{1}'", fieldNameDB, filter.FieldValue);
                    break;
                case FilterConditions.CONTAINS:
                    query += string.Format(" WHERE {0} like '%{1}%'", fieldNameDB, filter.FieldValue);
                    break;
            }    

#endif
        }

        /// <summary>
        /// Executes the query on the database
        /// </summary>
        /// <param name="filter">The 'CustomerListFilter' type object , which contains information on how to filter data. 
        /// If this parameter is 'null', function gets all data without any conditions.</param>
        private void MakeQuery(CustomerListFilter filter)
        {

#if (SQL_DATA)
            query = string.Format("SELECT id,rtrim(name),rtrim(surname),rtrim(phoneNumber),rtrim(AddressCity),rtrim(AddressStreet),rtrim(AddressCode) From dbo.customers");
            if (filter != null) AddConditions(filter);

            using (var conn = new SqlConnection(Properties.Settings.Default.SqlConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Customer customer = new Customer();
                        customer.Id = rdr.GetInt32(0);
                        customer.Name = rdr.GetString(1);
                        customer.Surname = rdr.GetString(2);
                        customer.PhoneNumber = rdr.GetString(3);
                        customer.PostalAddressCity = rdr.GetString(4);
                        customer.PostalAddressStreet = rdr.GetString(5);
                        customer.PostalAddressCode = rdr.GetString(6);
                        this.Add(customer);
                    }
                }
                conn.Close();
            }
#endif
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets all customers data from sql database or xml file
        /// </summary>
        public void GetAllItems()
        {
            this.Clear();

#if (SQL_DATA)
            // Gets all costomers data from sql database
            MakeQuery(null);
#endif

#if (XML_DATA)
            // Gets all costomers data from xml file
            XDocument xmlDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");
            IEnumerable<Customer> tmp = from c in xmlDoc.Descendants("Customer")
                                        select new Customer()
                                        {
                                            Id = (int)c.Attribute("id"),
                                            Name = (string)c.Element("Name").Value,
                                            Surname = (string)c.Element("Surname").Value,
                                            PhoneNumber = (string)c.Element("PhoneNumber").Value,
                                            PostalAddressCity = (string)c.Element("PostalAddressCity").Value,
                                            PostalAddressStreet = (string)c.Element("PostalAddressStreet").Value,
                                            PostalAddressCode = (string)c.Element("PostalAddressCode").Value
                                        };

            foreach (Customer c in tmp) { this.Add(c); }

#endif
        }

        /// <summary>
        /// Gets filtered customers data from sql database or xml file
        /// </summary>
        /// <param name="filter">The 'CustomerListFilter' type object , which contains information on how to filter data</param>
        public void GetItemsByFilter(CustomerListFilter filter)
        {

            this.Clear();

#if (SQL_DATA)
             //Gets filtered customers data from sql database
             MakeQuery(filter);
#endif

#if (XML_DATA)
            //Gets filtered customers data from xml file
            XDocument xmlDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");
            IEnumerable<Customer> tmp = from c in xmlDoc.Descendants("Customer")
                                        select new Customer()
                                        {
                                            Id = (int)c.Attribute("id"),
                                            Name = (string)c.Element("Name").Value,
                                            Surname = (string)c.Element("Surname").Value,
                                            PhoneNumber = (string)c.Element("PhoneNumber").Value,
                                            PostalAddressCity = (string)c.Element("PostalAddressCity").Value,
                                            PostalAddressStreet = (string)c.Element("PostalAddressStreet").Value,
                                            PostalAddressCode = (string)c.Element("PostalAddressCode").Value
                                        };


            switch (filter.Condition)
            {
                case FilterConditions.IS_EQUAL:
                    switch (filter.FieldName)
                    {
                        case FilterFieldsNames.NAME:        tmp = tmp.Where(c => c.Name == filter.FieldValue); break;
                        case FilterFieldsNames.SURNAME:     tmp = tmp.Where(c => c.Surname == filter.FieldValue); break;
                        case FilterFieldsNames.PHONE:       tmp = tmp.Where(c => c.PhoneNumber == filter.FieldValue); break;
                        case FilterFieldsNames.CITY:        tmp = tmp.Where(c => c.PostalAddressCity == filter.FieldValue); break;
                        case FilterFieldsNames.STREET:      tmp = tmp.Where(c => c.PostalAddressStreet == filter.FieldValue); break;
                        case FilterFieldsNames.POSTCODE:    tmp = tmp.Where(c => c.PostalAddressCode == filter.FieldValue); break;
                    }
                    break;

                case FilterConditions.CONTAINS:

                    switch (filter.FieldName)
                    {
                        case FilterFieldsNames.NAME: tmp = tmp.Where(c => c.Name.Contains(filter.FieldValue)); break;
                        case FilterFieldsNames.SURNAME: tmp = tmp.Where(c => c.Surname.Contains(filter.FieldValue)); break;
                        case FilterFieldsNames.PHONE: tmp = tmp.Where(c => c.PhoneNumber.Contains(filter.FieldValue)); break;
                        case FilterFieldsNames.CITY: tmp = tmp.Where(c => c.PostalAddressCity.Contains(filter.FieldValue)); break;
                        case FilterFieldsNames.STREET: tmp = tmp.Where(c => c.PostalAddressStreet.Contains(filter.FieldValue)); break;
                        case FilterFieldsNames.POSTCODE: tmp = tmp.Where(c => c.PostalAddressCode.Contains(filter.FieldValue)); break;
                    }
                    break;
            }

            foreach (Customer c in tmp) { this.Add(c); }

#endif
        }

#endregion
    }
}
