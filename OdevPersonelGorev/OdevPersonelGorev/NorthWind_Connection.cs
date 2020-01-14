using System.Data.SqlClient;

namespace OdevPersonelGorev
{
    class NorthWind_Connection
    {
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
