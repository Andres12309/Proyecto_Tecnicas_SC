using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Calificacion.Models;

namespace Sistema_Calificacion
{
    public partial class FrmAdministrador : Form
    {
        EMPLEADOS nEmpleados = null;
        public int? id = null;
        public FrmAdministrador()
        {              
            InitializeComponent();
            groupBoxPersonal.Hide();
            groupBoxDatosEmp.Hide();

        }

        private void btnInfoPersonal_Click(object sender, EventArgs e)
        {
            groupBoxPersonal.Show();
            dataGridView1.Focus();
        }

        private void groupBoxPersonal_Enter(object sender, EventArgs e)
        {
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            using (Sistema_CalificacionEntities2 db = new Sistema_CalificacionEntities2())
            {
                var lst = from d in db.EMPLEADOS
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }
        #endregion


        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNuevoEmpl_Click(object sender, EventArgs e)
        {
            buttonActualizar.Enabled = false;
            buttonGuardar.Enabled = true;
            groupBoxDatosEmp.Show();
            splitContainer1.Panel2.Hide();
            Refrescar();
        }
        #region 
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
        private void cargaDatos(int? id)
        {
            using (Sistema_CalificacionEntities2 db = new Sistema_CalificacionEntities2())
            {
                nEmpleados = db.EMPLEADOS.Find(id);
                textBoxNombreEmp.Text = nEmpleados.NOMBRE_EMPL;
                textBoxApellidoEmp.Text = nEmpleados.APELLIDO_EMPL;
                textBoxCedEmp.Text = nEmpleados.CEDULA_ALUMN;
                textBoxPassEmp.Text = nEmpleados.PASS_ALUMN;
                textBoxDirEmp.Text = nEmpleados.DIRECCION_EMPL;
                textBoxTelfEmp.Text = nEmpleados.TELEFONO_EMPL;
                textBoxTituloEmp.Text = nEmpleados.TITULO_EMPL;
            }
        }

        private void ButtonEditarEmp_Click(object sender, EventArgs e)
        {
            buttonActualizar.Enabled = true;
            buttonGuardar.Enabled = false;
            int? id = GetId();
            if (id != null)
            {
                groupBoxDatosEmp.Show();
                cargaDatos(id);
                splitContainer1.Panel2.Hide();
                Refrescar();

            }
        }

        private void groupBoxDatosEmp_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (Sistema_CalificacionEntities2 db = new Sistema_CalificacionEntities2())
            {
                if (id == null)
                {
                    nEmpleados = new EMPLEADOS();
                }                
                
                nEmpleados.NOMBRE_EMPL = textBoxNombreEmp.Text;
                nEmpleados.APELLIDO_EMPL = textBoxApellidoEmp.Text;
                nEmpleados.CEDULA_ALUMN = textBoxCedEmp.Text;
                nEmpleados.PASS_ALUMN = textBoxPassEmp.Text;
                nEmpleados.DIRECCION_EMPL = textBoxDirEmp.Text;
                nEmpleados.TELEFONO_EMPL = textBoxTelfEmp.Text;
                nEmpleados.TITULO_EMPL = textBoxTituloEmp.Text;                
                
                if (id == null)
                {
                    db.EMPLEADOS.Add(nEmpleados);      
                    
                }
                

                db.SaveChanges();

                
                groupBoxDatosEmp.Hide();
                Refrescar();
                splitContainer1.Panel2.Show();

                textBoxNombreEmp.Clear();
                textBoxApellidoEmp.Clear();
                textBoxCedEmp.Clear();
                textBoxPassEmp.Clear();
                textBoxDirEmp.Clear();
                textBoxTelfEmp.Clear();
                textBoxTituloEmp.Clear();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            using (Sistema_CalificacionEntities2 db = new Sistema_CalificacionEntities2())
            {
                nEmpleados.NOMBRE_EMPL = textBoxNombreEmp.Text;
                nEmpleados.APELLIDO_EMPL = textBoxApellidoEmp.Text;
                nEmpleados.CEDULA_ALUMN = textBoxCedEmp.Text;
                nEmpleados.PASS_ALUMN = textBoxPassEmp.Text;
                nEmpleados.DIRECCION_EMPL = textBoxDirEmp.Text;
                nEmpleados.TELEFONO_EMPL = textBoxTelfEmp.Text;
                nEmpleados.TITULO_EMPL = textBoxTituloEmp.Text;

                db.Entry(nEmpleados).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                groupBoxDatosEmp.Hide();
                Refrescar();
                splitContainer1.Panel2.Show();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id!= null)
            {
                using (Sistema_CalificacionEntities2 db = new Sistema_CalificacionEntities2())
                {
                    EMPLEADOS nEmpleados = db.EMPLEADOS.Find(id);
                    db.EMPLEADOS.Remove(nEmpleados);

                    db.SaveChanges();
                }

                Refrescar();
            }
        }
    }
}
