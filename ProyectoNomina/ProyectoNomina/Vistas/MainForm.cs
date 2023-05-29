using AccesoDatos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ReglaDeNegocios;

namespace ProyectoNomina
{
    public partial class MainForm : Form
    {
        private readonly ClaseNegocio claseNegocio;
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

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmployees);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReports);
        }
    }
}