using OrderNow.Admin.DAL;
using OrderNow.Admin.DAL.Repositorios;
using OrderNow.Common.Data.Entities;
using System.Data;

namespace OrderNow.Admin.Forms
{
    public partial class ABMRecetas : Form
    {
        public DataSet ingredientes { get; set; }
        public ABMRecetas()
        {
            InitializeComponent();
        }

        private void ABMRecetas_Load(object sender, EventArgs e)
        {

            DataSet dataSet = Conexion.ObtenerTodos("Recipes");

            dgvRecetas.DataSource = dataSet.Tables[0];
            dgvRecetas.Update();

            DataSet dsIngredientes = RepositorioRecetas.ObtenerIngredientes();

            cbIngredientes.DataSource = dsIngredientes.Tables[0];
            cbIngredientes.DisplayMember = "Name";
            cbIngredientes.ValueMember = "Code";
            cbIngredientes.Update();

            dgvIngredientes.Columns.Add("colCantidad", "Cantidad");
            dgvIngredientes.Columns.Add("colCodigo", "Código");

            dgvIngredientes.Columns.Add("colIngredientes", "Ingredientes");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvIngredientes.Rows.Add(txtCantidad.Text, cbIngredientes.SelectedValue.ToString(), cbIngredientes.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvIngredientes.Rows.Count > 0)
            {
                Recipes recipes = new Recipes()
                {
                    Name = txtNombre.Text,
                    Created = DateTime.Now,
                };
                recipes.Ingredients = new List<Ingredients>();
                List<Products> ListIngredients = RepositorioProductos.ObtenerProductos();

                foreach (DataGridViewRow item in dgvIngredientes.Rows)
                {
                    var cant = item.Cells[0].Value; //Cantidad
                    var cod = item.Cells[1].Value; //Codigo de producto en receta
                    if (cant != null)
                    {

                        Products? product = ListIngredients.FirstOrDefault(x => x.Code.Equals(cod));
                        Ingredients ingredient = new()
                        {
                            Quantity = int.Parse(cant.ToString()),
                            Ingredient = product,
                            Created = DateTime.Now
                        };
                        recipes.Ingredients.Add(ingredient);
                    }
                }
                RepositorioRecetas.GuardarReceta(recipes);

                foreach (var ingrediente in recipes.Ingredients)
                {
                    RepositorioRecetas.GuardarIngredienteDeReceta(recipes.Id, ingrediente);
                }




            
        }

    }
}
}
