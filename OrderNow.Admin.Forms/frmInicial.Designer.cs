namespace OrderNow.Admin.Forms
{
    partial class frmInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmABMRecetas = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comerciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMComerciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.recetasToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.comerciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMProductosToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // aBMProductosToolStripMenuItem
            // 
            this.aBMProductosToolStripMenuItem.Name = "aBMProductosToolStripMenuItem";
            this.aBMProductosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aBMProductosToolStripMenuItem.Text = "ABM Productos";
            this.aBMProductosToolStripMenuItem.Click += new System.EventHandler(this.ABMProductosToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmABMRecetas});
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // tsmABMRecetas
            // 
            this.tsmABMRecetas.Name = "tsmABMRecetas";
            this.tsmABMRecetas.Size = new System.Drawing.Size(180, 22);
            this.tsmABMRecetas.Text = "ABM Recetas";
            this.tsmABMRecetas.Click += new System.EventHandler(this.ABMRecetasToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMCategoriasToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // aBMCategoriasToolStripMenuItem
            // 
            this.aBMCategoriasToolStripMenuItem.Name = "aBMCategoriasToolStripMenuItem";
            this.aBMCategoriasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aBMCategoriasToolStripMenuItem.Text = "ABM Categorias";
            this.aBMCategoriasToolStripMenuItem.Click += new System.EventHandler(this.ABMCategoriasToolStripMenuItem_Click);
            // 
            // comerciosToolStripMenuItem
            // 
            this.comerciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMComerciosToolStripMenuItem});
            this.comerciosToolStripMenuItem.Name = "comerciosToolStripMenuItem";
            this.comerciosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.comerciosToolStripMenuItem.Text = "Comercios";
            // 
            // aBMComerciosToolStripMenuItem
            // 
            this.aBMComerciosToolStripMenuItem.Name = "aBMComerciosToolStripMenuItem";
            this.aBMComerciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMComerciosToolStripMenuItem.Text = "ABM Comercios";
            this.aBMComerciosToolStripMenuItem.Click += new System.EventHandler(this.ABMComerciosToolStripMenuItem_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicial";
            this.Text = "OrderNow - Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem aBMProductosToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem recetasToolStripMenuItem;
        private ToolStripMenuItem tsmABMRecetas;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem aBMCategoriasToolStripMenuItem;
        private ToolStripMenuItem comerciosToolStripMenuItem;
        private ToolStripMenuItem aBMComerciosToolStripMenuItem;
    }
}