namespace BA.Clientes.Formularios
{
    partial class VerDocumentosRegistroTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerDocumentosRegistroTarea));
            this.tlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblVerDocumentosClientes = new System.Windows.Forms.Label();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VisualizarPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tlpEncabezado.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarPDF1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tlpEncabezado.Controls.Add(this.lblVerDocumentosClientes, 0, 1);
            this.tlpEncabezado.Controls.Add(this.dtFechaHoy, 1, 0);
            this.tlpEncabezado.Location = new System.Drawing.Point(6, 12);
            this.tlpEncabezado.Name = "tlpEncabezado";
            this.tlpEncabezado.RowCount = 2;
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezado.Size = new System.Drawing.Size(1332, 63);
            this.tlpEncabezado.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(560, 26);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Barrios Abogados SAS -   Ver Adjunto Registro Tarea";
            // 
            // lblVerDocumentosClientes
            // 
            this.lblVerDocumentosClientes.AutoSize = true;
            this.lblVerDocumentosClientes.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblVerDocumentosClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVerDocumentosClientes.Location = new System.Drawing.Point(3, 31);
            this.lblVerDocumentosClientes.Name = "lblVerDocumentosClientes";
            this.lblVerDocumentosClientes.Size = new System.Drawing.Size(242, 23);
            this.lblVerDocumentosClientes.TabIndex = 2;
            this.lblVerDocumentosClientes.Text = " Ver Adjunto Registro Tarea";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.VisualizarPDF1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 579);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // VisualizarPDF1
            // 
            this.VisualizarPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualizarPDF1.Enabled = true;
            this.VisualizarPDF1.Location = new System.Drawing.Point(3, 3);
            this.VisualizarPDF1.Name = "VisualizarPDF1";
            this.VisualizarPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VisualizarPDF1.OcxState")));
            this.VisualizarPDF1.Size = new System.Drawing.Size(1326, 573);
            this.VisualizarPDF1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnImprimir, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 666);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1332, 51);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(1055, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(274, 45);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // VerDocumentosRegistroTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerDocumentosRegistroTarea";
            this.Text = "Barrios Abogados SAS - Ver Adjunto Registro Tarea";
            this.Load += new System.EventHandler(this.VerDocumentosRegistroTarea_Load);
            this.tlpEncabezado.ResumeLayout(false);
            this.tlpEncabezado.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarPDF1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEncabezado;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblVerDocumentosClientes;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxAcroPDFLib.AxAcroPDF VisualizarPDF1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnImprimir;
    }
}