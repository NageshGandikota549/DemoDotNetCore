using System.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Snowflake.Data.Client;

namespace TestWebApi.Models
{
 public class EmployeeContext: DbContext 
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

        var configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration["ConnectioinStrings:DeefaultConnnection"]);



using (IDbConnection conn = new SnowflakeDbConnection())
{
    conn.ConnectionString = "Server=.;Database=mydb;user id=sa;password=123456";
    conn.Open();

    IDbCommand cmd = conn.CreateCommand();
    cmd.CommandText = "insert into t values (?),(?),(?)";
    IDataReader reader = cmd.ExecuteReader();
                  
    var p1 = cmd.CreateParameter();
    p1.ParameterName = "1";
    p1.Value = 10;
    p1.DbType = DbType.Int32;
    cmd.Parameters.Add(p1);

    var p2 = cmd.CreateParameter();
    p2.ParameterName = "2";
    p2.Value = 10000L;
    p2.DbType = DbType.Int32;
    cmd.Parameters.Add(p2);

    var p3 = cmd.CreateParameter();
    p3.ParameterName = "3";
    p3.Value = (short)1;
    p3.DbType = DbType.Int16;
    cmd.Parameters.Add(p3);

    var count = cmd.ExecuteNonQuery();
    
    conn.Close();
}
    }

    public DbSet<Employee> Employees { get; set; }
    // protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
    // {
    //         // modelBuilder.HasDefaultSchema("Admin");

    //         modelBuilder.Entity<Employee>().ToTable("Employee");        
    // }


    
}  
}