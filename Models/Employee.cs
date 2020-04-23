using System;

namespace TestWebApi.Models
{
    public class Employee
    {
        public long EmployeeId { get; set; }

        public string  Name { get; set; }
        public int Age {get; set; }

        public string Role { get; set; }

        public DateTime JoiningDate {get;set;}
    }
}
