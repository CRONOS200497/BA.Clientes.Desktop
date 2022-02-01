namespace BA.Clientes.Formularios
{
    partial class Tareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tareas));
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblHojadeVida = new System.Windows.Forms.Label();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblConsultarCliente = new System.Windows.Forms.Label();
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
            this.lblNumeroidentificacionCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbTipoTarea = new System.Windows.Forms.ComboBox();
            this.cbTarea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTipoTarea = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblAdjuntarArchivo = new System.Windows.Forms.Label();
            this.cbAdjuntar = new System.Windows.Forms.CheckBox();
            this.btnAdjuntarDocumento = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblFechaSeguimiento = new System.Windows.Forms.Label();
            this.lblFechaModificado = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCreado = new System.Windows.Forms.Label();
            this.lblModificado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeguimiento = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbNotificarCliente = new System.Windows.Forms.CheckBox();
            this.btnAdjunto = new System.Windows.Forms.Button();
            this.tlpEncabezado.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tlpEncabezado.TabIndex = 13;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(605, 26);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Barrios Abogados SAS - Registro y Seguimiento de Tareas";
            // 
            // lblHojadeVida
            // 
            this.lblHojadeVida.AutoSize = true;
            this.lblHojadeVida.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblHojadeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHojadeVida.Location = new System.Drawing.Point(3, 31);
            this.lblHojadeVida.Name = "lblHojadeVida";
            this.lblHojadeVida.Size = new System.Drawing.Size(287, 23);
            this.lblHojadeVida.TabIndex = 2;
            this.lblHojadeVida.Text = "Registro y Seguimiento de Tareas";
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.9242F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblConsultarCliente, 0, 0);
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
            this.tableLayoutPanel3.Controls.Add(this.lblNumeroidentificacionCliente, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1332, 60);
            this.tableLayoutPanel3.TabIndex = 15;
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
            // txtNumeroIdentificacionCliente
            // 
            this.txtNumeroIdentificacionCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumeroIdentificacionCliente.Location = new System.Drawing.Point(163, 34);
            this.txtNumeroIdentificacionCliente.Name = "txtNumeroIdentificacionCliente";
            this.txtNumeroIdentificacionCliente.Size = new System.Drawing.Size(160, 20);
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
            this.txtPrimerNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrimerNombreCliente.Location = new System.Drawing.Point(329, 34);
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
            this.txtSegundoNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSegundoNombreCliente.Location = new System.Drawing.Point(496, 34);
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
            this.txtPrimerApellidoCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrimerApellidoCliente.Location = new System.Drawing.Point(663, 34);
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
            this.txtSegundoApellidoCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSegundoApellidoCliente.Location = new System.Drawing.Point(830, 34);
            this.txtSegundoApellidoCliente.Name = "txtSegundoApellidoCliente";
            this.txtSegundoApellidoCliente.Size = new System.Drawing.Size(161, 20);
            this.txtSegundoApellidoCliente.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.Location = new System.Drawing.Point(998, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 20);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevaBusqueda
            // 
            this.btnNuevaBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevaBusqueda.Location = new System.Drawing.Point(1166, 34);
            this.btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            this.btnNuevaBusqueda.Size = new System.Drawing.Size(161, 20);
            this.btnNuevaBusqueda.TabIndex = 7;
            this.btnNuevaBusqueda.Text = "Nueva Busqueda";
            this.btnNuevaBusqueda.UseVisualStyleBackColor = true;
            this.btnNuevaBusqueda.Click += new System.EventHandler(this.btnNuevaBusqueda_Click);
            // 
            // lblNumeroidentificacionCliente
            // 
            this.lblNumeroidentificacionCliente.AutoSize = true;
            this.lblNumeroidentificacionCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroidentificacionCliente.Location = new System.Drawing.Point(163, 0);
            this.lblNumeroidentificacionCliente.Name = "lblNumeroidentificacionCliente";
            this.lblNumeroidentificacionCliente.Size = new System.Drawing.Size(160, 21);
            this.lblNumeroidentificacionCliente.TabIndex = 20;
            this.lblNumeroidentificacionCliente.Text = "No de identificación";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAdjunto);
            this.panel1.Controls.Add(this.cbNotificarCliente);
            this.panel1.Controls.Add(this.btnSeguimiento);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblModificado);
            this.panel1.Controls.Add(this.lblCreado);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblFechaModificado);
            this.panel1.Controls.Add(this.lblFechaSeguimiento);
            this.panel1.Controls.Add(this.lblNombreArchivo);
            this.panel1.Controls.Add(this.txtNombreArchivo);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.btnAdjuntarDocumento);
            this.panel1.Controls.Add(this.lblAdjuntarArchivo);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cbPrioridad);
            this.panel1.Controls.Add(this.lblPrioridad);
            this.panel1.Controls.Add(this.cbResponsable);
            this.panel1.Controls.Add(this.lblResponsable);
            this.panel1.Controls.Add(this.lblTarea);
            this.panel1.Controls.Add(this.lblTipoTarea);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.cbTarea);
            this.panel1.Controls.Add(this.cbTipoTarea);
            this.panel1.Controls.Add(this.cbArea);
            this.panel1.Controls.Add(this.cbAdjuntar);
            this.panel1.Location = new System.Drawing.Point(6, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 395);
            this.panel1.TabIndex = 16;
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(7, 42);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(316, 28);
            this.cbArea.TabIndex = 0;
            this.cbArea.SelectedValueChanged += new System.EventHandler(this.cbArea_SelectedValueChanged);
            // 
            // cbTipoTarea
            // 
            this.cbTipoTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTarea.FormattingEnabled = true;
            this.cbTipoTarea.Location = new System.Drawing.Point(8, 105);
            this.cbTipoTarea.Name = "cbTipoTarea";
            this.cbTipoTarea.Size = new System.Drawing.Size(315, 28);
            this.cbTipoTarea.TabIndex = 1;
            this.cbTipoTarea.SelectedValueChanged += new System.EventHandler(this.cbTipoTarea_SelectedValueChanged);
            // 
            // cbTarea
            // 
            this.cbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTarea.FormattingEnabled = true;
            this.cbTarea.Location = new System.Drawing.Point(8, 165);
            this.cbTarea.Name = "cbTarea";
            this.cbTarea.Size = new System.Drawing.Size(315, 28);
            this.cbTarea.TabIndex = 2;
            this.cbTarea.SelectedValueChanged += new System.EventHandler(this.cbTarea_SelectedValueChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(4, 18);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(45, 21);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Área";
            // 
            // lblTipoTarea
            // 
            this.lblTipoTarea.AutoSize = true;
            this.lblTipoTarea.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTarea.Location = new System.Drawing.Point(4, 81);
            this.lblTipoTarea.Name = "lblTipoTarea";
            this.lblTipoTarea.Size = new System.Drawing.Size(91, 21);
            this.lblTipoTarea.TabIndex = 14;
            this.lblTipoTarea.Text = "Tipo Tarea";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(3, 141);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(51, 21);
            this.lblTarea.TabIndex = 15;
            this.lblTarea.Text = "Tarea";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(3, 205);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(106, 21);
            this.lblResponsable.TabIndex = 21;
            this.lblResponsable.Text = "Responsable";
            // 
            // cbResponsable
            // 
            this.cbResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(8, 229);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(315, 28);
            this.cbResponsable.TabIndex = 22;
            this.cbResponsable.SelectedValueChanged += new System.EventHandler(this.cbResponsable_SelectedValueChanged);
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(4, 270);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(79, 21);
            this.lblPrioridad.TabIndex = 23;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Location = new System.Drawing.Point(8, 294);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(315, 28);
            this.cbPrioridad.TabIndex = 24;
            this.cbPrioridad.SelectedValueChanged += new System.EventHandler(this.cbPrioridad_SelectedValueChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(4, 335);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 21);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(8, 359);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(315, 28);
            this.cbEstado.TabIndex = 26;
            this.cbEstado.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblAdjuntarArchivo
            // 
            this.lblAdjuntarArchivo.AutoSize = true;
            this.lblAdjuntarArchivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjuntarArchivo.Location = new System.Drawing.Point(353, 40);
            this.lblAdjuntarArchivo.Name = "lblAdjuntarArchivo";
            this.lblAdjuntarArchivo.Size = new System.Drawing.Size(138, 21);
            this.lblAdjuntarArchivo.TabIndex = 27;
            this.lblAdjuntarArchivo.Text = "Adjuntar Archivo";
            // 
            // cbAdjuntar
            // 
            this.cbAdjuntar.AutoSize = true;
            this.cbAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdjuntar.Location = new System.Drawing.Point(356, 67);
            this.cbAdjuntar.Name = "cbAdjuntar";
            this.cbAdjuntar.Size = new System.Drawing.Size(289, 24);
            this.cbAdjuntar.TabIndex = 28;
            this.cbAdjuntar.Text = "Seleccione si desea adjuntar un PDF";
            this.cbAdjuntar.UseVisualStyleBackColor = true;
            this.cbAdjuntar.CheckedChanged += new System.EventHandler(this.cbAdjuntar_CheckedChanged);
            // 
            // btnAdjuntarDocumento
            // 
            this.btnAdjuntarDocumento.Enabled = false;
            this.btnAdjuntarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarDocumento.Location = new System.Drawing.Point(356, 97);
            this.btnAdjuntarDocumento.Name = "btnAdjuntarDocumento";
            this.btnAdjuntarDocumento.Size = new System.Drawing.Size(380, 36);
            this.btnAdjuntarDocumento.TabIndex = 30;
            this.btnAdjuntarDocumento.Text = "Adjuntar";
            this.btnAdjuntarDocumento.UseVisualStyleBackColor = true;
            this.btnAdjuntarDocumento.Click += new System.EventHandler(this.btnAdjuntarDocumento_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(352, 141);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(45, 21);
            this.lblRuta.TabIndex = 31;
            this.lblRuta.Text = "Ruta";
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(356, 165);
            this.txtRuta.Multiline = true;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(380, 28);
            this.txtRuta.TabIndex = 32;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Enabled = false;
            this.txtNombreArchivo.Location = new System.Drawing.Point(357, 229);
            this.txtNombreArchivo.Multiline = true;
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(379, 28);
            this.txtNombreArchivo.TabIndex = 34;
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(352, 205);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(135, 21);
            this.lblNombreArchivo.TabIndex = 35;
            this.lblNombreArchivo.Text = "Nombre Archivo";
            // 
            // lblFechaSeguimiento
            // 
            this.lblFechaSeguimiento.AutoSize = true;
            this.lblFechaSeguimiento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSeguimiento.Location = new System.Drawing.Point(353, 270);
            this.lblFechaSeguimiento.Name = "lblFechaSeguimiento";
            this.lblFechaSeguimiento.Size = new System.Drawing.Size(151, 21);
            this.lblFechaSeguimiento.TabIndex = 39;
            this.lblFechaSeguimiento.Text = "Fecha Seguimiento";
            // 
            // lblFechaModificado
            // 
            this.lblFechaModificado.AutoSize = true;
            this.lblFechaModificado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificado.Location = new System.Drawing.Point(353, 297);
            this.lblFechaModificado.Name = "lblFechaModificado";
            this.lblFechaModificado.Size = new System.Drawing.Size(206, 21);
            this.lblFechaModificado.TabIndex = 41;
            this.lblFechaModificado.Text = "Fecha Último Seguimiento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(791, 42);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(521, 215);
            this.txtDescripcion.TabIndex = 42;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(787, 18);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcion.TabIndex = 43;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.Location = new System.Drawing.Point(589, 270);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(19, 21);
            this.lblCreado.TabIndex = 44;
            this.lblCreado.Text = "1";
            this.lblCreado.Visible = false;
            // 
            // lblModificado
            // 
            this.lblModificado.AutoSize = true;
            this.lblModificado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificado.Location = new System.Drawing.Point(589, 297);
            this.lblModificado.Name = "lblModificado";
            this.lblModificado.Size = new System.Drawing.Size(147, 21);
            this.lblModificado.TabIndex = 45;
            this.lblModificado.Text = "Fecha Modificado";
            this.lblModificado.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(356, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 36);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Registrar Tarea";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeguimiento.Enabled = false;
            this.btnSeguimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.Location = new System.Drawing.Point(552, 335);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.Size = new System.Drawing.Size(184, 36);
            this.btnSeguimiento.TabIndex = 47;
            this.btnSeguimiento.Text = "Registrar Seguimiento";
            this.btnSeguimiento.UseVisualStyleBackColor = true;
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbNotificarCliente
            // 
            this.cbNotificarCliente.AutoSize = true;
            this.cbNotificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificarCliente.Location = new System.Drawing.Point(356, 13);
            this.cbNotificarCliente.Name = "cbNotificarCliente";
            this.cbNotificarCliente.Size = new System.Drawing.Size(338, 24);
            this.cbNotificarCliente.TabIndex = 48;
            this.cbNotificarCliente.Text = "Seleccione si desea informar al responsable";
            this.cbNotificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAdjunto
            // 
            this.btnAdjunto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdjunto.Enabled = false;
            this.btnAdjunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjunto.Location = new System.Drawing.Point(1129, 270);
            this.btnAdjunto.Name = "btnAdjunto";
            this.btnAdjunto.Size = new System.Drawing.Size(184, 36);
            this.btnAdjunto.TabIndex = 49;
            this.btnAdjunto.Text = "Ver Adjunto";
            this.btnAdjunto.UseVisualStyleBackColor = true;
            this.btnAdjunto.Click += new System.EventHandler(this.btnAdjunto_Click);
            // 
            // Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tlpEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tareas";
            this.Text = "Barrios Abogados SAS - Registro y Seguimiento de Tareas";
            this.Load += new System.EventHandler(this.Tareas_Load);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblHojadeVida;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblConsultarCliente;
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
        private System.Windows.Forms.Label lblNumeroidentificacionCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbTarea;
        private System.Windows.Forms.ComboBox cbTipoTarea;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblTipoTarea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblAdjuntarArchivo;
        private System.Windows.Forms.CheckBox cbAdjuntar;
        private System.Windows.Forms.Button btnAdjuntarDocumento;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblFechaSeguimiento;
        private System.Windows.Forms.Label lblFechaModificado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.Label lblModificado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeguimiento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbNotificarCliente;
        private System.Windows.Forms.Button btnAdjunto;
    }
}