using OrderNow.Admin.DAL;
using System.Data;

namespace OrderNow.Admin.Forms
{
    public partial class ABMComercios : Form
    {
        public ABMComercios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ABMComercios_Load(object sender, EventArgs e)
        {
            DataSet dataSet = Conexion.ObtenerTodos("Businesses");

            dgvComercios.DataSource = dataSet.Tables[0];
            dgvComercios.Update();
        }
    }
}
