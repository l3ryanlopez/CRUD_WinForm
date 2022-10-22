using Microsoft.Reporting.WinForms;
using Sol_ProcesoCRUD.Logica;
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

namespace Sol_ProcesoCRUD.Reportes
{
    public partial class Frm_Rpt_Articulos : Form
    {
        public Frm_Rpt_Articulos()
        {
            InitializeComponent();
        }
        #region "Mis Metodos"
        private void Listado_Ar()
        {
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT A.codigo_ar, A.descripcion_ar, A.marca_ar, B.descripcion_me, C.descripcion_ca" +
                               " FROM tb_articulos A" +
                               " INNER JOIN tb_medidas B ON A.codigo_me = B.codigo_me" +
                               " INNER JOIN tb_categorias C ON A.codigo_ca = C.codigo_ca";

                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ReportDataSource fuente = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(fuente);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_ProcesoCRUD.Reportes.Rpt_Articulos.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
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
        #endregion

        private void Frm_Rpt_Articulos_Load(object sender, EventArgs e)
        {

            // this.reportViewer1.RefreshReport();
            this.Listado_Ar();
        }
    }
}
