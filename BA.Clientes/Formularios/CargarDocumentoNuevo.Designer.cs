namespace BA.Clientes.Formularios
{
    partial class CargarDocumentoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarDocumentoNuevo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHojadeVida = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.lblDocumentoCliente = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAdjuntarDocumento = new System.Windows.Forms.Button();
            this.lblSubidoPor = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblFechaLoad = new System.Windows.Forms.Label();
            this.lblFechaCargado = new System.Windows.Forms.Label();
            this.lblNotificarCliente = new System.Windows.Forms.Label();
            this.cbNotificarCliente = new System.Windows.Forms.CheckBox();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86842F));
            this.tableLayoutPanel1.Controls.Add(this.lblHojadeVida, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEmpresa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtFechaHoy, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHojadeVida
            // 
            this.lblHojadeVida.AutoSize = true;
            this.lblHojadeVida.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblHojadeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHojadeVida.Location = new System.Drawing.Point(3, 35);
            this.lblHojadeVida.Name = "lblHojadeVida";
            this.lblHojadeVida.Size = new System.Drawing.Size(270, 23);
            this.lblHojadeVida.TabIndex = 92;
            this.lblHojadeVida.Text = "Documentos Clientes - Familia";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(345, 35);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Barrios Abogados SAS - Cargar Documentos Clientes";
            // 
            // dtFechaHoy
            // 
            this.dtFechaHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaHoy.Enabled = false;
            this.dtFechaHoy.Location = new System.Drawing.Point(557, 3);
            this.dtFechaHoy.Name = "dtFechaHoy";
            this.dtFechaHoy.Size = new System.Drawing.Size(200, 20);
            this.dtFechaHoy.TabIndex = 91;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.7619F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.23809F));
            this.tableLayoutPanel2.Controls.Add(this.txtDocumentoCliente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDocumentoCliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCargar, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnAdjuntarDocumento, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSubidoPor, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblusuario, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblFechaLoad, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblFechaCargado, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblNotificarCliente, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbNotificarCliente, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblNombreArchivo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtNombreArchivo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblRuta, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtRuta, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTipoDocumento, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbTipoDocumento, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.023411F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 199);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Enabled = false;
            this.txtDocumentoCliente.Location = new System.Drawing.Point(238, 3);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(333, 20);
            this.txtDocumentoCliente.TabIndex = 0;
            // 
            // lblDocumentoCliente
            // 
            this.lblDocumentoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentoCliente.AutoSize = true;
            this.lblDocumentoCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoCliente.Location = new System.Drawing.Point(79, 0);
            this.lblDocumentoCliente.Name = "lblDocumentoCliente";
            this.lblDocumentoCliente.Size = new System.Drawing.Size(153, 21);
            this.lblDocumentoCliente.TabIndex = 27;
            this.lblDocumentoCliente.Text = "Documento Cliente";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(578, 153);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(179, 37);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAdjuntarDocumento
            // 
            this.btnAdjuntarDocumento.Location = new System.Drawing.Point(578, 29);
            this.btnAdjuntarDocumento.Name = "btnAdjuntarDocumento";
            this.btnAdjuntarDocumento.Size = new System.Drawing.Size(179, 20);
            this.btnAdjuntarDocumento.TabIndex = 2;
            this.btnAdjuntarDocumento.Text = "Adjuntar";
            this.btnAdjuntarDocumento.UseVisualStyleBackColor = true;
            this.btnAdjuntarDocumento.Click += new System.EventHandler(this.btnAdjuntarDocumento_Click);
            // 
            // lblSubidoPor
            // 
            this.lblSubidoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubidoPor.AutoSize = true;
            this.lblSubidoPor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubidoPor.Location = new System.Drawing.Point(136, 150);
            this.lblSubidoPor.Name = "lblSubidoPor";
            this.lblSubidoPor.Size = new System.Drawing.Size(96, 21);
            this.lblSubidoPor.TabIndex = 13;
            this.lblSubidoPor.Text = "Subido Por";
            this.lblSubidoPor.Visible = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(238, 150);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(0, 21);
            this.lblusuario.TabIndex = 26;
            this.lblusuario.Visible = false;
            // 
            // lblFechaLoad
            // 
            this.lblFechaLoad.AutoSize = true;
            this.lblFechaLoad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLoad.Location = new System.Drawing.Point(238, 128);
            this.lblFechaLoad.Name = "lblFechaLoad";
            this.lblFechaLoad.Size = new System.Drawing.Size(0, 21);
            this.lblFechaLoad.TabIndex = 25;
            this.lblFechaLoad.Visible = false;
            // 
            // lblFechaCargado
            // 
            this.lblFechaCargado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCargado.AutoSize = true;
            this.lblFechaCargado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCargado.Location = new System.Drawing.Point(108, 128);
            this.lblFechaCargado.Name = "lblFechaCargado";
            this.lblFechaCargado.Size = new System.Drawing.Size(124, 21);
            this.lblFechaCargado.TabIndex = 11;
            this.lblFechaCargado.Text = "Fecha Cargado";
            this.lblFechaCargado.Visible = false;
            // 
            // lblNotificarCliente
            // 
            this.lblNotificarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificarCliente.AutoSize = true;
            this.lblNotificarCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificarCliente.Location = new System.Drawing.Point(101, 102);
            this.lblNotificarCliente.Name = "lblNotificarCliente";
            this.lblNotificarCliente.Size = new System.Drawing.Size(131, 21);
            this.lblNotificarCliente.TabIndex = 12;
            this.lblNotificarCliente.Text = "Notificar Cliente";
            // 
            // cbNotificarCliente
            // 
            this.cbNotificarCliente.AutoSize = true;
            this.cbNotificarCliente.Location = new System.Drawing.Point(238, 105);
            this.cbNotificarCliente.Name = "cbNotificarCliente";
            this.cbNotificarCliente.Size = new System.Drawing.Size(206, 17);
            this.cbNotificarCliente.TabIndex = 5;
            this.cbNotificarCliente.Text = "Seleccione si desea informar al cliente";
            this.cbNotificarCliente.UseVisualStyleBackColor = true;
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(97, 77);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(135, 21);
            this.lblNombreArchivo.TabIndex = 10;
            this.lblNombreArchivo.Text = "Nombre Archivo";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Enabled = false;
            this.txtNombreArchivo.Location = new System.Drawing.Point(238, 80);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(333, 20);
            this.txtNombreArchivo.TabIndex = 4;
            // 
            // lblRuta
            // 
            this.lblRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(187, 52);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(45, 21);
            this.lblRuta.TabIndex = 9;
            this.lblRuta.Text = "Ruta";
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(238, 55);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(333, 20);
            this.txtRuta.TabIndex = 3;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(95, 26);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(137, 21);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(238, 29);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(333, 21);
            this.cbTipoDocumento.TabIndex = 1;
            this.cbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cbTipoDocumento_SelectedValueChanged);
            // 
            // CargarDocumentoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 298);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CargarDocumentoNuevo";
            this.Text = "Barrios Abogados SAS - Cargar Documento Nuevo";
            this.Load += new System.EventHandler(this.CargarDocumentoNuevo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.Label lblHojadeVida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblFechaCargado;
        private System.Windows.Forms.Label lblNotificarCliente;
        private System.Windows.Forms.Label lblSubidoPor;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnAdjuntarDocumento;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.CheckBox cbNotificarCliente;
        private System.Windows.Forms.Label lblFechaLoad;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label lblDocumentoCliente;
    }
}