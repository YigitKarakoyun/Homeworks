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
            con = Program.Connection; 
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
                SqlCommand com = new SqlCommand("Select_Employee_Tasks", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@employee_Id",employee_Id);

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
        #region INSERT
        public bool Get_InsertedTrue_And_Insert_EmployeeId_And_TaskId(int EmployeeID, int TaskID)
        {
            //BAĞLANTI AÇMA
            OpenConnection();

            SqlCommand com = new SqlCommand("Insert_EmployeeID_And_TasksID", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@employeeID", EmployeeID);
            com.Parameters.AddWithValue("@taskID", TaskID);
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
        #endregion

        #region DELETE
        public int Get_DeletedTrue_And_DeleteEmployeeTask(int employee_id, int task_Id)
        {
            int deletedCount = 0;
            OpenConnection();

            try
            {
                SqlCommand com_DeleteTasks = new SqlCommand("Delete_Employee_And_Task", con);
                com_DeleteTasks.CommandType = System.Data.CommandType.StoredProcedure;
                com_DeleteTasks.Parameters.AddWithValue("@employeeID", employee_id);
                com_DeleteTasks.Parameters.AddWithValue("@taskID", task_Id);
                deletedCount = com_DeleteTasks.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return deletedCount;
        }
        #endregion

    }
}

