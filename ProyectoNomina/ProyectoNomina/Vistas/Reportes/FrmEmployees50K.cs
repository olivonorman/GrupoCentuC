using ReglaDeNegocios.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNomina.Vistas
{
    public partial class FrmEmployees50K : Form
    {
        private readonly IEmpleadoRepository empleadoRepository;

        public FrmEmployees50K(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            LoadEmployee50K();
        }

        public void LoadEmployee50K()
        {
            int i = 0;
            dgvReport50K.Rows.Clear();
            DataTable dt = new DataTable();
            dt = empleadoRepository.ObtenerEmpleadosConSalarioSuperior();
            foreach (DataRow row in dt.Rows)
            {
                i++;
                string sexo = row["Sexo"].ToString();
                string sexoTexto = (sexo == "M") ? "Masculino" : (sexo == "F") ? "Femenino" : "";
                dgvReport50K.Rows.Add(row["Id"], row["Nombre"].ToString(), row["Apellido"].ToString(), row["Edad"].ToString(),
                    sexoTexto, Convert.ToDateTime(row["FechaNacimiento"]).Date.ToString("dd/MM/yyyy"), row["SueldoBruto"].ToString());
            }
        }

        private void dgvReport50K_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReport50K.Columns[e.ColumnIndex].Name == "SueldoBruto")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    CultureInfo cultureInfo = new CultureInfo("es-DO");
                    e.Value = valor.ToString("C", cultureInfo);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
