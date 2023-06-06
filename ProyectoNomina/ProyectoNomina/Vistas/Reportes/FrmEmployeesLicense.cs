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
    public partial class FrmEmployeesLicense : Form
    {
        #region Atributo
        private readonly IEmpleadoRepository empleadoRepository;
        #endregion
        #region Constructor
        public FrmEmployeesLicense(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            LoadEmployeeLicense();
        }
        #endregion
        #region Metodo para cargar el datagridview
        public void LoadEmployeeLicense()
        {
            int i = 0;
            DgvEmployeesLicense.Rows.Clear();
            DataTable dt = new DataTable();
            dt = empleadoRepository.ObtenerEmpleadoConLicencia();
            foreach (DataRow row in dt.Rows)
            {
                i++;
                string sexo = row["Sexo"].ToString();
                string sexoTexto = (sexo == "M") ? "Masculino" : (sexo == "F") ? "Femenino" : "";
                DgvEmployeesLicense.Rows.Add(row["Id"], row["Nombre"].ToString(), row["Apellido"].ToString(), row["Edad"].ToString(),
                    sexoTexto, Convert.ToDateTime(row["FechaNacimiento"]).Date.ToString("dd/MM/yyyy"));
            }
        }
        #endregion
    }
}
