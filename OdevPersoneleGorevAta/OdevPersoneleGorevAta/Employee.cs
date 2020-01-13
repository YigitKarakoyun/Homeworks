using System;
using System.Collections.Generic;

namespace OdevPersoneleGorevAta
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_FirstName { get; set; }
        public string Employee_LastName { get; set; }
        public string Employee_Title { get; set; }
        public DateTime Employee_BirthDate { get; internal set; }
        public string Employee_Country { get; set; }
        public EmployeeDetail EmployeeDetails { get; set; } = new EmployeeDetail();
        public List<Task> Employee_Tasks { get; set; } = new List<Task>();
    }
}
