namespace BA.Clientes.Formularios
{
    partial class RegistrarSeguimientoTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarSeguimientoTareas));
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblHojadeVida = new System.Windows.Forms.Label();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnSeguimiento = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbNotificarCliente = new System.Windows.Forms.CheckBox();
            this.lblModificado = new System.Windows.Forms.Label();
            this.lblCreado = new System.Windows.Forms.Label();
            this.lblFechaModificado = new System.Windows.Forms.Label();
            this.lblFechaSeguimiento = new System.Windows.Forms.Label();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnAdjuntarDocumento = new System.Windows.Forms.Button();
            this.lblAdjuntarArchivo = new System.Windows.Forms.Label();
            this.cbAdjuntar = new System.Windows.Forms.CheckBox();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.lblIdSolicitud = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tlpEncabezado.SuspendLayout();
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
            this.tlpEncabezado.TabIndex = 14;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(596, 26);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Barrios Abogados SAS - Registro Seguimientos de Tareas";
            // 
            // lblHojadeVida
            // 
            this.lblHojadeVida.AutoSize = true;
            this.lblHojadeVida.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblHojadeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHojadeVida.Location = new System.Drawing.Point(3, 31);
            this.lblHojadeVida.Name = "lblHojadeVida";
            this.lblHojadeVida.Size = new System.Drawing.Size(281, 23);
            this.lblHojadeVida.TabIndex = 2;
            this.lblHojadeVida.Text = "Registro Seguimientos de Tareas";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.btnSeguimiento);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cbNotificarCliente);
            this.panel1.Controls.Add(this.lblModificado);
            this.panel1.Controls.Add(this.lblCreado);
            this.panel1.Controls.Add(this.lblFechaModificado);
            this.panel1.Controls.Add(this.lblFechaSeguimiento);
            this.panel1.Controls.Add(this.lblNombreArchivo);
            this.panel1.Controls.Add(this.txtNombreArchivo);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.btnAdjuntarDocumento);
            this.panel1.Controls.Add(this.lblAdjuntarArchivo);
            this.panel1.Controls.Add(this.cbAdjuntar);
            this.panel1.Controls.Add(this.txtIdSolicitud);
            this.panel1.Controls.Add(this.lblIdSolicitud);
            this.panel1.Location = new System.Drawing.Point(6, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 358);
            this.panel1.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(405, 14);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcion.TabIndex = 65;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(409, 38);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(899, 180);
            this.txtDescripcion.TabIndex = 64;
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSeguimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.Location = new System.Drawing.Point(1124, 227);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.Size = new System.Drawing.Size(184, 36);
            this.btnSeguimiento.TabIndex = 63;
            this.btnSeguimiento.Text = "Guardar Seguimiento";
            this.btnSeguimiento.UseVisualStyleBackColor = true;
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(473, 232);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(380, 28);
            this.cbEstado.TabIndex = 62;
            this.cbEstado.SelectedValueChanged += new System.EventHandler(this.cbEstado_SelectedValueChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(405, 235);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 21);
            this.lblEstado.TabIndex = 61;
            this.lblEstado.Text = "Estado";
            // 
            // cbNotificarCliente
            // 
            this.cbNotificarCliente.AutoSize = true;
            this.cbNotificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificarCliente.Location = new System.Drawing.Point(7, 43);
            this.cbNotificarCliente.Name = "cbNotificarCliente";
            this.cbNotificarCliente.Size = new System.Drawing.Size(338, 24);
            this.cbNotificarCliente.TabIndex = 60;
            this.cbNotificarCliente.Text = "Seleccione si desea informar al responsable";
            this.cbNotificarCliente.UseVisualStyleBackColor = true;
            // 
            // lblModificado
            // 
            this.lblModificado.AutoSize = true;
            this.lblModificado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificado.Location = new System.Drawing.Point(213, 327);
            this.lblModificado.Name = "lblModificado";
            this.lblModificado.Size = new System.Drawing.Size(147, 21);
            this.lblModificado.TabIndex = 59;
            this.lblModificado.Text = "Fecha Modificado";
            this.lblModificado.Visible = false;
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.Location = new System.Drawing.Point(213, 290);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(19, 21);
            this.lblCreado.TabIndex = 58;
            this.lblCreado.Text = "1";
            this.lblCreado.Visible = false;
            // 
            // lblFechaModificado
            // 
            this.lblFechaModificado.AutoSize = true;
            this.lblFechaModificado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificado.Location = new System.Drawing.Point(3, 327);
            this.lblFechaModificado.Name = "lblFechaModificado";
            this.lblFechaModificado.Size = new System.Drawing.Size(164, 21);
            this.lblFechaModificado.TabIndex = 57;
            this.lblFechaModificado.Text = "Usuario Seguimiento";
            // 
            // lblFechaSeguimiento
            // 
            this.lblFechaSeguimiento.AutoSize = true;
            this.lblFechaSeguimiento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSeguimiento.Location = new System.Drawing.Point(4, 290);
            this.lblFechaSeguimiento.Name = "lblFechaSeguimiento";
            this.lblFechaSeguimiento.Size = new System.Drawing.Size(151, 21);
            this.lblFechaSeguimiento.TabIndex = 56;
            this.lblFechaSeguimiento.Text = "Fecha Seguimiento";
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(4, 235);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(135, 21);
            this.lblNombreArchivo.TabIndex = 55;
            this.lblNombreArchivo.Text = "Nombre Archivo";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Enabled = false;
            this.txtNombreArchivo.Location = new System.Drawing.Point(7, 259);
            this.txtNombreArchivo.Multiline = true;
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(381, 28);
            this.txtNombreArchivo.TabIndex = 54;
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(8, 190);
            this.txtRuta.Multiline = true;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(380, 28);
            this.txtRuta.TabIndex = 53;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(4, 166);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(45, 21);
            this.lblRuta.TabIndex = 52;
            this.lblRuta.Text = "Ruta";
            // 
            // btnAdjuntarDocumento
            // 
            this.btnAdjuntarDocumento.Enabled = false;
            this.btnAdjuntarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarDocumento.Location = new System.Drawing.Point(7, 127);
            this.btnAdjuntarDocumento.Name = "btnAdjuntarDocumento";
            this.btnAdjuntarDocumento.Size = new System.Drawing.Size(380, 36);
            this.btnAdjuntarDocumento.TabIndex = 51;
            this.btnAdjuntarDocumento.Text = "Adjuntar";
            this.btnAdjuntarDocumento.UseVisualStyleBackColor = true;
            this.btnAdjuntarDocumento.Click += new System.EventHandler(this.btnAdjuntarDocumento_Click);
            // 
            // lblAdjuntarArchivo
            // 
            this.lblAdjuntarArchivo.AutoSize = true;
            this.lblAdjuntarArchivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjuntarArchivo.Location = new System.Drawing.Point(4, 70);
            this.lblAdjuntarArchivo.Name = "lblAdjuntarArchivo";
            this.lblAdjuntarArchivo.Size = new System.Drawing.Size(138, 21);
            this.lblAdjuntarArchivo.TabIndex = 49;
            this.lblAdjuntarArchivo.Text = "Adjuntar Archivo";
            // 
            // cbAdjuntar
            // 
            this.cbAdjuntar.AutoSize = true;
            this.cbAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdjuntar.Location = new System.Drawing.Point(8, 97);
            this.cbAdjuntar.Name = "cbAdjuntar";
            this.cbAdjuntar.Size = new System.Drawing.Size(289, 24);
            this.cbAdjuntar.TabIndex = 50;
            this.cbAdjuntar.Text = "Seleccione si desea adjuntar un PDF";
            this.cbAdjuntar.UseVisualStyleBackColor = true;
            this.cbAdjuntar.CheckedChanged += new System.EventHandler(this.cbAdjuntar_CheckedChanged);
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Enabled = false;
            this.txtIdSolicitud.Location = new System.Drawing.Point(107, 14);
            this.txtIdSolicitud.Multiline = true;
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.Size = new System.Drawing.Size(271, 21);
            this.txtIdSolicitud.TabIndex = 35;
            // 
            // lblIdSolicitud
            // 
            this.lblIdSolicitud.AutoSize = true;
            this.lblIdSolicitud.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSolicitud.Location = new System.Drawing.Point(4, 14);
            this.lblIdSolicitud.Name = "lblIdSolicitud";
            this.lblIdSolicitud.Size = new System.Drawing.Size(97, 21);
            this.lblIdSolicitud.TabIndex = 34;
            this.lblIdSolicitud.Text = "Id Solicitud";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegistrarSeguimientoTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistrarSeguimientoTareas";
            this.Text = "Barrios Abogados SAS - Registro Seguimientos de Tareas";
            this.Load += new System.EventHandler(this.RegistrarSeguimientoTareas_Load);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblHojadeVida;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Label lblIdSolicitud;
        private System.Windows.Forms.CheckBox cbNotificarCliente;
        private System.Windows.Forms.Label lblModificado;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.Label lblFechaModificado;
        private System.Windows.Forms.Label lblFechaSeguimiento;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnAdjuntarDocumento;
        private System.Windows.Forms.Label lblAdjuntarArchivo;
        private System.Windows.Forms.CheckBox cbAdjuntar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnSeguimiento;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}