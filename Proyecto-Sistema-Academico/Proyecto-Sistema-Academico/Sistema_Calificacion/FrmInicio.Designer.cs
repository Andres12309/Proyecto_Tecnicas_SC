namespace Sistema_Calificacion
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPortada = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdministrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.SystemColors.Control;
            this.btnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicioSesion.FlatAppearance.BorderSize = 5;
            this.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnInicioSesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(368, 37);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(144, 34);
            this.btnInicioSesion.TabIndex = 1;
            this.btnInicioSesion.Text = "Iniciar Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.SystemColors.Control;
            this.btnAcerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcerca.FlatAppearance.BorderSize = 5;
            this.btnAcerca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAcerca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.Location = new System.Drawing.Point(368, 139);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(144, 34);
            this.btnAcerca.TabIndex = 2;
            this.btnAcerca.Text = "Acerca De";
            this.btnAcerca.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 5;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(368, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPortada
            // 
            this.lblPortada.AutoSize = true;
            this.lblPortada.BackColor = System.Drawing.Color.Transparent;
            this.lblPortada.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortada.ForeColor = System.Drawing.Color.Red;
            this.lblPortada.Location = new System.Drawing.Point(49, 37);
            this.lblPortada.Name = "lblPortada";
            this.lblPortada.Size = new System.Drawing.Size(206, 18);
            this.lblPortada.TabIndex = 4;
            this.lblPortada.Text = "SISTEMA DE CALIFICACIÓN";
            this.lblPortada.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Calificacion.Properties.Resources.inicio_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 335);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonAdministrar
            // 
            this.buttonAdministrar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdministrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdministrar.FlatAppearance.BorderSize = 5;
            this.buttonAdministrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonAdministrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdministrar.Location = new System.Drawing.Point(12, 289);
            this.buttonAdministrar.Name = "buttonAdministrar";
            this.buttonAdministrar.Size = new System.Drawing.Size(144, 34);
            this.buttonAdministrar.TabIndex = 5;
            this.buttonAdministrar.Text = "ADMINISTRAR";
            this.buttonAdministrar.UseVisualStyleBackColor = false;
            this.buttonAdministrar.Click += new System.EventHandler(this.buttonAdministrar_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 335);
            this.Controls.Add(this.buttonAdministrar);
            this.Controls.Add(this.lblPortada);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcerca);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInicio";
            this.Text = "BIEVENIDO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPortada;
        private System.Windows.Forms.Button buttonAdministrar;
    }
}

