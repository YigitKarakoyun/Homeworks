using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    class InsertTask
    {
        SqlConnection con;
        SqlCommand com;
        public InsertTask()
        {
            con = NorthWind_Connection.Connection;
            com = Northwind_Command.SqlCommand_InsertTask;
        }

        public int Get_TaskID_And_InsertTask(string task_Name, string task_Description, DateTime task_DateTime)
        {
            //TASK KAYDETME
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            com.Parameters.AddWithValue("@TaskName", task_Name);
            com.Parameters.AddWithValue("@TaskDescription", task_Description);
            com.Parameters.AddWithValue("@TaskDateTime", task_DateTime);
            int id = 0;
            try
            {
                //TASK IDSINI ÖĞRENME
                string id_String = com.ExecuteScalar().ToString();
                id = Convert.ToInt32(id_String);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }
    }
}

