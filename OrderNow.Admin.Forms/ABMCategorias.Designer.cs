namespace OrderNow.Admin.Forms
{
    partial class ABMCategorias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 705);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCategorias);
            this.panel2.Location = new System.Drawing.Point(368, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 706);
            this.panel2.TabIndex = 1;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(3, 3);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowTemplate.Height = 25;
            this.dgvCategorias.Size = new System.Drawing.Size(612, 700);
            this.dgvCategorias.TabIndex = 0;
            // 
            // ABMCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ABMCategorias";
            this.Text = "ABMCategorias";
            this.Load += new System.EventHandler(this.ABMCategorias_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvCategorias;
    }
}