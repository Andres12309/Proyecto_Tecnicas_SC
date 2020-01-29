namespace Sistema_Calificacion
{
    partial class FrmProfesor
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
            this.btnRegHorarios = new System.Windows.Forms.Button();
            this.btnRegEstudiantes = new System.Windows.Forms.Button();
            this.btnRegnotas = new System.Windows.Forms.Button();
            this.btnInfoPersonal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegHorarios
            // 
            this.btnRegHorarios.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegHorarios.Image = global::Sistema_Calificacion.Properties.Resources.registor_materias;
            this.btnRegHorarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegHorarios.Location = new System.Drawing.Point(268, 188);
            this.btnRegHorarios.Name = "btnRegHorarios";
            this.btnRegHorarios.Size = new System.Drawing.Size(128, 115);
            this.btnRegHorarios.TabIndex = 10;
            this.btnRegHorarios.Text = "Regisro Horarios";
            this.btnRegHorarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegHorarios.UseVisualStyleBackColor = true;
            // 
            // btnRegEstudiantes
            // 
            this.btnRegEstudiantes.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEstudiantes.Image = global::Sistema_Calificacion.Properties.Resources.registro_Est;
            this.btnRegEstudiantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegEstudiantes.Location = new System.Drawing.Point(268, 31);
            this.btnRegEstudiantes.Name = "btnRegEstudiantes";
            this.btnRegEstudiantes.Size = new System.Drawing.Size(128, 138);
            this.btnRegEstudiantes.TabIndex = 9;
            this.btnRegEstudiantes.Text = "Regisro Estudiantes";
            this.btnRegEstudiantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegEstudiantes.UseVisualStyleBackColor = true;
            // 
            // btnRegnotas
            // 
            this.btnRegnotas.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegnotas.Image = global::Sistema_Calificacion.Properties.Resources.regisros;
            this.btnRegnotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegnotas.Location = new System.Drawing.Point(442, 31);
            this.btnRegnotas.Name = "btnRegnotas";
            this.btnRegnotas.Size = new System.Drawing.Size(128, 138);
            this.btnRegnotas.TabIndex = 8;
            this.btnRegnotas.Text = "Regisro Notas";
            this.btnRegnotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegnotas.UseVisualStyleBackColor = true;
            // 
            // btnInfoPersonal
            // 
            this.btnInfoPersonal.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoPersonal.Image = global::Sistema_Calificacion.Properties.Resources.informacion_personal;
            this.btnInfoPersonal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInfoPersonal.Location = new System.Drawing.Point(86, 31);
            this.btnInfoPersonal.Name = "btnInfoPersonal";
            this.btnInfoPersonal.Size = new System.Drawing.Size(128, 138);
            this.btnInfoPersonal.TabIndex = 7;
            this.btnInfoPersonal.Text = "Informacion Personal";
            this.btnInfoPersonal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInfoPersonal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Calificacion.Properties.Resources.fondo_Modulos;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 315);
            this.Controls.Add(this.btnRegHorarios);
            this.Controls.Add(this.btnRegEstudiantes);
            this.Controls.Add(this.btnRegnotas);
            this.Controls.Add(this.btnInfoPersonal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmProfesor";
            this.Text = "FrmProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegHorarios;
        private System.Windows.Forms.Button btnRegEstudiantes;
        private System.Windows.Forms.Button btnRegnotas;
        private System.Windows.Forms.Button btnInfoPersonal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}