using System.Collections.Generic;
using TestWebApi.Models;
 namespace TestWebApi.Repositories
{
    public interface IEmployeeRepository{

    void AddEmployee();

    List<Employee> getEmployees();

}
}
