namespace Sistema_Calificacion
{
    partial class FrmLoginEstudiante
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
            this.lblUsuarioEst = new System.Windows.Forms.Label();
            this.lblContraseñaEstu = new System.Windows.Forms.Label();
            this.txtUsuarioEst = new System.Windows.Forms.TextBox();
            this.txtContraseñaEst = new System.Windows.Forms.TextBox();
            this.btnIngresarLoginEst = new System.Windows.Forms.Button();
            this.btnCancelarLogEst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Calificacion.Properties.Resources.loginestudiante;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuarioEst
            // 
            this.lblUsuarioEst.AutoSize = true;
            this.lblUsuarioEst.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEst.Location = new System.Drawing.Point(236, 58);
            this.lblUsuarioEst.Name = "lblUsuarioEst";
            this.lblUsuarioEst.Size = new System.Drawing.Size(64, 17);
            this.lblUsuarioEst.TabIndex = 1;
            this.lblUsuarioEst.Text = "Usuario:";
            // 
            // lblContraseñaEstu
            // 
            this.lblContraseñaEstu.AutoSize = true;
            this.lblContraseñaEstu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaEstu.Location = new System.Drawing.Point(236, 105);
            this.lblContraseñaEstu.Name = "lblContraseñaEstu";
            this.lblContraseñaEstu.Size = new System.Drawing.Size(88, 17);
            this.lblContraseñaEstu.TabIndex = 2;
            this.lblContraseñaEstu.Text = "Contraseña:";
            // 
            // txtUsuarioEst
            // 
            this.txtUsuarioEst.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuarioEst.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioEst.Location = new System.Drawing.Point(327, 55);
            this.txtUsuarioEst.Name = "txtUsuarioEst";
            this.txtUsuarioEst.Size = new System.Drawing.Size(140, 25);
            this.txtUsuarioEst.TabIndex = 3;
            // 
            // txtContraseñaEst
            // 
            this.txtContraseñaEst.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseñaEst.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaEst.Location = new System.Drawing.Point(327, 102);
            this.txtContraseñaEst.Name = "txtContraseñaEst";
            this.txtContraseñaEst.Size = new System.Drawing.Size(140, 25);
            this.txtContraseñaEst.TabIndex = 4;
            // 
            // btnIngresarLoginEst
            // 
            this.btnIngresarLoginEst.FlatAppearance.BorderSize = 5;
            this.btnIngresarLoginEst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnIngresarLoginEst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLoginEst.Location = new System.Drawing.Point(249, 182);
            this.btnIngresarLoginEst.Name = "btnIngresarLoginEst";
            this.btnIngresarLoginEst.Size = new System.Drawing.Size(75, 27);
            this.btnIngresarLoginEst.TabIndex = 5;
            this.btnIngresarLoginEst.Text = "Ingresar";
            this.btnIngresarLoginEst.UseVisualStyleBackColor = true;
            this.btnIngresarLoginEst.Click += new System.EventHandler(this.btnIngresarLoginEst_Click);
            // 
            // btnCancelarLogEst
            // 
            this.btnCancelarLogEst.FlatAppearance.BorderSize = 5;
            this.btnCancelarLogEst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnCancelarLogEst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogEst.Location = new System.Drawing.Point(385, 182);
            this.btnCancelarLogEst.Name = "btnCancelarLogEst";
            this.btnCancelarLogEst.Size = new System.Drawing.Size(82, 27);
            this.btnCancelarLogEst.TabIndex = 6;
            this.btnCancelarLogEst.Text = "Cancelar";
            this.btnCancelarLogEst.UseVisualStyleBackColor = true;
            this.btnCancelarLogEst.Click += new System.EventHandler(this.btnCancelarLogEst_Click);
            // 
            // FrmLoginEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 221);
            this.Controls.Add(this.btnCancelarLogEst);
            this.Controls.Add(this.btnIngresarLoginEst);
            this.Controls.Add(this.txtContraseñaEst);
            this.Controls.Add(this.txtUsuarioEst);
            this.Controls.Add(this.lblContraseñaEstu);
            this.Controls.Add(this.lblUsuarioEst);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLoginEstudiante";
            this.Text = "Login Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioEst;
        private System.Windows.Forms.Label lblContraseñaEstu;
        private System.Windows.Forms.TextBox txtUsuarioEst;
        private System.Windows.Forms.TextBox txtContraseñaEst;
        private System.Windows.Forms.Button btnIngresarLoginEst;
        private System.Windows.Forms.Button btnCancelarLogEst;
    }
}