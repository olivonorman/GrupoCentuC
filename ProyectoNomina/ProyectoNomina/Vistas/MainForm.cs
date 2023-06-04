using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProyectoNomina.Vistas;
using ProyectoNomina.Vistas.Empleados;
using ProyectoNomina.Vistas.Reportes;
using ReglaDeNegocios.Entidad;
using ReglaDeNegocios.Servicios.Interfaz;

namespace ProyectoNomina
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        private readonly IEmpleadoRepository empleadoRepository;
        public MainForm(IEmpleadoRepository empleadoRepository)
        {
            InitializeComponent();
            customizeDesign();
            this.empleadoRepository = empleadoRepository;
        }



        private void customizeDesign()
        {
            panelEmployees.Visible = false;
            panelReports.Visible = false;
            //LoadUserData();
        }

        private void LoadUserData()
        {
            var nombre = lblName.Text;
            var userName = lblUserName.Text;
            var id = Convert.ToInt32(lblId.Text);
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(userName))
            {
                UsuarioLoginCache usuarioLogin = new UsuarioLoginCache
                {
                    Id = id,
                    Name = nombre,
                    UserName = userName
                };
                empleadoRepository.UsuarioCache(usuarioLogin);
            }

        }

        private void hideSubmenu()
        {
            if (panelEmployees.Visible == true)
            {
                panelEmployees.Visible = false;
            }
            if (panelReports.Visible == true)
            {
                panelReports.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
            {
                hideSubmenu();
                submenu.Visible = false;
            }
        }



        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnEmployees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmployees);
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmployee(empleadoRepository));
            hideSubmenu();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReports);
        }

        private void btnEmployeesLisence_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmployeesLicense(empleadoRepository));
            hideSubmenu();
        }

        private void btnEmployeesWomen_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmployeesWoman(empleadoRepository));
            hideSubmenu();
        }

        private void btnEmployeeUpper50K_Click(object sender, EventArgs e)
        {

            openChildForm(new FrmEmployees50K(empleadoRepository));
            hideSubmenu();
        }

        private void btnCalcularNomina_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCalcularNomina(empleadoRepository));
            hideSubmenu();
        }
    }
}