using ReglaDeNegocios.Servicios.Interfaz;
using ReglaDeNegocios.Servicios.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNomina.Vistas.Reportes
{
    public partial class FrmEmployeesWoman : Form
    {
        #region Atributo 
        private readonly IEmpleadoRepository empleadoRepository;
        #endregion
        #region Constructor
        public FrmEmployeesWoman(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            LoadEmployeesWoman();
        }
        #endregion
        #region Metodo para cargar el datagridview
        public void LoadEmployeesWoman()
        {
            int i = 0;
            dgvEmployeesWoman.Rows.Clear();
            DataTable dt = new DataTable();
            dt = empleadoRepository.ObtenerEmpleadosMujeres();
            foreach (DataRow row in dt.Rows)
            {
                i++;
                dgvEmployeesWoman.Rows.Add(row["Id"], row["Nombre"].ToString(), row["Apellido"].ToString(), row["Edad"].ToString());
            }
        }
        #endregion
    }
}
