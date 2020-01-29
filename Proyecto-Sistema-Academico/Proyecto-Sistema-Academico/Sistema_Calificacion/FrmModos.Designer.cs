namespace Sistema_Calificacion
{
    partial class FrmModos
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
            this.lblmodoU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModosUsuarios = new System.Windows.Forms.ComboBox();
            this.btnAceptarModo = new System.Windows.Forms.Button();
            this.btnCancelarModo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Calificacion.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblmodoU
            // 
            this.lblmodoU.AutoSize = true;
            this.lblmodoU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodoU.Location = new System.Drawing.Point(163, 9);
            this.lblmodoU.Name = "lblmodoU";
            this.lblmodoU.Size = new System.Drawing.Size(223, 22);
            this.lblmodoU.TabIndex = 1;
            this.lblmodoU.Text = "MODOS DE USUARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modo:";
            // 
            // cmbModosUsuarios
            // 
            this.cmbModosUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModosUsuarios.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModosUsuarios.Items.AddRange(new object[] {
            "Administrador",
            "Profesor",
            "Estudiante"});
            this.cmbModosUsuarios.Location = new System.Drawing.Point(348, 124);
            this.cmbModosUsuarios.Name = "cmbModosUsuarios";
            this.cmbModosUsuarios.Size = new System.Drawing.Size(160, 22);
            this.cmbModosUsuarios.TabIndex = 3;
            this.cmbModosUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAceptarModo
            // 
            this.btnAceptarModo.FlatAppearance.BorderSize = 5;
            this.btnAceptarModo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAceptarModo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarModo.Location = new System.Drawing.Point(292, 278);
            this.btnAceptarModo.Name = "btnAceptarModo";
            this.btnAceptarModo.Size = new System.Drawing.Size(84, 35);
            this.btnAceptarModo.TabIndex = 4;
            this.btnAceptarModo.Text = "Aceptar";
            this.btnAceptarModo.UseVisualStyleBackColor = true;
            this.btnAceptarModo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarModo
            // 
            this.btnCancelarModo.FlatAppearance.BorderSize = 5;
            this.btnCancelarModo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCancelarModo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModo.Location = new System.Drawing.Point(435, 278);
            this.btnCancelarModo.Name = "btnCancelarModo";
            this.btnCancelarModo.Size = new System.Drawing.Size(94, 35);
            this.btnCancelarModo.TabIndex = 5;
            this.btnCancelarModo.Text = "Cancelar";
            this.btnCancelarModo.UseVisualStyleBackColor = true;
            this.btnCancelarModo.Click += new System.EventHandler(this.btnCancelarModo_Click);
            // 
            // FrmModos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 338);
            this.Controls.Add(this.btnCancelarModo);
            this.Controls.Add(this.btnAceptarModo);
            this.Controls.Add(this.cmbModosUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmodoU);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmModos";
            this.Text = "Modo de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblmodoU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModosUsuarios;
        private System.Windows.Forms.Button btnAceptarModo;
        private System.Windows.Forms.Button btnCancelarModo;
    }
}