using Microsoft.Extensions.Configuration;
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
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoNomina.Vistas.Empleados
{
    public partial class FrmCreateEmployee : Form
    {

        FrmEmployee employee;
        private readonly IEmpleadoRepository empleadoRepository;
        public bool isEditing = false;
        public FrmCreateEmployee(FrmEmployee frmEmployee,IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            employee = frmEmployee;
            this.empleadoRepository = empleadoRepository;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            char sexo = cbxSexo.SelectedItem.ToString()[0];
            DateTime fechaNacimiento = dtFechaNac.Value;
            bool poseeLicencia = chkLicencia.Checked;
            decimal sueldoBruto = Convert.ToDecimal(txtSueldo.Text);
            try
            {
                if (isEditing)
                {
                    if (MessageBox.Show("Seguro que deseas actualizar este registro?", "Actualizar Empleado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    }
                }
                else
                {
                    if (MessageBox.Show("Seguro que deseas guardar este registro?", "Guardar Empleado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Empleado empleado = new Empleado
                        {
                            Nombre = nombre,
                            Apellido = apellido,
                            Edad = edad,
                            Sexo = sexo,
                            FechaNacimiento = fechaNacimiento,
                            PoseeLicencia = poseeLicencia,
                            SueldoBruto = sueldoBruto

                        };

                        //EmpleadoRepository empleadoRepository = new EmpleadoRepository();
                        empleadoRepository.InsertarEmpleado(empleado);
                        MessageBox.Show("Empleado creado correctamente!");
                        employee.LoadEmployees();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
