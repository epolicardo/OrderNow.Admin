namespace OrderNow.Admin.Forms
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void ABMProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProductos form = new ABMProductos();
            form.Owner = this;
            form.Show(this);
        }

        private void ABMCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCategorias form = new ABMCategorias();
            form.Owner = this;
            form.Show(this);
        }

        private void ABMRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMRecetas form = new ABMRecetas();
            form.Owner = this;
            form.Show(this);
        }

        private void ABMComerciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMComercios form = new ABMComercios();
            form.Owner = this;
            form.Show(this);

        }
    }
}