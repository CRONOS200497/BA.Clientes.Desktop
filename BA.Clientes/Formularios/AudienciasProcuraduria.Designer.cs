namespace BA.Clientes.Formularios
{
    partial class AudienciasProcuraduria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudienciasProcuraduria));
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblHojadeVida = new System.Windows.Forms.Label();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblConsultarCliente = new System.Windows.Forms.Label();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.btnAudienciasHoy = new System.Windows.Forms.Button();
            this.btnAudienciasMes = new System.Windows.Forms.Button();
            this.btnBuscarTodasLasAudiencias = new System.Windows.Forms.Button();
            this.BtnBuscarAudienciaPorCliente = new System.Windows.Forms.Button();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarPorRangoDeFechas = new System.Windows.Forms.Button();
            this.btnModificarAudiencia = new System.Windows.Forms.Button();
            this.btnAgregarAudiencia = new System.Windows.Forms.Button();
            this.btnEliminarAudiencia = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAudiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procuraduria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAudiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abogado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoAbogado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdjuntarArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformarAbogado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSubido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaActualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerAdjunto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpEncabezado.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpEncabezado
            // 
            this.tlpEncabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEncabezado.ColumnCount = 2;
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1120F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tlpEncabezado.Controls.Add(this.lblEmpresa, 0, 0);
            this.tlpEncabezado.Controls.Add(this.lblHojadeVida, 0, 1);
            this.tlpEncabezado.Controls.Add(this.dtFechaHoy, 1, 0);
            this.tlpEncabezado.Location = new System.Drawing.Point(6, 12);
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.RowCount = 2;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1332, 63);
            this.tlpEncabezado.TabIndex = 12;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(523, 26);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Barrios Abogados SAS - Audiencias Procuraduria";
            // 
            // lblHojadeVida
            // 
            this.lblHojadeVida.AutoSize = true;
            this.lblHojadeVida.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblHojadeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHojadeVida.Location = new System.Drawing.Point(3, 31);
            this.lblHojadeVida.Name = "lblHojadeVida";
            this.lblHojadeVida.Size = new System.Drawing.Size(216, 23);
            this.lblHojadeVida.TabIndex = 2;
            this.lblHojadeVida.Text = "Audiencias Procuraduria";
            // 
            // dtFechaHoy
            // 
            this.dtFechaHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaHoy.Enabled = false;
            this.dtFechaHoy.Location = new System.Drawing.Point(1129, 3);
            this.dtFechaHoy.Name = "dtFechaHoy";
            this.dtFechaHoy.Size = new System.Drawing.Size(200, 20);
            this.dtFechaHoy.TabIndex = 90;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.24686F));
            this.tableLayoutPanel3.Controls.Add(this.lblInicial, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblConsultarCliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtConsultaCliente, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAudienciasHoy, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAudienciasMes, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarTodasLasAudiencias, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.BtnBuscarAudienciaPorCliente, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpInicial, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFinal, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpfinal, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnConsultarPorRangoDeFechas, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnModificarAudiencia, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregarAudiencia, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEliminarAudiencia, 6, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.03604F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1332, 62);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.Location = new System.Drawing.Point(553, 0);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(104, 21);
            this.lblInicial.TabIndex = 14;
            this.lblInicial.Text = "Fecha Inicial";
            // 
            // lblConsultarCliente
            // 
            this.lblConsultarCliente.AutoSize = true;
            this.lblConsultarCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCliente.Location = new System.Drawing.Point(3, 0);
            this.lblConsultarCliente.Name = "lblConsultarCliente";
            this.lblConsultarCliente.Size = new System.Drawing.Size(174, 22);
            this.lblConsultarCliente.TabIndex = 0;
            this.lblConsultarCliente.Text = "Consultar Cliente(s)";
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConsultaCliente.Location = new System.Drawing.Point(3, 35);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(177, 20);
            this.txtConsultaCliente.TabIndex = 1;
            // 
            // btnAudienciasHoy
            // 
            this.btnAudienciasHoy.Location = new System.Drawing.Point(186, 3);
            this.btnAudienciasHoy.Name = "btnAudienciasHoy";
            this.btnAudienciasHoy.Size = new System.Drawing.Size(177, 23);
            this.btnAudienciasHoy.TabIndex = 11;
            this.btnAudienciasHoy.Text = "Audiencias Hoy";
            this.btnAudienciasHoy.UseVisualStyleBackColor = true;
            this.btnAudienciasHoy.Click += new System.EventHandler(this.btnAudienciasHoy_Click_1);
            // 
            // btnAudienciasMes
            // 
            this.btnAudienciasMes.Location = new System.Drawing.Point(370, 3);
            this.btnAudienciasMes.Name = "btnAudienciasMes";
            this.btnAudienciasMes.Size = new System.Drawing.Size(177, 23);
            this.btnAudienciasMes.TabIndex = 7;
            this.btnAudienciasMes.Text = "Audiencias Mes Actual";
            this.btnAudienciasMes.UseVisualStyleBackColor = true;
            this.btnAudienciasMes.Click += new System.EventHandler(this.btnAudienciasMes_Click);
            // 
            // btnBuscarTodasLasAudiencias
            // 
            this.btnBuscarTodasLasAudiencias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarTodasLasAudiencias.Location = new System.Drawing.Point(370, 34);
            this.btnBuscarTodasLasAudiencias.Name = "btnBuscarTodasLasAudiencias";
            this.btnBuscarTodasLasAudiencias.Size = new System.Drawing.Size(177, 23);
            this.btnBuscarTodasLasAudiencias.TabIndex = 12;
            this.btnBuscarTodasLasAudiencias.Text = "Buscar todas las audiencias ";
            this.btnBuscarTodasLasAudiencias.UseVisualStyleBackColor = true;
            this.btnBuscarTodasLasAudiencias.Click += new System.EventHandler(this.btnBuscarTodasLasAudiencias_Click_1);
            // 
            // BtnBuscarAudienciaPorCliente
            // 
            this.BtnBuscarAudienciaPorCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBuscarAudienciaPorCliente.Location = new System.Drawing.Point(186, 34);
            this.BtnBuscarAudienciaPorCliente.Name = "BtnBuscarAudienciaPorCliente";
            this.BtnBuscarAudienciaPorCliente.Size = new System.Drawing.Size(177, 23);
            this.BtnBuscarAudienciaPorCliente.TabIndex = 13;
            this.BtnBuscarAudienciaPorCliente.Text = "Buscar audiencia por cliente";
            this.BtnBuscarAudienciaPorCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarAudienciaPorCliente.Click += new System.EventHandler(this.BtnBuscarAudienciaPorCliente_Click_1);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInicial.Location = new System.Drawing.Point(553, 35);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(196, 20);
            this.dtpInicial.TabIndex = 8;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(755, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(96, 21);
            this.lblFinal.TabIndex = 15;
            this.lblFinal.Text = "Fecha Final";
            // 
            // dtpfinal
            // 
            this.dtpfinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpfinal.Location = new System.Drawing.Point(755, 35);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(194, 20);
            this.dtpfinal.TabIndex = 9;
            this.dtpfinal.ValueChanged += new System.EventHandler(this.dtpfinal_ValueChanged);
            // 
            // btnConsultarPorRangoDeFechas
            // 
            this.btnConsultarPorRangoDeFechas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConsultarPorRangoDeFechas.Location = new System.Drawing.Point(955, 34);
            this.btnConsultarPorRangoDeFechas.Name = "btnConsultarPorRangoDeFechas";
            this.btnConsultarPorRangoDeFechas.Size = new System.Drawing.Size(177, 23);
            this.btnConsultarPorRangoDeFechas.TabIndex = 10;
            this.btnConsultarPorRangoDeFechas.Text = "Consultar por rango de fechas";
            this.btnConsultarPorRangoDeFechas.UseVisualStyleBackColor = true;
            this.btnConsultarPorRangoDeFechas.Click += new System.EventHandler(this.btnConsultarPorRangoDeFechas_Click);
            // 
            // btnModificarAudiencia
            // 
            this.btnModificarAudiencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarAudiencia.Enabled = false;
            this.btnModificarAudiencia.Location = new System.Drawing.Point(955, 3);
            this.btnModificarAudiencia.Name = "btnModificarAudiencia";
            this.btnModificarAudiencia.Size = new System.Drawing.Size(177, 23);
            this.btnModificarAudiencia.TabIndex = 4;
            this.btnModificarAudiencia.Text = "Modificar Audiencia";
            this.btnModificarAudiencia.UseVisualStyleBackColor = true;
            this.btnModificarAudiencia.Click += new System.EventHandler(this.btnModificarAudiencia_Click);
            // 
            // btnAgregarAudiencia
            // 
            this.btnAgregarAudiencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarAudiencia.Location = new System.Drawing.Point(1138, 3);
            this.btnAgregarAudiencia.Name = "btnAgregarAudiencia";
            this.btnAgregarAudiencia.Size = new System.Drawing.Size(177, 23);
            this.btnAgregarAudiencia.TabIndex = 5;
            this.btnAgregarAudiencia.Text = "Agregar Audiencia";
            this.btnAgregarAudiencia.UseVisualStyleBackColor = true;
            this.btnAgregarAudiencia.Click += new System.EventHandler(this.btnAgregarAudiencia_Click);
            // 
            // btnEliminarAudiencia
            // 
            this.btnEliminarAudiencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminarAudiencia.Enabled = false;
            this.btnEliminarAudiencia.Location = new System.Drawing.Point(1138, 34);
            this.btnEliminarAudiencia.Name = "btnEliminarAudiencia";
            this.btnEliminarAudiencia.Size = new System.Drawing.Size(177, 23);
            this.btnEliminarAudiencia.TabIndex = 16;
            this.btnEliminarAudiencia.Text = "Eliminar Audiencia";
            this.btnEliminarAudiencia.UseVisualStyleBackColor = true;
            this.btnEliminarAudiencia.Click += new System.EventHandler(this.btnEliminarAudiencia_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 149);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1332, 568);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAudiencia,
            this.Doc_Cliente,
            this.PrimerNombre,
            this.SegundoNombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.NumeroProceso,
            this.Procuraduria,
            this.FechaAudiencia,
            this.Abogado,
            this.CorreoAbogado,
            this.Observaciones,
            this.AdjuntarArchivo,
            this.InformarCliente,
            this.InformarAbogado,
            this.FechaSubido,
            this.FechaActualizado,
            this.Usu,
            this.VerAdjunto});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 562);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idAudiencia
            // 
            this.idAudiencia.HeaderText = "id Audiencia";
            this.idAudiencia.Name = "idAudiencia";
            this.idAudiencia.ReadOnly = true;
            this.idAudiencia.Width = 90;
            // 
            // Doc_Cliente
            // 
            this.Doc_Cliente.HeaderText = "Documento Cliente";
            this.Doc_Cliente.Name = "Doc_Cliente";
            this.Doc_Cliente.ReadOnly = true;
            this.Doc_Cliente.Width = 122;
            // 
            // PrimerNombre
            // 
            this.PrimerNombre.HeaderText = "Primer Nombre";
            this.PrimerNombre.Name = "PrimerNombre";
            this.PrimerNombre.ReadOnly = true;
            this.PrimerNombre.Width = 101;
            // 
            // SegundoNombre
            // 
            this.SegundoNombre.HeaderText = "Segundo Nombre";
            this.SegundoNombre.Name = "SegundoNombre";
            this.SegundoNombre.ReadOnly = true;
            this.SegundoNombre.Width = 115;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 101;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.Width = 115;
            // 
            // NumeroProceso
            // 
            this.NumeroProceso.HeaderText = "Número Proceso";
            this.NumeroProceso.Name = "NumeroProceso";
            this.NumeroProceso.Width = 111;
            // 
            // Procuraduria
            // 
            this.Procuraduria.HeaderText = "Procuraduria";
            this.Procuraduria.Name = "Procuraduria";
            this.Procuraduria.ReadOnly = true;
            this.Procuraduria.Width = 92;
            // 
            // FechaAudiencia
            // 
            this.FechaAudiencia.HeaderText = "Fecha Audiencia";
            this.FechaAudiencia.Name = "FechaAudiencia";
            this.FechaAudiencia.ReadOnly = true;
            this.FechaAudiencia.Width = 112;
            // 
            // Abogado
            // 
            this.Abogado.HeaderText = "Abogado";
            this.Abogado.Name = "Abogado";
            this.Abogado.ReadOnly = true;
            this.Abogado.Width = 75;
            // 
            // CorreoAbogado
            // 
            this.CorreoAbogado.HeaderText = "Correo Abogado";
            this.CorreoAbogado.Name = "CorreoAbogado";
            this.CorreoAbogado.ReadOnly = true;
            this.CorreoAbogado.Width = 109;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 103;
            // 
            // AdjuntarArchivo
            // 
            this.AdjuntarArchivo.HeaderText = "Adjuntar Archivo";
            this.AdjuntarArchivo.Name = "AdjuntarArchivo";
            this.AdjuntarArchivo.ReadOnly = true;
            this.AdjuntarArchivo.Width = 110;
            // 
            // InformarCliente
            // 
            this.InformarCliente.HeaderText = "Informar Cliente";
            this.InformarCliente.Name = "InformarCliente";
            this.InformarCliente.ReadOnly = true;
            this.InformarCliente.Width = 105;
            // 
            // InformarAbogado
            // 
            this.InformarAbogado.HeaderText = "Informar Abogado";
            this.InformarAbogado.Name = "InformarAbogado";
            this.InformarAbogado.ReadOnly = true;
            this.InformarAbogado.Width = 116;
            // 
            // FechaSubido
            // 
            this.FechaSubido.HeaderText = "Fecha Subido";
            this.FechaSubido.Name = "FechaSubido";
            this.FechaSubido.ReadOnly = true;
            this.FechaSubido.Width = 98;
            // 
            // FechaActualizado
            // 
            this.FechaActualizado.HeaderText = "Fecha Actualizado";
            this.FechaActualizado.Name = "FechaActualizado";
            this.FechaActualizado.ReadOnly = true;
            this.FechaActualizado.Width = 120;
            // 
            // Usu
            // 
            this.Usu.HeaderText = "Usuario";
            this.Usu.Name = "Usu";
            this.Usu.ReadOnly = true;
            this.Usu.Width = 68;
            // 
            // VerAdjunto
            // 
            this.VerAdjunto.HeaderText = "Ver Adjunto";
            this.VerAdjunto.Name = "VerAdjunto";
            this.VerAdjunto.ReadOnly = true;
            this.VerAdjunto.Width = 68;
            // 
            // AudienciasProcuraduria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tlpEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AudienciasProcuraduria";
            this.Text = "Barrios Abogados SAS - Audiencias Procuraduria";
            this.Load += new System.EventHandler(this.AudienciasJuzgado_Load);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblHojadeVida;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAgregarAudiencia;
        private System.Windows.Forms.Label lblConsultarCliente;
        private System.Windows.Forms.Button btnModificarAudiencia;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAudienciasMes;
        private System.Windows.Forms.Button btnConsultarPorRangoDeFechas;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpfinal;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Button btnAudienciasHoy;
        private System.Windows.Forms.Button btnBuscarTodasLasAudiencias;
        private System.Windows.Forms.Button BtnBuscarAudienciaPorCliente;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnEliminarAudiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAudiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procuraduria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAudiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abogado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoAbogado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjuntarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InformarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn InformarAbogado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSubido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaActualizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu;
        private System.Windows.Forms.DataGridViewButtonColumn VerAdjunto;
    }
}