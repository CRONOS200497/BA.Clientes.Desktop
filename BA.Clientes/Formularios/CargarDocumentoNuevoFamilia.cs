using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BA.Controllers.Controllers;
using BA.Models.Entidades;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;

namespace BA.Clientes.Formularios
{
    public partial class CargarDocumentoNuevoFamilia : Form
    {
        public string numero_documento;

        FamiliaController Familiar = new FamiliaController();
        DocumentosFamiliaresController TipoDocumento = new DocumentosFamiliaresController();
        DocumentosCargadosFamiliaresController CargarDocumentos = new DocumentosCargadosFamiliaresController();
        ParametrosControllers Parametros = new ParametrosControllers();
        DocumentosCargadosFamiliaViews EntidadDocumentos = new DocumentosCargadosFamiliaViews();
        public int Perfil_Rol;
        public string Usuario;

        public CargarDocumentoNuevoFamilia(string numero_documento, int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            txtDocumentoFamiliar.Text = numero_documento;
            txtDocumentoFamiliar.Enabled = false;
            CargarTipoDocumentos();

        }

        int value_tipo_documento = 0;
        string tipo_documento = string.Empty;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int numero_archivo = 0;

        private void CargarTipoDocumentos()
        {
            var Load_TipoDocumentos = TipoDocumento.ConsultarDocumentosFamilia();
            cbTipoDocumento.DisplayMember = "Nombre_Documento_Familia";
            cbTipoDocumento.ValueMember = "id_documento_Familia";
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.DataSource = Load_TipoDocumentos;

        }

        private void btnAdjuntarDocumento_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Pdf Files|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
                string año = DateTime.Now.Year.ToString();
                string mes = DateTime.Now.Month.ToString();
                string dia = DateTime.Now.Day.ToString();
                string documentos = tipo_documento;
                txtNombreArchivo.Text = txtDocumentoFamiliar.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
                cbTipoDocumento.Enabled = false;
            }
        }

        private void cbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            value_tipo_documento = Convert.ToInt32(cbTipoDocumento.SelectedValue);
            tipo_documento = Convert.ToString(TipoDocumento.MostrarTipoDocumentoFamiliaNombre(value_tipo_documento));
        }

        private void CopyFile(string origen, string destino)
        {
            //byte[] bt = new byte[1048756];
            int bufferSize = 1024 * 1024;

            using (FileStream fileStream = new FileStream(destino, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                FileStream fs = new FileStream(origen, FileMode.Open, FileAccess.ReadWrite);
                fileStream.SetLength(fs.Length);
                int bytesRead = -1;
                byte[] bytes = new byte[bufferSize];

                while ((bytesRead = fs.Read(bytes, 0, bufferSize)) > 0)
                {
                    fileStream.Write(bytes, 0, bytesRead);
                }
                fs.Dispose();
            }
        }

        public void guardar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RutaDocumentosFamilia");
            string Ruta_Diaria = Ruta_Original + Convert.ToString(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            string documentos = string.Empty;
            string validar_archivo = string.Empty;
            string año = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            string dia = DateTime.Now.Day.ToString();
            documentos = tipo_documento;
            validar_archivo = Ruta_Diaria + "\\" + txtDocumentoFamiliar.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";

            bool validar_guardado = false;

            if (System.IO.Directory.Exists(Ruta_Original))
            {
                if (System.IO.Directory.Exists(Ruta_Diaria))
                {

                }
                else
                {
                    if (Ruta_Diaria.Length > 0)
                    {
                        System.IO.Directory.CreateDirectory(Ruta_Diaria);
                    }
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(Ruta_Original);
                if (System.IO.Directory.Exists(Ruta_Diaria))
                {

                }
                else
                {
                    if (Ruta_Diaria.Length > 0)
                    {
                        System.IO.Directory.CreateDirectory(Ruta_Diaria);
                    }
                }
            }
            while (File.Exists(validar_archivo))
            {
                numero_archivo = numero_archivo + 1;
                validar_archivo = string.Empty;
                validar_archivo = Ruta_Diaria + "\\" + txtDocumentoFamiliar.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
            }

            CopyFile(txtRuta.Text, validar_archivo);
            EntidadDocumentos.doc_cliente = txtDocumentoFamiliar.Text;
            EntidadDocumentos.tipo_doc = tipo_documento;
            EntidadDocumentos.nombre_archivo = txtNombreArchivo.Text;
            EntidadDocumentos.ruta = validar_archivo;
            EntidadDocumentos.fecha_subido = DateTime.Now;
            EntidadDocumentos.fecha_actualizado = DateTime.Now;
            EntidadDocumentos.informar_cliente = Convert.ToBoolean(cbNotificarFamiliar.CheckState);
            EntidadDocumentos.usuario = Usuario_Login;
            validar_guardado = CargarDocumentos.GuardarDocumentosFamilia(EntidadDocumentos);
            if (validar_guardado == true)
            {
                lblFechaCargado.Visible = true;
                lblFechaLoad.Text = EntidadDocumentos.fecha_subido.ToString();
                lblFechaLoad.Visible = true;
                lblSubidoPor.Visible = true;
                lblusuario.Text = EntidadDocumentos.usuario;
                lblusuario.Visible = true;
                MessageBox.Show("El documento ha sido cargado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El documento no pudo ser cargado, por favor verifique la información y oprima guardar");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text.Length > 0)
            {
                guardar();
            }
            else
            {
                MessageBox.Show("Debe adjuntar el tipo de documento seleccionado.");
                return;
            }

        }

        private void CargarDocumentoNuevoFamilia_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
