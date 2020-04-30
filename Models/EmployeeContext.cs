using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using Snowflake.Data.Client;
using System;
using Newtonsoft.Json;
namespace TestWebApi.Models
{
    public class EmployeeContext
    {
        IDbConnection conn = new SnowflakeDbConnection();
        public EmployeeContext()
        {
            var configuration = GetConfiguration();
            conn.ConnectionString = configuration.GetSection("DefaultConnnection").Value;
            try
            {
                conn.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();

        }

        public IDataReader ExecuteNonQuery(string query)
        {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            IDataReader reader = cmd.ExecuteReader();
            conn.Close();
            return reader;
        }

    }
}