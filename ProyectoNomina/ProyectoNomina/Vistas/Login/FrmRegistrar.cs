﻿using Microsoft.Data.SqlClient;
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

namespace ProyectoNomina.Vistas.Login
{
    public partial class FrmRegistrar : Form
    {
        private readonly IEmpleadoRepository empleadoRepository;

        public FrmRegistrar(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            txtPassword.PasswordChar = '*';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtName.Text;
                var userName = txtUserName.Text;
                var clave = txtPassword.Text;
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Debe de llenar todos los campos", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Usuario usuario = new Usuario
                    {
                        Nombre = nombre,
                        UserName = userName,
                        Clave = clave
                    };

                    empleadoRepository.RegistrarUsuario(usuario);
                    MessageBox.Show("El usuario ha sido registrado", "Registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin login = new FrmLogin(empleadoRepository);
                    login.Show();
                    this.Hide();
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que deseas cancelar? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin(empleadoRepository);
                login.Show();
                this.Hide();

            }
            else
            {
                FrmRegistrar frmRegistrar = new FrmRegistrar(empleadoRepository);
                frmRegistrar.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro que deseas cancelar? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin(empleadoRepository);
                login.Show();
                this.Hide();

            }
            else
            {
                FrmRegistrar frmRegistrar = new FrmRegistrar(empleadoRepository);
                frmRegistrar.Show();
            }
        }
    }
}
