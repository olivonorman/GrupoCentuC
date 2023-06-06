using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProyectoNomina.Vistas.Empleados;
using ProyectoNomina.Vistas.Login;
using ReglaDeNegocios.Servicios.Interfaz;
using ReglaDeNegocios.Servicios.Repositorio;

namespace ProyectoNomina
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IEmpleadoRepository empleadoRepository = new EmpleadoRepository();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin(empleadoRepository));
        }
        
    }
}