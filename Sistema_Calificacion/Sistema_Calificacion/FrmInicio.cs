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

namespace Sistema_Calificacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            InitializeMyControl();
        }
        private void InitializeMyControl()
        {
            txtContraseñaAdmin.Text = "";
            txtContraseñaAdmin.PasswordChar = '*';
            txtContraseñaAdmin.MaxLength = 15;
        }
        SqlConnection conectarbd = new SqlConnection("Server=PC-DTAM\\MSSQLSERVER01;Database=Sistema_Calificacion;Integrated Security=true");
        public void logear(string usuario, string contraseña)
        {
            try
            {
                conectarbd.Open();
                SqlCommand cmd = new SqlCommand("SELECT CEDULA_Admin, Password_Admin FROM Administrador WHERE CEDULA_Admin = @cedula_admin AND Password_Admin = @pass_admin", conectarbd);
                cmd.Parameters.AddWithValue("cedula_admin", usuario);
                cmd.Parameters.AddWithValue("pass_admin", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    FrmAdministrador from = new FrmAdministrador();
                    from.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectarbd.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            PnlModos.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarModo_Click(object sender, EventArgs e)
        {
            if (cmbModosUsuarios.SelectedItem.ToString() == "Estudiante")
            {
                PnlEstudiante.Visible = true;
            }
            else if (cmbModosUsuarios.SelectedItem.ToString() == "Profesor")
            {
                PnlProfesor.Visible = true;
            }
            else if (cmbModosUsuarios.SelectedItem.ToString() == "Administrador")
            {
                PnlAdmin.Visible = true;
            }
            else
            {

                MessageBox.Show("Debe elegir un modo de usuario");
            }
        }

        private void btnCancelarModo_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnIngresarLoginProfe_Click(object sender, EventArgs e)
        {
            FrmProfesor from = new FrmProfesor();
            from.Show();
            this.Hide();
        }

        private void btnCancelarLogProfe_Click(object sender, EventArgs e)
        {
            PnlProfesor.Visible = false;
        }

        private void txtContraseñaProfe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioProfe_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseñaProfe_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuarioProfe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void btnIngresarLoginAdmin_Click_1(object sender, EventArgs e)
        {
            logear(this.txtUsuarioAdmin.Text, this.txtContraseñaAdmin.Text);
        }

        private void btnCancelarLogAdmin_Click_1(object sender, EventArgs e)
        {
            PnlAdmin.Visible = false;
        }

        private void btnIngresarLoginEst_Click_1(object sender, EventArgs e)
        {
            FrmEstudiante from = new FrmEstudiante();
            from.Show();
            this.Hide();
        }

        private void btnCancelarLogEst_Click_1(object sender, EventArgs e)
        {
            PnlEstudiante.Visible = false;
        }

        private void txtContraseñaEst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioEst_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseñaEstu_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuarioEst_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
