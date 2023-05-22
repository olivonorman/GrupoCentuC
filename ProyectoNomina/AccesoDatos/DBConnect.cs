using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace AccesoDatos
{
    public class DBConnect
    {
        private string conexion;

        public DBConnect()
        {
            conexion = GetConnectionString();
        }

        public string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("ConnectDB");
        }
    }
}