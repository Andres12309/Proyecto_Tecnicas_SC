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
    //public interface IInfoAdmin
    //{
    //    void conexion(SqlConnection conectarbd);
    //}
    public partial class FrmLoginAdministrador : Form/*, IInfoAdmin*/
    {
        
        public FrmLoginAdministrador()
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
        //SqlConnection conectarbd = new SqlConnection("Server=PC-DTAM;Database=Sistema_Calificacion;Integrated Security=true");
        
        //public void conexion(SqlConnection conectarbd)
        //{

        //}

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
                    conectarbd.Close();
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
        private void btnCancelarLogAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarLoginAdmin_Click(object sender, EventArgs e)
        {
            logear(this.txtUsuarioAdmin.Text, this.txtContraseñaAdmin.Text);
        }

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}
    }
}
