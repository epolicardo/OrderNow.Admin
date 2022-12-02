using OrderNow.Admin.DAL;
using OrderNow.Admin.DAL.Repositorios;
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
    public partial class frmRelacionarUsuariosComercios : Form
    {
        public frmRelacionarUsuariosComercios()
        {
            InitializeComponent();
        }

        private void frmRelacionarUsuariosComercios_Load(object sender, EventArgs e)
        {
            ActualizarCombos(cbComercios, "Businesses", "Id", "Name");
            ActualizarCombos(cbUsuarios, "AspNetUsers", "Id", "Email");
        }

        public static void ActualizarCombos(ComboBox comboBox, string Tabla, string value, string display)
        {
            DataSet ds = Conexion.ObtenerTodos(Tabla);
            DataTable dataTable = ds.Tables[0];

            comboBox.DisplayMember = display;
            comboBox.ValueMember = value;
            comboBox.DataSource = dataTable;
            comboBox.Update();
        }

        private void btnGuardarRelacion_Click(object sender, EventArgs e)
        {
            var userId = Guid.Parse(cbUsuarios.SelectedValue.ToString());
            var businessId = Guid.Parse(cbComercios.SelectedValue.ToString());

            RepositorioComercios.Relacionar(businessId, userId);
        }
    }
}