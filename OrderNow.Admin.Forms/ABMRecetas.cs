using OrderNow.Admin.DAL;
using System.Data;

namespace OrderNow.Admin.Forms
{
    public partial class ABMRecetas : Form
    {
        public ABMRecetas()
        {
            InitializeComponent();
        }

        private void ABMRecetas_Load(object sender, EventArgs e)
        {
      
            DataSet dataSet = Conexion.ObtenerTodos("Recipes");

            dgvRecetas.DataSource = dataSet.Tables[0];
            dgvRecetas.Update();
        }
    }
}
