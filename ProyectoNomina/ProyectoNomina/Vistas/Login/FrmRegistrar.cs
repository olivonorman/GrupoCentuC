using Microsoft.Data.SqlClient;
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
        #region Atributo
        private readonly IEmpleadoRepository empleadoRepository;
        #endregion
        #region Constructor
        public FrmRegistrar(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            txtPassword.PasswordChar = '*';
        }
        #endregion
        #region Botones del formulario
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

        private void picGuardar_Click(object sender, EventArgs e)
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

        private void picCancelar_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
