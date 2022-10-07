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
    public partial class ABMProductos : Form
    {
        public ABMProductos()
        {
            InitializeComponent();
        }

        private void ABMProductos_Load(object sender, EventArgs e)
        {
            Acciones acciones = new Acciones();
            DataSet dataSet = acciones.ObtenerTodos("Products");

            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Update();
        }
    }
}
