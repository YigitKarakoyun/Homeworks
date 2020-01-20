using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace OdevPersonelGorev
{
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
            Application.Run(new Form1());
        }

        //Northwind Connection
        private static SqlConnection connection { get; set; }
        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection();
                    connection.ConnectionString = Properties.Settings.Default.Connection_NorthWind;
                }

                return connection;
            }

        }
    }
}
