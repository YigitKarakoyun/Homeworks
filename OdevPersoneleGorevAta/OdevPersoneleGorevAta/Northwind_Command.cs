using System.Data.SqlClient;

namespace OdevPersoneleGorevAta
{
    class Northwind_Command
    {
        public static SqlCommand GetCommand()
        {
            return new SqlCommand();
        }
        public static SqlCommand GetCommand(SqlConnection sqlConnection)
        {
            return new SqlCommand() { Connection = sqlConnection };
        }
        public static SqlCommand GetCommand(SqlConnection sqlConnection, string commandText)
        {
            return new SqlCommand() { Connection = sqlConnection, CommandText = commandText };
        }
        public int ExecuteNonQuery(SqlCommand sqlCommand)
        {
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
