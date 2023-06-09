﻿using Microsoft.Data.SqlClient;
using ReglaDeNegocios.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeNegocios.Servicios.Interfaz
{
    public interface IEmpleadoRepository
    {
        #region Metodos para implementarlos en el repositorio
        DataTable ObtenerTodosLosEmpleados();
        void InsertarEmpleado(Empleado empleado);
        void ActualizarEmpleado(Empleado empleado);
        void EliminarEmpleado(int empleadoId);
        DataTable ObtenerEmpleadosMujeres();
        DataTable ObtenerEmpleadoConLicencia();
        DataTable ObtenerEmpleadosConSalarioSuperior();
        DataTable Consultar(SqlCommand comando);
        decimal CalcularISR(decimal sueldoBruto);
        decimal CalcularTSS(decimal sueldoBruto);  
        decimal CalcularSueldoNeto(decimal sueldoBruto);
        void CalcularNomina(int empleadoId, decimal isr, decimal tss, decimal sueldoNeto);
        Usuario IniciarSesion(UserLogin userLogin);
        void RegistrarUsuario(Usuario usuario);
        #endregion
    }
}
