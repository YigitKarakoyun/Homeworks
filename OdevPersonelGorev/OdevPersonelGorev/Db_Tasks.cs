using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersonelGorev
{
    class Db_Tasks
    {
        //SQL BAĞLANTISI
        public SqlConnection con { get; private set; }

        //SQL KOMUTU
        public SqlCommand com_selectTasks { get; private set; }

        public Db_Tasks()
        {
            this.con = NorthWind_Connection.Connection;
        }

        //BAĞLANTI KAPAMA
        private void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        //BAĞLANTI AÇMA
        private void OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }

        #region UPDATE 

        public int Get_UpdatedTrue_And_UpdateTask(Task task)
        {
            SqlCommand com = new SqlCommand("Update Tasks Set TaskName=@TaskName, TaskDescription=@TaskDescription,TaskDate=@TaskDate Where TaskId=" + task.Task_Id, con);
            OpenConnection();
            com.Parameters.AddWithValue("@TaskName", task.Task_Name);
            com.Parameters.AddWithValue("@TaskDescription", task.Task_Description);
            com.Parameters.AddWithValue("@TaskDate", task.Task_Date);
            int id = 0;
            try
            {
                //TASK IDSINI ÖĞRENME
                id = com.ExecuteNonQuery();
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }

        #endregion

        #region INSERT


        public int Get_TaskID_And_InsertTask(string task_Name, string task_Description, DateTime task_Date)
        {
            SqlCommand com = new SqlCommand("insert into Tasks(TaskName, TaskDescription, TaskDate) Values(@TaskName, @TaskDescription, @TaskDate) Select @@IDENTITY", con);
            OpenConnection();
            com.Parameters.AddWithValue("@TaskName", task_Name);
            com.Parameters.AddWithValue("@TaskDescription", task_Description);
            com.Parameters.AddWithValue("@TaskDate", task_Date);
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
        #endregion



    }
}
