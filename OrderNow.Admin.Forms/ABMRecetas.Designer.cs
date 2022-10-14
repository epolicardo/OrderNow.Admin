namespace OrderNow.Admin.Forms
{
    partial class ABMRecetas
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
            this.dgvRecetas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecetas
            // 
            this.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetas.Location = new System.Drawing.Point(506, 75);
            this.dgvRecetas.Name = "dgvRecetas";
            this.dgvRecetas.RowTemplate.Height = 25;
            this.dgvRecetas.Size = new System.Drawing.Size(471, 520);
            this.dgvRecetas.TabIndex = 0;
            // 
            // ABMRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 735);
            this.Controls.Add(this.dgvRecetas);
            this.Name = "ABMRecetas";
            this.Text = "ABMRecetas";
            this.Load += new System.EventHandler(this.ABMRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvRecetas;
    }
}