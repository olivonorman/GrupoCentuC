﻿using ReglaDeNegocios.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                dgvReport50K.Rows.Add(row["Id"], row["Nombre"].ToString(), row["Apellido"].ToString(), row["Edad"].ToString(),
                    row["Sexo"].ToString(), row["FechaNacimiento"].ToString(), row["SueldoBruto"].ToString());
            }
        }
    }
}
