using OrderNow.Admin.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderNow.Admin.Forms
{
    public partial class ABMCategorias : Form
    {
        public ABMCategorias()
        {
            InitializeComponent();
        }

        private void ABMCategorias_Load(object sender, EventArgs e)
        {
            Acciones acciones = new Acciones();
            DataSet dataSet = Conexion.ObtenerTodos("Categories");

            dgvCategorias.DataSource = dataSet.Tables[0];
            dgvCategorias.Update();

        }
    }
}
