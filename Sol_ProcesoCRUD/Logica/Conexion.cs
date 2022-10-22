using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_ProcesoCRUD.Logica
{
    public  class Conexion
    {
        private string BaseDatos;
        private static Conexion conn = null;

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=BRYANLOPEZLP\\SQLEXPRESS;Database=bd_tarea;Trusted_Connection=True;Application Name = Sol_ProcesoCRUD";
            }
            catch (Exception ex) 
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static  Conexion getInstancia()
        {
            if (conn == null)
            {
                conn = new Conexion();
            }
            return conn;
        }


    }
}
