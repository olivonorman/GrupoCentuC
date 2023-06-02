using AccesoDatos;
using Microsoft.Data.SqlClient;
using ReglaDeNegocios.Entidad;
using ReglaDeNegocios.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeNegocios.Servicios.Repositorio
{
    public class EmpleadoRepository:IEmpleadoRepository
    {
        private readonly DBConnect db;


        public EmpleadoRepository()
        {

            db = new DBConnect();

        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            using (var conexion = db.GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("ActualizaEmpleado", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id",empleado.Id);
                comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@Edad", empleado.Edad);
                comando.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento);
                comando.Parameters.AddWithValue("@PoseeLicencia", empleado.PoseeLicencia);
                comando.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);

                comando.ExecuteNonQuery();
            }
        }

        public decimal CalcularISR(decimal sueldoBruto)
        {
            decimal seguroFamiliarSalud = sueldoBruto * 0.0304m;
            decimal aporteFondoPensiones = sueldoBruto * 0.0287m;
            decimal sumaDescuentoTSS = seguroFamiliarSalud + aporteFondoPensiones;
            decimal salarioNeto = sueldoBruto - sumaDescuentoTSS;

            if (sueldoBruto <= 34685.00m)
            {
              return sueldoBruto;

            }else if(sueldoBruto > 34685.00m && sueldoBruto <= 52027.42m)
            {
                
                decimal montoEscala = 520270.42m;
                decimal excedente = montoEscala - salarioNeto;
                decimal tasaISR = excedente * 0.15m;
                
                return tasaISR;
            }else if(sueldoBruto > 52027.42m && sueldoBruto <= 72260.25m)
            {
                
                decimal montoEscala = 72260.25m + 2601.36m;
                decimal excedente = montoEscala - salarioNeto;
                decimal tasaISR = excedente * 0.20m;
                return tasaISR;
            }else if(sueldoBruto > 72260.25m)
            {
              
                decimal montoEscala = 72260.25m + 6647.92m;
                decimal excedente = montoEscala - salarioNeto;
                decimal tasaISR = excedente * 0.25m;
                return tasaISR;
            }
            return 0;
        }

        public decimal CalcularSueldoNeto(decimal sueldoBruto)
        {
            decimal seguroFamiliarSalud = sueldoBruto * 0.0304m;
            decimal aporteFondoPensiones = sueldoBruto * 0.0287m;
            decimal sumaDescuentoTSS = seguroFamiliarSalud + aporteFondoPensiones;
            decimal salarioNeto = sueldoBruto - sumaDescuentoTSS;

            return salarioNeto;
        }

        public decimal CalcularTSS(decimal sueldoBruto)
        {
            decimal seguroFamiliarSalud = sueldoBruto * 0.0304m;
            decimal aporteFondoPensiones = sueldoBruto * 0.0287m;
            decimal sumaDescuentoTSS = seguroFamiliarSalud + aporteFondoPensiones;

            return sumaDescuentoTSS;
        }

        public DataTable Consultar(SqlCommand comando)
        {
            try
            {
                using (var conexion = db.GetConnection())
                {
                    SqlDataReader dr;
                    conexion.Open();
                    comando.Connection = conexion;
                    dr = comando.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public void EliminarEmpleado(int empleadoId)
        {
            using (var conexion = db.GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("EliminarEmpleado",conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id", empleadoId);

                comando.ExecuteNonQuery();
            }
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            using (var conexion = db.GetConnection())
            {
                conexion.Open();
                var comando = new SqlCommand("InsertarEmpleado", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@Edad", empleado.Edad);
                comando.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento);
                comando.Parameters.AddWithValue("@PoseeLicencia", empleado.PoseeLicencia);
                comando.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);

                comando.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerEmpleadoConLicencia()
        {
            using (var conexion = db.GetConnection())
            {
                conexion.Open();
                try
                {
                    var comando = new SqlCommand("ObtenerEmpleadosConLicencia", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt = Consultar(comando);
                    return dt;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
        }

        public DataTable ObtenerEmpleadosConSalarioSuperior()
        {
            using (var conexion = db.GetConnection())
            {
                conexion.Open();
                try
                {
                    var comando = new SqlCommand("ObtenerEmpleadosSalario50", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt = Consultar(comando);
                    return dt;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
        }

        public DataTable ObtenerEmpleadosMujeres()
        {
            using (var conexion = db.GetConnection())
            {
                conexion.Open();
                try
                {
                    var comando = new SqlCommand("ObtenerEmpleadosMujeres", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt = Consultar(comando);
                    return dt;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
        }

        public DataTable ObtenerTodosLosEmpleados()
        {
            using (var conexion = db.GetConnection())
            {
                conexion.Open();
                try
                {
                    var comando = new SqlCommand("ObtenerEmpleados", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt = Consultar(comando);
                    return dt;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
        }
    }
}

