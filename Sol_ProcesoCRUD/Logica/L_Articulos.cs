using Sol_ProcesoCRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_ProcesoCRUD.Logica
{
    public class L_Articulos
    {
        public DataTable Listado_Ar(string cTexto)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                cTexto = "%"+cTexto.Trim()+"%";

                string query = "SELECT A.codigo_ar, A.descripcion_ar, A.marca_ar, B.descripcion_me, C.descripcion_ca, A.codigo_me, A.codigo_ca"+
                               " FROM tb_articulos A"+
                               " INNER JOIN tb_medidas B ON A.codigo_me = B.codigo_me"+
                               " INNER JOIN tb_categorias C ON A.codigo_ca = C.codigo_ca"+
                               " WHERE A.descripcion_ar LIKE '"+cTexto+"' ";
                SqlCommand comando = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }


        public string Guardar_Ar(int nOpcion, M_Articulos oAr)
        {
            string respuesta = "";
            string query = "";

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                if (nOpcion==1) //Nuevo Registro INSWRT
                {
                    query = "INSERT INTO tb_articulos(descripcion_ar, marca_ar, codigo_me, codigo_ca)"+
                            " VALUES('"+oAr.descripcionAr+"', '"+oAr.marcaAr+"', '"+oAr.codigoMe+"', '"+oAr.codigoCa+"')";
                }
                else //Actualizar Registro UPDATE
                {
                    query = "UPDATE tb_articulos"+
                            " SET descripcion_ar='" + oAr.descripcionAr + "', "+
                                      "marca_ar='" + oAr.marcaAr + "', "+
                                     "codigo_me='" + oAr.codigoMe + "', "+
                                     "codigo_ca='" + oAr.codigoCa + "' "+
                            "WHERE codigo_ar='" + oAr.codigoAr + "' ";
                }

                SqlCommand comando = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                respuesta = comando.ExecuteNonQuery () >= 1 ? "OK" : "No se pudo completar el proceso de registro";
                return respuesta;
            }
            catch (Exception ex)
            {

                return respuesta = ex .Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable Listado_Me()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = "SELECT descripcion_me, codigo_me" +
                               " FROM tb_medidas";
                SqlCommand comando = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable Listado_Ca()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = "SELECT descripcion_ca, codigo_ca" +
                               " FROM tb_categorias";
                SqlCommand comando = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string Eliminar_Ar(int nCodigo_ar)
        {
            string respuesta = "";
            string query = "";

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                query = "DELETE FROM tb_articulos"+
                        " WHERE codigo_ar='"+nCodigo_ar+"'";

                SqlCommand comando = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de eliminación";
                return respuesta;
            }
            catch (Exception ex)
            {

                return respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
