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
    public partial class FichasMedicas : Form
    {
        public int Perfil_Rol;
        public string Usuario;

        public FichasMedicas(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();

        }
        ClientesController Negocio = new ClientesController();
        FuerzaController Fuerza = new FuerzaController();
        DispensariosControllers Dispensario = new DispensariosControllers();
        DepartamentoController Departamentos = new DepartamentoController();
        CiudadesController Ciudades = new CiudadesController();
        EstadosFichasMedicasController EstadoFichaMedica = new EstadosFichasMedicasController();
        FichasMedicasController FichaMedica = new FichasMedicasController();
        FichasMedicasViews EntidadFichas = new FichasMedicasViews();
        ParametrosControllers Parametros = new ParametrosControllers();
        RolesController Rol = new RolesController();

        string Nombre_Estado_Ficha = string.Empty;
        int value_Ficha_Medica = 0;
        int value_departamento = 0;
        string departamento = string.Empty;
        int value_Ciudad = 0;
        string Nombre_Ciudad = string.Empty;
        int value_Dispensario = 0;
        string Nombre_Dispensario = string.Empty;
        int value_Fuerza = 0;
        string Nombre_Fuerza = string.Empty;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int id_novedad = 0;
        string ruta_documento_eliminar = string.Empty;
        string Nombre_documento_eliminar = string.Empty;
        string Ruta_Diaria = string.Empty;
        int numero_archivo = 0;
        string Ruta_documento_original = string.Empty;

        private void CargarDepartamentos()
        {
            var Load_Departamentos = Departamentos.MostrarDepartamentos();
            cbDepartamentoExpedicion.DisplayMember = "Nombre_Departamento";
            cbDepartamentoExpedicion.ValueMember = "id_Departamento";
            cbDepartamentoExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoExpedicion.DataSource = Load_Departamentos;
        }

        private void CargarDispensarios(int value_Fuerza)
        {
            var Load_Cargar_Dispensarios = Dispensario.MostrarDispensarios(value_Fuerza);
            cbDispensarioMedico.DisplayMember = "Nombre_Dispensario";
            cbDispensarioMedico.ValueMember = "id_Dispensario";
            cbDispensarioMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDispensarioMedico.DataSource = Load_Cargar_Dispensarios;
            cbDispensarioMedico.Enabled = true;
        }

        private void CargarCiudadesExpedicion(int value)
        {
            var Load_Ciudades_Expedicion = Ciudades.MostrarCiudades(value);
            cbCiudadExpedicion.DisplayMember = "Nombre_Ciudad";
            cbCiudadExpedicion.ValueMember = "id_Ciudad";
            cbCiudadExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadExpedicion.DataSource = Load_Ciudades_Expedicion;
        }

        private void CargarEstadosFicha(int value)
        {
            var Load_Fichas_Medicas = EstadoFichaMedica.MostrarTiposEstadosFichasMedicas(value);
            cbEstadoFichaMedica.DisplayMember = "Nombre_Estado";
            cbEstadoFichaMedica.ValueMember = "id_Estado_Ficha_Medica";
            cbEstadoFichaMedica.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoFichaMedica.DataSource = Load_Fichas_Medicas;
        }

        private void CargarEstadosFichaGenerado(string value)
        {
            var Load_Fichas_Medicas = EstadoFichaMedica.MostrarTiposEstadosFichasMedicasValor(value);
            cbEstadoFichaMedica.DisplayMember = "Nombre_Estado";
            cbEstadoFichaMedica.ValueMember = "id_Estado_Ficha_Medica";
            cbEstadoFichaMedica.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoFichaMedica.DataSource = Load_Fichas_Medicas;
            cbEstadoFichaMedica.Enabled = false;
        }

        private void CargarFuerzaGenerado(string value)
        {
            var Load_Cargar_Fuerza = Fuerza.MostrarFuerzaValor(value);
            cbFuerza.DisplayMember = "Nombre_Fuerza";
            cbFuerza.ValueMember = "id_Fuerza";
            cbFuerza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuerza.DataSource = Load_Cargar_Fuerza;
            cbFuerza.Enabled = false;
        }
        private void CargarDispensariosGenerado(string value)
        {
            var Load_Cargar_Dispensarios = Dispensario.MostrarDispensariosValor(value);
            cbDispensarioMedico.DisplayMember = "Nombre_Dispensario";
            cbDispensarioMedico.ValueMember = "id_Dispensario";
            cbDispensarioMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDispensarioMedico.DataSource = Load_Cargar_Dispensarios;
            //cbDispensarioMedico.Enabled = false;
        }

        private void CargarDepartamentosExpedicionGenerado(string value)
        {
            var Load_Departamentos = Departamentos.MostrarDepartamentosValor(value);
            cbDepartamentoExpedicion.DisplayMember = "Nombre_Departamento";
            cbDepartamentoExpedicion.ValueMember = "id_Departamento";
            cbDepartamentoExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoExpedicion.DataSource = Load_Departamentos;
            //cbDepartamentoExpedicion.Enabled = false;
        }

        private void CargarCiudadesExpedicionGenerado(string value, int dep)
        {
            var Load_Ciudades_Expedicion = Ciudades.MostrarCiudadesValor(value, dep);
            cbCiudadExpedicion.DisplayMember = "Nombre_Ciudad";
            cbCiudadExpedicion.ValueMember = "id_Ciudad";
            cbCiudadExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadExpedicion.DataSource = Load_Ciudades_Expedicion;
            //cbCiudadExpedicion.Enabled = false;
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
                dataGridView1.Enabled = true;
                Nombre_Fuerza = c.Fuerza;
                CargarFuerzaGenerado(Nombre_Fuerza);
                value_Fuerza = Fuerza.MostrarFuerzaValor2(Nombre_Fuerza);
                cbEstadoFichaMedica.Enabled = true;
                CargarEstadosFicha(value_Fuerza);
                cbDispensarioMedico.Enabled = true;
                CargarDispensarios(value_Fuerza);
                cbDepartamentoExpedicion.Enabled = true;
                CargarDepartamentos();
                cbCiudadExpedicion.Enabled = true;
                txtOtroLugarExpedicion.Clear();
                txtOtroLugarExpedicion.Enabled = true;
                if (c.Fecha_Salida == null)
                {
                    cbActivoFuerza.Checked = false;
                }
                else
                {
                    cbActivoFuerza.Checked = true;
                    dtpFechaSalida.Value = Convert.ToDateTime(c.Fecha_Salida);
                }
                cbEliminarAdjunto.Enabled = false;
                cbEliminarAdjunto.Checked = false;
                cbAdjuntarArchivo.Enabled = true;
                cbNotificarCliente.Enabled = true;
                cbNotificarCliente.Checked = false;
                txtDescripcion.Clear();
                txtDescripcion.Enabled = true;
                lblCreado.Visible = false;
                lblModificado.Visible = false;
                lblSubidoPor.Visible = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                ConsultarFichasClientes(txtNumeroIdentificacionCliente.Text);
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
                        Nombre_Fuerza = c.Fuerza;
                        CargarFuerzaGenerado(Nombre_Fuerza);
                        cbEstadoFichaMedica.Enabled = true;
                        CargarDispensarios(value_Fuerza);
                        cbDispensarioMedico.Enabled = true;
                        CargarDepartamentos();
                        if (c.Fecha_Salida == null)
                        {
                            cbActivoFuerza.Checked = false;
                        }
                        else
                        {
                            cbActivoFuerza.Checked = true;
                            dtpFechaSalida.Value = Convert.ToDateTime(c.Fecha_Salida);
                        }
                        cbAdjuntarArchivo.Enabled = true;
                        txtDescripcion.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        cbDepartamentoExpedicion.Enabled = true;
                        cbCiudadExpedicion.Enabled = true;
                        txtOtroLugarExpedicion.Enabled = true;
                        cbNotificarCliente.Enabled = true;
                        txtNumeroIdentificacionCliente.Enabled = false;
                        txtPrimerNombreCliente.Enabled = false;
                        txtSegundoNombreCliente.Enabled = false;
                        txtPrimerApellidoCliente.Enabled = false;
                        txtSegundoApellidoCliente.Enabled = false;
                        dataGridView1.Enabled = true;
                        ConsultarFichasClientes(txtNumeroIdentificacionCliente.Text);
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

        private void ConsultarFichasClientes(string doc_cliente)
        {
            var Load_Fichas = FichaMedica.ConsultarFichasPorCliente(doc_cliente);
            dataGridView1.Rows.Clear();
            if (Load_Fichas.Count > 0)
            {
                foreach (var d in Load_Fichas)
                {
                    dataGridView1.Rows.Add(d.id_Ficha, d.Fuerza, d.Estado_Ficha_Medica, d.Dispensario, d.Departamento, d.Ciudad, d.Otro_Lugar, d.Fecha_Salida, d.Adjuntar_Documento, d.Nombre_Archivo, d.Informar_Cliente, d.Observaciones, d.Fecha_Cargado, d.Fecha_Modificado, d.Usuario);
                    btnGuardar.Enabled = true;
                    btnVerAdjunto.Enabled = false;
                }
            }
            else
            {
                dataGridView1.Rows.Clear();

                btnGuardar.Enabled = true;
                btnVerAdjunto.Enabled = false;
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
            txtNumeroIdentificacionCliente.Enabled = true;
            txtPrimerNombreCliente.Enabled = true;
            txtSegundoNombreCliente.Enabled = true;
            txtPrimerApellidoCliente.Enabled = true;
            txtSegundoApellidoCliente.Enabled = true;
            txtDescripcion.Clear();
            txtNombreArchivo.Clear();
            txtRuta.Clear();
            cbEliminarAdjunto.Checked = false;
            cbAdjuntarArchivo.Checked = false;
            cbNotificarCliente.Checked = false;
            cbActivoFuerza.Checked = false;
            cbEliminarAdjunto.Enabled = false;
            cbAdjuntarArchivo.Enabled = false;
            cbNotificarCliente.Enabled = false;
            cbActivoFuerza.Enabled = false;
            cbFuerza.Enabled = false;
            cbEstadoFichaMedica.Enabled = false;
            cbDispensarioMedico.Enabled = false;
            cbDepartamentoExpedicion.Enabled = false;
            cbCiudadExpedicion.Enabled = false;
            txtOtroLugarExpedicion.Clear();
            txtOtroLugarExpedicion.Enabled = false;
            txtDescripcion.Enabled = false;
            dtpFechaSalida.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnVerAdjunto.Enabled = false;
            lblCreado.Visible = false;
            lblModificado.Visible = false;
            lblSubidoPor.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbDepartamentoExpedicion_SelectedValueChanged(object sender, EventArgs e)
        {
            value_departamento = Convert.ToInt32(cbDepartamentoExpedicion.SelectedValue);
            CargarCiudadesExpedicion(value_departamento);
            departamento = Convert.ToString(Departamentos.MostrarDepartamentosNombre(value_departamento));
        }

        private void cbFuerza_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Fuerza = Convert.ToInt32(cbFuerza.SelectedValue);
            CargarEstadosFicha(value_Fuerza);
            cbEstadoFichaMedica.Enabled = true;
            Nombre_Fuerza = Convert.ToString(Fuerza.MostrarFuerzaNombre(value_Fuerza));
        }

        private void cbDispensarioMedico_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Dispensario = Convert.ToInt32(cbDispensarioMedico.SelectedValue);
            Nombre_Dispensario = Convert.ToString(Dispensario.MostrarDispensariosNombre(value_Dispensario));
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
                string documentos = Nombre_Estado_Ficha;
                txtNombreArchivo.Text = txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
                cbEstadoFichaMedica.Enabled = false;
            }
        }

        private void cbEstadoFichaMedica_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Ficha_Medica = Convert.ToInt32(cbEstadoFichaMedica.SelectedValue);
            Nombre_Estado_Ficha = Convert.ToString(EstadoFichaMedica.MostrarTiposEstadosFichasMedicasNombre(value_Ficha_Medica, value_Fuerza));
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
            string Ruta_Original = Parametros.MostrarParametro("RutaFichasMedicas");
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
            documentos = Nombre_Estado_Ficha;
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
            EntidadFichas.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadFichas.Fuerza = Nombre_Fuerza;
            EntidadFichas.Estado_Ficha_Medica = Nombre_Estado_Ficha;
            EntidadFichas.Dispensario = Nombre_Dispensario;
            EntidadFichas.Departamento = departamento;
            EntidadFichas.Ciudad = Nombre_Ciudad;
            EntidadFichas.Otro_Lugar = txtOtroLugarExpedicion.Text;
            EntidadFichas.Fecha_Salida = dtpFechaSalida.Value;
            if (cbAdjuntarArchivo.Checked == true)
            {
                EntidadFichas.Adjuntar_Documento = true;
            }
            else
            {
                EntidadFichas.Adjuntar_Documento = false;
            }
            EntidadFichas.Nombre_Archivo = txtNombreArchivo.Text;
            EntidadFichas.Ruta = validar_archivo;
            if (cbNotificarCliente.Checked == true)
            {
                EntidadFichas.Informar_Cliente = true;
            }
            else
            {
                EntidadFichas.Informar_Cliente = false;
            }
            EntidadFichas.Observaciones = txtDescripcion.Text;
            EntidadFichas.Fecha_Cargado = System.DateTime.Now;
            EntidadFichas.Fecha_Modificado = System.DateTime.Now;
            EntidadFichas.Usuario = Usuario_Login;
            validar_guardado = FichaMedica.GuardarFichas(EntidadFichas);
            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadFichas.Fecha_Cargado.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadFichas.Fecha_Modificado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadFichas.Usuario.ToString();
                MessageBox.Show("La ficha ha sido cargada correctamente.");
                ConsultarFichasClientes(txtNumeroIdentificacionCliente.Text);
                PostGuardar();
            }
            else
            {
                MessageBox.Show("La ficha no pudo ser cargada, por favor verifique la información y oprima guardar");
            }
        }

        private void PostGuardar()
        {
            txtDescripcion.Clear();
            txtRuta.Clear();
            txtNombreArchivo.Clear();
            txtOtroLugarExpedicion.Clear();
            CargarDepartamentos();
            cbNotificarCliente.Checked = false;
            cbAdjuntarArchivo.Checked = false;
            lblCreado.Visible = false;
            lblModificado.Visible = false;
            lblSubidoPor.Visible = false;
            cbEstadoFichaMedica.Enabled = true;
            cbEliminarAdjunto.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GuardarFicha";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "EliminarFicha";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        id_novedad = Convert.ToInt32(ModificarNovedades());

                        EntidadFichas.id_Ficha = id_novedad;

                        DialogResult Confirmar_Modificacion = MessageBox.Show("¿Esta seguro que desea eliminar esta ficha?", "¡Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion == DialogResult.OK)
                        {
                            bool confirmar_eliminacion = FichaMedica.EliminarFichas(EntidadFichas);

                            if (cbAdjuntarArchivo.Checked == true)
                            {
                                if (System.IO.File.Exists(ruta_documento_eliminar))
                                {
                                    System.IO.File.Delete(ruta_documento_eliminar);
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("La ficha ha sido eliminada correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La ficha no pudo ser eliminada, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("La ficha ha sido eliminada correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La ficha no pudo ser eliminada, por favor verifique la información y oprima guardar");
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
                                        MessageBox.Show("La ficha ha sido eliminada correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La ficha no pudo ser eliminada, por favor verifique la información y oprima guardar");
                                    }
                                }
                                else
                                {
                                    if (confirmar_eliminacion == true)
                                    {
                                        MessageBox.Show("La ficha ha sido eliminada correctamente.");
                                        Buscar();
                                        PostGuardar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La ficha no pudo ser eliminada, por favor verifique la información y oprima guardar");
                                    }
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id_novedad = Convert.ToInt32(ModificarNovedades());
            var Load_Novedad_Id = FichaMedica.ConsultarFichaPorId(id_novedad);

            foreach (var d in Load_Novedad_Id)
            {
                Nombre_Fuerza = d.Fuerza;
                CargarFuerzaGenerado(Nombre_Fuerza);
                Nombre_Estado_Ficha = d.Estado_Ficha_Medica;
                value_Ficha_Medica = EstadoFichaMedica.MostrarTiposEstadosFichasMedicasValor(Nombre_Estado_Ficha);
                cbEstadoFichaMedica.SelectedValue = value_Ficha_Medica;
                Nombre_Dispensario = d.Dispensario;
                value_Dispensario = Dispensario.MostrarDispensariosValor2(Nombre_Dispensario);
                cbDispensarioMedico.SelectedValue = value_Dispensario;
                departamento = d.Departamento;
                value_departamento = Departamentos.MostrarDepartamentosValorId(departamento);
                cbDepartamentoExpedicion.SelectedValue = value_departamento;
                Nombre_Ciudad = d.Ciudad;
                value_Ciudad = Ciudades.MostrarCiudadesValor2(Nombre_Ciudad, value_departamento);
                cbCiudadExpedicion.SelectedValue = value_Ciudad;
                txtOtroLugarExpedicion.Text = d.Otro_Lugar;
                if (d.Fecha_Salida == null)
                {
                    cbActivoFuerza.Checked = false;
                }
                else
                {
                    cbActivoFuerza.Checked = true;
                    dtpFechaSalida.Value = Convert.ToDateTime(d.Fecha_Salida);
                }
                cbEliminarAdjunto.Enabled = true;
                cbAdjuntarArchivo.Checked = d.Adjuntar_Documento;
                ruta_documento_eliminar = d.Ruta;
                Ruta_documento_original = d.Ruta;
                Nombre_documento_eliminar = d.Nombre_Archivo;
                txtNombreArchivo.Text = "";
                txtRuta.Text = "";
                cbNotificarCliente.Checked = d.Informar_Cliente;
                txtDescripcion.Text = d.Observaciones;
                cbAdjuntarArchivo.Enabled = false;
                btnAdjuntarDocumento.Enabled = false;
                lblCreado.Visible = true;
                lblModificado.Visible = true;
                lblSubidoPor.Visible = true;
                lblCreado.Text = d.Fecha_Cargado.ToString();
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

        public void Modificar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RutaFichasMedicas");

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
            documentos = Nombre_Estado_Ficha;
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
            //if (cbAdjuntarArchivo.Checked == true)
            //{
            //    CopyFile(txtRuta.Text, validar_archivo);
            //}

            EntidadFichas.id_Ficha = id_novedad;
            EntidadFichas.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadFichas.Fuerza = Nombre_Fuerza;
            EntidadFichas.Estado_Ficha_Medica = Nombre_Estado_Ficha;
            EntidadFichas.Dispensario = Nombre_Dispensario;
            EntidadFichas.Departamento = departamento;
            EntidadFichas.Ciudad = Nombre_Ciudad;
            EntidadFichas.Otro_Lugar = txtOtroLugarExpedicion.Text;

            if (cbEliminarAdjunto.Checked == true)
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    EntidadFichas.Adjuntar_Documento = true;
                    EntidadFichas.Nombre_Archivo = txtNombreArchivo.Text;
                    EntidadFichas.Ruta = validar_archivo;
                    CopyFile(txtRuta.Text, validar_archivo);
                }
                else
                {
                    EntidadFichas.Adjuntar_Documento = false;
                    EntidadFichas.Ruta = "";
                    EntidadFichas.Nombre_Archivo = "";
                }
            }
            else
            {
                if (cbAdjuntarArchivo.Checked == true)
                {
                    if (File.Exists(Ruta_documento_original))
                    {
                        EntidadFichas.Adjuntar_Documento = true;
                        EntidadFichas.Nombre_Archivo = Nombre_documento_eliminar;
                        EntidadFichas.Ruta = Ruta_documento_original;
                    }
                    else
                    {
                        EntidadFichas.Adjuntar_Documento = true;
                        EntidadFichas.Nombre_Archivo = txtNombreArchivo.Text;
                        EntidadFichas.Ruta = validar_archivo;
                        CopyFile(txtRuta.Text, validar_archivo);
                    }
                }
                else
                {
                    EntidadFichas.Adjuntar_Documento = false;
                    EntidadFichas.Ruta = "";
                    EntidadFichas.Nombre_Archivo = "";
                }
            }

            if (cbNotificarCliente.Checked == true)
            {
                EntidadFichas.Informar_Cliente = true;
            }
            else
            {
                EntidadFichas.Informar_Cliente = false;
            }
            EntidadFichas.Observaciones = txtDescripcion.Text;
            EntidadFichas.Fecha_Cargado = Convert.ToDateTime(lblCreado.Text);
            EntidadFichas.Fecha_Modificado = System.DateTime.Now;
            EntidadFichas.Usuario = lblSubidoPor.Text;
            validar_guardado = FichaMedica.ModificarFichas(EntidadFichas);

            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadFichas.Fecha_Cargado.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadFichas.Fecha_Modificado.ToString();
                lblSubidoPor.Visible = true;
                lblSubidoPor.Text = EntidadFichas.Usuario.ToString();
                MessageBox.Show("La ficha ha sido modificada correctamente.");
                ConsultarFichasClientes(txtNumeroIdentificacionCliente.Text);
                PostGuardar();
            }
            else
            {
                MessageBox.Show("La ficha no pudo ser modificada, por favor verifique la información y oprima guardar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ModificarFicha";
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

        private void cbCiudadExpedicion_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Ciudad = Convert.ToInt32(cbCiudadExpedicion.SelectedValue);
            Nombre_Ciudad = Convert.ToString(Ciudades.MostrarCiudadesNombre(value_departamento, value_Ciudad));
        }

        private void btnVerAdjunto_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "VerAdjuntoFicha";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        VerDocumentosFichas Seguimiento = new VerDocumentosFichas(id_novedad, PerfilRol, Usuario_Login);
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

        private void FichasMedicas_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
