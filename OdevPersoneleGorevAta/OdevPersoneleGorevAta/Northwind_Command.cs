using System.Data.SqlClient;

namespace OdevPersoneleGorevAta
{
    class Northwind_Command
    {
        public static SqlCommand GetCommand(SqlConnection sqlConnection)
        {
            return new SqlCommand() { Connection = sqlConnection};
        }
        public static SqlCommand GetCommand(SqlConnection sqlConnection, string commandText)
        {
            return new SqlCommand() { Connection = sqlConnection, CommandText = commandText };
        }

        #region PREFAB COMMANDS
        public static SqlCommand SqlCommand_SelectTasks { get; } = GetCommand(NorthWind_Connection.Connection, Properties.Settings.Default.Command_SelectTask);
        public static SqlCommand SqlCommand_SelectEmployee { get; } = GetCommand(NorthWind_Connection.Connection, Properties.Settings.Default.Command_SelectEmployee);
        public static SqlCommand SqlCommand_InsertTask { get; } = GetCommand(NorthWind_Connection.Connection, Properties.Settings.Default.Command_InsertTask);
        public static SqlCommand SqlCommand_InsertEmployeeTask { get; } = GetCommand(NorthWind_Connection.Connection, Properties.Settings.Default.Command_InsertEmployeeTask);


        private static SqlCommand _SqlCommand_Select_EmployeeTask { get; } = GetCommand(NorthWind_Connection.Connection);
        private static string _SqlCommand_Select_EmployeeTask_string { get; } = Properties.Settings.Default.Command_SelectEmployeeTask;
        public static SqlCommand SqlCommand_Select_EmployeeTask(int EmployeeID)
        {
            _SqlCommand_Select_EmployeeTask.CommandText = _SqlCommand_Select_EmployeeTask_string + EmployeeID + ")";
            return _SqlCommand_Select_EmployeeTask;
        }

        private static SqlCommand _SqlCommand_Delete_Task { get; } = GetCommand(NorthWind_Connection.Connection);
        private static string _SqlCommand_Delete_Task_string { get; } = Properties.Settings.Default.Command_DeleteTask;
        public static SqlCommand SqlCommand_Delete_Task(int TaskID)
        {
            _SqlCommand_Delete_Task.CommandText = _SqlCommand_Delete_Task_string + TaskID;
            return _SqlCommand_Delete_Task;
        }
        #endregion

    }
}
