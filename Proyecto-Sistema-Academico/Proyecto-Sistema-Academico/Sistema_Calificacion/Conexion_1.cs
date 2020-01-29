using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Calificacion
{
    class Conexion_1
    {
        string cadena = "Server=PC-DTAM;Database=Sistema_Calificacion;Integrated Security=true";
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
                Console.WriteLine("Conexion abierta");
            }catch(Exception ex)
            {
                Console.WriteLine("Error al conectar con la BD"+ ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }

    }
}
