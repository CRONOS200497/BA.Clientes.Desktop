namespace BA.Clientes.Formularios
{
    partial class Dispensarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispensarios));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblValorModificar = new System.Windows.Forms.Label();
            this.txtIdBatallon = new System.Windows.Forms.TextBox();
            this.txtNombreDispensario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDispensario = new System.Windows.Forms.Label();
            this.lblIdDispensario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clIdBatallon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombreBatallon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFuerza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbFuerza = new System.Windows.Forms.ComboBox();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblValorModificar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblValorModificar
            // 
            this.lblValorModificar.AutoSize = true;
            this.lblValorModificar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorModificar.Location = new System.Drawing.Point(3, 0);
            this.lblValorModificar.Name = "lblValorModificar";
            this.lblValorModificar.Size = new System.Drawing.Size(570, 26);
            this.lblValorModificar.TabIndex = 8;
            this.lblValorModificar.Text = "Barrios Abogados SAS - Parametrizacion Dispensarios";
            // 
            // txtIdBatallon
            // 
            this.txtIdBatallon.Enabled = false;
            this.txtIdBatallon.Location = new System.Drawing.Point(18, 39);
            this.txtIdBatallon.Name = "txtIdBatallon";
            this.txtIdBatallon.Size = new System.Drawing.Size(100, 20);
            this.txtIdBatallon.TabIndex = 1;
            // 
            // txtNombreDispensario
            // 
            this.txtNombreDispensario.Location = new System.Drawing.Point(149, 39);
            this.txtNombreDispensario.Name = "txtNombreDispensario";
            this.txtNombreDispensario.Size = new System.Drawing.Size(497, 20);
            this.txtNombreDispensario.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDispensario);
            this.panel1.Controls.Add(this.lblIdDispensario);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbFuerza);
            this.panel1.Controls.Add(this.lblFuerza);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.txtIdBatallon);
            this.panel1.Controls.Add(this.txtNombreDispensario);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 615);
            this.panel1.TabIndex = 5;
            // 
            // lblDispensario
            // 
            this.lblDispensario.AutoSize = true;
            this.lblDispensario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispensario.Location = new System.Drawing.Point(145, 16);
            this.lblDispensario.Name = "lblDispensario";
            this.lblDispensario.Size = new System.Drawing.Size(153, 20);
            this.lblDispensario.TabIndex = 16;
            this.lblDispensario.Text = "Nombre Dispensario";
            // 
            // lblIdDispensario
            // 
            this.lblIdDispensario.AutoSize = true;
            this.lblIdDispensario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDispensario.Location = new System.Drawing.Point(14, 16);
            this.lblIdDispensario.Name = "lblIdDispensario";
            this.lblIdDispensario.Size = new System.Drawing.Size(111, 20);
            this.lblIdDispensario.TabIndex = 15;
            this.lblIdDispensario.Text = "Id Dispensario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdBatallon,
            this.clNombreBatallon,
            this.clFuerza,
            this.clEstado});
            this.dataGridView1.Location = new System.Drawing.Point(18, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(628, 431);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // clIdBatallon
            // 
            this.clIdBatallon.HeaderText = "Id Dispensario";
            this.clIdBatallon.Name = "clIdBatallon";
            this.clIdBatallon.ReadOnly = true;
            this.clIdBatallon.Width = 99;
            // 
            // clNombreBatallon
            // 
            this.clNombreBatallon.HeaderText = "Nombre Dispensario";
            this.clNombreBatallon.Name = "clNombreBatallon";
            this.clNombreBatallon.ReadOnly = true;
            this.clNombreBatallon.Width = 127;
            // 
            // clFuerza
            // 
            this.clFuerza.HeaderText = "Fuerza";
            this.clFuerza.Name = "clFuerza";
            this.clFuerza.ReadOnly = true;
            this.clFuerza.Width = 64;
            // 
            // clEstado
            // 
            this.clEstado.HeaderText = "Estado";
            this.clEstado.Name = "clEstado";
            this.clEstado.ReadOnly = true;
            this.clEstado.Width = 65;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(286, 570);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 30);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(408, 570);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 30);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(530, 570);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.txtGuardar_Click);
            // 
            // cbFuerza
            // 
            this.cbFuerza.FormattingEnabled = true;
            this.cbFuerza.Location = new System.Drawing.Point(149, 95);
            this.cbFuerza.Name = "cbFuerza";
            this.cbFuerza.Size = new System.Drawing.Size(225, 21);
            this.cbFuerza.TabIndex = 10;
            this.cbFuerza.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuerza.Location = new System.Drawing.Point(145, 72);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(59, 20);
            this.lblFuerza.TabIndex = 9;
            this.lblFuerza.Text = "Fuerza";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(417, 72);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(421, 95);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(225, 21);
            this.cbEstado.TabIndex = 7;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // Dispensarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dispensarios";
            this.Text = "Barrios Abogados SAS - Parametrizacion Dispensarios";
            this.Load += new System.EventHandler(this.Dispensarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblValorModificar;
        private System.Windows.Forms.TextBox txtIdBatallon;
        private System.Windows.Forms.TextBox txtNombreDispensario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbFuerza;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIdDispensario;
        private System.Windows.Forms.Label lblDispensario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdBatallon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombreBatallon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFuerza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstado;
    }
}