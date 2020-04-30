using System.Collections.Generic;
using System.Data;
using TestWebApi.Models;
 namespace TestWebApi.Services
{
    public interface IEmployeeService{

    void AddEmployee();

    IDataReader getEmployees();

}
}
