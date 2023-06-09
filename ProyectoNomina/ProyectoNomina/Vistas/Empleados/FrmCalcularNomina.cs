﻿using ReglaDeNegocios.Servicios.Interfaz;
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
    public partial class FrmCalcularNomina : Form
    {
        #region Atributos
        private readonly IEmpleadoRepository empleadoRepository;
        #endregion
        #region Constructor
        public FrmCalcularNomina(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            LoadCalcularNomina();
        }
        #endregion
        #region Metodos para mostrar el DataGridView
        private void LoadCalcularNomina()
        {
            int i = 0;
            dgvCalculoNomina.Rows.Clear();
            DataTable dt = new DataTable();
            dt = empleadoRepository.ObtenerTodosLosEmpleados();
            foreach (DataRow dr in dt.Rows)
            {
                i++;
                dgvCalculoNomina.Rows.Add(dr["Id"].ToString(), dr["Nombre"].ToString(), dr["Apellido"].ToString(),
                    dr["SueldoBruto"].ToString(), dr["TSS"].ToString(), dr["ISR"].ToString(), dr["SueldoNeto"].ToString());
            }
        }

        private void btnCalcularNomina_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCalculoNomina.SelectedRows)
            {
                decimal sueldoBruto = Convert.ToDecimal(row.Cells["SueldoBruto"].Value);

                decimal isr = empleadoRepository.CalcularISR(sueldoBruto);
                decimal tss = empleadoRepository.CalcularTSS(sueldoBruto);
                decimal sueldoNeto = empleadoRepository.CalcularSueldoNeto(sueldoBruto);

                int empleadoId = Convert.ToInt32(row.Cells["Id"].Value);
                empleadoRepository.CalcularNomina(empleadoId, isr, tss, sueldoNeto);
            }

            MessageBox.Show("La nómina ha sido calculada para los empleados seleccionados.");
            LoadCalcularNomina();
        }

        private void dgvCalculoNomina_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = { "SueldoBruto", "ISR", "TSS", "SueldoNeto" };

            if (columnNames.Contains(dgvCalculoNomina.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal precio))
                {
                    CultureInfo culture = new CultureInfo("es-DO");
                    e.Value = precio.ToString("C", culture);
                    e.FormattingApplied = true;

                }
            }
        }

        #endregion
    }
}
