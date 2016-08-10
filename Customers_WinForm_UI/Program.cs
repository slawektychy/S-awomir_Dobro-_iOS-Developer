/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */

using System;
using System.Windows.Forms;

namespace Customers_WinForm_UI
{
    /// <summary>
    /// Main program class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmCustomers());

        }
    }
}
