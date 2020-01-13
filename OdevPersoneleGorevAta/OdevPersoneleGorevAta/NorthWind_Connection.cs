using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevPersoneleGorevAta
{
    class NorthWind_Connection
    {
        private static SqlConnection connection { get; set; }
        public static SqlConnection Connection
        {
            get{
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
