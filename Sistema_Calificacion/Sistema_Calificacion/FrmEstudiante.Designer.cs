namespace Sistema_Calificacion
{
    partial class FrmEstudiante
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
            this.btnVerHorarios = new System.Windows.Forms.Button();
            this.btnVernotas = new System.Windows.Forms.Button();
            this.btnInfoPersonal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerHorarios
            // 
            this.btnVerHorarios.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHorarios.Image = global::Sistema_Calificacion.Properties.Resources.registor_materias;
            this.btnVerHorarios.Location = new System.Drawing.Point(420, 31);
            this.btnVerHorarios.Name = "btnVerHorarios";
            this.btnVerHorarios.Size = new System.Drawing.Size(128, 138);
            this.btnVerHorarios.TabIndex = 15;
            this.btnVerHorarios.Text = "Ver Horarios";
            this.btnVerHorarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerHorarios.UseVisualStyleBackColor = true;
            // 
            // btnVernotas
            // 
            this.btnVernotas.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVernotas.Image = global::Sistema_Calificacion.Properties.Resources.regisros;
            this.btnVernotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVernotas.Location = new System.Drawing.Point(253, 31);
            this.btnVernotas.Name = "btnVernotas";
            this.btnVernotas.Size = new System.Drawing.Size(128, 138);
            this.btnVernotas.TabIndex = 13;
            this.btnVernotas.Text = "Ver Notas";
            this.btnVernotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVernotas.UseVisualStyleBackColor = true;
            // 
            // btnInfoPersonal
            // 
            this.btnInfoPersonal.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoPersonal.Image = global::Sistema_Calificacion.Properties.Resources.informacion_personal;
            this.btnInfoPersonal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInfoPersonal.Location = new System.Drawing.Point(84, 31);
            this.btnInfoPersonal.Name = "btnInfoPersonal";
            this.btnInfoPersonal.Size = new System.Drawing.Size(128, 138);
            this.btnInfoPersonal.TabIndex = 12;
            this.btnInfoPersonal.Text = "Informacion Personal";
            this.btnInfoPersonal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInfoPersonal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Calificacion.Properties.Resources.fondo_Modulos;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 189);
            this.Controls.Add(this.btnVerHorarios);
            this.Controls.Add(this.btnVernotas);
            this.Controls.Add(this.btnInfoPersonal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmEstudiante";
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerHorarios;
        private System.Windows.Forms.Button btnVernotas;
        private System.Windows.Forms.Button btnInfoPersonal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}