using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Sistema_Calificacion.Models;

namespace Sistema_Calificacion
{
    public partial class FrmRegistrarEstudiantes : Form
    {
        ALUMNOS nAlumnos = null;
        public int? id = null;
        Conexion_1 cl_1 = new Conexion_1();
        public FrmRegistrarEstudiantes()
        {
            InitializeComponent();
        }
        private void Refrescar()
        {
            using (Sistema_CalificacionEntities db = new Sistema_CalificacionEntities())
            {
                var lst = from d in db.ALUMNOS
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }
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

        private void cargaDatos(int? id)
        {
            using (Sistema_CalificacionEntities db = new Sistema_CalificacionEntities())
            {
                nAlumnos = db.ALUMNOS.Find(id);
                txt_nombre.Text = nAlumnos.NOMBRE_ALUMN;
                txt_apellido.Text = nAlumnos.APELLIDO_ALUMN;
                txt_cedula.Text = nAlumnos.CEDULA_ALUMN;
                txt_pass.Text = nAlumnos.PASS_ALUMN;
                txt_direccion.Text = nAlumnos.DIRECCION_ALUMN;
                dtmPicker1.Value= nAlumnos.FECHA_NACIMINETO_ALUMN;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl_1.abrir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_estudiantes, dt_carreras = new DataTable();
                label1.Text = "Buscando informacion en access";
                Application.DoEvents();
                dt_estudiantes = cl_1.Traer_datos_de_access_estudiantes();
                dt_carreras = cl_1.Traer_datos_de_access_carreras();
                label1.Text = "cargando controles";
                Application.DoEvents();
                this.dataGridView1.DataSource = dt_estudiantes.DefaultView;
                this.comboBox1.DataSource = dt_carreras;
                this.comboBox1.DisplayMember = "carrera";
                this.comboBox1.ValueMember = "id";
                label1.Text = "Listo";
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar a la base de datos access" + Environment.NewLine + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //linkLabel1.Links.Add(0, linkLabel1.Text.Length, "http://www.iunp.edu.ve/");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form2 abrir = new Form2();
            //abrir.Show();
            //this.Hide();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea cerrar el formulario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al registro de Alumnos, por favor hacer clic en el Menú Principal");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{

            //    txt_cedula.Text = this.dataGridView1.SelectedRows[0].Cells["cedula"].Value.ToString();
            //    txt_apellido.Text = this.dataGridView1.SelectedRows[0].Cells["apellido"].Value.ToString();
            //    txt_nombre.Text = this.dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
            //    txt_numero.Text = this.dataGridView1.SelectedRows[0].Cells["numero"].Value.ToString();
            //    txt_pass.Text = this.dataGridView1.SelectedRows[0].Cells["edad"].Value.ToString();
            //    txt_direccion.Text = this.dataGridView1.SelectedRows[0].Cells["correo"].Value.ToString();

            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(info);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (Sistema_CalificacionEntities db = new Sistema_CalificacionEntities())
            {
                if (id == null)
                {
                    nAlumnos = new ALUMNOS();
                }

                nAlumnos.NOMBRE_ALUMN = txt_nombre.Text;
                nAlumnos.APELLIDO_ALUMN = txt_apellido.Text;
                nAlumnos.CEDULA_ALUMN = txt_cedula.Text;
                nAlumnos.PASS_ALUMN = txt_pass.Text;
                nAlumnos.DIRECCION_ALUMN = txt_direccion.Text;
                nAlumnos.FECHA_NACIMINETO_ALUMN = dtmPicker1.Value;

                if (id == null)
                {
                    db.ALUMNOS.Add(nAlumnos);

                }


                db.SaveChanges();

                Refrescar();

                txt_cedula.Clear();
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_direccion.Clear();
                txt_pass.Clear();

            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            BtnActualizar.Visible = true;
            int? id = GetId();
            if (id != null)
            {
                cargaDatos(id);
                Refrescar();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (Sistema_CalificacionEntities db = new Sistema_CalificacionEntities())
                {
                    ALUMNOS nAlumnos = db.ALUMNOS.Find(id);
                    db.ALUMNOS.Remove(nAlumnos);

                    db.SaveChanges();
                }

                Refrescar();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            using (Sistema_CalificacionEntities db = new Sistema_CalificacionEntities())
            {
                nAlumnos.NOMBRE_ALUMN = txt_nombre.Text;
                nAlumnos.APELLIDO_ALUMN = txt_apellido.Text;
                nAlumnos.CEDULA_ALUMN = txt_cedula.Text;
                nAlumnos.PASS_ALUMN = txt_pass.Text;
                nAlumnos.DIRECCION_ALUMN = txt_direccion.Text;
                nAlumnos.FECHA_NACIMINETO_ALUMN = dtmPicker1.Value;

                db.Entry(nAlumnos).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                Refrescar();
            }
            BtnActualizar.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}