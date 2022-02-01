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

namespace BA.Clientes.Formularios
{
    public partial class NovedadesFamiliares : Form
    {
        public int Id_Perfil;
        public string Usuario;
        public NovedadesFamiliares(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
        }

        ClientesController Negocio = new ClientesController();
        FamiliaController Familiar = new FamiliaController();
        TiposNovedadesController TiposNovedades = new TiposNovedadesController();
        NovedadesFamiliaController Novedades = new NovedadesFamiliaController();
        NovedadesFamiliaViews EntidadNovedades = new NovedadesFamiliaViews();
        ParametrosControllers Parametros = new ParametrosControllers();
        RolesController Rol = new RolesController();
        int value_tipo_Novedad = 0;
        string Tipo_Novedad = string.Empty;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int id_novedad = 0;
        string ruta_documento_eliminar = string.Empty;
        string Ruta_Diaria = string.Empty;
        int numero_archivo = 0;
        string documento_Cliente = string.Empty;
        string Nombre_documento_eliminar = string.Empty;
        string Ruta_documento_original = string.Empty;
        private void NovedadesCliente_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        private void ConsultarNovedadesFamiliares(string doc_cliente)
        {
            var Load_Novedades = Novedades.ConsultarNovedadesPorFamiliar(doc_cliente);
            dataGridView1.Rows.Clear();
            if (Load_Novedades.Count > 0)
            {
                foreach (var d in Load_Novedades)
                {
                    dataGridView1.Rows.Add(d.Id_Novedad, d.Tipo_Novedad, d.Descripcion, d.Adjuntar_Archivo, d.Nombre_Archivo, d.Informar_Cliente, d.Fecha_Subido, d.Fecha_Modificado, d.Usuario);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                btnGuardar.Enabled = true;
                btnVerAdjunto.Enabled = false;
            }
        }

        private void PostGuardar()
        {
            var Load_Familiar = Familiar.ConsultarFamiliarNumeroDocumento(txtNumeroIdentificacionFamiliar.Text);
            foreach (var c in Load_Familiar)
            {
                txtDescripcion.Clear();
                txtNumeroIdentificacionFamiliar.Text = c.Numero_Documento_Cliente;
                txtPrimerNombreFamiliar.Text = c.Primer_Nombre;
                txtSegundoNombreFamiliar.Text = c.Segundo_Nombre;
                txtPrimerApellidoFamiliar.Text = c.Primer_Apellido;
                txtSegundoApellidoFamiliar.Text = c.Segundo_Apellido;
                txtNumeroIdentificacionFamiliar.Enabled = false;
                txtPrimerNombreFamiliar.Enabled = false;
                txtSegundoNombreFamiliar.Enabled = false;
                txtPrimerApellidoFamiliar.Enabled = false;
                txtSegundoApellidoFamiliar.Enabled = false;
                cbTipoSeguimiento.Enabled = true;
                cbAdjuntarArchivo.Enabled = true;
                cbNotificarCliente.Enabled = true;
                txtDescripcion.Enabled = true;
                dataGridView1.Enabled = true;
                lblCreado.Visible = false;
                cbEliminarAdjunto.Checked = false;
                cbAdjuntarArchivo.Checked = false;
                cbNotificarCliente.Checked = false;
                lblModificado.Visible = false;
                lblSubidoPor.Visible = false;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                CargarTiposNovedades();
                documento_Cliente = c.Numero_Documento_Cliente;
            }
            CargarNovedadesFamilia(txtNumeroIdentificacionFamiliar.Text);
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtNumeroIdentificacionFamiliar.Clear();
            txtPrimerNombreFamiliar.Clear();
            txtSegundoNombreFamiliar.Clear();
            txtPrimerApellidoFamiliar.Clear();
            txtSegundoApellidoFamiliar.Clear();
            txtNumeroIdentificacionCliente.Clear();
            txtPrimerNombreCliente.Clear();
            txtSegundoNombreCliente.Clear();
            txtPrimerApellidoCliente.Clear();
            txtSegundoApellidoCliente.Clear();
            txtDescripcion.Clear();
            txtNombreArchivo.Clear();
            txtRuta.Clear();
            cbEliminarAdjunto.Enabled = false;
            cbEliminarAdjunto.Checked = false;
            cbAdjuntarArchivo.Checked = false;
            cbNotificarCliente.Checked = false;
            txtNumeroIdentificacionFamiliar.Enabled = true;
            txtPrimerNombreFamiliar.Enabled = true;
            txtSegundoNombreFamiliar.Enabled = true;
            txtPrimerApellidoFamiliar.Enabled = true;
            txtSegundoApellidoFamiliar.Enabled = true;
            cbTipoSeguimiento.Enabled = false;
            cbAdjuntarArchivo.Enabled = false;
            cbNotificarCliente.Enabled = false;
            txtDescripcion.Enabled = false;
            dataGridView1.Enabled = false;
            btnAdjuntarDocumento.Enabled = false;
            cbAdjuntarArchivo.Enabled = false;
            lblCreado.Visible = false;
            lblModificado.Visible = false;
            lblSubidoPor.Visible = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnVerAdjunto.Enabled = false;
        }

        private void cbAdjuntarArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdjuntarArchivo.Checked == true)
            {
                btnAdjuntarDocumento.Enabled = true;
            }
            else
            {
                btnAdjuntarDocumento.Enabled = false;
            }
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
                string documentos = Tipo_Novedad;
                txtNombreArchivo.Text = txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
                cbTipoSeguimiento.Enabled = false;
            }
        }

        private void cbTipoSeguimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            value_tipo_Novedad = Convert.ToInt32(cbTipoSeguimiento.SelectedValue);
            Tipo_Novedad = Convert.ToString(TiposNovedades.MostrarTiposNovedadesNombre(value_tipo_Novedad));
        }

        private void CargarTiposNovedades()
        {
            var Load_TipoDocumentos = TiposNovedades.MostrarTiposNovedades();
            cbTipoSeguimiento.DisplayMember = "Nombre_Documento_Novedad";
            cbTipoSeguimiento.ValueMember = "id_Documento_Novedad";
            cbTipoSeguimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoSeguimiento.DataSource = Load_TipoDocumentos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GuardarNovedadFamiliar";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        if (txtDescripcion.Text.Length > 0)
                        {

                            if (cbAdjuntarArchivo.Checked == true)
                            {
                                if (txtRuta.Text.Length > 0)
                                {
                                    guardar();
                                }
                                else
                                {
                                    MessageBox.Show("Si selecciono adjuntar archivo, debe adjuntarlo de lo contrario no lo seleccione y guarde la novedad.");
                                }
                            }
                            else
                            {
                                guardar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe redactar una breve descripción de la novedad.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
            }
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
            string Ruta_Original = Parametros.MostrarParametro("RutaNovedadesFamiliares");

            if (cbAdjuntarArchivo.Checked == true)
            {
                Ruta_Diaria = Ruta_Original + Convert.ToString(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            }
            else
            {
                Ruta_Diaria = "";
            }

            string documentos = string.Empty;
            string validar_archivo = string.Empty;
            string año = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            string dia = DateTime.Now.Day.ToString();
            documentos = Tipo_Novedad;
            validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionFamiliar.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";

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

            if (cbAdjuntarArchivo.Checked == true)
            {

                //Ruta_Diaria = Ruta_Diaria + "\\" + txtNombreArchivo.Text;

                while (File.Exists(validar_archivo))
                {
                    numero_archivo = numero_archivo + 1;
                    validar_archivo = string.Empty;
                    validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
                }
            }
            else
            {
                validar_archivo = "";
            }

            if (cbAdjuntarArchivo.Checked == true)
            {
                CopyFile(txtRuta.Text, validar_archivo);
            }
            EntidadNovedades.Doc_Familiar = txtNumeroIdentificacionFamiliar.Text;
            EntidadNovedades.Tipo_Novedad = Tipo_Novedad;
            EntidadNovedades.Descripcion = txtDescripcion.Text;
            if (cbAdjuntarArchivo.Checked == true)
            {
                EntidadNovedades.Adjuntar_Archivo = true;
            }
            else
            {
                EntidadNovedades.Adjuntar_Archivo = false;
            }
            EntidadNovedades.Nombre_Archivo = txtNombreArchivo.Text;
            EntidadNovedades.Ruta = validar_archivo;
            if (cbNotificarCliente.Checked == true)
            {
                EntidadNovedades.Informar_Cliente = true;
            }
            else
            {
                EntidadNovedades.Informar_Cliente = false;
            }
            EntidadNovedades.Fecha_Subido = System.DateTime.Now;
            EntidadNovedades.Fecha_Modificado = System.DateTime.Now;
            EntidadNovedades.Usuario = Usuario_Login;
            validar_guardado = Novedades.GuardarNovedadFamiliar(EntidadNovedades);
            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadNovedades.Fecha_Subido.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadNovedades.Fecha_Modificado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadNovedades.Usuario.ToString();
                MessageBox.Show("La novedad ha sido cargada correctamente.");
                ConsultarNovedadesFamiliares(txtNumeroIdentificacionCliente.Text);
                PostGuardar();
            }
            else
            {
                MessageBox.Show("La novedad no pudo ser cargada, por favor verifique la información y oprima guardar");
            }
        }

        public void Modificar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RutaNovedadesFamiliares");

            if (cbAdjuntarArchivo.Checked == true)
            {
                Ruta_Diaria = Ruta_Original + Convert.ToString(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            }
            else
            {
                Ruta_Diaria = "";
            }

            string documentos = string.Empty;
            string validar_archivo = string.Empty;
            string año = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            string dia = DateTime.Now.Day.ToString();
            documentos = Tipo_Novedad;
            validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionFamiliar.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";

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

            if (cbAdjuntarArchivo.Checked == true)
            {
                //Ruta_Diaria = Ruta_Diaria + "\\" + txtNombreArchivo.Text;
                while (File.Exists(validar_archivo))
                {
                    numero_archivo = numero_archivo + 1;
                    validar_archivo = string.Empty;
                    validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
                }
            }
            else
            {
                validar_archivo = "";
            }
            //if (cbAdjuntarArchivo.Checked == true)
            //{
            //    CopyFile(txtRuta.Text, validar_archivo);
            //}

            EntidadNovedades.Id_Novedad = id_novedad;
            EntidadNovedades.Doc_Familiar = txtNumeroIdentificacionFamiliar.Text;
            EntidadNovedades.Tipo_Novedad = Tipo_Novedad;
            EntidadNovedades.Descripcion = txtDescripcion.Text;

            if (cbEliminarAdjunto.Checked == true)
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    EntidadNovedades.Adjuntar_Archivo = true;
                    EntidadNovedades.Nombre_Archivo = txtNombreArchivo.Text;
                    EntidadNovedades.Ruta = validar_archivo;
                    CopyFile(txtRuta.Text, validar_archivo);
                }
                else
                {
                    EntidadNovedades.Adjuntar_Archivo = false;
                    EntidadNovedades.Ruta = "";
                    EntidadNovedades.Nombre_Archivo = "";
                }
            }
            else
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    if (File.Exists(Ruta_documento_original))
                    {
                        EntidadNovedades.Adjuntar_Archivo = true;
                        EntidadNovedades.Nombre_Archivo = Nombre_documento_eliminar;
                        EntidadNovedades.Ruta = Ruta_documento_original;
                    }
                    else
                    {
                        EntidadNovedades.Adjuntar_Archivo = true;
                        EntidadNovedades.Nombre_Archivo = txtNombreArchivo.Text;
                        EntidadNovedades.Ruta = validar_archivo;
                        CopyFile(txtRuta.Text, validar_archivo);

                    }
                }
                else
                {
                    EntidadNovedades.Adjuntar_Archivo = false;
                    EntidadNovedades.Ruta = "";
                    EntidadNovedades.Nombre_Archivo = "";
                }
                if (cbNotificarCliente.Checked == true)
                {
                    EntidadNovedades.Informar_Cliente = true;
                }
                else
                {
                    EntidadNovedades.Informar_Cliente = false;
                }

                EntidadNovedades.Fecha_Subido = Convert.ToDateTime(lblCreado.Text);
                EntidadNovedades.Fecha_Modificado = System.DateTime.Now;
                EntidadNovedades.Usuario = lblSubidoPor.Text;

                validar_guardado = Novedades.ModificarNovedadFamiliar(EntidadNovedades);

                if (validar_guardado == true)
                {
                    lblCreado.Visible = true;
                    lblCreado.Text = EntidadNovedades.Fecha_Subido.ToString();
                    lblModificado.Visible = true;
                    lblModificado.Text = EntidadNovedades.Fecha_Modificado.ToString();
                    lblSubidoPor.Visible = true;
                    lblSubidoPor.Text = EntidadNovedades.Usuario.ToString();
                    MessageBox.Show("La novedad ha sido modificada correctamente.");
                    ConsultarNovedadesFamiliares(txtNumeroIdentificacionCliente.Text);
                    PostGuardar();
                }
                else
                {
                    MessageBox.Show("La novedad no pudo ser modificada, por favor verifique la información y oprima guardar");
                }
            }
        }

        private string ModificarNovedades()
        {
            try
            {
                return dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ModificarNovedadFamiliar";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        if (txtDescripcion.Text.Length > 0)
                        {
                            if (cbEliminarAdjunto.Checked == true)
                            {
                                if (ruta_documento_eliminar.Length > 0)
                                {
                                    if (cbAdjuntarArchivo.Checked == true)
                                    {
                                        if (txtRuta.Text.Length > 0)
                                        {
                                            if (System.IO.File.Exists(ruta_documento_eliminar))
                                            {
                                                System.IO.File.Delete(ruta_documento_eliminar);
                                            }

                                            Modificar();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Si selecciono modificar archivo, debe adjuntarlo de lo contrario no lo seleccione y oprima modificar, tenga en cuenta que se eliminara el adjunto de la ficha.");
                                        }
                                    }
                                    else
                                    {
                                        if (System.IO.File.Exists(ruta_documento_eliminar))
                                        {
                                            System.IO.File.Delete(ruta_documento_eliminar);
                                            Modificar();
                                        }
                                        else
                                        {
                                            Modificar();
                                        }
                                    }
                                }
                                else
                                {
                                    Modificar();
                                }
                            }
                            else
                            {
                                Modificar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe redactar una breve descripción de la novedad.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id_novedad = Convert.ToInt32(ModificarNovedades());
            var Load_Novedad_Id = Novedades.ConsultarNovedadPorIdFamiliar(id_novedad);

            foreach (var d in Load_Novedad_Id)
            {
                Tipo_Novedad = d.Tipo_Novedad;
                value_tipo_Novedad = TiposNovedades.MostrarTiposNovedadesValor(Tipo_Novedad);
                cbTipoSeguimiento.SelectedValue = value_tipo_Novedad;
                txtDescripcion.Text = d.Descripcion;
                cbAdjuntarArchivo.Checked = Convert.ToBoolean(d.Adjuntar_Archivo);
                txtNombreArchivo.Text = "";
                cbEliminarAdjunto.Enabled = true;
                cbAdjuntarArchivo.Enabled = false;
                ruta_documento_eliminar = d.Ruta;
                Ruta_documento_original = d.Ruta;
                Nombre_documento_eliminar = d.Nombre_Archivo;
                txtNombreArchivo.Text = "";
                txtRuta.Text = "";
                Ruta_Diaria = "";
                cbNotificarCliente.Checked = d.Informar_Cliente;
                lblCreado.Visible = true;
                lblModificado.Visible = true;
                lblSubidoPor.Visible = true;
                lblCreado.Text = d.Fecha_Subido.ToString();
                lblModificado.Text = d.Fecha_Modificado.ToString();
                lblSubidoPor.Text = d.Usuario.ToString();
                btnGuardar.Enabled = false;

                if (ruta_documento_eliminar.Length > 0)
                {
                    btnVerAdjunto.Enabled = true;
                }
                else
                {
                    btnVerAdjunto.Enabled = false;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "EliminarNovedadFamiliar";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        id_novedad = Convert.ToInt32(ModificarNovedades());

                        EntidadNovedades.Id_Novedad = id_novedad;

                        DialogResult Confirmar_Modificacion = MessageBox.Show("¿Esta seguro que desea eliminar esta novedad?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion == DialogResult.OK)
                        {
                            bool confirmar_eliminacion = Novedades.EliminarNovedadesFamiliar(EntidadNovedades);

                            if (cbAdjuntarArchivo.Checked == true)
                            {
                                if (System.IO.File.Exists(ruta_documento_eliminar))
                                {
                                    System.IO.File.Delete(ruta_documento_eliminar);
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("La novedad ha sido eliminada correctamente.");
                                        ConsultarNovedadesFamiliares(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La novedad no pudo ser eliminada, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("La novedad ha sido eliminada correctamente.");
                                        ConsultarNovedadesFamiliares(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La novedad no pudo ser eliminada, por favor verifique la información y oprima guardar");
                                    }
                                }
                            }
                            else
                            {
                                if (System.IO.File.Exists(ruta_documento_eliminar))
                                {
                                    System.IO.File.Delete(ruta_documento_eliminar);
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("La novedad ha sido eliminada correctamente.");
                                        ConsultarNovedadesFamiliares(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La novedad no pudo ser eliminada, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("La novedad ha sido eliminada correctamente.");
                                        ConsultarNovedadesFamiliares(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La novedad no pudo ser eliminada, por favor verifique la información y oprima guardar");
                                    }
                                }
                            }

                        }
                        else
                        {
                            return;

                        }
                    }

                    else
                    {
                        MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
            }
        }

        private void btnVerAdjunto_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "VerAdjuntoNovedadFamiliar";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        VerDocumentosNovedadesFamilia Novedades = new VerDocumentosNovedadesFamilia(id_novedad, PerfilRol, Usuario_Login);
                        Novedades.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
            }
        }

        private void CargarNovedadesFamilia(string doc)
        {
            var Load_Novedades = Novedades.ConsultarNovedadesPorFamiliar(txtNumeroIdentificacionFamiliar.Text);
            dataGridView1.Rows.Clear();
            if (Load_Novedades.Count > 0)
            {
                foreach (var d in Load_Novedades)
                {
                    dataGridView1.Rows.Add(d.Id_Novedad, d.Tipo_Novedad, d.Descripcion, d.Adjuntar_Archivo, d.Nombre_Archivo, d.Informar_Cliente, d.Fecha_Subido, d.Fecha_Modificado, d.Usuario);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                btnGuardar.Enabled = true;
                btnVerAdjunto.Enabled = false;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtNumeroIdentificacionFamiliar.Text.Length > 0)
            {
                bool validar_Familiar_Existe = Familiar.ValidarSiFamiliarExiste(txtNumeroIdentificacionFamiliar.Text);
                if (validar_Familiar_Existe == false)
                {
                    var Load_Familiar = Familiar.ConsultarFamiliarNumeroDocumento(txtNumeroIdentificacionFamiliar.Text);
                    foreach (var c in Load_Familiar)
                    {
                        txtNumeroIdentificacionFamiliar.Text = c.Numero_Documento_Cliente;
                        txtPrimerNombreFamiliar.Text = c.Primer_Nombre;
                        txtSegundoNombreFamiliar.Text = c.Segundo_Nombre;
                        txtPrimerApellidoFamiliar.Text = c.Primer_Apellido;
                        txtSegundoApellidoFamiliar.Text = c.Segundo_Apellido;
                        txtNumeroIdentificacionFamiliar.Enabled = false;
                        txtPrimerNombreFamiliar.Enabled = false;
                        txtSegundoNombreFamiliar.Enabled = false;
                        txtPrimerApellidoFamiliar.Enabled = false;
                        txtSegundoApellidoFamiliar.Enabled = false;
                        cbTipoSeguimiento.Enabled = true;
                        cbAdjuntarArchivo.Enabled = true;
                        cbNotificarCliente.Enabled = true;
                        txtDescripcion.Enabled = true;
                        dataGridView1.Enabled = true;
                        btnGuardar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        CargarTiposNovedades();
                        documento_Cliente = c.Numero_Documento_Cliente;
                    }
                    var Load_Cliente = Negocio.ConsultarClienteAsociarFamilia(documento_Cliente);
                    foreach (var c in Load_Cliente)
                    {
                        txtNumeroIdentificacionCliente.Text = c.Numero_Documento_Cliente;
                        txtPrimerNombreCliente.Text = c.Primer_Nombre;
                        txtSegundoNombreCliente.Text = c.Segundo_Nombre;
                        txtPrimerApellidoCliente.Text = c.Primer_Apellido;
                        txtSegundoApellidoCliente.Text = c.Segundo_Apellido;
                    }
                    CargarNovedadesFamilia(txtNumeroIdentificacionFamiliar.Text);

                }
                else
                {
                    MessageBox.Show("El número de documento digitado, no corresponde a ninguno de los familiares registrados, por favor verifique la información y vuelva a intentar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del familiar a buscar");
            }
        }

        private void cbEliminarAdjunto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminarAdjunto.Checked == true)
            {
                cbAdjuntarArchivo.Enabled = true;
            }
            else
            {
                cbAdjuntarArchivo.Enabled = false;
            }
        }
    }
}




