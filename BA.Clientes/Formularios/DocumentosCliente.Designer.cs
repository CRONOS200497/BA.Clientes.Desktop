namespace BA.Clientes.Formularios
{
    partial class DocumentosCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentosCliente));
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblHojadeVida = new System.Windows.Forms.Label();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblConsultarCliente = new System.Windows.Forms.Label();
            this.lblNumeroidentificacionCliente = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.lblPrimerNombreCliente = new System.Windows.Forms.Label();
            this.txtPrimerNombreCliente = new System.Windows.Forms.TextBox();
            this.lblSegundoNombreCliente = new System.Windows.Forms.Label();
            this.txtSegundoNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblPrimerApellidoCliente = new System.Windows.Forms.Label();
            this.txtSegundoApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevaBusqueda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombreArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombeArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFechaSubido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFechaActualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInformarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoDocumento = new System.Windows.Forms.Button();
            this.tlpEncabezado.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tlpEncabezado.TabIndex = 4;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(559, 26);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Barrios Abogados SAS - Cargar Documentos Clientes";
            // 
            // lblHojadeVida
            // 
            this.lblHojadeVida.AutoSize = true;
            this.lblHojadeVida.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblHojadeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHojadeVida.Location = new System.Drawing.Point(3, 31);
            this.lblHojadeVida.Name = "lblHojadeVida";
            this.lblHojadeVida.Size = new System.Drawing.Size(189, 23);
            this.lblHojadeVida.TabIndex = 2;
            this.lblHojadeVida.Text = "Documentos Clientes";
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
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.9242F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblConsultarCliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNumeroidentificacionCliente, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNumeroIdentificacionCliente, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPrimerNombreCliente, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPrimerNombreCliente, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSegundoNombreCliente, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSegundoNombreCliente, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPrimerApellidoCliente, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPrimerApellidoCliente, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSegundoApellidoCliente, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscar, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnNuevaBusqueda, 7, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1332, 60);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // lblConsultarCliente
            // 
            this.lblConsultarCliente.AutoSize = true;
            this.lblConsultarCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCliente.Location = new System.Drawing.Point(3, 0);
            this.lblConsultarCliente.Name = "lblConsultarCliente";
            this.lblConsultarCliente.Size = new System.Drawing.Size(138, 21);
            this.lblConsultarCliente.TabIndex = 7;
            this.lblConsultarCliente.Text = "Consultar Cliente";
            // 
            // lblNumeroidentificacionCliente
            // 
            this.lblNumeroidentificacionCliente.AutoSize = true;
            this.lblNumeroidentificacionCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroidentificacionCliente.Location = new System.Drawing.Point(161, 0);
            this.lblNumeroidentificacionCliente.Name = "lblNumeroidentificacionCliente";
            this.lblNumeroidentificacionCliente.Size = new System.Drawing.Size(160, 21);
            this.lblNumeroidentificacionCliente.TabIndex = 12;
            this.lblNumeroidentificacionCliente.Text = "No de identificación";
            // 
            // txtNumeroIdentificacionCliente
            // 
            this.txtNumeroIdentificacionCliente.Location = new System.Drawing.Point(161, 32);
            this.txtNumeroIdentificacionCliente.Name = "txtNumeroIdentificacionCliente";
            this.txtNumeroIdentificacionCliente.Size = new System.Drawing.Size(161, 20);
            this.txtNumeroIdentificacionCliente.TabIndex = 1;
            // 
            // lblPrimerNombreCliente
            // 
            this.lblPrimerNombreCliente.AutoSize = true;
            this.lblPrimerNombreCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombreCliente.Location = new System.Drawing.Point(329, 0);
            this.lblPrimerNombreCliente.Name = "lblPrimerNombreCliente";
            this.lblPrimerNombreCliente.Size = new System.Drawing.Size(125, 21);
            this.lblPrimerNombreCliente.TabIndex = 8;
            this.lblPrimerNombreCliente.Text = "Primer Nombre";
            // 
            // txtPrimerNombreCliente
            // 
            this.txtPrimerNombreCliente.Location = new System.Drawing.Point(329, 32);
            this.txtPrimerNombreCliente.Name = "txtPrimerNombreCliente";
            this.txtPrimerNombreCliente.Size = new System.Drawing.Size(161, 20);
            this.txtPrimerNombreCliente.TabIndex = 2;
            // 
            // lblSegundoNombreCliente
            // 
            this.lblSegundoNombreCliente.AutoSize = true;
            this.lblSegundoNombreCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombreCliente.Location = new System.Drawing.Point(496, 0);
            this.lblSegundoNombreCliente.Name = "lblSegundoNombreCliente";
            this.lblSegundoNombreCliente.Size = new System.Drawing.Size(142, 21);
            this.lblSegundoNombreCliente.TabIndex = 9;
            this.lblSegundoNombreCliente.Text = "Segundo Nombre";
            // 
            // txtSegundoNombreCliente
            // 
            this.txtSegundoNombreCliente.Location = new System.Drawing.Point(496, 32);
            this.txtSegundoNombreCliente.Name = "txtSegundoNombreCliente";
            this.txtSegundoNombreCliente.Size = new System.Drawing.Size(161, 20);
            this.txtSegundoNombreCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(663, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Primer Apellido";
            // 
            // txtPrimerApellidoCliente
            // 
            this.txtPrimerApellidoCliente.Location = new System.Drawing.Point(663, 32);
            this.txtPrimerApellidoCliente.Name = "txtPrimerApellidoCliente";
            this.txtPrimerApellidoCliente.Size = new System.Drawing.Size(161, 20);
            this.txtPrimerApellidoCliente.TabIndex = 4;
            // 
            // lblPrimerApellidoCliente
            // 
            this.lblPrimerApellidoCliente.AutoSize = true;
            this.lblPrimerApellidoCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellidoCliente.Location = new System.Drawing.Point(830, 0);
            this.lblPrimerApellidoCliente.Name = "lblPrimerApellidoCliente";
            this.lblPrimerApellidoCliente.Size = new System.Drawing.Size(143, 21);
            this.lblPrimerApellidoCliente.TabIndex = 11;
            this.lblPrimerApellidoCliente.Text = "Segundo Apellido";
            // 
            // txtSegundoApellidoCliente
            // 
            this.txtSegundoApellidoCliente.Location = new System.Drawing.Point(830, 32);
            this.txtSegundoApellidoCliente.Name = "txtSegundoApellidoCliente";
            this.txtSegundoApellidoCliente.Size = new System.Drawing.Size(161, 20);
            this.txtSegundoApellidoCliente.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(998, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 20);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevaBusqueda
            // 
            this.btnNuevaBusqueda.Location = new System.Drawing.Point(1166, 32);
            this.btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            this.btnNuevaBusqueda.Size = new System.Drawing.Size(161, 20);
            this.btnNuevaBusqueda.TabIndex = 19;
            this.btnNuevaBusqueda.Text = "Nueva Busqueda";
            this.btnNuevaBusqueda.UseVisualStyleBackColor = true;
            this.btnNuevaBusqueda.Click += new System.EventHandler(this.btnNuevaBusqueda_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDocumento,
            this.clNombreArchivo,
            this.clNombeArchivo,
            this.clFechaSubido,
            this.clFechaActualizado,
            this.clInformarCliente,
            this.clUsuario,
            this.btnVer,
            this.btnModificar,
            this.btnEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(6, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1332, 518);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clDocumento
            // 
            this.clDocumento.HeaderText = "Id Documento";
            this.clDocumento.Name = "clDocumento";
            this.clDocumento.Width = 99;
            // 
            // clNombreArchivo
            // 
            this.clNombreArchivo.HeaderText = "Tipo Documento";
            this.clNombreArchivo.Name = "clNombreArchivo";
            this.clNombreArchivo.Width = 111;
            // 
            // clNombeArchivo
            // 
            this.clNombeArchivo.HeaderText = "Nombre Archivo";
            this.clNombeArchivo.Name = "clNombeArchivo";
            this.clNombeArchivo.Width = 108;
            // 
            // clFechaSubido
            // 
            this.clFechaSubido.HeaderText = "Fecha subido";
            this.clFechaSubido.Name = "clFechaSubido";
            this.clFechaSubido.Width = 96;
            // 
            // clFechaActualizado
            // 
            this.clFechaActualizado.HeaderText = "Fecha Actualizado";
            this.clFechaActualizado.Name = "clFechaActualizado";
            this.clFechaActualizado.Width = 120;
            // 
            // clInformarCliente
            // 
            this.clInformarCliente.HeaderText = "Notificar";
            this.clInformarCliente.Name = "clInformarCliente";
            this.clInformarCliente.Width = 71;
            // 
            // clUsuario
            // 
            this.clUsuario.HeaderText = "Subido Por";
            this.clUsuario.Name = "clUsuario";
            this.clUsuario.Width = 84;
            // 
            // btnVer
            // 
            this.btnVer.HeaderText = "Ver";
            this.btnVer.Name = "btnVer";
            this.btnVer.Text = "Ver";
            this.btnVer.Width = 29;
            // 
            // btnModificar
            // 
            this.btnModificar.HeaderText = "Modificar";
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Width = 56;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Width = 49;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoDocumento, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 46);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnNuevoDocumento
            // 
            this.btnNuevoDocumento.Enabled = false;
            this.btnNuevoDocumento.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoDocumento.Name = "btnNuevoDocumento";
            this.btnNuevoDocumento.Size = new System.Drawing.Size(271, 40);
            this.btnNuevoDocumento.TabIndex = 8;
            this.btnNuevoDocumento.Text = "Cargar Documento";
            this.btnNuevoDocumento.UseVisualStyleBackColor = true;
            this.btnNuevoDocumento.Click += new System.EventHandler(this.btnNuevoDocumento_Click);
            // 
            // DocumentosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tlpEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentosCliente";
            this.Text = "Barrios Abogados SAS - Documentos Clientes";
            this.Load += new System.EventHandler(this.DocumentosCliente_Load);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblHojadeVida;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblConsultarCliente;
        private System.Windows.Forms.Label lblNumeroidentificacionCliente;
        private System.Windows.Forms.TextBox txtNumeroIdentificacionCliente;
        private System.Windows.Forms.Label lblPrimerNombreCliente;
        private System.Windows.Forms.TextBox txtPrimerNombreCliente;
        private System.Windows.Forms.Label lblSegundoNombreCliente;
        private System.Windows.Forms.TextBox txtSegundoNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimerApellidoCliente;
        private System.Windows.Forms.Label lblPrimerApellidoCliente;
        private System.Windows.Forms.TextBox txtSegundoApellidoCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevaBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNuevoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombreArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombeArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFechaSubido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFechaActualizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInformarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnVer;
        private System.Windows.Forms.DataGridViewButtonColumn btnModificar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}