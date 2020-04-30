using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWebApi.Models;
using TestWebApi.Repositories;
using System.Web;
using TestWebApi.Services;
using System.Data;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("api/Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _IEmployeeService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService IEmployeeService)
        {
            _logger = logger;
            _IEmployeeService = IEmployeeService;

        }
        [Route("AddEmployee")]
        public HttpResponseMessage AddEmployee()
        {
            try
            {
                _IEmployeeService.AddEmployee();
                return new HttpResponseMessage(HttpStatusCode.OK);


            }
            catch 
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        [Route("GetEmployees")]
        public IDataReader GetEmployees()
        {
            return _IEmployeeService.getEmployees();
        }
    }
}
