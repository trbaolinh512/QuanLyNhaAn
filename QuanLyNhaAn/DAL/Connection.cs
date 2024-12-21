using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace PhanMemBaoCom.DAL
{
    public class Connection
    {
        private readonly string _connectionString;

        public Connection()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Set the base path to the current directory
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)  // Add the appsettings.json file
                .Build();
            
            // Retrieve connection string
            _connectionString = configuration.GetConnectionString("SqlServer");
        }

        public SqlConnection GetConnect()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
