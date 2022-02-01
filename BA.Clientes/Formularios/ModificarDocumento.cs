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
    public partial class ModificarDocumento : Form
    {
        public string numero_documento;
        ClientesController Negocio = new ClientesController();
        DocumentosClientesController TipoDocumento = new DocumentosClientesController();
        DocumentosCargadosController CargarDocumentos = new DocumentosCargadosController();
        ParametrosControllers Parametros = new ParametrosControllers();
        DocumentosCargadosViews EntidadDocumentos = new DocumentosCargadosViews();
        public int id_archivo;
        public int Id_Perfil;
        public string Usuario;

        public ModificarDocumento(int id_archivo, int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            CargarDocumentoCargado(id_archivo);
            CargarOpcionesModificar();
        }

        int value_tipo_documento = 0;
        string tipo_documento = string.Empty;
        string ruta_documento_eliminar = string.Empty;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        string usuario_Creador;
        int numero_archivo = 0;

        private void CargarOpcionesModificar()
        {
            cbListasModificar.Items.Add("Tipo Documento");
            cbListasModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarDocumentoCargado(int value)
        {
            var load_Documento_Cargado = CargarDocumentos.ConsultarDocumentoClienteID(value);

            foreach (var c in load_Documento_Cargado)
            {
                ruta_documento_eliminar = c.ruta;
                lblIdArchivo.Text = Convert.ToString(c.id_Archivo);
                txtDocumentoCliente.Text = c.doc_cliente;
                tipo_documento = c.tipo_doc;
                CargarTipoDocumentoGenerado(tipo_documento);
                txtRuta.Text = "";
                txtNombreArchivo.Text = c.nombre_archivo;
                cbNotificarCliente.Checked = c.informar_cliente;
                lblFechaLoad.Text = Convert.ToString(c.fecha_subido);
                usuario_Creador = c.usuario;
                lblusuario.Text = usuario_Creador;
            }
        }

        private void CargarTipoDocumentoGenerado(string tipo_documento)
        {
            var Load_TipoDocumentos = TipoDocumento.MostrarDocumentosClientesValue(tipo_documento);
            cbTipoDocumento.DisplayMember = "Nombre_Documento";
            cbTipoDocumento.ValueMember = "id_documento";
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.DataSource = Load_TipoDocumentos;
            cbTipoDocumento.Enabled = false;
        }

        private void CargarTipoDocumentos()
        {
            var Load_TipoDocumentos = TipoDocumento.ConsultarDocumentosClientes();
            cbTipoDocumento.DisplayMember = "Nombre_Documento";
            cbTipoDocumento.ValueMember = "id_documento";
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.DataSource = Load_TipoDocumentos;
            cbTipoDocumento.Enabled = true;
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
                txtNombreArchivo.Text = txtDocumentoCliente.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
                cbTipoDocumento.Enabled = false;
            }
        }

        private void cbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            value_tipo_documento = Convert.ToInt32(cbTipoDocumento.SelectedValue);
            tipo_documento = Convert.ToString(TipoDocumento.MostrarTipoDocumentoClientesNombre(value_tipo_documento));
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
            string Ruta_Original = Parametros.MostrarParametro("RutaDocumentosClientes");
            string Ruta_Diaria = Ruta_Original + Convert.ToString(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            string documentos = string.Empty;
            string validar_archivo = string.Empty;
            string año = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            string dia = DateTime.Now.Day.ToString();
            documentos = tipo_documento;
            validar_archivo = Ruta_Diaria + "\\" + txtDocumentoCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";

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
                validar_archivo = Ruta_Diaria + "\\" + txtDocumentoCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
            }

            CopyFile(txtRuta.Text, validar_archivo);
            EntidadDocumentos.id_Archivo = Convert.ToInt32(lblIdArchivo.Text);
            EntidadDocumentos.doc_cliente = txtDocumentoCliente.Text;
            EntidadDocumentos.tipo_doc = tipo_documento;
            EntidadDocumentos.nombre_archivo = txtNombreArchivo.Text;
            EntidadDocumentos.ruta = validar_archivo;
            EntidadDocumentos.fecha_subido = Convert.ToDateTime(lblFechaLoad.Text);
            EntidadDocumentos.fecha_actualizado = DateTime.Now;
            EntidadDocumentos.informar_cliente = Convert.ToBoolean(cbNotificarCliente.CheckState);
            EntidadDocumentos.usuario = usuario_Creador;
            validar_guardado = CargarDocumentos.ModificarDocumentosClientes(EntidadDocumentos);
            if (validar_guardado == true)
            {
                lblFechaActualizacion.Visible = true;
                lblActualizado.Text = EntidadDocumentos.fecha_actualizado.ToString();
                lblActualizado.Visible = true;
                MessageBox.Show("El documento ha sido actualizado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El documento no pudo ser actualizado, por favor verifique la información y oprima guardar");
            }
        }

        private void cbListasModificar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbListasModificar.SelectedItem != null)
            {

                if (cbListasModificar.SelectedItem.Equals("Tipo Documento"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarTipoDocumentos();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opción valida");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtRuta.Text))
            {
                DialogResult Confirmar_Cierre_Archivo = MessageBox.Show("Antes de modificar el documento, recuerde que debe estar cerrado.", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                if (Confirmar_Cierre_Archivo == DialogResult.OK)
                {
                    DialogResult Confirmar_Modificacion = MessageBox.Show("¿Esta seguro que desea modificar este documento?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                    if (Confirmar_Modificacion == DialogResult.OK)
                    {
                        System.IO.File.Delete(ruta_documento_eliminar);

                        guardar();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("La ruta especificada no existe.");
            }
        }
    }
}