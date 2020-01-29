using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sistema_Calificacion
{
    class Conexion_1
    {
        string cadena = "Server=PC-DTAM\\MSSQLSERVER01;Database=Sistema_Calificacion;Integrated Security=true";
        public SqlConnection conectarbd = new SqlConnection();

        public Conexion_1()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos" + Environment.NewLine + ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }
        public bool probar_conectar()
        {
            DataTable datos = new DataTable();
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();

            if (File.Exists(@"labase.accd"))
            {
                conn.ConnectionString = "Server=PC-DTAM\\MSSQLSERVER01;Database=Sistema_Calificacion;Integrated Security=true";

                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            { return false; }
        }
        public DataTable Traer_datos_de_access_estudiantes()
        {
            DataTable dt = new DataTable();
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();

            string sentencia_sql = "select * from estudiante_1";

            if (File.Exists(@"labase.accdb"))
            {
                conn.ConnectionString = "Server=PC-DTAM\\MSSQLSERVER01;Database=Sistema_Calificacion;Integrated Security=true";
                OleDbDataAdapter da_oldb = new OleDbDataAdapter(sentencia_sql, conn.ConnectionString);

                try
                {
                    conn.Open();
                    da_oldb.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            { return null; }

        }
        public DataTable Traer_datos_de_access_carreras()
        {
            DataTable dt = new DataTable();
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();

            string sentencia_sql = "select * from carreras";

            if (File.Exists(@"labase.accdb"))
            {
                conn.ConnectionString = "Server=PC-DTAM\\MSSQLSERVER01;Database=Sistema_Calificacion;Integrated Security=true";
                OleDbDataAdapter da_oldb = new OleDbDataAdapter(sentencia_sql, conn.ConnectionString);

                try
                {
                    conn.Open();
                    da_oldb.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            { return null; }

        }

        public bool ingresar_a_la_Base_De_Datos(string cedula,
            string nombre,
            string apellido,
            string numero,
            string correo,
            string edad,
            string carrera)
        {

            string sentencia = "insert into estudiante_1 (cedula,nombre,apellido,numero,correo,edad,carrera) values('";
            sentencia += cedula + "', '";
            sentencia += nombre + "','";
            sentencia += apellido + "','";
            sentencia += numero + "','";
            sentencia += correo + "','";
            sentencia += edad + "','";
            sentencia += carrera + "');";

            System.Data.OleDb.OleDbConnection conn = new
     System.Data.OleDb.OleDbConnection();
            if (File.Exists(@"labase.accdb"))
            {
                conn.ConnectionString = "Server=PC-DTAM\\MSSQLSERVER01;Database=Sistema_Calificacion;Integrated Security=true";
                OleDbCommand comando = new OleDbCommand(sentencia, conn);
                comando.CommandType = CommandType.Text;

                try
                {
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return false;
            }
        }
        public bool actualizar_dato(string nombre, string apellido, string cedula)
        {

            string sentencia = "UPDATE estudiante_1 SET nombre='" + nombre + "',apellido='" + apellido + "' WHERE cedula='" + cedula + "';";
            try
            {
                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

                if (File.Exists(@"labase.accdb"))
                {
                    conn.ConnectionString = "Server=PC-DTAM\\MSSQLSERVER01;Database=Sistema_Calificacion;Integrated Security=true";
                    OleDbCommand comando = new OleDbCommand(sentencia, conn);
                    comando.CommandType = CommandType.Text;
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Borrar_Estudiante_Seleccionado(string cedula)
        {
            string sentencia = "delete from estudiante_1 where cedula='" + cedula + "';";
            try
            {
                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

                if (File.Exists(@"labase.accdb"))
                {

                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"labase.accdb ;" + "Persist Security Info=False;";
                    OleDbCommand comando = new OleDbCommand(sentencia, conn);
                    comando.CommandType = CommandType.Text;

                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
