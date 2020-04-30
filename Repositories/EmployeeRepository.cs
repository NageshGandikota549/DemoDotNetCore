using System.Collections.Generic;
using TestWebApi.Models;
using System.Data.Entity;
using System.Linq;
using TestWebApi.Constants;

namespace TestWebApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeContext _employeeContext;
        EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
    
        public void AddEmployee()
        {
            _employeeContext.ExecuteNonQuery(EmployeeConstants.AddEmployee);
        }
      

        public List<Employee> getEmployees()
        {
            // return  _employeeContext.ExecuteNonQuery(EmployeeConstants.GetEmployees);
            return null;
            
        }
    }
}