using System.Collections.Generic;
using TestWebApi.Models;
 namespace TestWebApi.Repositories
{
    public interface IEmployeeRepository{

    void AddEmployee(Employee employee);

    List<Employee> getEmployees();

    Employee getEmployeeById(long employeeId);


}
}
