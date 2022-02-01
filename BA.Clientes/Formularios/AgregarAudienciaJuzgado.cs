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
    public partial class AgregarAudienciaJuzgado : Form
    {
        public int Id_Perfil;
        public string Usuario;
        public int id_Audiencia;

        public AgregarAudienciaJuzgado(int Id_Perfil, string User, int id_Audiencia)
        {
            if (id_Audiencia == 0)
            {
                InitializeComponent();
                Usuario_Login = User;
                PerfilRol = Id_Perfil;
                CargarJuzgados();
                CargarAbogados();
            }
            else
            {
                InitializeComponent();
                numero_audiencia = id_Audiencia;
                Usuario_Login = User;
                PerfilRol = Id_Perfil;
                ConsultarAudiencia(id_Audiencia);
            }
        }

        private void AgregarAudienciaJuzgado_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        AudienciasJuzgadosController Audiencias = new AudienciasJuzgadosController();
        ClientesController Negocio = new ClientesController();
        JuzgadosController Juzgados = new JuzgadosController();
        AbogadosController Abogados = new AbogadosController();
        ParametrosControllers Parametros = new ParametrosControllers();
        RolesController Rol = new RolesController();
        AudienciasJuzgadoViews EntidadJuzgados = new AudienciasJuzgadoViews();
        FamiliaController Familiar = new FamiliaController();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int numero_archivo = 0;
        int value_Juzgado = 0;
        string Nombre_Juzgado = string.Empty;
        int value_Abogado = 0;
        string Nombre_Abogado = string.Empty;
        string CorreoAbogado = string.Empty;
        string ruta_documento_eliminar = string.Empty;
        string Nombre_documento_eliminar = string.Empty;
        string Ruta_documento_original = string.Empty;
        int numero_audiencia = 0;

        public void ConsultarAudiencia(int id_Audiencia)
        {
            var load_Audiencia = Audiencias.ConsultarAudienciaPorID(id_Audiencia);
            foreach (var datos_audiencia in load_Audiencia)
            {
                numero_audiencia = datos_audiencia.id_Audiencia_Juzgado;
                txtNumeroIdentificacionCliente.Text = datos_audiencia.Doc_Cliente;
                txtPrimerNombreCliente.Text = datos_audiencia.Primer_Nombre;
                txtSegundoNombreCliente.Text = datos_audiencia.Segundo_Nombre;
                txtPrimerApellidoCliente.Text = datos_audiencia.Primer_Apellido;
                txtSegundoApellidoCliente.Text = datos_audiencia.SegundoApellido;
                txtNumeroProceso.Text = datos_audiencia.Numero_Proceso;
                Nombre_Juzgado = datos_audiencia.Juzgado;
                CargarJuzgadosPorNombre(Nombre_Juzgado);
                dtpFechaAudiencia.Value = datos_audiencia.Fecha_Audiencia;
                Nombre_Abogado = datos_audiencia.Abogado;
                CargarAbogadosPorNombre(Nombre_Abogado);
                CorreoAbogado = datos_audiencia.Correo_Abogado;
                txtObservaciones.Text = datos_audiencia.Observaciones;
                cbAdjuntarArchivo.Checked = datos_audiencia.Adjuntar_Archivo;
                Ruta_documento_original = datos_audiencia.Ruta;
                txtRuta.Text = datos_audiencia.Ruta;
                ruta_documento_eliminar = datos_audiencia.Ruta;
                txtNombreArchivo.Text = datos_audiencia.Nombre_Archivo;
                Nombre_documento_eliminar = datos_audiencia.Nombre_Archivo;
                cbNotificarCliente.Checked = datos_audiencia.Informar_Cliente;
                cbNotificarAbogado.Checked = datos_audiencia.Informar_Abogado;
                lblCreado.Text = datos_audiencia.Fecha_Subido.ToString();
                lblModificado.Text = datos_audiencia.Fecha_Actualizado.ToString();
                lblSubidoPor.Text = datos_audiencia.Usuario;
                txtNumeroIdentificacionCliente.Enabled = false;
                txtPrimerNombreCliente.Enabled = false;
                txtSegundoNombreCliente.Enabled = false;
                txtPrimerApellidoCliente.Enabled = false;
                txtSegundoApellidoCliente.Enabled = false;
                txtNumeroProceso.Enabled = true;
                cbJuzgado.Enabled = true;
                dtpFechaAudiencia.Enabled = true;
                cbAbogados.Enabled = true;
                if (cbAdjuntarArchivo.Checked == true)
                {
                    cbEliminarAdjunto.Enabled = true;
                    cbAdjuntarArchivo.Enabled = false;
                }
                else
                {
                    cbEliminarAdjunto.Enabled = false;
                    cbAdjuntarArchivo.Enabled = true;
                }
                cbModificarAbogado.Enabled = true;
                cbModificarJuzgado.Enabled = true;
                cbNotificarCliente.Enabled = true;
                cbNotificarAbogado.Enabled = true;
                cbAdjuntarArchivo.Visible = true;
                cbNotificarCliente.Visible = true;
                cbNotificarAbogado.Visible = true;
                txtObservaciones.Enabled = true;
                lblCreado.Visible = true;
                lblModificado.Visible = true;
                lblSubidoPor.Visible = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnNuevaBusqueda.Enabled = false;
                btnBuscar.Enabled = false;
            }
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
                        txtNumeroProceso.Enabled = true;
                        cbJuzgado.Enabled = true;
                        dtpFechaAudiencia.Enabled = true;
                        cbAbogados.Enabled = true;
                        cbAdjuntarArchivo.Enabled = true;
                        cbNotificarCliente.Enabled = true;
                        cbNotificarAbogado.Enabled = true;
                        txtObservaciones.Enabled = true;
                        btnGuardar.Enabled = true;
                        btnModificar.Enabled = false;
                        btnBuscar.Enabled = false;
                    }
                }
                else if (validar_Cliente_Existe == true)
                {
                    bool validar_Familiar_Existe = Audiencias.ValidarSiFamiliarExiste(txtNumeroIdentificacionCliente.Text);
                    if (validar_Familiar_Existe == false)
                    {
                        var Load_Familiar = Familiar.ConsultarFamiliarNumeroDocumento(txtNumeroIdentificacionCliente.Text);
                        foreach (var c in Load_Familiar)
                        {
                            txtNumeroIdentificacionCliente.Text = c.Numero_Documento;
                            txtPrimerNombreCliente.Text = c.Primer_Nombre;
                            txtSegundoNombreCliente.Text = c.Segundo_Nombre;
                            txtPrimerApellidoCliente.Text = c.Primer_Apellido;
                            txtSegundoApellidoCliente.Text = c.Segundo_Apellido;
                            txtNumeroIdentificacionCliente.Enabled = false;
                            txtPrimerNombreCliente.Enabled = false;
                            txtSegundoNombreCliente.Enabled = false;
                            txtPrimerApellidoCliente.Enabled = false;
                            txtSegundoApellidoCliente.Enabled = false;
                            txtNumeroProceso.Enabled = true;
                            cbJuzgado.Enabled = true;
                            dtpFechaAudiencia.Enabled = true;
                            cbAbogados.Enabled = true;
                            cbAdjuntarArchivo.Enabled = true;
                            cbNotificarCliente.Enabled = true;
                            cbNotificarAbogado.Enabled = true;
                            txtObservaciones.Enabled = true;
                            btnGuardar.Enabled = true;
                            btnModificar.Enabled = false;
                            btnBuscar.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número de documento digitado no corresponde a ninguno de los clientes o familiares registrados, por favor verifique la información y vuelva a intentar.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del cliente o familiar a buscar.");
            }
        }


        private void CargarJuzgados()
        {
            var Load_Mostrar_Juzgados = Juzgados.MostrarJuzgados();
            if (Load_Mostrar_Juzgados.Count() > 0)
            {
                cbJuzgado.DisplayMember = "Nombre_Juzgado";
                cbJuzgado.ValueMember = "id_Juzgado";
                cbJuzgado.DropDownStyle = ComboBoxStyle.DropDownList;
                cbJuzgado.DataSource = Load_Mostrar_Juzgados;
            }
            else
            {
                cbJuzgado = null;
            }
        }

        private void CargarJuzgadosPorNombre(string Nombre_Juzgado)
        {
            var Load_Mostrar_Juzgados = Juzgados.MostrarJuzgadoSeleccionado(Nombre_Juzgado);
            cbJuzgado.DisplayMember = "Nombre_Juzgado";
            cbJuzgado.ValueMember = "id_Juzgado";
            cbJuzgado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJuzgado.DataSource = Load_Mostrar_Juzgados;
        }

        private void CargarAbogados()
        {
            var Load_Mostrar_Abogados = Abogados.MostrarAbogados();
            if (Load_Mostrar_Abogados.Count() > 0)
            {
                cbAbogados.DisplayMember = "Nombre_Abogado";
                cbAbogados.ValueMember = "id_Abogados";
                cbAbogados.DropDownStyle = ComboBoxStyle.DropDownList;
                cbAbogados.DataSource = Load_Mostrar_Abogados;
            }
            else
            {
                cbAbogados = null;
            }
        }

        private void CargarAbogadosPorNombre(string Nombre_Abogado)
        {
            var Load_Mostrar_Abogados = Abogados.MostrarAbogadoSeleccionado(Nombre_Abogado);
            cbAbogados.DisplayMember = "Nombre_Abogado";
            cbAbogados.ValueMember = "id_Abogados";
            cbAbogados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAbogados.DataSource = Load_Mostrar_Abogados;
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
                string documentos = "Audiencia_Juzgado";
                txtNombreArchivo.Text = txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
            }
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
                txtRuta.Clear();
                txtNombreArchivo.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
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

        public void Guardar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RutaAudienciasJuzgado");
            string Ruta_Diaria = Ruta_Original + Convert.ToString(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            string documentos = string.Empty;
            string validar_archivo = string.Empty;
            string año = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            string dia = DateTime.Now.Day.ToString();
            documentos = "Audiencia_Juzgado";
            validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
            bool validar_guardado = false;
            if (cbAdjuntarArchivo.Checked == true)
            {
                if (txtRuta.Text.Length > 0)
                {
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
                        validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
                    }

                    CopyFile(txtRuta.Text, validar_archivo);
                }
                else
                {
                    MessageBox.Show("Si selecciono que adjuntara un archivo por favor cárguelo, de lo contrario desmarque la casilla.");
                    return;
                }
            }
            EntidadJuzgados.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadJuzgados.Primer_Nombre = txtPrimerNombreCliente.Text;
            EntidadJuzgados.Segundo_Nombre = txtSegundoNombreCliente.Text;
            EntidadJuzgados.Primer_Apellido = txtPrimerApellidoCliente.Text;
            EntidadJuzgados.SegundoApellido = txtSegundoApellidoCliente.Text;
            EntidadJuzgados.Numero_Proceso = txtNumeroProceso.Text;
            EntidadJuzgados.Juzgado = Nombre_Juzgado;
            EntidadJuzgados.Fecha_Audiencia = dtpFechaAudiencia.Value;
            EntidadJuzgados.Abogado = Nombre_Abogado;
            EntidadJuzgados.Correo_Abogado = CorreoAbogado;
            EntidadJuzgados.Observaciones = txtObservaciones.Text;
            if (cbAdjuntarArchivo.Checked == true)
            {
                EntidadJuzgados.Adjuntar_Archivo = true;
                EntidadJuzgados.Ruta = validar_archivo;
                EntidadJuzgados.Nombre_Archivo = txtNombreArchivo.Text;
            }
            else
            {
                EntidadJuzgados.Adjuntar_Archivo = false;
                EntidadJuzgados.Ruta = "";
                EntidadJuzgados.Nombre_Archivo = "";
            }          

            if (cbNotificarCliente.Checked == true)
            {
                EntidadJuzgados.Informar_Cliente = true;
            }
            else
            {
                EntidadJuzgados.Informar_Cliente = false;
            }
            if (cbNotificarAbogado.Checked == true)
            {
                EntidadJuzgados.Informar_Abogado = true;
            }
            else
            {
                EntidadJuzgados.Informar_Abogado = false;
            }
            EntidadJuzgados.Fecha_Subido = System.DateTime.Now;
            EntidadJuzgados.Fecha_Actualizado = System.DateTime.Now;
            EntidadJuzgados.Usuario = Usuario_Login;
            validar_guardado = Audiencias.AgregarAudiencia(EntidadJuzgados);
            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadJuzgados.Fecha_Subido.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadJuzgados.Fecha_Actualizado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadJuzgados.Usuario;
                MessageBox.Show("La audiencia de juzgado ha sido registrada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("La audiencia de juzgado no pudo ser registrada, por favor verifique la información y oprima guardar");
            }
        }

        private void cbJuzgado_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Juzgado = Convert.ToInt32(cbJuzgado.SelectedValue);
            Nombre_Juzgado = Convert.ToString(Juzgados.MostrarJuzgadosNombre(value_Juzgado));
        }

        private void cbAbogados_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Abogado = Convert.ToInt32(cbAbogados.SelectedValue);
            Nombre_Abogado = Convert.ToString(Abogados.MostrarAbogadosNombre(value_Abogado));
            CorreoAbogado = Convert.ToString(Abogados.MostrarCorreoAbogado(value_Abogado));
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
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
            txtNumeroProceso.Clear();
            txtNumeroProceso.Enabled = false;
            CargarJuzgados();
            cbJuzgado.Enabled = false;
            dtpFechaAudiencia.Enabled = false;
            CargarAbogados();
            cbAbogados.Enabled = false;
            cbAdjuntarArchivo.Checked = false;
            cbAdjuntarArchivo.Enabled = false;
            cbNotificarCliente.Checked = false;
            cbNotificarCliente.Enabled = false;
            cbNotificarAbogado.Checked = false;
            cbNotificarAbogado.Enabled = false;
            txtObservaciones.Clear();
            txtObservaciones.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        public void Modificar()
        {
            string Ruta_Diaria = string.Empty;

            string Ruta_Original = Parametros.MostrarParametro("RutaAudienciasJuzgado");

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
            documentos = "Audiencia_Juzgado";
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
            EntidadJuzgados.id_Audiencia_Juzgado = numero_audiencia;
            EntidadJuzgados.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadJuzgados.Primer_Nombre = txtPrimerNombreCliente.Text;
            EntidadJuzgados.Segundo_Nombre = txtSegundoNombreCliente.Text;
            EntidadJuzgados.Primer_Apellido = txtPrimerApellidoCliente.Text;
            EntidadJuzgados.SegundoApellido = txtSegundoApellidoCliente.Text;
            EntidadJuzgados.Numero_Proceso = txtNumeroProceso.Text;
            EntidadJuzgados.Juzgado = Nombre_Juzgado;
            EntidadJuzgados.Fecha_Audiencia = dtpFechaAudiencia.Value;
            EntidadJuzgados.Abogado = Nombre_Abogado;
            EntidadJuzgados.Correo_Abogado = CorreoAbogado;
            EntidadJuzgados.Observaciones = txtObservaciones.Text;

            if (cbEliminarAdjunto.Checked == true)
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    EntidadJuzgados.Adjuntar_Archivo = true;
                    EntidadJuzgados.Nombre_Archivo = txtNombreArchivo.Text;
                    EntidadJuzgados.Ruta = validar_archivo;
                    CopyFile(txtRuta.Text, validar_archivo);
                }
                else
                {
                    EntidadJuzgados.Adjuntar_Archivo = false;
                    EntidadJuzgados.Ruta = "";
                    EntidadJuzgados.Nombre_Archivo = "";
                }
            }
            else
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    if (File.Exists(Ruta_documento_original))
                    {
                        EntidadJuzgados.Adjuntar_Archivo = true;
                        EntidadJuzgados.Nombre_Archivo = Nombre_documento_eliminar;
                        EntidadJuzgados.Ruta = Ruta_documento_original;

                    }
                    else
                    {
                        EntidadJuzgados.Adjuntar_Archivo = true;
                        EntidadJuzgados.Nombre_Archivo = txtNombreArchivo.Text;
                        EntidadJuzgados.Ruta = validar_archivo;
                        CopyFile(txtRuta.Text, validar_archivo);
                    }
                }
                else
                {
                    EntidadJuzgados.Adjuntar_Archivo = false;
                    EntidadJuzgados.Ruta = "";
                    EntidadJuzgados.Nombre_Archivo = "";
                }
            }

            if (cbNotificarCliente.Checked == true)
            {
                EntidadJuzgados.Informar_Cliente = true;
            }
            else
            {
                EntidadJuzgados.Informar_Cliente = false;
            }
            if (cbNotificarAbogado.Checked == true)
            {
                EntidadJuzgados.Informar_Abogado = true;
            }
            else
            {
                EntidadJuzgados.Informar_Abogado = false;
            }

            EntidadJuzgados.Fecha_Subido = DateTime.Parse(lblCreado.Text);
            EntidadJuzgados.Fecha_Actualizado = System.DateTime.Now;
            EntidadJuzgados.Usuario = Usuario_Login;
            validar_guardado = Audiencias.ModificarAudiencia(EntidadJuzgados);
            if (validar_guardado == true)
            {
                lblCreado.Text = EntidadJuzgados.Fecha_Subido.ToString();
                lblModificado.Text = EntidadJuzgados.Fecha_Actualizado.ToString();
                lblSubidoPor.Text = EntidadJuzgados.Usuario;
                MessageBox.Show("La audiencia de juzgado ha sido modificado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("La audiencia de juzgado no pudo ser modificada, por favor verifique la información y oprima modificar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                            MessageBox.Show("Si selecciono modificar archivo, debe adjuntarlo de lo contrario no lo seleccione y oprima modificar, tenga en cuenta que se eliminara el adjunto de la audiencia.");
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

        private void dtpFechaAudiencia_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaAudiencia.Format = DateTimePickerFormat.Custom;
            dtpFechaAudiencia.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }

        private void cbModificarJuzgado_Click(object sender, EventArgs e)
        {

            DialogResult ModificarJuzgado = MessageBox.Show("Confirme si desea modificar el juzgado.", "¡Alerta!", MessageBoxButtons.YesNo);
            if (ModificarJuzgado == DialogResult.Yes)
            {
                CargarJuzgados();
            }
            else if (ModificarJuzgado == DialogResult.No)
            {
                cbModificarJuzgado.Checked = false;
                return;
            }
            else
            {
                cbModificarJuzgado.Checked = false;
                return;
            }

        }

        private void cbModificarAbogado_Click(object sender, EventArgs e)
        {
            DialogResult ModificarAbogado = MessageBox.Show("Confirme si desea modificar el abogado.", "¡Alerta!", MessageBoxButtons.YesNo);
            if (ModificarAbogado == DialogResult.Yes)
            {
                CargarAbogados();
            }
            else if (ModificarAbogado == DialogResult.No)
            {
                cbModificarAbogado.Checked = false;
                return;
            }
            else
            {
                cbModificarAbogado.Checked = false;
                return;
            }
        }

        private void cbEliminarAdjunto_Click(object sender, EventArgs e)
        {
            DialogResult ModificarAdjunto = MessageBox.Show("Oprima si, para reemplazar el adjunto anterior o No para cancelar la acción.\nNota: En caso de oprimir SI, el adjunto anterior se eliminara.", "¡Alerta!", MessageBoxButtons.YesNo);
            if (ModificarAdjunto == DialogResult.Yes)
            {
                cbAdjuntarArchivo.Enabled = true;
                cbAdjuntarArchivo.Checked = false;
                txtNombreArchivo.Clear();
                txtRuta.Clear();
            }
            else if (ModificarAdjunto == DialogResult.No)
            {
                cbAdjuntarArchivo.Enabled = false;
                cbEliminarAdjunto.Checked = false;
                return;
            }
            else
            {
                cbAdjuntarArchivo.Enabled = false;
                cbEliminarAdjunto.Checked = false;
                return;
            }
        }
    }
}
