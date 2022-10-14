using OrderNow.Admin.DAL;
using OrderNow.Admin.DAL.Repositorios;
using OrderNow.Common.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            DataSet dataSet = Conexion.ObtenerTodos("Products");

            dgvProductos.DataSource = dataSet.Tables[0];
            dgvProductos.Update();

            ActualizarCombos();
        }

        private void ActualizarCombos()
        {
          
            DataSet dsCategorias = Conexion.ObtenerTodos("Categories");
            DataTable dtCategorias = dsCategorias.Tables[0];

            cbCategoria.DisplayMember = "Name";
            cbCategoria.ValueMember = "Id";
            cbCategoria.DataSource = dtCategorias;
            cbCategoria.Update();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Categories categories = new Categories();
            categories.Name = cbCategoria.Text;
            categories.Id = Guid.Parse("269c886d-325f-4865-9cc4-34449aa3f56b");

            Businesses businesses = new Businesses
            {
                Id = Guid.Parse("269c886d-325f-4865-9cc4-34449aa3f56a"),
                ContractURL = "askldjasldkj"
            };

            Recipes recipes = new Recipes();
            recipes.Id = Guid.Parse("ec4f7031-bdf7-47a5-9548-5b1514962960");

            Products producto = new Products
            {
                Id = Guid.NewGuid(),
                EAN = txtEAN.Text,
                Code = txtCodigo.Text,
                Description = txtDescripcion.Text,
                Name = txtNombre.Text,
                LegalName = txtNombreLegal.Text,
                Brand = txtMarca.Text,
                Category = categories,
                HasRecipe = cbxReceta.Checked,
                IsSelleable = cbxVendible.Checked,
                IsSuggested = cbxSugerido.Checked,
                Created = DateTime.Now,
                URLIcon = txtURLIcono.Text,
                URLImage = txtURLImagen.Text,
                Price = Decimal.Parse(txtPrecio.Text),
                Stock = float.Parse(txtStockActual.Text),
                Business = businesses,
                Qualifications = 0,
                Score = 0,
                Status = true,
                LastModified = DateTime.Now,
                OptionsList = null,
                Recipe = recipes,



            };
            int rows = RepositorioProductos.AltaProducto(producto);

            if (rows > 0)
            {
                MessageBox.Show("El registro se ha insertado correctamente");
            }
        }
    }
}
