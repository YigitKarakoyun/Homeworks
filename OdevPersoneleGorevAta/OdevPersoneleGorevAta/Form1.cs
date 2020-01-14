using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Db_Employee employee_selectdb = new Db_Employee();
        List<Employee> employeeList;

        private void Form1_Load(object sender, EventArgs e)
        {
            //EMPLOYEES VERİLERİNİ ÇEK
            employeeList = employee_selectdb.Get_EmployeeList_And_FillListView(listView1);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = (Employee)listView1.FocusedItem.Tag;
            EmployeeDetail personelDetail = employee.EmployeeDetails;

            lblIseGirisTarihi.Text = personelDetail.Employee_HireDate.ToString();
            lblAdres.Text = personelDetail.Employee_Adress;
            lblNotlar.Text = personelDetail.Employee_Notes;
            lblTelefon.Text = personelDetail.Employee_HomePhone;
        }

        private void btnGorevleriGoster_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)listView1.FocusedItem.Tag;
            if (employee == null)
            {
                MessageBox.Show("Listeden Çalışan Seçiniz");
                return;
            }

            FormEmployeeTasks frm = new FormEmployeeTasks(employee);
            frm.ShowDialog();

        }

        private void btnGorevAta_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)listView1.FocusedItem.Tag;
            if (employee==null)
            {
                MessageBox.Show("Listeden Çalışan Seçiniz");
                return;
            }

            FormNewTask frm = new FormNewTask(employee);
            frm.ShowDialog();
        }
    }
}
