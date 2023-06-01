using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AccesoDatos
{
    public class DBConnect
    {
        private readonly string _connectionString;

        public DBConnect()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();
            _connectionString = configuration.GetValue<string>("ConnectDB");
        }


        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}