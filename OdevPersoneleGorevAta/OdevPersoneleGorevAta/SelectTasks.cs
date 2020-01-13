using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    class SelectTasks
    {
        //SQL BAĞLANTISI
        public SqlConnection con { get; private set; }

        //SQL KOMUTU
        public SqlCommand com_selectTasks { get; private set; }

        public SelectTasks()
        {
            this.con = NorthWind_Connection.Connection;
            this.com_selectTasks = Northwind_Command.SqlCommand_SelectTasks;
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

        //SQLDATA READER OKUMA(---ÇALIŞMASI İÇİN SQLCONNECTİON AÇIK BIRAKTIM---)
        public SqlDataReader Get_SqlDataReader_And_SelectTasks()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = null;

            try
            {
                dr = com_selectTasks.ExecuteReader();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }

            return dr;
        }
        public SqlDataReader Get_SqlDataReader_And_SelectTasks(int employeeId)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = null;
            SqlCommand com = Northwind_Command.SqlCommand_Select_EmployeeTask(employeeId);

            try
            {
                dr = com.ExecuteReader();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }

            return dr;
        }

        //TASK LİSTESİ DÖNDÜRME
        public List<Task> Get_TaskList()
        {
            SqlDataReader dr = Get_SqlDataReader_And_SelectTasks();
            List<Task> tasks = new List<Task>();
            OpenConnection();

            if (dr != null && dr.HasRows)
            {
                try
                {
                    while (dr.Read())
                    {
                        //TASK VERİLERİ ÇEKER
                        int TaskId = Convert.ToInt32(dr["TaskId"]);
                        string TaskName = dr["TaskName"].ToString();
                        string TaskDescription = dr["TaskDescription"].ToString();
                        DateTime TaskDateTime = Convert.ToDateTime(dr["TaskDateTime"]);

                        //TASK OLUŞTURUP & DOLDURMA
                        Task task = new Task() { Task_Id = TaskId, Task_Name = TaskName, Task_Description = TaskDescription, Task_Date = TaskDateTime};
                        tasks.Add(task);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            CloseConnection();
            return tasks;
        }

        public List<Task> Get_TaskList(int employeeId)
        {
            SqlDataReader dr = Get_SqlDataReader_And_SelectTasks(employeeId);
            List<Task> tasks = new List<Task>();
            OpenConnection();

            if (dr != null && dr.HasRows)
            {
                try
                {
                    while (dr.Read())
                    {
                        //TASK VERİLERİ ÇEKER
                        int TaskId = Convert.ToInt32(dr["TaskId"]);
                        string TaskName = dr["TaskName"].ToString();
                        string TaskDescription = dr["TaskDescription"].ToString();
                        DateTime TaskDateTime = Convert.ToDateTime(dr["TaskDateTime"]);

                        //TASK OLUŞTURUP & DOLDURMA
                        Task task = new Task() { Task_Id = TaskId, Task_Name = TaskName, Task_Description = TaskDescription, Task_Date = TaskDateTime };
                        tasks.Add(task);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            CloseConnection();
            return tasks;
        }

        //


    }
}
