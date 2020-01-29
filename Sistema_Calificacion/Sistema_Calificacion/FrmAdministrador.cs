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
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        private void btnRegEstudiantes_Click(object sender, EventArgs e)
        {
            FrmRegistrarEstudiantes from = new FrmRegistrarEstudiantes();
            from.Show();
        }
    }
}
