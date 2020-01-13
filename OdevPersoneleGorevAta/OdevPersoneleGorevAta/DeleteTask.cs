using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    class DeleteTask
    {
        //SQL BAĞLANTISI
        public SqlConnection con { get; private set; }

        //SQL KOMUTU
        public SqlCommand com_DeleteTasks { get; private set; }

        public DeleteTask()
        {
            this.con = NorthWind_Connection.Connection;
        }

        //SQLDATA READER OKUMA(---ÇALIŞMASI İÇİN SQLCONNECTİON AÇIK BIRAKTIM---)
        public int Get_DeletedTrue_And_DeleteTask(int taskId)
        {
            int deletedCount = 0;
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                com_DeleteTasks = Northwind_Command.SqlCommand_Delete_Task(taskId);
                deletedCount = com_DeleteTasks.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return deletedCount;
        }
        

        //


    }
}
