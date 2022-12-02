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
using ComboBox = System.Windows.Forms.ComboBox;

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
            if (dataSet.Tables.Count > 0)
            {

                dgvProductos.DataSource = dataSet.Tables[0];
                dgvProductos.Update();
            }

            ActualizarCombos(cbCategoria, "Categories", "Id", "Name");
            ActualizarCombos(cbComercios, "Businesses", "Id", "Name");
            ActualizarCombos(cbReceta, "Recipes", "Id", "Name");
            ActualizarCombos(cbUsuarios, "AspNetUsers", "Id", "Email");
        }

        private void ActualizarCombos(ComboBox comboBox, string Tabla, string value, string display)
        {

            DataSet ds = Conexion.ObtenerTodos(Tabla);
            DataTable dataTable = ds.Tables[0];

            comboBox.DisplayMember = display;
            comboBox.ValueMember = value;
            comboBox.DataSource = dataTable;
            comboBox.Update();
            comboBox.SelectedIndex = -1;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Businesses businesses = new();
            Categories categories = new();

            if (cbCategoria.SelectedIndex != -1)
                categories.Id = Guid.Parse(cbCategoria.SelectedValue.ToString());
            else
                MessageBox.Show("Debe seleccionar una categoria para continuar");

            if (cbComercios.SelectedIndex != -1)
                businesses.Id = Guid.Parse(cbComercios.SelectedValue.ToString());
            else
                MessageBox.Show("Debe seleccionar un comercio para continuar");

            Products producto = new Products
            {
                Id = Guid.NewGuid(),
                EAN = txtEAN.Text,
                Code = txtCodigo.Text,
                Description = txtDescripcion.Text,
                Name = txtNombre.Text,
                LegalName = txtNombreLegal.Text,
                Brand = txtMarca.Text,
                IsSelleable = cbxVendible.Checked,
                IsSuggested = cbxSugerido.Checked,
                Created = DateTime.Now,
                URLIcon = txtURLIcono.Text,
                URLImage = txtURLImagen.Text,
                Price = Decimal.Parse(txtPrecio.Text),
                Stock = float.Parse(txtStockActual.Text),
                Category = categories,
                Business = businesses,
                Qualifications = 0,
                Score = 0,
                Status = true,
                LastModified = DateTime.Now,
                OptionsList = null,

            };

            if (cbxReceta.Checked)
            {
                if (cbReceta.Items.Count != 0)
                {

                    if (cbReceta.SelectedIndex != -1)
                    {

                        Recipes recipes = new Recipes
                        {
                            Id = Guid.Parse(cbReceta.SelectedValue.ToString())
                        };
                        producto.HasRecipe = true;
                        producto.Recipe = recipes;

                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una receta o desmarcar el tilde de Receta");
                    }
                }
                else
                {
                    MessageBox.Show("No hay recetas cargadas en el sistema.");

                }
            }
            else
            {
                producto.HasRecipe = false;
                producto.Recipe = null;
            }

            Guid userId = Guid.Parse(cbUsuarios.SelectedValue.ToString());
            int rows = RepositorioProductos.AltaProducto(producto, userId);

            if (rows > 0)
            {
                MessageBox.Show("El registro se ha insertado correctamente");
            }
            dgvProductos.Update();
            dgvProductos.Refresh();
        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            //txtCodigo.Text = dgvClientes.CurrentRow.Cells[0].display.ToString();
            //txtNombre.Text = dgvClientes.CurrentRow.Cells[1].display.ToString();
            //txtDescripcion.Text = dgvClientes.CurrentRow.Cells[2].display.ToString();
            //txt.Text = dgvClientes.CurrentRow.Cells[3].display.ToString();
            //txt.Text = dgvClientes.CurrentRow.Cells[3].display.ToString();


        }

        private void txtNombreLegal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
