using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    public partial class FormEmployeeTasks : Form
    {
        Employee employee;
        public FormEmployeeTasks(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        private void ShowMe()
        {
            if (employee != null)
            {
                listView1.Items.Clear();

                label1.Text = employee.Employee_FirstName + " " + employee.Employee_LastName;

                if (employee.Employee_TaskList != null)
                {
                    foreach (Task task in employee.Employee_TaskList)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = task.Task_Id.ToString();
                        item.SubItems.Add(task.Task_Name);
                        item.SubItems.Add(task.Task_Description);
                        item.SubItems.Add(task.Task_Date.ToString());
                        item.Tag = task;
                        listView1.Items.Add(item);
                    }

                }
            }
        }
        private void FormEmployeeTasks_Load(object sender, EventArgs e)
        {
            ShowMe();
        }
        Db_EmployeeTasks DeleteTask_db = new Db_EmployeeTasks();
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (employee!=null)
            {
                var selectedtask = listView1.FocusedItem;
                if (selectedtask == null)
                {
                    MessageBox.Show("Önce Silinecek Görevi Seçmelisiniz");
                    return;
                }

                Task task = (Task)selectedtask.Tag;
                if (task!=null)
                {
                    employee.Employee_TaskList.Remove(task);

                    int deletedCount = DeleteTask_db.Get_DeletedTrue_And_DeleteEmployeeTask(employee.Employee_Id,task.Task_Id);
                    if (deletedCount > 0)
                    {
                        //ShowMe();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Görev Silindi");
                    }
                }
                
            }
            


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
