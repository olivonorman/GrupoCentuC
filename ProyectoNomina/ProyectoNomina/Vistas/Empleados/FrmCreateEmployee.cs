using Microsoft.Extensions.Configuration;
using ProyectoNomina.Vistas.Login;
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
        public FrmCreateEmployee(FrmEmployee frmEmployee, IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            employee = frmEmployee;
            this.empleadoRepository = empleadoRepository;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad;
            char sexo;
            DateTime fechaNacimiento = dtFechaNac.Value;
            bool poseeLicencia = chkLicencia.Checked;
            decimal sueldoBruto;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(txtEdad.Text) || cbxSexo.SelectedItem == null || string.IsNullOrEmpty(txtSueldo.Text))
            {
                MessageBox.Show("Debe de llenar todos los campos", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtEdad.Text, out edad) || edad <= 18)
            {
                MessageBox.Show("La edad debe ser mayor a 18", "Edad invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!char.TryParse(cbxSexo.SelectedItem.ToString(), out sexo))
            {
                MessageBox.Show("El sexo seleccionado no es valido", "Sexo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!decimal.TryParse(txtSueldo.Text, out sueldoBruto))
            {
                MessageBox.Show("El sueldo seleccionado no es valido", "Sueldo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DateTime.Now.AddYears(-18) <= fechaNacimiento)
            {
                MessageBox.Show("La fecha de nacimiento debe ser de una persona mayor a 18 años", "Fecha de nacimiento inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (isEditing)
                    {
                        if (MessageBox.Show("Seguro que deseas actualizar este registro?", "Actualizar Empleado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Empleado empleado = new Empleado
                            {
                                Nombre = nombre,
                                Apellido = apellido,
                                Edad = edad,
                                Sexo = sexo,
                                FechaNacimiento = fechaNacimiento,
                                PoseeLicencia = poseeLicencia,
                                SueldoBruto = sueldoBruto,
                                Id = int.Parse(lblId.Text)

                            };

                            empleadoRepository.ActualizarEmpleado(empleado);
                            MessageBox.Show("Empleado actualizado correctamente!");
                            employee.LoadEmployees();
                            this.Close();
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
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que deseas cancelar? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                employee.Show();
                this.Close();

            }
            else
            {
                this.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que deseas cancelar? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                employee.Show();
                this.Close();

            }
            else
            {
                this.Show();
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void FrmCreateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
