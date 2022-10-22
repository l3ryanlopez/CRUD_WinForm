using Sol_ProcesoCRUD.Logica;
using Sol_ProcesoCRUD.Modelo;
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

namespace Sol_ProcesoCRUD
{
    public partial class Frm_articulos : Form
    {
        public Frm_articulos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nEstadoGuarda = 0; // 1-Guardar 2-Actualizar
        int nCodigoAr = 0;
        int nCodigoMe = 0;
        int nCodigoCa = 0;
        #endregion

        #region "Mis Metodos"
        private void Estado_Texto(bool lEstado)
        {
            txtDescripcionAr.ReadOnly = !lEstado;
            txtMarcaAr.ReadOnly = !lEstado;
        }
        private void Limpia_Texto()
        {
            txtDescripcionAr.Clear();
            txtMarcaAr.Clear();
            txtDescripcionMe.Clear();
            txtDescripcionCa.Clear();
        }
        private void Estado_BotonesProcesos(bool lEstado)
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado;
            btnLupaCa.Visible = lEstado;
            btnLupaMe.Visible = lEstado;

            btnBuscar.Enabled = !lEstado;
            txtBuscar.Enabled = !lEstado;
            dgvListado_ar.Enabled = !lEstado;
        }
        private void Estado_BotonesPrincipales(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            btnEliminar.Enabled = lEstado;
            btnActualizar.Enabled = lEstado;
            btnReporte.Enabled = lEstado;
            btnSalir.Enabled = lEstado;
        }
        private void Formato_Ar()
        {
            dgvListado_ar.Columns[0].Width = 90;
            dgvListado_ar.Columns[0].HeaderText = "ART. CODIGO";
            dgvListado_ar.Columns[1].Width = 220;
            dgvListado_ar.Columns[1].HeaderText = "ARTICULO";
            dgvListado_ar.Columns[2].Width = 120;
            dgvListado_ar.Columns[2].HeaderText = "MARCA";
            dgvListado_ar.Columns[3].Width = 100;
            dgvListado_ar.Columns[3].HeaderText = "MEDIDA";
            dgvListado_ar.Columns[4].Width = 150;
            dgvListado_ar.Columns[4].HeaderText = "CATEGORIA";
            dgvListado_ar.Columns[5].Visible = false;
            dgvListado_ar.Columns[6].Visible = false;
        }
        private void Listado_Ar(string cTexto)
        {
            L_Articulos Datos = new L_Articulos();
            dgvListado_ar.DataSource = Datos.Listado_Ar(cTexto);
            this.Formato_Ar();
        }


