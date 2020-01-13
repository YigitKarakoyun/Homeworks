using System;

namespace OdevPersoneleGorevAta
{
    public class Task
    {
        public int Task_Id { get; internal set; }
        public string Task_Name { get; set; }
        public string Task_Description { get; set; }
        public DateTime Task_Date { get; set; }
    }
}
