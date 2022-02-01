namespace BA.Clientes.Formularios
{
    partial class HistorialSeguimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialSeguimientos));
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblHojadeVida = new System.Windows.Forms.Label();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdSolicitud = new System.Windows.Forms.Label();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_Seguimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notificar_Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Seguimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerAdjunto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpEncabezado.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tlpEncabezado.TabIndex = 14;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(473, 26);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Barrios Abogados SAS - Seguimientos Tareas";
            // 
            // lblHojadeVida
            // 
            this.lblHojadeVida.AutoSize = true;
            this.lblHojadeVida.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblHojadeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHojadeVida.Location = new System.Drawing.Point(3, 31);
            this.lblHojadeVida.Name = "lblHojadeVida";
            this.lblHojadeVida.Size = new System.Drawing.Size(181, 23);
            this.lblHojadeVida.TabIndex = 2;
            this.lblHojadeVida.Text = "Seguimientos Tareas";
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
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtIdSolicitud);
            this.panel1.Controls.Add(this.lblIdSolicitud);
            this.panel1.Location = new System.Drawing.Point(6, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 481);
            this.panel1.TabIndex = 15;
            // 
            // lblIdSolicitud
            // 
            this.lblIdSolicitud.AutoSize = true;
            this.lblIdSolicitud.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSolicitud.Location = new System.Drawing.Point(6, 13);
            this.lblIdSolicitud.Name = "lblIdSolicitud";
            this.lblIdSolicitud.Size = new System.Drawing.Size(97, 21);
            this.lblIdSolicitud.TabIndex = 14;
            this.lblIdSolicitud.Text = "Id Solicitud";
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Enabled = false;
            this.txtIdSolicitud.Location = new System.Drawing.Point(109, 13);
            this.txtIdSolicitud.Multiline = true;
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.Size = new System.Drawing.Size(168, 21);
            this.txtIdSolicitud.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Seguimiento,
            this.idSolicitud,
            this.Descripcion,
            this.Adjunto,
            this.Nombre_Archivo,
            this.Notificar_Responsable,
            this.Estado,
            this.Fecha_Seguimiento,
            this.Usu,
            this.VerAdjunto});
            this.dataGridView1.Location = new System.Drawing.Point(8, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1308, 426);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_Seguimiento
            // 
            this.id_Seguimiento.HeaderText = "Id Seguimiento";
            this.id_Seguimiento.Name = "id_Seguimiento";
            this.id_Seguimiento.Width = 102;
            // 
            // idSolicitud
            // 
            this.idSolicitud.HeaderText = "Id Solicitud";
            this.idSolicitud.Name = "idSolicitud";
            this.idSolicitud.Width = 84;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 88;
            // 
            // Adjunto
            // 
            this.Adjunto.HeaderText = "Adjunto";
            this.Adjunto.Name = "Adjunto";
            this.Adjunto.Width = 68;
            // 
            // Nombre_Archivo
            // 
            this.Nombre_Archivo.HeaderText = "Nombre Archivo";
            this.Nombre_Archivo.Name = "Nombre_Archivo";
            this.Nombre_Archivo.Width = 108;
            // 
            // Notificar_Responsable
            // 
            this.Notificar_Responsable.HeaderText = "Notificar Responsable";
            this.Notificar_Responsable.Name = "Notificar_Responsable";
            this.Notificar_Responsable.Width = 136;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 65;
            // 
            // Fecha_Seguimiento
            // 
            this.Fecha_Seguimiento.HeaderText = "Fecha Seguimiento";
            this.Fecha_Seguimiento.Name = "Fecha_Seguimiento";
            this.Fecha_Seguimiento.Width = 123;
            // 
            // Usu
            // 
            this.Usu.HeaderText = "Usuario";
            this.Usu.Name = "Usu";
            this.Usu.Width = 68;
            // 
            // VerAdjunto
            // 
            this.VerAdjunto.HeaderText = "Ver Adjunto";
            this.VerAdjunto.Name = "VerAdjunto";
            this.VerAdjunto.Width = 68;
            // 
            // HistorialSeguimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistorialSeguimientos";
            this.Text = "Barrios Abogados SAS - Seguimientos Tareas";
            this.Load += new System.EventHandler(this.HistorialSeguimientos_Load);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblHojadeVida;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdSolicitud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Seguimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notificar_Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Seguimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu;
        private System.Windows.Forms.DataGridViewButtonColumn VerAdjunto;
    }
}