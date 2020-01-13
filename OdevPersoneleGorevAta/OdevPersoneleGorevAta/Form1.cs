using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //SQL BAĞLANTISI
            SqlConnection con = NorthWind_Connection.Get_Connection();

            //SQL KOMUTU
            SqlCommand com = Northwind_Command.GetCommand(con,Properties.Settings.Default.Command_SelectEmployee);

            try
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //PERSONEL VERİLERİ ÇEKER
                        int employee_Id = Convert.ToInt32(dr["EmployeeID"]);
                        string FirstName = dr["FirstName"].ToString();
                        string LastName = dr["LastName"].ToString();
                        string Title = dr["Title"].ToString();
                        DateTime BirthDate = Convert.ToDateTime(dr["BirthDate"]);
                        string Country = dr["Country"].ToString();

                        //PERSONEL DETAILS VERİLERİ ÇEKER
                        DateTime HireDate = Convert.ToDateTime(dr["HireDate"]);
                        string Address = dr["Address"].ToString();
                        string Notes = dr["Notes"].ToString();
                        string HomePhone = dr["HomePhone"].ToString();

                        //PERSONEL OLUŞTURUP & DOLDURMA
                        Employee employee = new Employee();
                        employee.Employee_Id = employee_Id;
                        employee.Employee_FirstName = FirstName;
                        employee.Employee_LastName = LastName;
                        employee.Employee_Title = Title;
                        employee.Employee_BirthDate = BirthDate;
                        employee.Employee_Country = Country;

                        //PERSONEL İÇİNDEKİ DETAİLS DOLDURMA
                        employee.EmployeeDetails.Employee_Adress = Address;
                        employee.EmployeeDetails.Employee_HireDate = HireDate;
                        employee.EmployeeDetails.Employee_Notes = Notes;
                        employee.EmployeeDetails.Employee_HomePhone = HomePhone;

                        

                        //LİSTVİEWITEM OLUŞTURUP & DOLDURMA
                        ListViewItem li = new ListViewItem();
                        li.Text = FirstName;
                        li.SubItems.Add(LastName);
                        li.SubItems.Add(Title);
                        li.SubItems.Add(BirthDate.ToString());
                        li.SubItems.Add(Country);
                        li.Tag = employee;

                        //LİSTVİEW E ITEM EKLEME
                        listView1.Items.Add(li);

                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
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

        private void btnYeniGorevOIustur_Click(object sender, EventArgs e)
        {
            //FormYeniGorev formYeniGorev = new FormYeniGorev();
            //formYeniGorev.ShowDialog();

        }
    }
}
