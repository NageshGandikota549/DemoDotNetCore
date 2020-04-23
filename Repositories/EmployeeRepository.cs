using System.Collections.Generic;
using TestWebApi.Models;
using System.Data.Entity;
using System.Linq;

namespace TestWebApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeContext _employeeContext;
        EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
 
        public void AddEmployee(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
        }
        public Employee getEmployeeById(long employeeId)
        {
            return _employeeContext.Employees.ToList().Find(emp => emp.EmployeeId.Equals(employeeId));
        }

        public List<Employee> getEmployees()
        {
            return  _employeeContext.Employees.ToList();
        }
    }
}