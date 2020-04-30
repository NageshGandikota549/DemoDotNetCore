namespace TestWebApi.Constants
{
    public class EmployeeConstants
    {
        
        public  const string AddEmployee = "insert into employee values(1, 'Nagesh', 25, 'Software Engineer', to_date('08-04-2020', 'DD-MM-YYYY'))";
        public  const string GetEmployees = "select * from employee";
      

    }
}