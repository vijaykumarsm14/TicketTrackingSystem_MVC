using System;
using System.ComponentModel.DataAnnotations;


namespace TTS_MVC.Models
{
    public class Employee
    {
        
        public int EID { get; set; }
        public string Employee_Name { get; set; }
        public DateTime Hire_Date { get; set; }
        public string Department { get; set; }

    }
}
