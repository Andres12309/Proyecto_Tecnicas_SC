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
    public partial class FrmLoginProfesor : Form
    {
        public FrmLoginProfesor()
        {
            InitializeComponent();
        }

        private void btnCancelarLogProfe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLoginProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarLoginProfe_Click(object sender, EventArgs e)
        {
            FrmProfesor from = new FrmProfesor();
            from.Show();
            this.Hide();
        }
    }
}
