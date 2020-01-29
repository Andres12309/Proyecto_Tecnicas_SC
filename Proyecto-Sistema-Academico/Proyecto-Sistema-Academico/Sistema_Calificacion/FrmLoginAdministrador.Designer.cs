namespace Sistema_Calificacion
{
    partial class FrmLoginAdministrador
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
            this.btnCancelarLogAdmin = new System.Windows.Forms.Button();
            this.btnIngresarLoginAdmin = new System.Windows.Forms.Button();
            this.txtContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.lblContraseñaAdmin = new System.Windows.Forms.Label();
            this.lblUsuarioAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Calificacion.Properties.Resources.loginadministrador;
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarLogAdmin
            // 
            this.btnCancelarLogAdmin.FlatAppearance.BorderSize = 5;
            this.btnCancelarLogAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnCancelarLogAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogAdmin.Location = new System.Drawing.Point(306, 135);
            this.btnCancelarLogAdmin.Name = "btnCancelarLogAdmin";
            this.btnCancelarLogAdmin.Size = new System.Drawing.Size(82, 27);
            this.btnCancelarLogAdmin.TabIndex = 12;
            this.btnCancelarLogAdmin.Text = "Cancelar";
            this.btnCancelarLogAdmin.UseVisualStyleBackColor = true;
            this.btnCancelarLogAdmin.Click += new System.EventHandler(this.btnCancelarLogAdmin_Click);
            // 
            // btnIngresarLoginAdmin
            // 
            this.btnIngresarLoginAdmin.FlatAppearance.BorderSize = 5;
            this.btnIngresarLoginAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnIngresarLoginAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLoginAdmin.Location = new System.Drawing.Point(191, 135);
            this.btnIngresarLoginAdmin.Name = "btnIngresarLoginAdmin";
            this.btnIngresarLoginAdmin.Size = new System.Drawing.Size(75, 27);
            this.btnIngresarLoginAdmin.TabIndex = 11;
            this.btnIngresarLoginAdmin.Text = "Ingresar";
            this.btnIngresarLoginAdmin.UseVisualStyleBackColor = true;
            this.btnIngresarLoginAdmin.Click += new System.EventHandler(this.btnIngresarLoginAdmin_Click);
            // 
            // txtContraseñaAdmin
            // 
            this.txtContraseñaAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseñaAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaAdmin.Location = new System.Drawing.Point(297, 71);
            this.txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            this.txtContraseñaAdmin.Size = new System.Drawing.Size(140, 25);
            this.txtContraseñaAdmin.TabIndex = 10;
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuarioAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(297, 32);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(140, 25);
            this.txtUsuarioAdmin.TabIndex = 9;
            // 
            // lblContraseñaAdmin
            // 
            this.lblContraseñaAdmin.AutoSize = true;
            this.lblContraseñaAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaAdmin.Location = new System.Drawing.Point(188, 79);
            this.lblContraseñaAdmin.Name = "lblContraseñaAdmin";
            this.lblContraseñaAdmin.Size = new System.Drawing.Size(88, 17);
            this.lblContraseñaAdmin.TabIndex = 8;
            this.lblContraseñaAdmin.Text = "Contraseña:";
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.AutoSize = true;
            this.lblUsuarioAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAdmin.Location = new System.Drawing.Point(188, 35);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(64, 17);
            this.lblUsuarioAdmin.TabIndex = 7;
            this.lblUsuarioAdmin.Text = "Usuario:";
            // 
            // FrmLoginAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 220);
            this.Controls.Add(this.btnCancelarLogAdmin);
            this.Controls.Add(this.btnIngresarLoginAdmin);
            this.Controls.Add(this.txtContraseñaAdmin);
            this.Controls.Add(this.txtUsuarioAdmin);
            this.Controls.Add(this.lblContraseñaAdmin);
            this.Controls.Add(this.lblUsuarioAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLoginAdministrador";
            this.Text = "Login Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarLogAdmin;
        private System.Windows.Forms.Button btnIngresarLoginAdmin;
        private System.Windows.Forms.TextBox txtContraseñaAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.Label lblContraseñaAdmin;
        private System.Windows.Forms.Label lblUsuarioAdmin;
    }
}