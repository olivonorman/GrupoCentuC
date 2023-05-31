using AccesoDatos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProyectoNomina.Vistas;
using ProyectoNomina.Vistas.Empleados;
using ReglaDeNegocios;
using ReglaDeNegocios.Interfaz;
using ReglaDeNegocios.Servicios;

namespace ProyectoNomina
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();

        }

        

        private void customizeDesign()
        {
            panelEmployees.Visible = false;
            panelReports.Visible = false;
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

        private Form activeForm = null;
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReports);
        }

        private void btnEmployeeUpper50K_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmployees50K());
            hideSubmenu();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .Build();
            IEmpleadoRepository empleadoRepository = new EmpleadoRepository(configuration);
            openChildForm(new FrmEmployee(empleadoRepository));
            hideSubmenu();
        }
    }
}