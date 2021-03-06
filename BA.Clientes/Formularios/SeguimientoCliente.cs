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
    public partial class SeguimientoCliente : Form
    {
        public int Id_Perfil;
        public string Usuario;
        public SeguimientoCliente(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
        }

        ClientesController Negocio = new ClientesController();
        TiposSeguimientosController TiposSeguimientos = new TiposSeguimientosController();
        SeguimientoClienteController Seguimientos = new SeguimientoClienteController();
        SeguimientoClienteViews EntidadSeguimientos = new SeguimientoClienteViews();
        ParametrosControllers Parametros = new ParametrosControllers();
        RolesController Rol = new RolesController();
        int value_tipo_Seguimiento = 0;
        string Tipo_Seguimiento = string.Empty;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int id_novedad = 0;
        string ruta_documento_eliminar = string.Empty;
        string Nombre_documento_eliminar = string.Empty;
        string Ruta_Diaria = string.Empty;
        int numero_archivo = 0;
        string Ruta_documento_original = string.Empty;

        private void NovedadesCliente_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumeroIdentificacionCliente.Text.Length > 0)
            {
                bool validar_Cliente_Existe = Negocio.ValidarSiClienteExiste(txtNumeroIdentificacionCliente.Text);
                if (validar_Cliente_Existe == false)
                {
                    var Load_Cliente = Negocio.ConsultarClienteAsociarFamilia(txtNumeroIdentificacionCliente.Text);
                    foreach (var c in Load_Cliente)
                    {
                        txtNumeroIdentificacionCliente.Text = c.Numero_Documento_Cliente;
                        txtPrimerNombreCliente.Text = c.Primer_Nombre;
                        txtSegundoNombreCliente.Text = c.Segundo_Nombre;
                        txtPrimerApellidoCliente.Text = c.Primer_Apellido;
                        txtSegundoApellidoCliente.Text = c.Segundo_Apellido;
                        txtNumeroIdentificacionCliente.Enabled = false;
                        txtPrimerNombreCliente.Enabled = false;
                        txtSegundoNombreCliente.Enabled = false;
                        txtPrimerApellidoCliente.Enabled = false;
                        txtSegundoApellidoCliente.Enabled = false;
                        cbTipoSeguimiento.Enabled = true;
                        cbAdjuntarArchivo.Enabled = true;
                        cbNotificarCliente.Enabled = true;
                        txtDescripcion.Enabled = true;
                        dataGridView1.Enabled = true;
                        cbAdjuntarArchivo.Enabled = true;
                        btnGuardar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        CargarTiposSeguimientos();
                        ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El número de documento digitado, no corresponde a ninguno de los clientes registrados, por favor verifique la información y vuelva a intentar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del cliente a buscar");
            }
        }

        private void ConsultarSeguimientosClientes(string doc_cliente)
        {
            var Load_Seguimientos = Seguimientos.ConsultarSeguimientoPorCliente(doc_cliente);
            dataGridView1.Rows.Clear();
            if (Load_Seguimientos.Count > 0)
            {
                foreach (var d in Load_Seguimientos)
                {
                    dataGridView1.Rows.Add(d.ID_Seguimiento, d.Tipo_Seguimiento, d.Descripcion, d.Adjuntar_Archivo, d.Nombre_Archivo, d.Informar_Cliente, d.Fecha_Seguimiento, d.Fecha_Modificado, d.Usuario);
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
            var Load_Cliente = Negocio.ConsultarClienteAsociarFamilia(txtNumeroIdentificacionCliente.Text);
            foreach (var c in Load_Cliente)
            {
                txtNumeroIdentificacionCliente.Text = c.Numero_Documento_Cliente;
                txtPrimerNombreCliente.Text = c.Primer_Nombre;
                txtSegundoNombreCliente.Text = c.Segundo_Nombre;
                txtPrimerApellidoCliente.Text = c.Primer_Apellido;
                txtSegundoApellidoCliente.Text = c.Segundo_Apellido;
                txtNumeroIdentificacionCliente.Enabled = false;
                txtPrimerNombreCliente.Enabled = false;
                txtSegundoNombreCliente.Enabled = false;
                txtPrimerApellidoCliente.Enabled = false;
                txtSegundoApellidoCliente.Enabled = false;
                cbTipoSeguimiento.Enabled = true;
                txtDescripcion.Clear();
                txtRuta.Clear();
                txtNombreArchivo.Clear();
                cbEliminarAdjunto.Checked = false;
                cbAdjuntarArchivo.Checked = false;
                cbNotificarCliente.Enabled = true;
                cbNotificarCliente.Checked = false;
                cbAdjuntarArchivo.Enabled = true;
                cbNotificarCliente.Enabled = true;
                txtDescripcion.Enabled = true;
                dataGridView1.Enabled = true;
                cbEliminarAdjunto.Enabled = false;
                cbEliminarAdjunto.Checked = false;
                cbAdjuntarArchivo.Checked = false;
                lblCreado.Visible = false;
                lblModificado.Visible = false;
                lblSubidoPor.Visible = false;
                cbTipoSeguimiento.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                CargarTiposSeguimientos();
                ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
            }

        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
            txtNumeroIdentificacionCliente.Enabled = true;
            txtPrimerNombreCliente.Enabled = true;
            txtSegundoNombreCliente.Enabled = true;
            txtPrimerApellidoCliente.Enabled = true;
            txtSegundoApellidoCliente.Enabled = true;
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
                string documentos = Tipo_Seguimiento;
                txtNombreArchivo.Text = txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
                cbTipoSeguimiento.Enabled = false;
            }
        }

        private void cbTipoSeguimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            value_tipo_Seguimiento = Convert.ToInt32(cbTipoSeguimiento.SelectedValue);
            Tipo_Seguimiento = Convert.ToString(TiposSeguimientos.MostrarTipoSeguimientosNombre(value_tipo_Seguimiento));
        }

        private void CargarTiposSeguimientos()
        {
            var Load_Tipos_Seguimientos = TiposSeguimientos.MostrarTiposSeguimientos();
            cbTipoSeguimiento.DisplayMember = "Nombre_Tipo_Seguimiento";
            cbTipoSeguimiento.ValueMember = "Id_Tipo_Seguimiento";
            cbTipoSeguimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoSeguimiento.DataSource = Load_Tipos_Seguimientos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GuardarSeguimiento";
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
            string Ruta_Original = Parametros.MostrarParametro("RutaSeguimientosClientes");
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
            documentos = Tipo_Seguimiento;
            validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";

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
            EntidadSeguimientos.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadSeguimientos.Tipo_Seguimiento = Tipo_Seguimiento;
            EntidadSeguimientos.Descripcion = txtDescripcion.Text;
            if (cbAdjuntarArchivo.Checked == true)
            {
                EntidadSeguimientos.Adjuntar_Archivo = true;
            }
            else
            {
                EntidadSeguimientos.Adjuntar_Archivo = false;
            }
            EntidadSeguimientos.Nombre_Archivo = txtNombreArchivo.Text;
            EntidadSeguimientos.Ruta = validar_archivo;
            if (cbNotificarCliente.Checked == true)
            {
                EntidadSeguimientos.Informar_Cliente = true;
            }
            else
            {
                EntidadSeguimientos.Informar_Cliente = false;
            }
            EntidadSeguimientos.Fecha_Seguimiento = System.DateTime.Now;
            EntidadSeguimientos.Fecha_Modificado = System.DateTime.Now;
            EntidadSeguimientos.Usuario = Usuario_Login;
            validar_guardado = Seguimientos.GuardarSeguimiento(EntidadSeguimientos);
            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadSeguimientos.Fecha_Seguimiento.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadSeguimientos.Fecha_Modificado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadSeguimientos.Usuario.ToString();
                MessageBox.Show("El seguimiento ha sido cargada correctamente.");
                ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
                PostGuardar();
            }
            else
            {
                MessageBox.Show("El seguimiento no pudo ser cargado, por favor verifique la información y oprima guardar");
            }
        }

        public void Modificar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RutaSeguimientosClientes");

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
            documentos = Tipo_Seguimiento;
            validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";

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

            EntidadSeguimientos.ID_Seguimiento = id_novedad;
            EntidadSeguimientos.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadSeguimientos.Tipo_Seguimiento = Tipo_Seguimiento;
            EntidadSeguimientos.Descripcion = txtDescripcion.Text;
            if (cbEliminarAdjunto.Checked == true)
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    EntidadSeguimientos.Adjuntar_Archivo = true;
                    EntidadSeguimientos.Nombre_Archivo = txtNombreArchivo.Text;
                    EntidadSeguimientos.Ruta = validar_archivo;
                    CopyFile(txtRuta.Text, validar_archivo);
                }
                else
                {
                    EntidadSeguimientos.Adjuntar_Archivo = false;
                    EntidadSeguimientos.Ruta = "";
                    EntidadSeguimientos.Nombre_Archivo = "";
                }
            }
            else
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    if (File.Exists(Ruta_documento_original))
                    {
                        EntidadSeguimientos.Adjuntar_Archivo = true;
                        EntidadSeguimientos.Nombre_Archivo = Nombre_documento_eliminar;
                        EntidadSeguimientos.Ruta = Ruta_documento_original;
                    }
                    else
                    {
                        EntidadSeguimientos.Adjuntar_Archivo = true;
                        EntidadSeguimientos.Nombre_Archivo = txtNombreArchivo.Text;
                        EntidadSeguimientos.Ruta = validar_archivo;
                        CopyFile(txtRuta.Text, validar_archivo);
                    }
                }
                else
                {
                    EntidadSeguimientos.Adjuntar_Archivo = false;
                    EntidadSeguimientos.Ruta = "";
                    EntidadSeguimientos.Nombre_Archivo = "";
                }
            }

            if (cbNotificarCliente.Checked == true)
            {
                EntidadSeguimientos.Informar_Cliente = true;
            }
            else
            {
                EntidadSeguimientos.Informar_Cliente = false;
            }

            EntidadSeguimientos.Fecha_Seguimiento = Convert.ToDateTime(lblCreado.Text);
            EntidadSeguimientos.Fecha_Modificado = System.DateTime.Now;
            EntidadSeguimientos.Usuario = lblSubidoPor.Text;

            validar_guardado = Seguimientos.ModificarSeguimiento(EntidadSeguimientos);

            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadSeguimientos.Fecha_Seguimiento.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadSeguimientos.Fecha_Modificado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadSeguimientos.Usuario.ToString();
                MessageBox.Show("El seguimiento ha sido modificado correctamente.");
                ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
                PostGuardar();
            }
            else
            {
                MessageBox.Show("El seguimiento no pudo ser modificado, por favor verifique la información y oprima guardar");
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
            string Nombre_Formulario = "ModificarSeguimiento";
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
            var Load_Novedad_Id = Seguimientos.ConsultarSeguimientoPorId(id_novedad);

            foreach (var d in Load_Novedad_Id)
            {
                Tipo_Seguimiento = d.Tipo_Seguimiento;
                value_tipo_Seguimiento = TiposSeguimientos.MostrarTipoSeguimientosValor(Tipo_Seguimiento);  /*TiposNovedades.MostrarTiposNovedadesValor(Tipo_Seguimiento);*/
                cbTipoSeguimiento.SelectedValue = value_tipo_Seguimiento;
                txtDescripcion.Text = d.Descripcion;
                cbAdjuntarArchivo.Checked = Convert.ToBoolean(d.Adjuntar_Archivo);
                txtNombreArchivo.Text = "";
                ruta_documento_eliminar = d.Ruta;
                Ruta_documento_original = d.Ruta;
                Nombre_documento_eliminar = d.Nombre_Archivo;
                txtNombreArchivo.Text = "";
                txtRuta.Text = "";
                cbEliminarAdjunto.Enabled = true;
                cbAdjuntarArchivo.Enabled = false;
                cbNotificarCliente.Enabled = true;
                cbNotificarCliente.Checked = d.Informar_Cliente;
                lblCreado.Visible = true;
                lblModificado.Visible = true;
                lblSubidoPor.Visible = true;
                lblCreado.Text = d.Fecha_Seguimiento.ToString();
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
            string Nombre_Formulario = "EliminarSeguimiento";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        id_novedad = Convert.ToInt32(ModificarNovedades());

                        EntidadSeguimientos.ID_Seguimiento = id_novedad;

                        DialogResult Confirmar_Modificacion = MessageBox.Show("¿Esta seguro que desea eliminar este seguimiento?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion == DialogResult.OK)
                        {
                            bool confirmar_eliminacion = Seguimientos.EliminarSeguimiento(EntidadSeguimientos);

                            if (cbAdjuntarArchivo.Checked == true)
                            {
                                if (System.IO.File.Exists(ruta_documento_eliminar))
                                {
                                    System.IO.File.Delete(ruta_documento_eliminar);
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("El seguimiento ha sido eliminado correctamente.");
                                        ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El seguimiento no pudo ser eliminado, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("El seguimiento ha sido eliminado correctamente.");
                                        ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El seguimiento no pudo ser eliminado, por favor verifique la información y oprima guardar");
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
                                        MessageBox.Show("El seguimiento ha sido eliminado correctamente.");
                                        ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El seguimiento no pudo ser eliminado, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("El seguimiento ha sido eliminado correctamente.");
                                        ConsultarSeguimientosClientes(txtNumeroIdentificacionCliente.Text);
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El seguimiento no pudo ser eliminado, por favor verifique la información y oprima guardar");
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
            string Nombre_Formulario = "VerAdjuntoSeguimiento";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        VerDocumentosSeguimientos Seguimiento = new VerDocumentosSeguimientos(id_novedad, PerfilRol, Usuario_Login);
                        Seguimiento.ShowDialog();
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

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




