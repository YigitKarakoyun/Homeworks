using System;

namespace OdevPersonelGorev
{
    public class Task
    {
        public int Task_Id { get; internal set; }
        public string Task_Name { get; set; }
        public string Task_Description { get; set; }
        public DateTime Task_Date { get; set; }

        public override string ToString()
        {
            return Task_Id + " " + Task_Name + " " + Task_Description + " " + Task_Date; 
        }
    }
}