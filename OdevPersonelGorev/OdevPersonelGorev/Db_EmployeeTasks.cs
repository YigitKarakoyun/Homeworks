using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersonelGorev
{
    class Db_EmployeeTasks
    {
        SqlConnection con;
        public Db_EmployeeTasks()
        {
            con = NorthWind_Connection.Connection;
        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }
        public List<Task> Get_TaskList(int employee_Id)
        {
            List<Task> tasks = new List<Task>();
            

            try
            {
                SqlCommand com = new SqlCommand("select t.* from Tasks t where t.TaskID in (select et.TaskID from EmployeeTasks et where et.Visible=1 and et.EmployeeID = "+ employee_Id + ")",con);
                OpenConnection();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Task task = new Task();
                        task.Task_Id = Convert.ToInt32(dr["TaskID"]);
                        task.Task_Name = dr["TaskName"].ToString();
                        task.Task_Description = dr["TaskDescription"].ToString();
                        task.Task_Date = Convert.ToDateTime(dr["TaskDate"]);

                        tasks.Add(task);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            ;
            return tasks;
        }
        //--------------------------------------------------------------
        //Update Tasks Set TaskName = @TaskName, TaskDescription = @TaskDescription,TaskDateTime=@TaskDateTime Where TaskId=
        public bool Get_InsertedTrue_And_Insert_EmployeeId_And_TaskId(int EmployeeID, int TaskID)
        {
            //BAĞLANTI AÇMA
            OpenConnection();

            SqlCommand com = new SqlCommand("insert into EmployeeTasks(EmployeeID, TaskID) Values("+EmployeeID+", "+ TaskID+")", con);

        

            int id = 0;
            try
            {
                //ETKİLENEN KAYIT SAYISINI ÖĞRENME
                id = com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            return id > 0;
        }

        public int Get_DeletedTrue_And_DeleteEmployeeTask(int employee_id, int task_Id)
        {
            int deletedCount = 0;
            OpenConnection();

            try
            {
                SqlCommand com_DeleteTasks = new SqlCommand("Update EmployeeTasks Set Visible = 0 Where TaskId =" + task_Id + " and EmployeeId=" + employee_id,con);
                deletedCount = com_DeleteTasks.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return deletedCount;
        }

        

        #region DELETE
        //public int Get_DeletedTrue_And_DeleteTask(int taskId)
        //{
        //    int deletedCount = 0;
        //    OpenConnection();

        //    try
        //    {
        //        SqlCommand com_DeleteTasks = new SqlCommand("Update EmployeeTasks Set EmployeeTasks_Visible = 0 Where EmployeeTasks_TaskId =" + taskId);
        //        deletedCount = com_DeleteTasks.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return deletedCount;
        //}

        #endregion
        //


    }
}

