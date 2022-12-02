namespace OrderNow.Admin.Forms
{
    partial class frmRelacionarUsuariosComercios
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
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.cbComercios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarRelacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(240, 198);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(213, 23);
            this.cbUsuarios.TabIndex = 0;
            // 
            // cbComercios
            // 
            this.cbComercios.FormattingEnabled = true;
            this.cbComercios.Location = new System.Drawing.Point(459, 198);
            this.cbComercios.Name = "cbComercios";
            this.cbComercios.Size = new System.Drawing.Size(219, 23);
            this.cbComercios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comercios";
            // 
            // btnGuardarRelacion
            // 
            this.btnGuardarRelacion.Location = new System.Drawing.Point(358, 347);
            this.btnGuardarRelacion.Name = "btnGuardarRelacion";
            this.btnGuardarRelacion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRelacion.TabIndex = 4;
            this.btnGuardarRelacion.Text = "Guardar relacion";
            this.btnGuardarRelacion.UseVisualStyleBackColor = true;
            this.btnGuardarRelacion.Click += new System.EventHandler(this.btnGuardarRelacion_Click);
            // 
            // frmRelacionarUsuariosComercios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarRelacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComercios);
            this.Controls.Add(this.cbUsuarios);
            this.Name = "frmRelacionarUsuariosComercios";
            this.Text = "frmRelacionarUsuariosComercios";
            this.Load += new System.EventHandler(this.frmRelacionarUsuariosComercios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbUsuarios;
        private ComboBox cbComercios;
        private Label label1;
        private Label label2;
        private Button btnGuardarRelacion;
    }
}