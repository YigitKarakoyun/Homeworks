﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OdevPersoneleGorevAta
{
    class SelectEmployee
    {
        //SQL BAĞLANTISI
        public SqlConnection con { get; private set; }

        //SQL KOMUTU
        public SqlCommand com_select_employee { get; private set; }
        public SelectTasks tasks_db { get; set; } = new SelectTasks();
        public SelectEmployee()
        {
            this.con = NorthWind_Connection.Connection;
            this.com_select_employee = Northwind_Command.GetCommand(con, Properties.Settings.Default.Command_SelectEmployee);
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
        public SqlDataReader Get_SqlDataReader_And_SelectEmployees()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = null;

            try
            {
                dr = com_select_employee.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            return dr;
        }
        //SQLDATA READER OKUMA(---ÇALIŞMASI İÇİN SQLCONNECTİON AÇIK BIRAKTIM---)
        public SqlDataReader Get_SqlDataReader_And_SelectTasks(int employeeId)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = null;

            try
            {
                dr = com_select_employee.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return dr;
        }
        //EMPLOYEES LİSTESİ DÖNDÜRME
        public List<Employee> Get_EmployeeList()
        {
            SqlDataReader dr = Get_SqlDataReader_And_SelectEmployees();
            List<Employee> employees = new List<Employee>();
            OpenConnection();

            if (dr != null && dr.HasRows)
            {
                try
                {
                    while (dr.Read())
                    {
                        //PERSONEL VERİLERİ ÇEKER
                        int Employee_Id = Convert.ToInt32(dr["EmployeeID"]);
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
                        Employee employee = Get_Employee(
                            Employee_Id, FirstName, LastName, 
                            Title, BirthDate, Country, Address, 
                            HireDate, Notes, HomePhone);
                    

                        employees.Add(employee);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            CloseConnection();
            return employees;
        }

        //TASK LİSTESİ DÖNDÜRME
        public List<Task> Get_TaskList(int employeeId)
        {
            SqlDataReader dr = Get_SqlDataReader_And_SelectEmployees();
            List<Task> employees = new List<Task>();
            OpenConnection();

            if (dr != null && dr.HasRows)
            {
                try
                {
                    while (dr.Read())
                    {
                        //PERSONEL VERİLERİ ÇEKER
                        int Employee_Id = Convert.ToInt32(dr["EmployeeID"]);
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
                        Employee employee = Get_Employee(
                            Employee_Id, FirstName, LastName,
                            Title, BirthDate, Country, Address,
                            HireDate, Notes, HomePhone);


                        //employees.Add(employee);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            CloseConnection();
            return employees;
        }

        //
        public List<Employee> Get_EmployeeList_And_FillListView(ListView listView1)
        {
            listView1.Items.Clear();
            List<Employee> employees = Get_EmployeeList();
           
            if (employees!=null && employees.Count>0)
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

                    //*-------------
                    employee.Employee_TaskList = tasks_db.Get_TaskList(employee.Employee_Id);
                    

                }
                
            }
            CloseConnection();
            return employees;
        }
        public Employee Get_Employee(int id,string firstname, string lastname, string title,DateTime birthdate, string country, string address, DateTime hiredate, string notes, string homephone)
        {
            //EMPLOYEE OLUŞTURUP & DOLDURMA
            Employee employee = new Employee();
            employee.Employee_Id = id;
            employee.Employee_FirstName = firstname;
            employee.Employee_LastName = lastname;
            employee.Employee_Title = title;
            employee.Employee_BirthDate = birthdate;
            employee.Employee_Country = country;

            //EMPLOYEE İÇİNDEKİ DETAİLS DOLDURMA
            employee.EmployeeDetails.Employee_Adress = address;
            employee.EmployeeDetails.Employee_HireDate = hiredate;
            employee.EmployeeDetails.Employee_Notes = notes;
            employee.EmployeeDetails.Employee_HomePhone = homephone;

            return employee;
        }

    }
}
