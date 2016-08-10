/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */
 
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Customers_self_hosted_service
{
    /// <summary>
    /// A single element of the customer
    /// </summary>
    public class Customer
    {

        #region Private properties

        int id;
        string name;
        string surname;
        string phoneNumber;

        string postalAddressCity;
        string postalAddressStreet;
        string postalAddressCode;

        #endregion

        #region Public properties

        /// <summary>
        /// Customer identifier
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        /// <summary>
        /// Customer name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Customer surname
        /// </summary>
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        /// <summary>
        /// Customer main phone number
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        /// <summary>
        /// Customer address: city
        /// </summary>
        public string PostalAddressCity
        {
            get
            {
                return postalAddressCity;
            }

            set
            {
                postalAddressCity = value;
            }
        }

        /// <summary>
        /// Customer address: street
        /// </summary>
        public string PostalAddressStreet
        {
            get
            {
                return postalAddressStreet;
            }

            set
            {
                postalAddressStreet = value;
            }
        }

        /// <summary>
        /// Customer address: postcode
        /// </summary>
        public string PostalAddressCode
        {
            get
            {
                return postalAddressCode;
            }

            set
            {
                postalAddressCode = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public Customer(){}

        /// <summary>
        /// Constructor with identity
        /// </summary>
        /// <remarks>
        /// Automatically fills an object with data. Gets data from a database or XML file.
        /// </remarks>
        /// <param name="id">Customer identifier</param>
        public Customer(int id)
        {
            this.id = id;
            this.GetData();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Gets data from a database or XML file
        /// </summary>
        void GetData()
        {

#if (SQL_DATA)

            string query = string.Format("SELECT rtrim(name),rtrim(surname),rtrim(phoneNumber),rtrim(AddressCity),rtrim(AddressStreet),rtrim(AddressCode) From dbo.customers WHERE id = {0}", this.id);
            using (var conn = new SqlConnection(Properties.Settings.Default.SqlConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if(rdr.Read())
                    {
                        this.name = rdr.GetString(0);
                        this.surname = rdr.GetString(1);
                        this.phoneNumber = rdr.GetString(2);
                        this.postalAddressCity = rdr.GetString(3);
                        this.postalAddressStreet = rdr.GetString(4);
                        this.postalAddressCode = rdr.GetString(5);
                    }
                }
                conn.Close();
            }
#endif

#if (XML_DATA)

            XDocument xmlDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");
            IEnumerable<Customer> cst = from c in xmlDoc.Descendants("Customer")
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
            cst = cst.Where(c => c.id == this.id);

            this.id = cst.First().id;
            this.name = cst.First().name;
            this.surname = cst.First().surname;
            this.phoneNumber = cst.First().phoneNumber;
            this.postalAddressCity = cst.First().postalAddressCity;
            this.postalAddressStreet = cst.First().postalAddressStreet;
            this.postalAddressCode = cst.First().postalAddressCode;
#endif

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Saves data to the database or XML file  
        /// </summary>
        public void Save()
        {

#if (SQL_DATA)
            string query = "";

            //If id > 0 we make update, otherwise insert
            if (this.id > 0)
            {
                query = string.Format("UPDATE dbo.customers SET name = '{0}',surname ='{1}',phoneNumber='{2}', "
                    + "AddressCity='{3}',AddressStreet='{4}',AddressCode='{5}'  WHERE id = {6}"
                    , this.name
                    , this.surname
                    , this.phoneNumber
                    , this.postalAddressCity
                    , this.postalAddressStreet
                    , this.postalAddressCode
                    , this.id);

            }
            else
            {
                query = string.Format("INSERT INTO dbo.customers (name,surname,phoneNumber,AddressCity,AddressStreet,AddressCode) "
                    + " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')"
                    , this.name
                    , this.surname
                    , this.phoneNumber
                    , this.postalAddressCity
                    , this.postalAddressStreet
                    , this.postalAddressCode);
            }

            using (var conn = new SqlConnection(Properties.Settings.Default.SqlConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    rdr.Read();
                }
                conn.Close();
            }

#endif

#if (XML_DATA)

            XDocument xmlDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");

            if(this.id == 0)    // insert new item
            {
                var items = xmlDoc.Element("Customers").Elements("Customer");
                int newId = items.Max(c => (int)c.Attribute("id")) + 1;
                this.id = newId;    

                XElement item = new XElement("Customer", new XAttribute("id", this.id));
                xmlDoc.Element("Customers").Add(item);
                item.Add(
                    new XElement("Name", this.name),
                    new XElement("Surname", this.surname),
                    new XElement("PhoneNumber", this.phoneNumber),
                    new XElement("PostalAddressCity", this.postalAddressCity),
                    new XElement("PostalAddressStreet", this.postalAddressStreet),
                    new XElement("PostalAddressCode", this.postalAddressCode)
                    );

               
            }
            else    // update item
            {
                XElement item = xmlDoc.Element("Customers").Elements("Customer")
                    .Where(x => x.Attribute("id").Value == this.id.ToString()).FirstOrDefault();

                item.SetElementValue("Name", this.name);
                item.SetElementValue("Surname", this.surname);
                item.SetElementValue("PhoneNumber", this.phoneNumber);
                item.SetElementValue("PostalAddressCity", this.postalAddressCity);
                item.SetElementValue("PostalAddressStreet", this.postalAddressStreet);
                item.SetElementValue("PostalAddressCode", this.postalAddressCode);
            }

            xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");

#endif
            Console.WriteLine(string.Format("... INFO: The '{0}' customer was saved ...", this.name + " " + this.surname));
        }

        /// <summary>
        /// Deletes data from a database or XML file
        /// </summary>
        public void Delete()
        {

#if (SQL_DATA)

            string query = string.Format("DELETE dbo.customers WHERE id = {0}", this.id);
            using (var conn = new SqlConnection(Properties.Settings.Default.SqlConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    rdr.Read();
                }
                conn.Close();
            }
#endif

#if (XML_DATA)

            XDocument xmlDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");

            xmlDoc.Descendants("Customers")
            .Elements("Customer")
            .Where(x => x.Attribute("id").Value == this.id.ToString())
            .Remove();

            xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");
            Console.WriteLine(string.Format("... INFO: The '{0}' customer was deleted ...", this.name + " " + this.surname));
#endif


        }

        #endregion

    }
}
