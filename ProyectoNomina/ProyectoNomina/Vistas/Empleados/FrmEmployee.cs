﻿
using ReglaDeNegocios.Entidad;
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

namespace ProyectoNomina.Vistas.Empleados
{
    public partial class FrmEmployee : Form
    {
        #region atributo
        private readonly IEmpleadoRepository empleadoRepository;
        #endregion
        #region Constructor
        public FrmEmployee(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            LoadEmployees();
        }
        #endregion
        #region Metodos y botones
        public void LoadEmployees()
        {

            int i = 0;
            dgvEmployees.Rows.Clear();
            DataTable dataTable = new DataTable();
            dataTable = empleadoRepository.ObtenerTodosLosEmpleados();
            foreach (DataRow row in dataTable.Rows)
            {
                i++;
                var sexo = Convert.ToChar(row["Sexo"]);
                var poseeLicencia = bool.Parse(row["PoseeLicencia"].ToString());
                dgvEmployees.Rows.Add(row["Id"], row["Nombre"].ToString(), row["Apellido"].ToString(), row["Edad"].ToString(),
                    sexo, Convert.ToDateTime(row["FechaNacimiento"]).Date.ToString("dd/MM/yyyy"),poseeLicencia , row["SueldoBruto"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCreateEmployee frmCreate = new FrmCreateEmployee(this, empleadoRepository);
            frmCreate.ShowDialog();

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var colunmName = dgvEmployees.Columns[e.ColumnIndex].Name;
                if (colunmName == "Edit")
                {
                    FrmCreateEmployee frmCreate = new FrmCreateEmployee(this, empleadoRepository);
                    frmCreate.lblId.Text = dgvEmployees["Id", e.RowIndex].Value.ToString();
                    frmCreate.txtNombre.Text = dgvEmployees["Nombre", e.RowIndex].Value.ToString();
                    frmCreate.txtApellido.Text = dgvEmployees["Apellido", e.RowIndex].Value.ToString();
                    frmCreate.txtEdad.Text = dgvEmployees["Edad", e.RowIndex].Value.ToString();
                    frmCreate.cbxSexo.Text = dgvEmployees["Sexo", e.RowIndex].Value.ToString();
                    frmCreate.dtFechaNac.Text = dgvEmployees["FechaNacimiento", e.RowIndex].Value.ToString();
                    var poseeLicencia = Convert.ToBoolean(dgvEmployees["PoseeLicencia",e.RowIndex].Value.ToString());
                    frmCreate.chkLicencia.Checked = poseeLicencia;
                    frmCreate.txtSueldo.Text = dgvEmployees["SueldoBruto", e.RowIndex].Value.ToString();
                    frmCreate.isEditing = true;
                    frmCreate.ShowDialog();
                }
                else if (colunmName == "Delete")
                {
                    if (MessageBox.Show("Seguro que deseas eliminar este registro?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var id = int.Parse(dgvEmployees["Id", e.RowIndex].Value.ToString());
                        empleadoRepository.EliminarEmpleado(id);
                        MessageBox.Show("El empleado ha sido eliminado correctamente!!", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadEmployees();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "SueldoBruto")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal sueldoBruto))
                {
                    CultureInfo cultureInfo = new CultureInfo("es-DO");
                    e.Value = sueldoBruto.ToString("C", cultureInfo);
                    e.FormattingApplied = true;
                }
            }

            if (dgvEmployees.Columns[e.ColumnIndex].Name == "PoseeLicencia")
            {
                if (e.Value != null)
                {
                    var poseeLicencia = (bool)e.Value;
                    e.Value = poseeLicencia ? "Si" : "No";
                    e.FormattingApplied = true;
                }
            }

            if (dgvEmployees.Columns[e.ColumnIndex].Name == "Sexo")
            {
                if (e.Value != null)
                {
                    var sexo = (char)e.Value;
                    e.Value = sexo == 'M' ? "Masculino" : "Femenino";
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion
    }
}
