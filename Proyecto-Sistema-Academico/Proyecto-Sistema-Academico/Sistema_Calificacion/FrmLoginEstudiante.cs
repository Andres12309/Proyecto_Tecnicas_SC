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
    public partial class FrmLoginEstudiante : Form
    {
        public FrmLoginEstudiante()
        {
            InitializeComponent();
        }

        private void btnCancelarLogEst_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarLoginEst_Click(object sender, EventArgs e)
        {
            FrmEstudiante from = new FrmEstudiante();
            from.Show();
            this.Hide();
        }
    }
}
