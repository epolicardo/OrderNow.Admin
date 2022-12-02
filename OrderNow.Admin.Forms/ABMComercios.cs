using OrderNow.Admin.DAL;
using OrderNow.Admin.DAL.Repositorios;
using OrderNow.Common.Data.Entities;
using System.Data;

namespace OrderNow.Admin.Forms
{
    public partial class ABMComercios : Form
    {
        public ABMComercios()
        {
            InitializeComponent();
        }

        private void ABMComercios_Load(object sender, EventArgs e)
        {
            ActualizarCombos(cbUser, "AspNetUsers", "Id", "Email");
            ActualizarGrillas(dgvComercios);
        }

        private void ActualizarGrillas(DataGridView dgv)
        {
            DataSet dataSet = RepositorioComercios.ObtenerListadoComercios();

            dgv.DataSource = dataSet.Tables[0];
            dgv.Update();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiarEstados(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Guardar")
            {
                Addresses domicilio = new Addresses()
                {
                    Id = Guid.NewGuid(),
                    Street = txtCalle.Text,
                    Number = txtNro.Text,
                    Floor = txtPiso.Text,
                    City = txtLocalidad.Text,
                    Apartment = "",
                    Tower = "",
                    Observations = "",
                    Created = DateTime.Now,
                    LastModified = DateTime.Now
                };
                RepositorioDomicilios.InsertarNuevo(domicilio);

                Businesses businesses = new Businesses()
                {
                    Address = domicilio,
                    ContractURL = txtContractUrl.Text,
                    LegalName = txtLegalName.Text,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    PromoMessage = txtPromoMessage.Text,
                    CUIT = txtCUIT.Text,
                    Created = DateTime.Parse(dtpAlta.Text),
                    LastModified = DateTime.Now,
                    IsValidated = true,
                    IsFrachise = true,
                    ValidationExpires = DateTime.Parse(dtpAlta.Text),
                    ValidationTime = DateTime.Parse(dtpValidacion.Text),
                    Score = 0,
                    Qualification = 0,
                    URLIconImage = "",
                    URLRegularImage = string.Empty
                };
                Businesses comercio = businesses;

                var u = cbUser.SelectedValue;

                int res = RepositorioComercios.InsertarNuevoComercio(comercio, Guid.Parse(u.ToString()));
            }
            else
            {
                Businesses comercio = RepositorioComercios.ObtenerComercioPorURL(txtContractUrl.Text);
                comercio.Name = txtName.Text;
                comercio.URLRegularImage = string.Empty;
                comercio.URLIconImage = string.Empty;
                comercio.ContractURL = txtContractUrl.Text;
                comercio.PromoMessage = txtPromoMessage.Text;
                comercio.IsFrachise = cbxFranquicia.Checked;
                comercio.CUIT = txtCUIT.Text;
                comercio.LegalName = txtLegalName.Text;
                comercio.Phone = txtPhone.Text;
                comercio.IsValidated = cbxValidado.Checked;
                comercio.ValidationTime = dtpValidacion.Value;
                comercio.ValidationExpires = dtpExpira.Value;
                comercio.PromoMessage = txtEmail.Text;
                comercio.LastModified = DateTime.Now;
                comercio.Address.Street = txtCalle.Text;
                comercio.Address.City = txtLocalidad.Text;
                int resultado = RepositorioComercios.ActualizarComercio(comercio);
                if (resultado == 1)
                {
                    MessageBox.Show("El comercio fue actualizado con exito", "ABM Comercios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CambiarEstados(false);
                    ActualizarGrillas(dgvComercios);
                }
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ofdArchivos.ShowDialog();
            pictureBox2.Tag = ofdArchivos.FileName;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ofdArchivos.ShowDialog();
            pictureBox1.Tag = ofdArchivos.FileName;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            CambiarEstados(true);
        }

        private void CambiarEstados(bool estado)
        {
            btnGuardar.Enabled = estado;
            txtName.Enabled = estado;
            txtLegalName.Enabled = estado;
            txtPhone.Enabled = estado;
            txtCUIT.Enabled = estado;
            txtEmail.Enabled = estado;
            txtCalle.Enabled = estado;
            txtNro.Enabled = estado;
            txtPiso.Enabled = estado;
            txtLocalidad.Enabled = estado;
            txtObservaciones.Enabled = estado;
            dtpAlta.Enabled = estado;
            dtpValidacion.Enabled = estado;
            dtpExpira.Enabled = estado;
            txtContractUrl.Enabled = estado;
            cbUser.Enabled = estado;
            txtPromoMessage.Enabled = estado;
            cbxFranquicia.Enabled = estado;
            cbxValidado.Enabled = estado;
            btnIcon.Enabled = estado;
            btnImage.Enabled = estado;
            btnCancelar.Enabled = estado;
            btnNuevo.Enabled = !estado;

            txtName.Text = "";
            txtLegalName.Text = "";
            txtPhone.Text = "";
            txtCUIT.Text = "";
            txtEmail.Text = "";
            txtCalle.Text = "";
            txtNro.Text = "";
            txtPiso.Text = "";
            txtLocalidad.Text = "";
            txtContractUrl.Text = "";
            txtPromoMessage.Text = "";
            txtObservaciones.Text = "";

            cbUser.Text = "";

            cbxValidado.Checked = estado;
            cbxFranquicia.Checked = estado;
        }

        private void dgvComercios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CambiarEstados(true);
                DataGridViewRow row = this.dgvComercios.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtLegalName.Text = row.Cells["LegalName"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtCUIT.Text = row.Cells["CUIT"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtCalle.Text = row.Cells["Street"].Value.ToString();
                txtNro.Text = row.Cells["Number"].Value.ToString();
                txtPiso.Text = row.Cells["Floor"].Value.ToString();
                txtLocalidad.Text = row.Cells["City"].Value.ToString();
                txtContractUrl.Text = row.Cells["ContractUrl"].Value.ToString();
                txtPromoMessage.Text = row.Cells["PromoMessage"].Value.ToString();
                txtObservaciones.Text = row.Cells["Name"].Value.ToString();
                cbxFranquicia.Checked = Boolean.Parse(row.Cells[10].Value.ToString());
                cbxValidado.Checked = Boolean.Parse(row.Cells[14].Value.ToString());
                cbUser.Text = "";
                cbUser.SelectedText = row.Cells["UserName"].Value.ToString();
                dtpAlta.Text = row.Cells["Created"].Value.ToString();
                dtpExpira.Text = row.Cells["ValidationExpires"].Value.ToString();
                dtpValidacion.Text = row.Cells["ValidationTime"].Value.ToString();
                btnGuardar.Text = "Guardar Cambios";
            }
        }
    }
}