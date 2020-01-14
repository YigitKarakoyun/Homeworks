using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
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

        #region SELECT 

        //SQLDATA READER OKUMA(---ÇALIŞMASI İÇİN SQLCONNECTİON AÇIK BIRAKTIM---)
        //public SqlDataReader Get_SqlDataReader_And_SelectTasks(int employeeId)
        //{
        //    OpenConnection();
        //    SqlDataReader dr = null;
        //    SqlCommand com = new SqlCommand("select * from Tasks where Tasks_Visible = 1"+ employeeId);

        //    try
        //    {
        //        dr = com.ExecuteReader();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return dr;
        //}

        //public List<Task> Get_TaskList(int employeeId)
        //{
        //    SqlDataReader dr = Get_SqlDataReader_And_SelectTasks(employeeId);
        //    List<Task> tasks = new List<Task>();
        //    OpenConnection();

        //    if (dr != null && dr.HasRows)
        //    {
        //        try
        //        {
        //            while (dr.Read())
        //            {
        //                //TASK VERİLERİ ÇEKER
        //                int TaskId = Convert.ToInt32(dr["TaskId"]);
        //                string TaskName = dr["TaskName"].ToString();
        //                string TaskDescription = dr["TaskDescription"].ToString();
        //                DateTime TaskDateTime = Convert.ToDateTime(dr["TaskDateTime"]);

        //                //TASK OLUŞTURUP & DOLDURMA
        //                Task task = new Task() { Task_Id = TaskId, Task_Name = TaskName, Task_Description = TaskDescription, Task_Date = TaskDateTime };
        //                tasks.Add(task);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }

        //    }
        //    CloseConnection();
        //    return tasks;
        //}

        #endregion

        #region INSERT


        //Update Tasks Set TaskName = @TaskName, TaskDescription = @TaskDescription,TaskDateTime=@TaskDateTime Where TaskId=
        public int Get_TaskID_And_InsertTask(string task_Name, string task_Description, DateTime task_DateTime)
        {
            SqlCommand com = new SqlCommand("insert into Tasks(TaskName, TaskDescription, TaskDateTime) Values(@TaskName, @TaskDescription, @TaskDateTime) Select @@IDENTITY",con);
            OpenConnection();
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
        #endregion

       

    }
}
