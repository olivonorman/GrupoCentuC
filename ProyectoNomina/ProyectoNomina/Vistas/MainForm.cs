using AccesoDatos;

namespace ProyectoNomina
{
    public partial class MainForm : Form
    {
        private DBConnect connect;
        public MainForm()
        {
            InitializeComponent();

            connect = new DBConnect();
            string conexion = connect.GetConnectionString();
        }



    }
}