using ReglaDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeNegocios.Interfaz
{
    public interface IEmpleadoRepository
    {
        List<Empleado> ObtenerTodosLosEmpleados();
        void InsertarEmpleado(Empleado empleado);
        void ActualizarEmpleado(Empleado empleado);
        void EliminarEmpleado(int empleadoId);
        List<Empleado> ObtenerEmpleadosMujeres();
        List<Empleado> ObtenerEmpleadoConLicencia();
        List<Empleado> ObtenerEmpleadosConSalarioSuperior();
    }
}
