using ReglaDeNegocios.Entidades;
using ReglaDeNegocios.Interfaz;
using ReglaDeNegocios.Servicios;
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
        public Empleado Empleado = new Empleado();
        public FrmEmployee(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            FrmCreateEmployee frmCreate = new FrmCreateEmployee(this,empleadoRepository);
            frmCreate.ShowDialog();
        }
    }
}
