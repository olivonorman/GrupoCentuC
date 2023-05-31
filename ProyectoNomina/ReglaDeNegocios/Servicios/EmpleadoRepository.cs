using AccesoDatos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ReglaDeNegocios.Entidades;
using ReglaDeNegocios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeNegocios.Servicios
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly DBConnect db;

        

        public EmpleadoRepository(IConfiguration configuration)
        {

            db = new DBConnect(configuration);

        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public void EliminarEmpleado(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public void InsertarEmpleado(Empleado empleado)
        {
          using(var conexion = db.GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("InsertarEmpleado", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@Edad", empleado.Edad);
                comando.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento);
                comando.Parameters.AddWithValue("@PoseeLicencia", empleado.PoseeLicencia);
                comando.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);

                comando.ExecuteNonQuery();
            }
        }

        public List<Empleado> ObtenerEmpleadoConLicencia()
        {
            throw new NotImplementedException();
        }

        public List<Empleado> ObtenerEmpleadosConSalarioSuperior()
        {
            throw new NotImplementedException();
        }

        public List<Empleado> ObtenerEmpleadosMujeres()
        {
            throw new NotImplementedException();
        }

        public List<Empleado> ObtenerTodosLosEmpleados()
        {
            throw new NotImplementedException();
        }
    }
}
