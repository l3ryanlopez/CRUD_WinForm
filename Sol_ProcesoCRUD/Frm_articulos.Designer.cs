namespace Sol_ProcesoCRUD
{
    partial class Frm_articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_articulos));
            this.dgvListado_ar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDescripcionAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarcaAr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionMe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionCa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLupaMe = new System.Windows.Forms.Button();
            this.btnLupaCa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlMe = new System.Windows.Forms.Panel();
            this.btnRetornarMe = new System.Windows.Forms.Button();
            this.dgvMe = new System.Windows.Forms.DataGridView();
            this.pnlCa = new System.Windows.Forms.Panel();
            this.btnRetornarCa = new System.Windows.Forms.Button();
            this.dgvCa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado_ar)).BeginInit();
            this.pnlMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMe)).BeginInit();
            this.pnlCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado_ar
            // 
            this.dgvListado_ar.AllowUserToAddRows = false;
            this.dgvListado_ar.AllowUserToDeleteRows = false;
            this.dgvListado_ar.AllowUserToOrderColumns = true;
            this.dgvListado_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado_ar.Location = new System.Drawing.Point(12, 69);
            this.dgvListado_ar.Name = "dgvListado_ar";
            this.dgvListado_ar.ReadOnly = true;
            this.dgvListado_ar.Size = new System.Drawing.Size(690, 356);
            this.dgvListado_ar.TabIndex = 0;
            this.dgvListado_ar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_ar_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(76, 36);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 27);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(258, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(207)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ImageKey = "registro.png";
            this.btnNuevo.ImageList = this.imageList1;
            this.btnNuevo.Location = new System.Drawing.Point(461, 461);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 69);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "salir.png");
            this.imageList1.Images.SetKeyName(1, "reporte.png");
            this.imageList1.Images.SetKeyName(2, "editar.png");
            this.imageList1.Images.SetKeyName(3, "registro.png");
            this.imageList1.Images.SetKeyName(4, "eliminar.png");
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(207)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ImageKey = "editar.png";
            this.btnActualizar.ImageList = this.imageList1;
            this.btnActualizar.Location = new System.Drawing.Point(554, 461);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 69);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(207)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ImageKey = "eliminar.png";
            this.btnEliminar.ImageList = this.imageList1;
            this.btnEliminar.Location = new System.Drawing.Point(647, 461);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 69);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(207)))));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ImageKey = "reporte.png";
            this.btnReporte.ImageList = this.imageList1;
            this.btnReporte.Location = new System.Drawing.Point(740, 461);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(87, 69);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(207)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ImageKey = "salir.png";
            this.btnSalir.ImageList = this.imageList1;
            this.btnSalir.Location = new System.Drawing.Point(833, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 69);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtDescripcionAr
            // 
            this.txtDescripcionAr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionAr.Location = new System.Drawing.Point(742, 91);
            this.txtDescripcionAr.Name = "txtDescripcionAr";
            this.txtDescripcionAr.ReadOnly = true;
            this.txtDescripcionAr.Size = new System.Drawing.Size(225, 27);
            this.txtDescripcionAr.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(738, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Articulo (*):";
            // 
            // txtMarcaAr
            // 
            this.txtMarcaAr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaAr.Location = new System.Drawing.Point(742, 162);
            this.txtMarcaAr.Name = "txtMarcaAr";
            this.txtMarcaAr.ReadOnly = true;
            this.txtMarcaAr.Size = new System.Drawing.Size(225, 27);
            this.txtMarcaAr.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca (*):";
            // 
            // txtDescripcionMe
            // 
            this.txtDescripcionMe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMe.Location = new System.Drawing.Point(742, 239);
            this.txtDescripcionMe.Name = "txtDescripcionMe";
            this.txtDescripcionMe.ReadOnly = true;
            this.txtDescripcionMe.Size = new System.Drawing.Size(178, 27);
            this.txtDescripcionMe.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(738, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Medida (*):";
            // 
            // txtDescripcionCa
            // 
            this.txtDescripcionCa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCa.Location = new System.Drawing.Point(742, 305);
            this.txtDescripcionCa.Name = "txtDescripcionCa";
            this.txtDescripcionCa.ReadOnly = true;
            this.txtDescripcionCa.Size = new System.Drawing.Size(178, 27);
            this.txtDescripcionCa.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categoria (*):";
            // 
            // btnLupaMe
            // 
            this.btnLupaMe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupaMe.Location = new System.Drawing.Point(926, 237);
            this.btnLupaMe.Name = "btnLupaMe";
            this.btnLupaMe.Size = new System.Drawing.Size(41, 29);
            this.btnLupaMe.TabIndex = 17;
            this.btnLupaMe.Text = ":::";
            this.btnLupaMe.UseVisualStyleBackColor = true;
            this.btnLupaMe.Visible = false;
            this.btnLupaMe.Click += new System.EventHandler(this.btnLupaMe_Click);
            // 
            // btnLupaCa
            // 
            this.btnLupaCa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupaCa.Location = new System.Drawing.Point(926, 303);
            this.btnLupaCa.Name = "btnLupaCa";
            this.btnLupaCa.Size = new System.Drawing.Size(41, 29);
            this.btnLupaCa.TabIndex = 18;
            this.btnLupaCa.Text = ":::";
            this.btnLupaCa.UseVisualStyleBackColor = true;
            this.btnLupaCa.Visible = false;
            this.btnLupaCa.Click += new System.EventHandler(this.btnLupaCa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(742, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.Location = new System.Drawing.Point(873, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 37);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlMe
            // 
            this.pnlMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMe.Controls.Add(this.btnRetornarMe);
            this.pnlMe.Controls.Add(this.dgvMe);
            this.pnlMe.Location = new System.Drawing.Point(17, 431);
            this.pnlMe.Name = "pnlMe";
            this.pnlMe.Size = new System.Drawing.Size(180, 230);
            this.pnlMe.TabIndex = 21;
            this.pnlMe.Visible = false;
            // 
            // btnRetornarMe
            // 
            this.btnRetornarMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRetornarMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornarMe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarMe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRetornarMe.Location = new System.Drawing.Point(11, 200);
            this.btnRetornarMe.Name = "btnRetornarMe";
            this.btnRetornarMe.Size = new System.Drawing.Size(158, 27);
            this.btnRetornarMe.TabIndex = 22;
            this.btnRetornarMe.Text = "Retornar";
            this.btnRetornarMe.UseVisualStyleBackColor = false;
            this.btnRetornarMe.Click += new System.EventHandler(this.btnRetornarMe_Click);
            // 
            // dgvMe
            // 
            this.dgvMe.AllowUserToAddRows = false;
            this.dgvMe.AllowUserToDeleteRows = false;
            this.dgvMe.AllowUserToOrderColumns = true;
            this.dgvMe.ColumnHeadersHeight = 28;
            this.dgvMe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMe.Location = new System.Drawing.Point(11, 5);
            this.dgvMe.Name = "dgvMe";
            this.dgvMe.ReadOnly = true;
            this.dgvMe.Size = new System.Drawing.Size(158, 192);
            this.dgvMe.TabIndex = 0;
            this.dgvMe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMe_CellDoubleClick);
            // 
            // pnlCa
            // 
            this.pnlCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCa.Controls.Add(this.btnRetornarCa);
            this.pnlCa.Controls.Add(this.dgvCa);
            this.pnlCa.Location = new System.Drawing.Point(212, 431);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(180, 230);
            this.pnlCa.TabIndex = 23;
            this.pnlCa.Visible = false;
            // 
            // btnRetornarCa
            // 
            this.btnRetornarCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRetornarCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornarCa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarCa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRetornarCa.Location = new System.Drawing.Point(11, 200);
            this.btnRetornarCa.Name = "btnRetornarCa";
            this.btnRetornarCa.Size = new System.Drawing.Size(158, 27);
            this.btnRetornarCa.TabIndex = 24;
            this.btnRetornarCa.Text = "Retornar";
            this.btnRetornarCa.UseVisualStyleBackColor = false;
            this.btnRetornarCa.Click += new System.EventHandler(this.btnRetornarCa_Click);
            // 
            // dgvCa
            // 
            this.dgvCa.AllowUserToAddRows = false;
            this.dgvCa.AllowUserToDeleteRows = false;
            this.dgvCa.AllowUserToOrderColumns = true;
            this.dgvCa.ColumnHeadersHeight = 28;
            this.dgvCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCa.Location = new System.Drawing.Point(11, 5);
            this.dgvCa.Name = "dgvCa";
            this.dgvCa.ReadOnly = true;
            this.dgvCa.Size = new System.Drawing.Size(158, 192);
            this.dgvCa.TabIndex = 0;
            this.dgvCa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCa_CellDoubleClick);
            // 
            // Frm_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(979, 542);
            this.Controls.Add(this.pnlCa);
            this.Controls.Add(this.pnlMe);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLupaCa);
            this.Controls.Add(this.btnLupaMe);
            this.Controls.Add(this.txtDescripcionCa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcionMe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarcaAr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcionAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListado_ar);
            this.Name = "Frm_articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_articulos";
            this.Load += new System.EventHandler(this.Frm_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado_ar)).EndInit();
            this.pnlMe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMe)).EndInit();
            this.pnlCa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado_ar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDescripcionAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarcaAr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionMe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionCa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLupaMe;
        private System.Windows.Forms.Button btnLupaCa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlMe;
        private System.Windows.Forms.Button btnRetornarMe;
        private System.Windows.Forms.DataGridView dgvMe;
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.DataGridView dgvCa;
        private System.Windows.Forms.Button btnRetornarCa;
    }
}