using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersonelGorev
{
    public partial class FormEmployeeTasks : Form
    {
        Employee employee;
        SqlConnection con;
        public FormEmployeeTasks(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            con = NorthWind_Connection.Connection;
        }

        private void FormEmployeeTasks_Load(object sender, EventArgs e)
        {
            label1.Text = employee.Employee_FirstName + " " + employee.Employee_LastName;
            Set_ListViewItems();
        }
        
        #region DOLU TASK LİSTESİNİ LİSTVİEW A YÜKLER
        public void Set_ListViewItems()
        {
            listView1.Items.Clear();

            if (employee != null && employee.Employee_TaskList != null)
            { 
                foreach (Task task in employee.Employee_TaskList)
                {
                    //LİSTVİEWITEM OLUŞTURUP & DOLDURMA
                    ListViewItem li = new ListViewItem();
                    li.Text = task.Task_Id.ToString();
                    li.SubItems.Add(task.Task_Name);
                    li.SubItems.Add(task.Task_Description);
                    li.SubItems.Add(task.Task_Date.ToString());
                  
                    li.Tag = task;

                    //LİSTVİEW E ITEM EKLEME
                    listView1.Items.Add(li);
                }
            }
        }
        #endregion

        Db_EmployeeTasks DeleteTask_db = new Db_EmployeeTasks();
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                var selectedtask = listView1.FocusedItem;
                if (selectedtask == null)
                {
                    MessageBox.Show("Önce Silinecek Görevi Seçmelisiniz");
                    return;
                }

                Task task = (Task)selectedtask.Tag;
                if (task != null)
                {
                    employee.Employee_TaskList.Remove(task);

                    int deletedCount = DeleteTask_db.Get_DeletedTrue_And_DeleteEmployeeTask(employee.EmployeeID, task.Task_Id);
                    if (deletedCount > 0)
                    {
                        Set_ListViewItems();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Görev Silindi");
                    }
                }

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Task task = (Task)listView1.FocusedItem.Tag;
            if (task == null)
            {
                MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz");
                return;
            }

            FormNewTask frm = new FormNewTask(employee,task);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Set_ListViewItems();
            }
        }
    }
}
