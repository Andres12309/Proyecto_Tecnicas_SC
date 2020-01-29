using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Calificacion
{
    public partial class FrmModos : Form
    {
        public FrmModos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbModosUsuarios.SelectedItem.ToString() == "Estudiante"){
                FrmLoginEstudiante from = new FrmLoginEstudiante();
                from.Show();
                this.Hide();
            }
            else if(cmbModosUsuarios.SelectedItem.ToString() == "Profesor"){
                FrmLoginProfesor from = new FrmLoginProfesor();
                from.Show();
                this.Hide();
            }
            else if (cmbModosUsuarios.SelectedItem.ToString() == "Administrador")
            {
                FrmLoginAdministrador from = new FrmLoginAdministrador();
                from.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Debe elegir un modo de usuario");
            }
            
        }

        private void btnCancelarModo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
