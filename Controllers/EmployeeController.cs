using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWebApi.Models;
using TestWebApi.Repositories;
using System.Web;
namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("api/Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _IEmployeeRepository;
        private static readonly List<Employee> employees = new List<Employee>{
                new Employee{EmployeeId=1,Name="Nagesh",Age=25,Role="Senior Software Engineer",JoiningDate=DateTime.Now},
                new Employee{EmployeeId=1,Name="Sridhar",Age=25,Role="Software Engineer",JoiningDate=DateTime.Now},
                new Employee{EmployeeId=1,Name="Kiran",Age=25,Role="Architect",JoiningDate=DateTime.Now}
            };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeRepository IEmployeeRepository)
        {
            _logger = logger;
            _IEmployeeRepository = IEmployeeRepository;

        }

        public HttpResponseMessage AddEmployee(Employee employee)
        {
            try
            {
                _IEmployeeRepository.AddEmployee(employee);
                return new HttpResponseMessage(HttpStatusCode.OK);


            }
            catch 
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return _IEmployeeRepository.getEmployees();
        }

        [Route("GetEmployeeById")]
        public Employee GetEmployeeById(long employeeId)
        {
            return _IEmployeeRepository.getEmployeeById(employeeId);
        }
    }
}
