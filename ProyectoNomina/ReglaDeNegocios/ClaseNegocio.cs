using AccesoDatos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeNegocios
{
    public class ClaseNegocio
    {
        private readonly DBConnect connect;
        public ClaseNegocio(IConfiguration configuration) 
        {
            connect = new DBConnect(configuration);
        }   

        public void RealizarOperacion()
        {
            using (SqlConnection conexion = connect.GetConnection())
            {
                conexion.Open();
                
            }
        }
    }
}
