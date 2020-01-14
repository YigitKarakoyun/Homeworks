using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
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

        //Update Tasks Set TaskName = @TaskName, TaskDescription = @TaskDescription,TaskDateTime=@TaskDateTime Where TaskId=
        public bool Get_InsertedTrue_And_Insert_EmployeeId_And_TaskId(int EmployeeId, int TaskId)
        {
            //BAĞLANTI AÇMA
            OpenConnection();

            SqlCommand com = new SqlCommand("insert into EmployeeTasks(EmployeeTasks_EmployeeId, EmployeeTasks_TaskId) Values(@EmployeeTasks_EmployeeId, @EmployeeTasks_TaskId", con);
            com.Parameters.AddWithValue("@EmployeeTasks_EmployeeId", EmployeeId);
            com.Parameters.AddWithValue("@EmployeeTasks_TaskId", TaskId);

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
                SqlCommand com_DeleteTasks = new SqlCommand("Update EmployeeTasks Set EmployeeTasks_Visible = 0 Where EmployeeTasks_TaskId =" + task_Id + " and EmployeeTasks_EmployeeId=" + employee_id,con);
                deletedCount = com_DeleteTasks.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return deletedCount;
        }

        public List<Task> Get_TaskList(int employee_Id)
        {

            List<Task> tasks = new List<Task>();
            OpenConnection();

            try
            {
                SqlCommand com_DeleteTasks = new SqlCommand("Select * from EmployeeTasks Where EmployeeTasks_Visible = 1 and " + " and EmployeeTasks_EmployeeId  = " + employee_Id);
                com_DeleteTasks.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tasks;
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

