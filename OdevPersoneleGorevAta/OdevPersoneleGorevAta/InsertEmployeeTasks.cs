using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    class InsertEmployeeTasks
    {
        SqlConnection con;
        SqlCommand com_insert;
        public InsertEmployeeTasks()
        {
            con = NorthWind_Connection.Connection;
            com_insert = Northwind_Command.SqlCommand_InsertEmployeeTask;
        }

        public bool Get_InsertedTrue_And_Insert_EmployeeId_And_TaskId(int EmployeeId, int TaskId)
        {
            //TASK KAYDETME
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            com_insert.Parameters.AddWithValue("@EmployeeTasks_EmployeeId", EmployeeId);
            com_insert.Parameters.AddWithValue("@EmployeeTasks_TaskId", TaskId);

            int id = 0;
            try
            {
                //TASK IDSINI ÖĞRENME
                id = com_insert.ExecuteNonQuery();
      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id > 0;    
        }

        
    }
}

