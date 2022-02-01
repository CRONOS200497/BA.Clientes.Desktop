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
    public partial class Cartera : Form
    {
        public int Id_Perfil;
        public string Usuario;
        public Cartera(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
        }

        ClientesController Negocio = new ClientesController();
        RolesController Rol = new RolesController();
        ParametrosControllers Parametros = new ParametrosControllers();
        EstadosCuentasController EstadosCuentas = new EstadosCuentasController();
        TitulosValoresController TitulosValores = new TitulosValoresController();
        CarteraController CarteraCliente = new CarteraController();
        CarteraViews EntidadCartera = new CarteraViews();
        string Ruta_documento_original = string.Empty;
        string Ruta_Diaria = string.Empty;
        string ruta_documento_eliminar = string.Empty;
        string Nombre_documento_eliminar = string.Empty;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        string Nombre_Estado_Cuenta = string.Empty;
        int value_Estado_Cuenta = 0;
        string Nombre_Titutlo_Valor = string.Empty;
        int value_Titutlo_Valor = 0;
        int numero_archivo = 0;
        int id_novedad = 0;
        bool sumar_restar = false;


        private void Cartera_Load(object sender, EventArgs e)
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
                        txtSobre.Enabled = true;
                        cbTituloValor.Enabled = true;
                        CargarTitulosValores();
                        txtDescripcion.Enabled = true;
                        dtpFechaPrestamo.Enabled = true;
                        txtValor.Enabled = true;
                        //txtConsolidado.Enabled = true;                        
                        cbActivarTitulo.Enabled = true;
                        cbAdjuntarArchivo.Enabled = true;
                        cbEstadoCuenta.Enabled = true;
                        CargarEstadosCuentas();
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        dataGridView1.Enabled = true;
                        ConsultarCarteraClientes(txtNumeroIdentificacionCliente.Text);
                        SumarDeuda();
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

        public void SumarDeuda()
        {
            double suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value != null)

                    if (row.Cells[6].Value.Equals(true))
                    {
                        suma += (double)row.Cells[5].Value;
                    }
            }

            if (suma == 0)
            {
                txtConsolidado.Text = "0";
            }
            else
            {
                txtConsolidado.Text = suma.ToString();
            }

        }

        private void CargarTitulosValores()
        {
            var Load_Titulos_Valores = TitulosValores.MostrarTiposTitulosValores();
            cbTituloValor.DisplayMember = "Nombre_Titulo_Valor";
            cbTituloValor.ValueMember = "id_Titulos_Valores";
            cbTituloValor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTituloValor.DataSource = Load_Titulos_Valores;
        }

        private void CargarEstadosCuentas()
        {
            var Load_Estados_Cuentas = EstadosCuentas.MostrarTiposEstadosCuentas();
            cbEstadoCuenta.DisplayMember = "Nombre_Estado_Cartera";
            cbEstadoCuenta.ValueMember = "id_Estado_Cartera";
            cbEstadoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoCuenta.DataSource = Load_Estados_Cuentas;
            cbEstadoCuenta.Enabled = true;
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Enabled = false;
            txtNumeroIdentificacionCliente.Clear();
            txtPrimerNombreCliente.Clear();
            txtSegundoNombreCliente.Clear();
            txtPrimerApellidoCliente.Clear();
            txtSegundoApellidoCliente.Clear();
            txtNumeroIdentificacionCliente.Enabled = true;
            txtPrimerNombreCliente.Enabled = true;
            txtSegundoNombreCliente.Enabled = true;
            txtPrimerApellidoCliente.Enabled = true;
            txtSegundoApellidoCliente.Enabled = true;
            txtSobre.Clear();
            txtSobre.Enabled = false;
            cbTituloValor.Enabled = false;
            txtDescripcion.Clear();
            txtDescripcion.Enabled = false;
            dtpFechaPrestamo.Enabled = false;
            txtValor.Enabled = false;
            txtValor.Clear();
            txtConsolidado.Enabled = false;
            txtConsolidado.Clear();
            cbActivarTitulo.Enabled = false;
            cbActivarTitulo.Checked = false;
            cbEliminarAdjunto.Enabled = false;
            cbEliminarAdjunto.Checked = false;
            cbAdjuntarArchivo.Enabled = false;
            cbAdjuntarArchivo.Checked = false;
            txtNombreArchivo.Clear();
            txtRuta.Clear();
            cbEstadoCuenta.Enabled = false;
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

        private void btnVerAdjunto_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "VerAdjuntoCartera";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        VerDocumentosCartera Cartera = new VerDocumentosCartera(id_novedad, PerfilRol, Usuario_Login);
                        Cartera.ShowDialog();
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id_novedad = Convert.ToInt32(ModificarNovedades());
            var Load_Cartera = CarteraCliente.ConsultarCarterapPorId(id_novedad);

            foreach (var d in Load_Cartera)
            {
                txtSobre.Text = d.Sobre;
                Nombre_Titutlo_Valor = d.Titulo_Valor;
                value_Titutlo_Valor = TitulosValores.MostrarTiposTitulosValoresValor(Nombre_Titutlo_Valor);
                cbTituloValor.SelectedValue = value_Titutlo_Valor;
                txtDescripcion.Text = d.Descripcion;
                dtpFechaPrestamo.Value = d.Fecha;
                txtValor.Text = Convert.ToString(d.Valor);
                cbActivarTitulo.Checked = d.Documento_Activo;
                cbEliminarAdjunto.Enabled = true;
                cbAdjuntarArchivo.Checked = d.Adjuntar_Archivo.Value;
                cbAdjuntarArchivo.Enabled = false;
                btnAdjuntarDocumento.Enabled = false;
                ruta_documento_eliminar = d.Ruta;
                Ruta_documento_original = d.Ruta;
                Nombre_documento_eliminar = d.Nombre_Archivo;
                txtNombreArchivo.Text = "";
                txtRuta.Text = "";
                Nombre_Estado_Cuenta = d.Estado_Cuenta;
                value_Estado_Cuenta = EstadosCuentas.MostrarTiposEstadosCuentasValor(Nombre_Estado_Cuenta);
                cbEstadoCuenta.SelectedValue = value_Estado_Cuenta;
                lblCreado.Visible = true;
                lblModificado.Visible = true;
                lblSubidoPor.Visible = true;
                lblCreado.Text = d.Fecha_Subido.ToString();
                lblModificado.Text = d.fecha_Actualizado.ToString();
                lblSubidoPor.Text = d.Usuario.ToString();
                btnGuardar.Enabled = false;
                SumarDeuda();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GuardarCartera";
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
                            MessageBox.Show("Debe redactar una breve descripción de la ficha.");
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

        public void guardar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RutaCartera");
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
            documentos = Nombre_Titutlo_Valor;
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
            EntidadCartera.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadCartera.Sobre = txtSobre.Text;
            EntidadCartera.Titulo_Valor = Nombre_Titutlo_Valor;
            EntidadCartera.Descripcion = txtDescripcion.Text;
            EntidadCartera.Fecha = dtpFechaPrestamo.Value;
            EntidadCartera.Valor = float.Parse(txtValor.Text);
            if (cbActivarTitulo.Checked == true)
            {
                EntidadCartera.Suma_Total = float.Parse(txtConsolidado.Text) + EntidadCartera.Valor;
                EntidadCartera.Documento_Activo = true;
            }
            else
            {
                EntidadCartera.Suma_Total = float.Parse(txtConsolidado.Text);

                EntidadCartera.Documento_Activo = false;
            }
            if (cbAdjuntarArchivo.Checked == true)
            {
                EntidadCartera.Adjuntar_Archivo = true;
            }
            else
            {
                EntidadCartera.Adjuntar_Archivo = false;
            }
            EntidadCartera.Nombre_Archivo = txtNombreArchivo.Text;
            EntidadCartera.Ruta = validar_archivo;
            EntidadCartera.Estado_Cuenta = Nombre_Estado_Cuenta;
            EntidadCartera.Fecha_Subido = System.DateTime.Now;
            EntidadCartera.fecha_Actualizado = System.DateTime.Now;
            EntidadCartera.Usuario = Usuario_Login;
            validar_guardado = CarteraCliente.GuardarCartera(EntidadCartera);
            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadCartera.Fecha_Subido.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadCartera.fecha_Actualizado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadCartera.Usuario.ToString();
                MessageBox.Show("El registro ha sido cargado correctamente.");
                ConsultarCarteraClientes(txtNumeroIdentificacionCliente.Text);
                PostGuardar();
            }
            else
            {
                MessageBox.Show("El registro no pudo ser cargado, por favor verifique la información y oprima guardar");
            }
        }
        private void CopyFile(string origen, string destino)
        {
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
        private void ConsultarCarteraClientes(string doc_cliente)
        {
            var Load_Cartera = CarteraCliente.ConsultarCarteraPorCliente(doc_cliente);
            dataGridView1.Rows.Clear();
            if (Load_Cartera.Count > 0)
            {
                foreach (var d in Load_Cartera)
                {
                    dataGridView1.Rows.Add(d.id_Cartera, d.Sobre, d.Titulo_Valor, d.Descripcion, d.Fecha, d.Valor, d.Documento_Activo, d.Suma_Total, d.Adjuntar_Archivo, d.Nombre_Archivo, d.Estado_Cuenta, d.Fecha_Subido, d.fecha_Actualizado, d.Usuario);
                    btnGuardar.Enabled = true;
                    btnVerAdjunto.Enabled = false;
                }
                SumarDeuda();
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
            txtSobre.Clear();
            cbTituloValor.Enabled = true;
            CargarTitulosValores();
            txtDescripcion.Clear();
            txtValor.Clear();
            //txtConsolidado.Clear();
            cbActivarTitulo.Checked = false;
            cbAdjuntarArchivo.Checked = false;
            txtNombreArchivo.Clear();
            txtRuta.Clear();
            cbEstadoCuenta.Enabled = true;
            CargarEstadosCuentas();
            lblCreado.Visible = false;
            lblModificado.Visible = false;
            lblSubidoPor.Visible = false;
            cbEliminarAdjunto.Checked = false;
            cbEliminarAdjunto.Enabled = false;

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
                string documentos = Nombre_Titutlo_Valor;
                txtNombreArchivo.Text = txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
                cbTituloValor.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "EliminarCartera";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        id_novedad = Convert.ToInt32(ModificarNovedades());

                        EntidadCartera.id_Cartera = id_novedad;

                        DialogResult Confirmar_Modificacion = MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion == DialogResult.OK)
                        {
                            bool confirmar_eliminacion = CarteraCliente.EliminarCartera(EntidadCartera);

                            if (cbAdjuntarArchivo.Checked == true)
                            {
                                if (System.IO.File.Exists(ruta_documento_eliminar))
                                {
                                    System.IO.File.Delete(ruta_documento_eliminar);
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("registro ha sido eliminado correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("registro no pudo ser eliminado, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("registro ha sido eliminado correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("registro no pudo ser eliminado, por favor verifique la información y oprima guardar");
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
                                        MessageBox.Show("registro ha sido eliminado correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("registro no pudo ser eliminado, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("registro ha sido eliminado correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("registro no pudo ser eliminado, por favor verifique la información y oprima guardar");
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



        private void Buscar()
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
                txtSobre.Enabled = true;
                cbTituloValor.Enabled = true;
                CargarTitulosValores();
                txtDescripcion.Enabled = true;
                dtpFechaPrestamo.Enabled = true;
                txtValor.Enabled = true;
                cbActivarTitulo.Enabled = true;
                cbAdjuntarArchivo.Enabled = true;
                cbEstadoCuenta.Enabled = true;
                CargarEstadosCuentas();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                dataGridView1.Enabled = true;
                ConsultarCarteraClientes(txtNumeroIdentificacionCliente.Text);
                SumarDeuda();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ModificarCartera";
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

        public void Modificar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RutaCartera");

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
            documentos = Nombre_Titutlo_Valor;
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

            EntidadCartera.id_Cartera = id_novedad;
            EntidadCartera.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadCartera.Sobre = txtSobre.Text;
            EntidadCartera.Titulo_Valor = Nombre_Titutlo_Valor;
            EntidadCartera.Descripcion = txtDescripcion.Text;
            EntidadCartera.Fecha = dtpFechaPrestamo.Value;
            EntidadCartera.Valor = float.Parse(txtValor.Text);
            sumar_restar = CarteraCliente.ConsultarEstadoDocumento(id_novedad);
            if (cbActivarTitulo.Checked == true)
            {
                if (sumar_restar == true)
                {
                    EntidadCartera.Suma_Total = float.Parse(txtConsolidado.Text);
                    EntidadCartera.Documento_Activo = true;
                }
                else
                {
                    EntidadCartera.Suma_Total = float.Parse(txtConsolidado.Text) + EntidadCartera.Valor;
                    EntidadCartera.Documento_Activo = true;
                }
            }
            else
            {
                if (sumar_restar == true)
                {
                    EntidadCartera.Suma_Total = float.Parse(txtConsolidado.Text) - EntidadCartera.Valor;
                    EntidadCartera.Documento_Activo = false;
                }
                else
                {
                    EntidadCartera.Suma_Total = float.Parse(txtConsolidado.Text);
                    EntidadCartera.Documento_Activo = false;
                }
            }

            if (cbEliminarAdjunto.Checked == true)
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    EntidadCartera.Adjuntar_Archivo = true;
                    EntidadCartera.Nombre_Archivo = txtNombreArchivo.Text;
                    EntidadCartera.Ruta = validar_archivo;
                    CopyFile(txtRuta.Text, validar_archivo);
                }
                else
                {
                    EntidadCartera.Adjuntar_Archivo = false;
                    EntidadCartera.Ruta = "";
                    EntidadCartera.Nombre_Archivo = "";
                }
            }
            else
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    if (File.Exists(Ruta_documento_original))
                    {

                        EntidadCartera.Adjuntar_Archivo = true;
                        EntidadCartera.Nombre_Archivo = Nombre_documento_eliminar;
                        EntidadCartera.Ruta = ruta_documento_eliminar;
                    }
                    else
                    {
                        EntidadCartera.Adjuntar_Archivo = true;
                        EntidadCartera.Nombre_Archivo = txtNombreArchivo.Text;
                        EntidadCartera.Ruta = validar_archivo;
                        CopyFile(txtRuta.Text, validar_archivo);
                    }
                }
                else
                {
                    EntidadCartera.Adjuntar_Archivo = false;
                    EntidadCartera.Ruta = "";
                    EntidadCartera.Nombre_Archivo = "";
                }
            }
            EntidadCartera.Estado_Cuenta = Nombre_Estado_Cuenta;
            EntidadCartera.Fecha_Subido = Convert.ToDateTime(lblCreado.Text);
            EntidadCartera.fecha_Actualizado = System.DateTime.Now;
            EntidadCartera.Usuario = lblSubidoPor.Text;
            validar_guardado = CarteraCliente.ModificarCartera(EntidadCartera);

            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadCartera.Fecha_Subido.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadCartera.fecha_Actualizado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadCartera.Usuario.ToString();
                MessageBox.Show("El registro ha sido modificado correctamente.");
                ConsultarCarteraClientes(txtNumeroIdentificacionCliente.Text);
                PostGuardar();
            }
            else
            {
                MessageBox.Show("El registro no pudo ser modificado, por favor verifique la información y oprima guardar");
            }
        }

        private void cbTituloValor_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Titutlo_Valor = Convert.ToInt32(cbTituloValor.SelectedValue);
            Nombre_Titutlo_Valor = Convert.ToString(TitulosValores.MostrarTiposTitulosValoresNombre(value_Titutlo_Valor));

        }

        private void cbEstadoCuenta_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Estado_Cuenta = Convert.ToInt32(cbEstadoCuenta.SelectedValue);
            Nombre_Estado_Cuenta = Convert.ToString(EstadosCuentas.MostrarTiposEstadosCuentasNombre(value_Estado_Cuenta));
        }
    }
}
