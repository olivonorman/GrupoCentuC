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
    public partial class FrmLogin : Form
    {
        private readonly IEmpleadoRepository empleadoRepository;

        public FrmLogin(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            this.empleadoRepository = empleadoRepository;
            txtPassword.PasswordChar = '*';
        }

        private void MsgError(string mensaje)
        {
            lblErrorMessage.Text = " " + mensaje;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
            txtUserName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    var usuario = txtUserName.Text;
                    var clave = txtPassword.Text;
                    UserLogin userLogin = new UserLogin
                    {
                        UserName = usuario,
                        Clave = clave
                    };

                    Usuario usuarioAutenticado = empleadoRepository.IniciarSesion(userLogin);

                    if (usuarioAutenticado != null)
                    {

                        MainForm mainForm = new MainForm(empleadoRepository);
                        mainForm.lblName.Text = "Bienvenid@  " + usuarioAutenticado.Nombre;
                        mainForm.lblUserName.Text = usuarioAutenticado.UserName;
                        mainForm.lblId.Text = usuarioAutenticado.Id.ToString();

                        mainForm.Show();
                        mainForm.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MsgError("Usuario o Clave Incorrecta");
                    }
                }
                else
                {
                    MsgError("Por favor introduzca su clave!");
                }

            }
            else
            {
                MsgError("Por favor introduzca su usuario!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que deseas salir de la aplicacion? ", "Salir de la aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {
                FrmLogin login = new FrmLogin(empleadoRepository);
                login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrar registrar = new FrmRegistrar(empleadoRepository);
            registrar.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
