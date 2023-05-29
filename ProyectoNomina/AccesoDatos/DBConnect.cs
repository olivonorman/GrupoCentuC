using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace AccesoDatos
{
    public class DBConnect
    {
        private readonly string _connectionString;

        public DBConnect(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConnectDB");
        }


        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
        
    }
}