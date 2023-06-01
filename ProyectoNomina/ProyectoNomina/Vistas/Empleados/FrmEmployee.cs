
using ReglaDeNegocios.Entidad;
using ReglaDeNegocios.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNomina.Vistas.Empleados
{
    public partial class FrmEmployee : Form
    {
        private readonly IEmpleadoRepository empleadoRepository;
        public FrmEmployee(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            
            int i = 0;
            dgvEmployees.Rows.Clear();
            DataTable dataTable = new DataTable();
            dataTable = empleadoRepository.ObtenerTodosLosEmpleados();
            foreach (DataRow row in dataTable.Rows)
            {
                i++;
                dgvEmployees.Rows.Add(row["Id"], row["Nombre"].ToString(), row["Apellido"].ToString(), row["Edad"].ToString(),
                    row["Sexo"].ToString(), row["FechaNacimiento"].ToString(), row["PoseeLicencia"].ToString(), row["SueldoBruto"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmCreateEmployee frmCreate = new FrmCreateEmployee(this, empleadoRepository);
            frmCreate.ShowDialog();
        }
    }
}
