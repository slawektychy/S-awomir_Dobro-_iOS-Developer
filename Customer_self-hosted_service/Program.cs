/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 *      
 *      Please remember set XML_DATA or/and SQL_DATA compilation symbol in the 'Bulid' section of project properties.
 *      (By default XML_DATA is set)
 *      
 *      You can also change the address and port on which the service runs and sql connectionstring, if you need to. 
 *      To do this, go to the project properties and select the "Settings".
 *      
 *      Service during startup needs specific permission to register the URL. Please run the program with administrator privileges.
 */

using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Xml.Linq;

namespace Customers_self_hosted_service
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main program function. 
        /// Creates, configures and starts service and creates xml document if needed.
        /// </summary>
        /// <param name="args">The function does not need any input parameters</param>
        static void Main(string[] args)
        {

            #region Create xml file if necessary

#if (XML_DATA)
            if (!System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml")) XmlCreateCustomersFile();
#endif

            #endregion

            #region We create, we configure and run the service

            Uri baseAddress = new Uri(Properties.Settings.Default.ServiceAddress);
            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(CustomersService), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine(string.Format("... INFO: The service is ready at {0}", baseAddress));
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }

            #endregion

        }

        /// <summary>
        /// Creates xml file in executable path
        /// </summary>
        static void XmlCreateCustomersFile()
        {
#if (XML_DATA)

            XDocument xmlDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("This is the file with costomers data ..."),
                new XElement("Customers")
                );
            xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "Customers.xml");
            Console.WriteLine(string.Format("... INFO: The '{0}' file was created\n", AppDomain.CurrentDomain.BaseDirectory + "Customers.xml"));
#endif
        }
    }
}
