using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersonelGorev
{
    public partial class FormNewTask : Form
    {
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
        Task task = null;
        public FormNewTask(Employee employee,Task task)
        {
            InitializeComponent();
            this.task = task;
            this.employee = employee;
            if (employee !=null && task != null)
            {
                Text = task.Task_Name + " "+ " Güncellemesi";

                txtGorevAdi.Text = task.Task_Name;
                txtGorevAciklamasi.Text = task.Task_Description;
                datePickerGorevTarihi.Value = task.Task_Date;
               //MessageBox.Show(task.Task_Name);
            }
        }
        private void FormNewTask_Load(object sender, EventArgs e)
        {
            

        }
        Db_Tasks db_Tasks = new Db_Tasks();
        Db_EmployeeTasks db_EmployeeTasks = new Db_EmployeeTasks();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //KAYDEDİLECEK BİLGİLERİ ÇEKER
            string task_Name = txtGorevAdi.Text;
            string task_Description = txtGorevAciklamasi.Text;
            DateTime task_Date = datePickerGorevTarihi.Value;

            if (employee != null && task != null)
            {
                //TASK KAYDETME
                task.Task_Name = task_Name;
                task.Task_Description = task_Description;
                task.Task_Date = task_Date;

                //EMPLOYEE TASK GÜNCELLENMESİ
                int etkilenenKayit=db_Tasks.Get_UpdatedTrue_And_UpdateTask(task);
                Temizlik();
                if (etkilenenKayit > 0)
                {
                    //KAYIT TAMAMLANDI MESAJI
                    MessageBox.Show("Kaydınız Başarılı İle Güncellenmiştir.");
                    DialogResult = DialogResult.OK;
                }
            }
            else if (employee != null)
            {
                //TASK KAYDETME
                int taskID = db_Tasks.Get_TaskID_And_InsertTask(task_Name, task_Description, task_Date);
                Task task = new Task() { Task_Id = taskID, Task_Name = task_Name, Task_Date = task_Date, Task_Description = task_Description };
                employee.Employee_TaskList.Add(task);

                //EMPLOYEE TASK KAYITLANMASI
                bool insert_true = db_EmployeeTasks.Get_InsertedTrue_And_Insert_EmployeeId_And_TaskId(employee.EmployeeID, taskID);
                Temizlik();
                if (insert_true)
                {
                    //KAYIT TAMAMLANDI MESAJI
                    MessageBox.Show("Kaydınız Başarılı İle Tamamlanmıştır.");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lblHataMesaji.Text = "";
                }
            }
            
            else
            {
                throw new Exception("Form New Taskta Hiç bir durum uymadığından hata verdi");
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
