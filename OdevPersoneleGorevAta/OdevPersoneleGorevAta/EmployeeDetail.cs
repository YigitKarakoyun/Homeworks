using System;

namespace OdevPersoneleGorevAta
{
    public class EmployeeDetail
    {
        public DateTime Employee_HireDate { get; set; }
        public string Employee_Adress { get; set; }
        public string Employee_Notes { get; set; }
        public string Employee_HomePhone { get; internal set; }
    }
}
