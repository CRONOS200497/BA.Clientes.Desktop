namespace BA.Clientes.Formularios
{
    partial class GestionFamiliares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionFamiliares));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarFamiliar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblConsultarFamiliar = new System.Windows.Forms.Label();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscarFamiliarPorCliente = new System.Windows.Forms.Button();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.23831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.76169F));
            this.tableLayoutPanel1.Controls.Add(this.dtFechaHoy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmpresa, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtFechaHoy
            // 
            this.dtFechaHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaHoy.Enabled = false;
            this.dtFechaHoy.Location = new System.Drawing.Point(1123, 3);
            this.dtFechaHoy.Name = "dtFechaHoy";
            this.dtFechaHoy.Size = new System.Drawing.Size(200, 20);
            this.dtFechaHoy.TabIndex = 91;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(488, 26);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Barrios Abogados SAS - Gestión de Familiares";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 126);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1323, 591);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1317, 585);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 611F));
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarFamiliar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEditar, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblConsultarFamiliar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtConsultaCliente, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BtnBuscarFamiliarPorCliente, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarTodos, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.03604F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1326, 62);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnBuscarFamiliar
            // 
            this.btnBuscarFamiliar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarFamiliar.Location = new System.Drawing.Point(187, 34);
            this.btnBuscarFamiliar.Name = "btnBuscarFamiliar";
            this.btnBuscarFamiliar.Size = new System.Drawing.Size(177, 23);
            this.btnBuscarFamiliar.TabIndex = 1;
            this.btnBuscarFamiliar.Text = "Buscar Familiar";
            this.btnBuscarFamiliar.UseVisualStyleBackColor = true;
            this.btnBuscarFamiliar.Click += new System.EventHandler(this.btnBuscarFamiliar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(738, 34);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(177, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // lblConsultarFamiliar
            // 
            this.lblConsultarFamiliar.AutoSize = true;
            this.lblConsultarFamiliar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarFamiliar.Location = new System.Drawing.Point(3, 0);
            this.lblConsultarFamiliar.Name = "lblConsultarFamiliar";
            this.lblConsultarFamiliar.Size = new System.Drawing.Size(166, 22);
            this.lblConsultarFamiliar.TabIndex = 0;
            this.lblConsultarFamiliar.Text = "Consultar Familiar";
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConsultaCliente.Location = new System.Drawing.Point(3, 35);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(177, 20);
            this.txtConsultaCliente.TabIndex = 0;
            // 
            // BtnBuscarFamiliarPorCliente
            // 
            this.BtnBuscarFamiliarPorCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBuscarFamiliarPorCliente.Location = new System.Drawing.Point(371, 34);
            this.BtnBuscarFamiliarPorCliente.Name = "BtnBuscarFamiliarPorCliente";
            this.BtnBuscarFamiliarPorCliente.Size = new System.Drawing.Size(177, 23);
            this.BtnBuscarFamiliarPorCliente.TabIndex = 2;
            this.BtnBuscarFamiliarPorCliente.Text = "Buscar Familiares por Cliente";
            this.BtnBuscarFamiliarPorCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarFamiliarPorCliente.Click += new System.EventHandler(this.BtnBuscarFamiliarPorCliente_Click);
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarTodos.Location = new System.Drawing.Point(555, 34);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(177, 23);
            this.btnBuscarTodos.TabIndex = 3;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // GestionFamiliares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionFamiliares";
            this.Text = "Barrios Abogados SAS - Consultar Familiares";
            this.Load += new System.EventHandler(this.GestionFamiliares_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.DateTimePicker dtFechaHoy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblConsultarFamiliar;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.Button BtnBuscarFamiliarPorCliente;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscarFamiliar;
    }
}