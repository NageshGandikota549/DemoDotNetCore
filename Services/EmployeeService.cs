using System.Collections.Generic;
using System.Data;
using TestWebApi.Constants;
using TestWebApi.Models;
using TestWebApi.Repositories;
 namespace TestWebApi.Services
{
    public class EmployeeService : IEmployeeService{
        private readonly EmployeeContext _employeeContext;
        public EmployeeService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public void AddEmployee()
        {
            _employeeContext.ExecuteNonQuery(EmployeeConstants.AddEmployee);
        }

        public IDataReader getEmployees()
        {
          return  _employeeContext.ExecuteNonQuery(EmployeeConstants.GetEmployees);
        }
    }
}
