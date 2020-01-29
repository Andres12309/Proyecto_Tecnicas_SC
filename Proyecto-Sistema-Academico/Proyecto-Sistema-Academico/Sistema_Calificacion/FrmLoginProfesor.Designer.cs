namespace Sistema_Calificacion
{
    partial class FrmLoginProfesor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelarLogProfe = new System.Windows.Forms.Button();
            this.btnIngresarLoginProfe = new System.Windows.Forms.Button();
            this.txtContraseñaProfe = new System.Windows.Forms.TextBox();
            this.txtUsuarioProfe = new System.Windows.Forms.TextBox();
            this.lblContraseñaProfe = new System.Windows.Forms.Label();
            this.lblUsuarioProfe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Calificacion.Properties.Resources.loginprofesor;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarLogProfe
            // 
            this.btnCancelarLogProfe.FlatAppearance.BorderSize = 5;
            this.btnCancelarLogProfe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnCancelarLogProfe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogProfe.Location = new System.Drawing.Point(412, 180);
            this.btnCancelarLogProfe.Name = "btnCancelarLogProfe";
            this.btnCancelarLogProfe.Size = new System.Drawing.Size(82, 27);
            this.btnCancelarLogProfe.TabIndex = 12;
            this.btnCancelarLogProfe.Text = "Cancelar";
            this.btnCancelarLogProfe.UseVisualStyleBackColor = true;
            this.btnCancelarLogProfe.Click += new System.EventHandler(this.btnCancelarLogProfe_Click);
            // 
            // btnIngresarLoginProfe
            // 
            this.btnIngresarLoginProfe.FlatAppearance.BorderSize = 5;
            this.btnIngresarLoginProfe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnIngresarLoginProfe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLoginProfe.Location = new System.Drawing.Point(276, 180);
            this.btnIngresarLoginProfe.Name = "btnIngresarLoginProfe";
            this.btnIngresarLoginProfe.Size = new System.Drawing.Size(75, 27);
            this.btnIngresarLoginProfe.TabIndex = 11;
            this.btnIngresarLoginProfe.Text = "Ingresar";
            this.btnIngresarLoginProfe.UseVisualStyleBackColor = true;
            this.btnIngresarLoginProfe.Click += new System.EventHandler(this.btnIngresarLoginProfe_Click);
            // 
            // txtContraseñaProfe
            // 
            this.txtContraseñaProfe.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseñaProfe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaProfe.Location = new System.Drawing.Point(354, 100);
            this.txtContraseñaProfe.Name = "txtContraseñaProfe";
            this.txtContraseñaProfe.Size = new System.Drawing.Size(140, 25);
            this.txtContraseñaProfe.TabIndex = 10;
            // 
            // txtUsuarioProfe
            // 
            this.txtUsuarioProfe.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuarioProfe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioProfe.Location = new System.Drawing.Point(354, 53);
            this.txtUsuarioProfe.Name = "txtUsuarioProfe";
            this.txtUsuarioProfe.Size = new System.Drawing.Size(140, 25);
            this.txtUsuarioProfe.TabIndex = 9;
            // 
            // lblContraseñaProfe
            // 
            this.lblContraseñaProfe.AutoSize = true;
            this.lblContraseñaProfe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaProfe.Location = new System.Drawing.Point(263, 103);
            this.lblContraseñaProfe.Name = "lblContraseñaProfe";
            this.lblContraseñaProfe.Size = new System.Drawing.Size(88, 17);
            this.lblContraseñaProfe.TabIndex = 8;
            this.lblContraseñaProfe.Text = "Contraseña:";
            // 
            // lblUsuarioProfe
            // 
            this.lblUsuarioProfe.AutoSize = true;
            this.lblUsuarioProfe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioProfe.Location = new System.Drawing.Point(263, 56);
            this.lblUsuarioProfe.Name = "lblUsuarioProfe";
            this.lblUsuarioProfe.Size = new System.Drawing.Size(64, 17);
            this.lblUsuarioProfe.TabIndex = 7;
            this.lblUsuarioProfe.Text = "Usuario:";
            // 
            // FrmLoginProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 244);
            this.Controls.Add(this.btnCancelarLogProfe);
            this.Controls.Add(this.btnIngresarLoginProfe);
            this.Controls.Add(this.txtContraseñaProfe);
            this.Controls.Add(this.txtUsuarioProfe);
            this.Controls.Add(this.lblContraseñaProfe);
            this.Controls.Add(this.lblUsuarioProfe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLoginProfesor";
            this.Text = "Login Profesor";
            this.Load += new System.EventHandler(this.FrmLoginProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarLogProfe;
        private System.Windows.Forms.Button btnIngresarLoginProfe;
        private System.Windows.Forms.TextBox txtContraseñaProfe;
        private System.Windows.Forms.TextBox txtUsuarioProfe;
        private System.Windows.Forms.Label lblContraseñaProfe;
        private System.Windows.Forms.Label lblUsuarioProfe;
    }
}