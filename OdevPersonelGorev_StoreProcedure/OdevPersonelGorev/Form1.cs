using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OdevPersonelGorev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>();
        Db_Employee db_Employee = new Db_Employee();
        Db_EmployeeTasks db_EmployeeTasks = new Db_EmployeeTasks();
        private void Form1_Load(object sender, EventArgs e)
        {
            #region EMPLOYEE & TASKLARINI DOLDURMA
            employees = db_Employee.Get_EmployeeList();
            foreach (Employee employee in employees)
            {
                List<Task> taskList = db_EmployeeTasks.Get_TaskList(employee.EmployeeID);
                if (taskList != null && taskList.Count>0)
                {

                    employee.Employee_TaskList = taskList;
                    //foreach (var item in taskList)
                    //{
                    //    MessageBox.Show(item.ToString());
                    //}
                    //MessageBox.Show("adet "+taskList.Count);
                   
                }
            }
            //foreach (Employee employee in employees)
            //{
            //    foreach (Task item in employee.Employee_TaskList)
            //    {
            //        MessageBox.Show(item.ToString());
            //    }
            //}
            Set_ListViewItems();
            #endregion

        }

        #region DOLU EMPLOYEES LİSTVİEW A YÜKLER
        public void Set_ListViewItems()
        {
            listView1.Items.Clear();

            if (employees != null && employees.Count > 0)
            {
                foreach (Employee employee in employees)
                {
                    //LİSTVİEWITEM OLUŞTURUP & DOLDURMA
                    ListViewItem li = new ListViewItem();
                    li.Text = employee.Employee_FirstName;
                    li.SubItems.Add(employee.Employee_LastName);
                    li.SubItems.Add(employee.Employee_Title);
                    li.SubItems.Add(employee.Employee_BirthDate.ToString());
                    li.SubItems.Add(employee.Employee_Country);
                    li.Tag = employee;

                    //LİSTVİEW E ITEM EKLEME
                    listView1.Items.Add(li);
                }
            }
        }
        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = (Employee)listView1.FocusedItem.Tag;
            EmployeeDetail personelDetail = employee.EmployeeDetails;

            lblHireDate.Text = personelDetail.Employee_HireDate.ToString();
            lblAddress.Text = personelDetail.Employee_Adress;
            lblNotes.Text = personelDetail.Employee_Notes;
            lblHomePhone.Text = personelDetail.Employee_HomePhone;
        }

        private void btnShowTasks_Click(object sender, EventArgs e)
        {
            var selectedItem = listView1.FocusedItem;
            if (selectedItem != null)
            {
                var employee = (Employee)selectedItem.Tag;
                if (employee != null)
                {
                    FormEmployeeTasks frm = new FormEmployeeTasks(employee);
                    frm.ShowDialog();
                }
            }
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)listView1.FocusedItem.Tag;
            if (employee == null)
            {
                MessageBox.Show("Listeden Çalışan Seçiniz");
                return;
            }

            FormNewTask frm = new FormNewTask(employee);
            frm.ShowDialog();
        }
    }
}
