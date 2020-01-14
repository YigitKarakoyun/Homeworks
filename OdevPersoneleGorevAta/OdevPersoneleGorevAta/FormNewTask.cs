using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    public partial class FormNewTask : Form
    {
        #region FORM LOAD
        private void FormEmployeeTask_Load(object sender, EventArgs e)
        {
            con = NorthWind_Connection.Connection;
        }
        #endregion

        SqlConnection con;

        Db_Tasks insert_Task_db = new Db_Tasks();
        Db_EmployeeTasks insert_EmployeeTasks_db = new Db_EmployeeTasks();


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

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //KAYDEDİLECEK BİLGİLERİ ÇEKER
            string task_Name = txtGorevAdi.Text;
            string task_Description = txtGorevAciklamasi.Text;
            DateTime task_DateTime = datePickerGorevTarihi.Value;

            if (employee!=null)
            {

                //TASK KAYDETME
                int taskid = insert_Task_db.Get_TaskID_And_InsertTask(task_Name, task_Description, task_DateTime);
                Task task = new Task() { Task_Id = taskid, Task_Name = task_Name, Task_Date = task_DateTime, Task_Description = task_Description };
                employee.Employee_TaskList.Add(task);

                //EMPLOYEE TASK KAYITLANMASI
                bool insert_true = insert_EmployeeTasks_db.Get_InsertedTrue_And_Insert_EmployeeId_And_TaskId(employee.Employee_Id,taskid);
                Temizlik();
                if (insert_true)
                {
                    //KAYIT TAMAMLANDI MESAJI
                    MessageBox.Show("Kaydınız Başarılı İle Tamamlanmıştır.");
                    DialogResult = DialogResult.OK;
                }

                
                
                

            }


            
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

        
    }
}