        private void Selecciona_Item_Ar()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvListado_ar.CurrentRow.Cells["codigo_ar"].Value)))
            {
                MessageBox.Show("Seleccione un registro",
                               "Aviso del sistema",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigoAr = Convert.ToInt32(dgvListado_ar.CurrentRow.Cells["codigo_ar"].Value);
                txtDescripcionAr.Text = Convert.ToString(dgvListado_ar.CurrentRow.Cells["descripcion_ar"].Value);
                txtMarcaAr.Text = Convert.ToString(dgvListado_ar.CurrentRow.Cells["marca_ar"].Value);
                this.nCodigoMe = Convert.ToInt32(dgvListado_ar.CurrentRow.Cells["codigo_me"].Value);
                txtDescripcionMe.Text = Convert.ToString(dgvListado_ar.CurrentRow.Cells["descripcion_me"].Value);
                this.nCodigoCa = Convert.ToInt32(dgvListado_ar.CurrentRow.Cells["codigo_ca"].Value);
                txtDescripcionCa.Text = Convert.ToString(dgvListado_ar.CurrentRow.Cells["descripcion_ca"].Value);

            }
        }
        // MEDIDAS *******
        private void Formato_Me()
        {
            dgvMe.Columns[0].Width = 115;
            dgvMe.Columns[0].HeaderText = "MEDIDA";
            dgvMe.Columns[1].Visible = false;
        }
        private void Listado_Me()
        {
            L_Articulos Datos = new L_Articulos();
            dgvMe.DataSource = Datos.Listado_Me();
            this.Formato_Me();
        }
        private void Selecciona_Item_Me()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvMe.CurrentRow.Cells["codigo_me"].Value)))
            {
                MessageBox.Show("Seleccione un registro",
                               "Aviso del sistema",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigoMe = Convert.ToInt32(dgvMe.CurrentRow.Cells["codigo_me"].Value);
                txtDescripcionMe.Text = Convert.ToString(dgvMe.CurrentRow.Cells["descripcion_me"].Value);
            }
        }
        // CATEGORIAS *******
        private void Formato_Ca()
        {
            dgvCa.Columns[0].Width = 115;
            dgvCa.Columns[0].HeaderText = "CATEGORIA";
            dgvCa.Columns[1].Visible = false;
        }
        private void Listado_Ca()
        {
            L_Articulos Datos = new L_Articulos();
            dgvCa.DataSource = Datos.Listado_Ca();
            this.Formato_Ca();
        }
        private void Selecciona_Item_Ca()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvCa.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("Seleccione un registro",
                               "Aviso del sistema",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigoCa = Convert.ToInt32(dgvCa.CurrentRow.Cells["codigo_ca"].Value);
                txtDescripcionCa.Text = Convert.ToString(dgvCa.CurrentRow.Cells["descripcion_ca"].Value);
            }
        }


        #endregion


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo Registro
            this.Estado_Texto(true);
            this.Limpia_Texto();
            this.Estado_BotonesProcesos(true);
            this.Estado_BotonesPrincipales(false);
            txtDescripcionAr.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Texto(false);
            this.Limpia_Texto();
            this.Estado_BotonesProcesos(false);
            this.Estado_BotonesPrincipales(true);
            nEstadoGuarda = 0;
            nCodigoCa = 0;
            nCodigoMe = 0;
            nCodigoAr = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvListado_ar.Rows.Count<=0)
            {
                MessageBox.Show("No se tiene registro para actualizar",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nEstadoGuarda = 2; //Actualiza el Registro
                this.Estado_Texto(true);
                this.Estado_BotonesProcesos(true);
                this.Estado_BotonesPrincipales(false);
                txtDescripcionAr.Focus();
            }
        }

        private void Frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_Ar("%");
            this.Listado_Me();
            this.Listado_Ca();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            M_Articulos oAr = new M_Articulos();
            oAr.codigoAr = nCodigoAr;
            oAr.descripcionAr = txtDescripcionAr.Text.Trim();
            oAr.marcaAr = txtMarcaAr.Text.Trim();
            oAr.codigoMe = nCodigoMe;
            oAr.codigoCa = nCodigoCa;

            L_Articulos Datos = new L_Articulos();

            Rpta = Datos.Guardar_Ar(nEstadoGuarda, oAr);
            if (Rpta.Equals("OK"))
            {
                this.Estado_Texto(false);
                this.Estado_BotonesProcesos(false);
                this.Estado_BotonesPrincipales(true);
                this.Listado_Ar("%");
                nEstadoGuarda = 0;
                nCodigoCa = 0;
                nCodigoMe = 0;
                nCodigoAr = 0;
                MessageBox.Show("Los datos han sido guardados correctamente",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Limpia_Texto();
            }
            else
            {
                MessageBox.Show(Rpta);
            }
        }

        private void btnLupaMe_Click(object sender, EventArgs e)
        {
            pnlMe.Location = txtDescripcionAr.Location;
            pnlMe.Visible = true;

        }

        private void btnRetornarMe_Click(object sender, EventArgs e)
        {
            pnlMe.Visible = false;
        }

        private void dgvMe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Proceso
            this.Selecciona_Item_Me();
            pnlMe.Visible = false;
        }

        private void btnLupaCa_Click(object sender, EventArgs e)
        {
            pnlCa.Location = txtDescripcionAr.Location;
            pnlCa.Visible = true;
        }


        private void btnRetornarCa_Click(object sender, EventArgs e)
        {
            pnlCa.Visible = false;
        }

        private void dgvCa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Ca();
            pnlCa.Visible = false;
        }

        private void dgvListado_ar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Ar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_Ar(txtBuscar.Text.Trim());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListado_ar.Rows.Count<=0)
            {
                MessageBox.Show("No se tiene registro para eliminar",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                L_Articulos Datos = new L_Articulos();
                Rpta = Datos.Eliminar_Ar(nCodigoAr);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_Ar("%");
                    this.Limpia_Texto();
                    nCodigoAr = 0;
                    nCodigoCa = 0;
                    nCodigoMe = 0;
                    MessageBox.Show("El registro fue eliminado",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Articulos oRpt = new Reportes.Frm_Rpt_Articulos();
            oRpt.ShowDialog();
        }
    }
}
