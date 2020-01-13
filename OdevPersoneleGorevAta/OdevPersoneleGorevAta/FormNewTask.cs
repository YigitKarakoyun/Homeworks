using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    public partial class FormNewTask : Form
    {
        #region ÇALIŞANA GÖREV ATAMASI
        Employee employee;
        public FormNewTask(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            if (employee != null)
            {
                Text = employee.Employee_FirstName + " " + employee.Employee_LastName + " Görev Ataması";
            }
        }
        #endregion


        Task task;
        public FormNewTask(Task task)
        {
            InitializeComponent();
            this.task = task;

        }
        /*private void FormYeniGorev_Load(object sender, EventArgs e)
        {

            datePickerGorevTarihi.Value = DateTime.Now;
            if (task == null)
            {
                Text = "Yeni Görev";
                btnKaydet.Text = "Kaydet";
            }
            else
            {
                Text = "Görev Güncelleme";
                btnKaydet.Text = "Güncelle";
                txtGorevAdi.Text = task.Task_Name;
                txtGorevAciklamasi.Text = task.Task_Description;
                //datePickerGorevTarihi.Value = task.GorevTarihi;

            }
        }*/

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //KAYDEDİLECEK BİLGİLERİ ÇEKER
            string task_Name = txtGorevAdi.Text;
            string task_Description = txtGorevAciklamasi.Text;
            DateTime task_DateTime = datePickerGorevTarihi.Value;

            if (employee!=null)
            {
                //TASK KAYDETME
                SqlConnection con = NorthWind_Connection.Get_Connection();
                SqlCommand com = Northwind_Command.GetCommand(con, Properties.Settings.Default.Command_InsertTask);
                com.Parameters.AddWithValue("@TaskName", task_Name);
                com.Parameters.AddWithValue("@TaskDescription", task_Description);
                com.Parameters.AddWithValue("@TaskDateTime", task_DateTime);

                try
                {
                    con.Open();

                    //TASK IDSINI ÖĞRENME
                    string id_String = com.ExecuteScalar().ToString();
                    int id = Convert.ToInt32(id_String);
                    
                    //EMPLOYEE TASK EKLEME
                    Task task = new Task() {Task_Id = id , Task_Name = task_Name, Task_Date= task_DateTime, Task_Description = task_Description };
                    if (employee.Employee_Tasks==null)
                    {
                        employee.Employee_Tasks = new System.Collections.Generic.List<Task>();
                    }
                    employee.Employee_Tasks.Add(task);

                    //EMPLOYEE TASK KAYITLANMASI
                    

                    //KAYIT TAMAMLANDI MESAJI
                    Temizlik();
                    MessageBox.Show("Kaydınız Başarılı İle Tamamlanmıştır.");
                    DialogResult = DialogResult.OK;
                    
                }
                catch (Exception ex)
                {
                    lblHataMesaji.Text = ex.Message;

                    MessageBox.Show(ex.Message);
                }
            }


            ////SQL BAĞLANTISI
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = Properties.Settings.Default.Connection_NorthWind;

                ////SQL KOMUTU
                //SqlCommand com = new SqlCommand();
                //com.Connection = con;

                //if (task == null)
                //{
                //    com.CommandText = Properties.Settings.Default.Command_InsertTask;
                //    com.Parameters.AddWithValue("@TaskName", GorevAdi);
                //    com.Parameters.AddWithValue("@TaskDescription", GorevAciklamasi);
                //    com.Parameters.AddWithValue("@TaskDateTime", GorevDateTime);


                //    try
                //    {
                //        con.Open();
                //        int adet = com.ExecuteNonQuery();
                //        if (adet > 0)
                //        {
                //            Temizlik();
                //            MessageBox.Show("Kaydınız Başarılı İle Tamamlanmıştır.");
                //            DialogResult = DialogResult.OK;
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        lblHataMesaji.Text = ex.Message;

                //        MessageBox.Show(ex.Message);
                //    }

                //}
                //else
                //{
                //    com.CommandText = Properties.Settings.Default.Command_UpdateTask + task.Task_Id;
                //    com.Parameters.AddWithValue("@TaskName", GorevAdi);
                //    com.Parameters.AddWithValue("@TaskDescription", GorevAciklamasi);
                //    com.Parameters.AddWithValue("@TaskDateTime", GorevDateTime);
                //    try
                //    {
                //        con.Open();
                //        int etkilenenKayit = com.ExecuteNonQuery();
                //        if (etkilenenKayit > 0)
                //        {
                //            Temizlik();

                //            MessageBox.Show("Kaydınız Güncellenmiştir");
                //            DialogResult = DialogResult.OK;
                //            Close();

                //        }

                //    }
                //    catch (Exception ex)
                //    {
                //        lblHataMesaji.Text = ex.Message;
                //        MessageBox.Show(ex.Message);
                //    }



                //}
                //if (con.State == System.Data.ConnectionState.Open)
                //{
                //    con.Close();
                //}
            }

        private void Temizlik()
        {
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Text = "";

                }

            }
        }

        private void FormEmployeeTask_Load(object sender, EventArgs e)
        {
            
        }
    }
}
