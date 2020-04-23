using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

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
    }

    public DbSet<Employee> Employees { get; set; }
    // protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
    // {
    //         // modelBuilder.HasDefaultSchema("Admin");

    //         modelBuilder.Entity<Employee>().ToTable("Employee");        
    // }
}  
}