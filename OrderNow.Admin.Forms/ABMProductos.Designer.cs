namespace OrderNow.Admin.Forms
{
    partial class ABMProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtURLIcono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtURLImagen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxVendible = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxSugerido = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxReceta = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbReceta = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreLegal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "ABM Productos";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvProductos);
            this.panel2.Location = new System.Drawing.Point(376, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 630);
            this.panel2.TabIndex = 39;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(8, 11);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(901, 606);
            this.dgvProductos.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(13, 203);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(326, 23);
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.Text = "Gaseosa coca cola en lata de aluminio de 354cc edicion regular";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(326, 23);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.Text = "Coca Cola Lata 354cc regular";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(136, 414);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(100, 23);
            this.txtStockActual.TabIndex = 30;
            this.txtStockActual.Text = "300";
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(136, 29);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(149, 23);
            this.txtEAN.TabIndex = 21;
            this.txtEAN.Text = "7798788979787655";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(132, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 30);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(13, 414);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 31;
            this.txtPrecio.Text = "1000";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(13, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.Text = "1234";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(17, 587);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtURLIcono
            // 
            this.txtURLIcono.Location = new System.Drawing.Point(13, 357);
            this.txtURLIcono.Name = "txtURLIcono";
            this.txtURLIcono.Size = new System.Drawing.Size(314, 23);
            this.txtURLIcono.TabIndex = 32;
            this.txtURLIcono.Text = "sfdhjkghfdsafghfgdsa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre legal";
            // 
            // txtURLImagen
            // 
            this.txtURLImagen.Location = new System.Drawing.Point(13, 309);
            this.txtURLImagen.Name = "txtURLImagen";
            this.txtURLImagen.Size = new System.Drawing.Size(314, 23);
            this.txtURLImagen.TabIndex = 33;
            this.txtURLImagen.Text = "asdfghjkl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "URL Imagen";
            // 
            // cbxVendible
            // 
            this.cbxVendible.AutoSize = true;
            this.cbxVendible.Location = new System.Drawing.Point(165, 477);
            this.cbxVendible.Name = "cbxVendible";
            this.cbxVendible.Size = new System.Drawing.Size(71, 19);
            this.cbxVendible.TabIndex = 34;
            this.cbxVendible.Text = "Vendible";
            this.cbxVendible.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "EAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "URL Icon";
            // 
            // cbxSugerido
            // 
            this.cbxSugerido.AutoSize = true;
            this.cbxSugerido.Location = new System.Drawing.Point(254, 477);
            this.cbxSugerido.Name = "cbxSugerido";
            this.cbxSugerido.Size = new System.Drawing.Size(73, 19);
            this.cbxSugerido.TabIndex = 35;
            this.cbxSugerido.Text = "Sugerido";
            this.cbxSugerido.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Stock actual";
            // 
            // cbxReceta
            // 
            this.cbxReceta.AutoSize = true;
            this.cbxReceta.Location = new System.Drawing.Point(13, 452);
            this.cbxReceta.Name = "cbxReceta";
            this.cbxReceta.Size = new System.Drawing.Size(97, 19);
            this.cbxReceta.TabIndex = 36;
            this.cbxReceta.Text = "Tiene Receta?";
            this.cbxReceta.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Puntaje";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(218, 514);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "Calificaciones";
            // 
            // cbReceta
            // 
            this.cbReceta.FormattingEnabled = true;
            this.cbReceta.Location = new System.Drawing.Point(13, 477);
            this.cbReceta.Name = "cbReceta";
            this.cbReceta.Size = new System.Drawing.Size(121, 23);
            this.cbReceta.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Categoria";
            // 
            // txtNombreLegal
            // 
            this.txtNombreLegal.Location = new System.Drawing.Point(13, 143);
            this.txtNombreLegal.Name = "txtNombreLegal";
            this.txtNombreLegal.Size = new System.Drawing.Size(200, 23);
            this.txtNombreLegal.TabIndex = 23;
            this.txtNombreLegal.Text = "Coca lata 354cc reg";
            // 
            // label18
            // 
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
            this.label18.Location = new System.Drawing.Point(115, 538);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 32);
            this.label18.TabIndex = 41;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Gaseosas"});
            this.cbCategoria.Location = new System.Drawing.Point(13, 254);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(199, 23);
            this.cbCategoria.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.lblCalificaciones);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreLegal);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbReceta);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbxReceta);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbxSugerido);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxVendible);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtURLImagen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtURLIcono);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtEAN);
            this.panel1.Controls.Add(this.txtStockActual);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 630);
            this.panel1.TabIndex = 38;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(218, 254);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 23);
            this.txtMarca.TabIndex = 46;
            this.txtMarca.Text = "Coca Cola";
            // 
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.Location = new System.Drawing.Point(218, 538);
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(55, 15);
            this.lblCalificaciones.TabIndex = 45;
            this.lblCalificaciones.Text = "3.564.849";
            // 
            // label19
            // 
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.Location = new System.Drawing.Point(149, 538);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 32);
            this.label19.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(81, 538);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 32);
            this.label17.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(47, 538);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 32);
            this.label16.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(13, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 38;
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ABMProductos";
            this.Text = "ABMProductos";
            this.Load += new System.EventHandler(this.ABMProductos_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Panel panel2;
        private DataGridView dgvProductos;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtStockActual;
        private TextBox txtEAN;
        private Button btnCancelar;
        private TextBox txtPrecio;
        private TextBox txtCodigo;
        private Button btnGuardar;
        private TextBox txtURLIcono;
        private Label label6;
        private TextBox txtURLImagen;
        private Label label7;
        private Label label5;
        private Label label8;
        private CheckBox cbxVendible;
        private Label label9;
        private Label label4;
        private Label label10;
        private CheckBox cbxSugerido;
        private Label label11;
        private Label label3;
        private Label label12;
        private CheckBox cbxReceta;
        private Label label13;
        private Label label14;
        private ComboBox cbReceta;
        private Label label15;
        private TextBox txtNombreLegal;
        private Label label18;
        private ComboBox cbCategoria;
        private Panel panel1;
        private Label lblCalificaciones;
        private Label label19;
        private Label label17;
        private Label label16;
        private Label label2;
        private TextBox txtMarca;
    }
}