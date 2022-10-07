namespace OrderNow.Admin.Forms
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void aBMProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProductos prod = new ABMProductos();
            prod.Owner = this;
            prod.Show(this);
        }
    }
}