using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Calificacion.Models;

namespace Sistema_Calificacion
{
    public partial class FormEmpl : Form
    {
        public FormEmpl()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (Sistema_CalificacionEntities2 db = new Sistema_CalificacionEntities2())
            {
                EMPLEADOS nEmpleados = new EMPLEADOS();
                nEmpleados.NOMBRE_EMPL = textBoxNombreEmp.Text;
                nEmpleados.APELLIDO_EMPL = textBoxApellidoEmp.Text;
                nEmpleados.CEDULA_ALUMN = textBoxCedEmp.Text;
                nEmpleados.PASS_ALUMN = textBoxPassEmp.Text;
                nEmpleados.DIRECCION_EMPL = textBoxDirEmp.Text;
                nEmpleados.TELEFONO_EMPL = textBoxTelfEmp.Text;
                nEmpleados.TITULO_EMPL = textBoxTituloEmp.Text;

                db.EMPLEADOS.Add(nEmpleados);
                db.SaveChanges();

                this.Close();
            }
        }
    }
}
