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
using BA.Models.Models;
using BA.Models.Entidades;
using BA.Correos;

namespace BA.Clientes.Formularios
{

    public partial class RegistrarClientes : Form
    {

        public int Perfil_Rol;
        public string Usuario;
        public RegistrarClientes(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            CargarDepartamentosExpedicion();
            CargarDepartamentosRegistro();
            CargarDepartamentosResidencia();
            CargarTiposDocumentos();
            CargarTipoRegistro();
            CargarRedesSociales();
            //CargarBatallones();
            //CargarDispensarios();
            CargarFuerza();
            CargarEtapasProcesos();
            CargarEstadosProcesos();
        }

        ClientesController Negocio = new ClientesController();
        DepartamentoController Departamentos = new DepartamentoController();
        CiudadesController Ciudades = new CiudadesController();
        ClientesViews EntidadClientes = new ClientesViews();
        TipoDocumentoController tiposDocumentos = new TipoDocumentoController();
        TipoRegistroController TipoRegistro = new TipoRegistroController();
        RedesSocialesController RedesSociales = new RedesSocialesController();
        DispensariosControllers Dispensarios = new DispensariosControllers();
        BatallonesControllers Batallones = new BatallonesControllers();
        FuerzaController FuerzaV = new FuerzaController();
        GradosController Grados = new GradosController();
        EtapasProcesosController EtapasProcesos = new EtapasProcesosController();
        EstadosProcesosController EstadosProcesos = new EstadosProcesosController();
        TelefonosClientesController Telefono = new TelefonosClientesController();
        CorreosClientesController Correos = new CorreosClientesController();
        TelefonosClientesViews EntidadTelefonos = new TelefonosClientesViews();
        CorreosClientesViews EntidadCorreos = new CorreosClientesViews();
        Metodos Correo = new Metodos();


        int value_tipo_documento = 0;
        int value_departamento_Expedicion = 0;
        int value_departamento_Registro = 0;
        int value_departamento_Residencia = 0;
        int value_Ciudad_Expedicion = 0;
        int value_Ciudad_Registro = 0;
        int value_Ciudad_Residencia = 0;
        int value_Tipo_Registro = 0;
        int value_Red_Social = 0;
        int value_Dispensario = 0;
        int value_Batallon = 0;
        int value_Fuerza = 0;
        int value_Grado = 0;
        int value_Estado_Proceso = 0;
        int Value_Etapa_Proceso = 0;
        string tipo_documento = string.Empty;
        string departamento_Expedicion = string.Empty;
        string departamento_Registro = string.Empty;
        string departamento_Residencia = string.Empty;
        string Ciudad_Expedicion = string.Empty;
        string Ciudad_Registro = string.Empty;
        string Ciudad_Residencia = string.Empty;
        string Tipo_Registro = string.Empty;
        string Red_Social = string.Empty;
        string Dispensario = string.Empty;
        string Batallon = string.Empty;
        string Fuerza = string.Empty;
        string Grado = string.Empty;
        string Estado_Proceso = string.Empty;
        string Etapa_Proceso = string.Empty;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;



        private void CargarEtapasProcesos()
        {
            var Load_Etapas_Procesos = EtapasProcesos.MostrarEtapasProcesos();
            cbEtapaProceso.DisplayMember = "Nombre_EtapasProceso";
            cbEtapaProceso.ValueMember = "id_EtapasProceso";
            cbEtapaProceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEtapaProceso.DataSource = Load_Etapas_Procesos;
        }
        private void CargarEstadosProcesos()
        {
            var Load_Estados_Procesos = EstadosProcesos.MostrarEstadosProcesos();
            cbEstadoProceso.DisplayMember = "Nombre_Estado_Proceso";
            cbEstadoProceso.ValueMember = "id_Estado_Proceso";
            cbEstadoProceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoProceso.DataSource = Load_Estados_Procesos;
            cbEstadoProceso.Enabled = true;
        }
        private void CargarGrados(int value_fuerza)
        {
            var Load_Cargar_Grados = Grados.MostrarGrados(value_fuerza);
            cbGrado.DisplayMember = "Nombre_Rago";
            cbGrado.ValueMember = "id_grado";
            cbGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrado.DataSource = Load_Cargar_Grados;
        }
        private void CargarFuerza()
        {
            var Load_Cargar_Fuerza = FuerzaV.MostrarFuerza();
            cbFuerza.DisplayMember = "Nombre_Fuerza";
            cbFuerza.ValueMember = "id_Fuerza";
            cbFuerza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuerza.DataSource = Load_Cargar_Fuerza;
        }

        private void CargarBatallones(int fuerza)
        {
            var Load_Cargar_Batallones = Batallones.MostrarBatallones(fuerza);
            cbBatallon.DisplayMember = "Nombre_Batallon";
            cbBatallon.ValueMember = "id_Batallon";
            cbBatallon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatallon.DataSource = Load_Cargar_Batallones;
        }

        private void CargarDispensarios(int fuerza)
        {
            var Load_Cargar_Dispensarios = Dispensarios.MostrarDispensarios(fuerza);
            cbDispensarioMedico.DisplayMember = "Nombre_Dispensario";
            cbDispensarioMedico.ValueMember = "id_Dispensario";
            cbDispensarioMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDispensarioMedico.DataSource = Load_Cargar_Dispensarios;
        }


        private void CargarRedesSociales()
        {
            var Load_Redes_Sociales = RedesSociales.MostrarRedesSociales();
            cbRedSocial.DisplayMember = "Nombre_Red_Social";
            cbRedSocial.ValueMember = "id_RedSocial";
            cbRedSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRedSocial.DataSource = Load_Redes_Sociales;
        }
        private void CargarTipoRegistro()
        {
            var load_TipoRegistro = TipoRegistro.MostrarTipoRegistro();
            cbTipoRegistro.DisplayMember = "Nombre_Tipo_Registro";
            cbTipoRegistro.ValueMember = "id_Tipo_Registro";
            cbTipoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoRegistro.DataSource = load_TipoRegistro;
        }
        private void CargarTiposDocumentos()
        {
            var Load_TiposDocumentos = tiposDocumentos.MostrarTipoDocumentos();
            cbTipoDocumento.DisplayMember = "Nombre_Tipo_Documento";
            cbTipoDocumento.ValueMember = "id_Tipo_Documento";
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.DataSource = Load_TiposDocumentos;
        }

        private void CargarDepartamentosExpedicion()
        {
            var Load_Departamentos = Departamentos.MostrarDepartamentos();
            cbDepartamentoExpedicion.DisplayMember = "Nombre_Departamento";
            cbDepartamentoExpedicion.ValueMember = "id_Departamento";
            cbDepartamentoExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoExpedicion.DataSource = Load_Departamentos;
        }
        private void CargarDepartamentosRegistro()
        {
            var Load_Departamentos_Registro = Departamentos.MostrarDepartamentos();
            cbDepartamentoRegistro.DisplayMember = "Nombre_Departamento";
            cbDepartamentoRegistro.ValueMember = "id_Departamento";
            cbDepartamentoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoRegistro.DataSource = Load_Departamentos_Registro;
        }

        private void CargarDepartamentosResidencia()
        {
            var Load_Departamentos_Residencia = Departamentos.MostrarDepartamentos();
            cbDepartamentoResdidencia.DisplayMember = "Nombre_Departamento";
            cbDepartamentoResdidencia.ValueMember = "id_Departamento";
            cbDepartamentoResdidencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoResdidencia.DataSource = Load_Departamentos_Residencia;

        }

        private void CargarCiudadesExpedicion(int value)
        {

            var Load_Ciudades_Expedicion = Ciudades.MostrarCiudades(value);
            cbCiudadExpedicion.DisplayMember = "Nombre_Ciudad";
            cbCiudadExpedicion.ValueMember = "id_Ciudad";
            cbCiudadExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadExpedicion.DataSource = Load_Ciudades_Expedicion;
        }
        private void CargarCiudadesRegistro(int value)
        {
            var Load_Ciudades_Registro = Ciudades.MostrarCiudades(value);
            cbCiudadRegistro.DisplayMember = "Nombre_Ciudad";
            cbCiudadRegistro.ValueMember = "id_Ciudad";
            cbCiudadRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadRegistro.DataSource = Load_Ciudades_Registro;
        }
        private void CargarCiudadesResidencia(int value)
        {
            var Load_Ciudades_Residencia = Ciudades.MostrarCiudades(value);
            cbCiudadResidencia.DisplayMember = "Nombre_Ciudad";
            cbCiudadResidencia.ValueMember = "id_Ciudad";
            cbCiudadResidencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadResidencia.DataSource = Load_Ciudades_Residencia;
        }

        private void Guardar()
        {
            EntidadClientes.Primer_Nombre = txtPrimerNombre.Text.ToUpper();
            EntidadClientes.Segundo_Nombre = txtSegundoNombre.Text.ToUpper();
            if (txtOtroNombre.Visible.Equals(true))
            {
                EntidadClientes.Otro_Nombre = txtOtroNombre.Text.ToUpper();
            }
            else
            {
                EntidadClientes.Otro_Nombre = "";
            }
            EntidadClientes.Primer_Apellido = txtPrimerApellido.Text.ToUpper();
            EntidadClientes.Segundo_Apellido = txtSegundoApellido.Text.ToUpper();
            EntidadClientes.Tipo_Documento = tipo_documento;
            EntidadClientes.Numero_Documento_Cliente = txtNumeroDocumento.Text;
            EntidadClientes.Departamento_Expedicion = departamento_Expedicion;
            EntidadClientes.Ciudad_Expedicion = Ciudad_Expedicion;
            if (txtOtroLugarExpedicion.Text.Length > 0)
            {
                EntidadClientes.Otro_Lugar_Expedicion = txtOtroLugarExpedicion.Text.ToUpper();
            }
            else
            {
                EntidadClientes.Otro_Lugar_Expedicion = "";
            }
            EntidadClientes.Fecha_Nacimiento = dtpFechaNacimiento.Value;
            EntidadClientes.Tipo_Registro = Tipo_Registro;
            EntidadClientes.Nombre_Lugar_Registro = txtNombreLugarRegistro.Text;
            EntidadClientes.Departamento_Registro = departamento_Registro;
            EntidadClientes.Ciudad_Registro = Ciudad_Registro;
            if (txtOtroLugarRegistro.Text.Length > 0)
            {
                EntidadClientes.Otro_Lugar_Registro = txtOtroLugarRegistro.Text.ToUpper();
            }
            else
            {
                EntidadClientes.Otro_Lugar_Registro = "";
            }
            EntidadClientes.Telefono_Fijo = txtTelefonoFijo.Text;
            EntidadClientes.Telefono_Celular = txtTelefonoCelular.Text;
            EntidadClientes.Correo = txtCorreo.Text;
            EntidadClientes.Red_Social = Red_Social;
            EntidadClientes.Nombre_Red_Social = txtNombreRedSocial.Text;

            if (value_departamento_Residencia == 0)
            {

                MessageBox.Show("Seleccione un departamento de residencia valido");
                return;
            }
            else
            {
                EntidadClientes.Departamento_Residencia = departamento_Residencia;
            }

            EntidadClientes.Ciudad_Residencia = Ciudad_Residencia;
            if (txtOtroLugarResidencia.Text.Length > 0)
            {
                EntidadClientes.Otro_Lugar_Residencia = txtOtroLugarResidencia.Text.ToUpper();
            }
            else
            {
                EntidadClientes.Otro_Lugar_Residencia = "";
            }
            if (cbxCasaPropia.Checked == true)
            {
                EntidadClientes.Casa_Propia = Convert.ToBoolean(cbxCasaPropia.Checked);
            }
            else
            {
                EntidadClientes.Casa_Propia = false;
            }
            EntidadClientes.Direccion_Residencia = txtDireccionResidencia.Text;
            EntidadClientes.Barrio = txtBarrio.Text.ToUpper();
            EntidadClientes.Fuerza = Fuerza;
            EntidadClientes.Grado = Grado;
            EntidadClientes.Fecha_Ingreso = dtpFechaIngreso.Value;
            if (dtpFechaSalida.Visible.Equals(true))
            {
                EntidadClientes.Fecha_Salida = dtpFechaSalida.Value;
            }
            else
            {
                EntidadClientes.Fecha_Salida = null;
            }
            EntidadClientes.Año_Contingente = Convert.ToInt32(txtAñoContingente.Text);
            EntidadClientes.Numero_Contigente = Convert.ToInt32(txtNumeroContingente.Text);
            EntidadClientes.Batallon = Batallon;
            EntidadClientes.Fecha_Hechos = dtpFechaHechos.Value;
            EntidadClientes.Dispensario = Dispensario;
            EntidadClientes.Estado_Proceso = Estado_Proceso;
            EntidadClientes.Etapa_Proceso = Etapa_Proceso;
            EntidadClientes.Fecha_Autenticado = Convert.ToDateTime(dtpFechaAutenticacion.Value);
            EntidadClientes.Fecha_Creado = System.DateTime.Now;
            EntidadClientes.Fecha_Actualizado = System.DateTime.Now;
            EntidadClientes.Usurio = Usuario_Login;
            bool validar_guardado = Negocio.Guardar(EntidadClientes);

            if (validar_guardado == true)
            {
                lblFechaCreacionSoftware.Visible = true;
                lblFechaCreado.Visible = true;
                lblFechaCreado.Text = Convert.ToString(EntidadClientes.Fecha_Creado);

                {
                    EntidadTelefonos.Numero_Telefono = txtTelefonoCelular.Text;
                    EntidadTelefonos.Doc_Cliente = txtNumeroDocumento.Text;
                    EntidadTelefonos.Fecha_Insertado = EntidadClientes.Fecha_Creado;
                    EntidadTelefonos.Fecha_Actualizado = EntidadClientes.Fecha_Actualizado;
                    EntidadTelefonos.Usuario = Usuario_Login;
                    bool ValidarRegistroTelefono = Telefono.GuardarTelefono(EntidadTelefonos);
                    if (ValidarRegistroTelefono == true)
                    {
                        MessageBox.Show("El teléfono ha sido cargado en la agenda correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("El teléfono no pudo ser cargado en la agenda, por favor diríjase a la agenda y créelo manualmente.");
                    }
                }

                if (txtTelefonoFijo.Text.Length > 0)
                {
                    EntidadTelefonos.Numero_Telefono = txtTelefonoFijo.Text;
                    EntidadTelefonos.Doc_Cliente = txtNumeroDocumento.Text;
                    EntidadTelefonos.Fecha_Insertado = EntidadClientes.Fecha_Creado;
                    EntidadTelefonos.Fecha_Actualizado = EntidadClientes.Fecha_Actualizado;
                    EntidadTelefonos.Usuario = Usuario_Login;
                    bool ValidarRegistroTelefono = Telefono.GuardarTelefono(EntidadTelefonos);
                    if (ValidarRegistroTelefono == true)
                    {
                        MessageBox.Show("El teléfono fijo ha sido cargado en la agenda correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("El teléfono fijo no pudo ser cargado en la agenda, por favor diríjase a la agenda y créelo manualmente.");
                    }

                }

                {
                    EntidadCorreos.Correo = txtCorreo.Text;
                    EntidadCorreos.Doc_Cliente = txtNumeroDocumento.Text;
                    EntidadCorreos.Fecha_Insertado = EntidadClientes.Fecha_Creado;
                    EntidadCorreos.Fecha_Actualizado = EntidadClientes.Fecha_Actualizado;
                    EntidadCorreos.Usuario = Usuario_Login;
                    bool ValidarRegistroCorreo = Correos.GuardarCorreo(EntidadCorreos);
                    if (ValidarRegistroCorreo == true)
                    {

                        MessageBox.Show("El Correo ha sido cargado en la agenda correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("El correo no pudo ser cargado en la agenda, por favor diríjase a la agenda y créelo manualmente.");
                    }

                }

                //bool validar_EnvioCorreo = Correo.EnviarCorreoDeBienvenida(EntidadClientes.Numero_Documento_Cliente);

                //if (validar_EnvioCorreo == true)
                //{
                //    MessageBox.Show("El Correo de bienvenida ha sido enviado correctamente");
                //}
                //else
                //{
                //    MessageBox.Show("El Correo de bienvenida no pudo ser enviado, por favor informe al administrador de la aplicación");
                //}

                MessageBox.Show("El Cliente ha sido creado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("El cliente no pudo ser creado, por favor verifique la información y oprima guardar");
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length > 0)
            {
                bool validar_Cliente_Existe = Negocio.ValidarSiClienteExiste(txtNumeroDocumento.Text);

                if (validar_Cliente_Existe != false)
                {

                    if (txtPrimerNombre.Text.Length > 0 || 75 <= txtPrimerNombre.Text.Length)
                    {
                        if (txtSegundoNombre.Text.Length <= 75)
                        {
                            if (txtOtroNombre.Text.Length <= 75)
                            {
                                if (txtPrimerApellido.Text.Length > 0 || 75 <= txtPrimerApellido.Text.Length)
                                {
                                    if (txtSegundoApellido.Text.Length <= 75)
                                    {
                                        if (cbTipoDocumento.SelectedValue != null)
                                        {
                                            if (txtNumeroDocumento.Text.Length > 0 || 18 <= txtNumeroDocumento.Text.Length)
                                            {
                                                if (cbDepartamentoExpedicion.SelectedValue != null)
                                                {
                                                    if (cbCiudadExpedicion.SelectedValue != null)
                                                    {
                                                        if (txtOtroLugarExpedicion.Text.Length <= 75)
                                                        {
                                                            if (cbTipoRegistro.SelectedValue != null)
                                                            {
                                                                if (txtNombreLugarRegistro.Text.Length > 0 || 75 <= txtNumeroDocumento.Text.Length)
                                                                {
                                                                    if (cbDepartamentoRegistro.SelectedValue != null)
                                                                    {
                                                                        if (cbCiudadRegistro.SelectedValue != null)
                                                                        {

                                                                            if (txtOtroLugarRegistro.Text.Length <= 75)
                                                                            {

                                                                                if (txtTelefonoFijo.Text.Length <= 18)
                                                                                {
                                                                                    if (txtTelefonoCelular.Text.Length > 0 || 18 <= txtTelefonoCelular.Text.Length)
                                                                                    {
                                                                                        if (txtCorreo.Text.Length > 0 || 100 <= txtCorreo.Text.Length)
                                                                                        {
                                                                                            if (cbRedSocial.SelectedValue != null)
                                                                                            {
                                                                                                if (txtNombreRedSocial.Text.Length <= 75)
                                                                                                {
                                                                                                    if (cbDepartamentoResdidencia.SelectedValue != null)
                                                                                                    {
                                                                                                        if (cbCiudadExpedicion.SelectedValue != null)
                                                                                                        {
                                                                                                            if (txtOtroLugarResidencia.Text.Length <= 75)
                                                                                                            {

                                                                                                                if (txtDireccionResidencia.Text.Length <= 75)
                                                                                                                {
                                                                                                                    if (txtBarrio.Text.Length <= 75)
                                                                                                                    {
                                                                                                                        if (cbFuerza.SelectedValue != null)
                                                                                                                        {
                                                                                                                            if (cbGrado.SelectedValue != null)
                                                                                                                            {
                                                                                                                                if (txtAñoContingente.Text.Length > 0 || 4 <= txtAñoContingente.Text.Length)
                                                                                                                                {
                                                                                                                                    if (txtNumeroContingente.Text.Length > 0 || 4 <= txtNumeroContingente.Text.Length)
                                                                                                                                    {
                                                                                                                                        Guardar();
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        MessageBox.Show("El número de contingente es obligatorio, debe digitar el número del contigente.");
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    MessageBox.Show("El año de contingente es obligatorio, debe digitar el número de año correspondiente.");
                                                                                                                                }


                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                MessageBox.Show("Debe seleccionar un grado válido.");
                                                                                                                            }


                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            MessageBox.Show("Debe seleccionar una fuerza armada válida.");
                                                                                                                        }

                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        MessageBox.Show("El barrio no es obligatorio, pero puede tener un máximo 75 caracteres.");
                                                                                                                    }

                                                                                                                }
                                                                                                                else
                                                                                                                {

                                                                                                                    MessageBox.Show("La dirección no es obligatoria, pero puede tener un máximo 75 caracteres.");
                                                                                                                }

                                                                                                            }
                                                                                                            else
                                                                                                            {

                                                                                                                MessageBox.Show("Otro lugar de residencia no es obligatorio, pero puede tener un máximo 75 caracteres.");
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            MessageBox.Show("Debe seleccionar una ciudad de residencia valida.");
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        MessageBox.Show("Debe seleccionar un departamento de residencia valido.");
                                                                                                    }
                                                                                                }

                                                                                                else
                                                                                                {
                                                                                                    MessageBox.Show("El nombre de la red social no es obligatorio, pero puede tener un máximo 75 caracteres.");
                                                                                                }

                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                MessageBox.Show("Debe seleccionar un tipo de red socialválido.");
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            MessageBox.Show("El correo electrónico es obligatorio y debe tener mínimo un carácter y máximo 150, si es más de un correo separarlo por punto y coma (;) y si el cliente no tiene correo debe crearle un nuevo correo.");
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("El teléfono celular es obligatorio y debe tener mínimo un caracter y máximo 18, todos los caracteres tienen que ser númericos sin comas, puntos o algún otro caracter especial.");
                                                                                    }

                                                                                }
                                                                                else
                                                                                {

                                                                                    MessageBox.Show("El teléfono fijo no es obligatorio, pero puede tener un máximo 18 caracteres, todos los caracteres tienen que ser númericos sin comas, puntos o algún otro caracter especial.");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("Otro lugar de registro no es obligatorio, pero puede tener un máximo 75 caracteres.");
                                                                            }


                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Debe seleccionar una ciudad de registro valida.");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Debe seleccionar un departamento de registro valido.");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("El nombre del lugar de nacimiento es obligatorio y debe tener mínimo un caracter y máximo 75.");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Debe seleccionar un tipo de registro de nacimiento válido.");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Otro lugar de expedición no es obligatorio, pero puede tener un máximo 75 caracteres.");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe seleccionar una ciudad de expedición valida.");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe seleccionar un departamento de expedición valido.");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("El número de documento es obligatorio y debe tener mínimo un caracter y máximo 18.");

                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe seleccionar un tipo de documento válido.");
                                        }



                                    }
                                    else { MessageBox.Show("El segundo apellido no es obligatorio, pero puede tener un máximo 75 caracteres."); }
                                }
                                else
                                {
                                    MessageBox.Show("El primer apellido es obligatorio y debe tener mínimo un caracter y máximo 75.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("El tercer nombre no es obligatorio, pero puede tener un máximo 75 caracteres.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El segundo nombre no es obligatorio, pero puede tener un máximo 75 caracteres.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El primer nombre es obligatorio y debe tener mínimo un caracter y máximo 75.");
                    }


                }
                else
                    MessageBox.Show("El cliente que está digitando, ya se encuentra registrado.");
            }
            else
            {

                MessageBox.Show("El número de documento del cliente es obligatorio,debe tener mínimo un caracter y máximo 18, todos los caracteres tienen que ser númericos sin comas, puntos o algún otro caracter especial.");
            }
        }

        private void RegistrarClientes_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        private void cbDepartamentoExpedicion_SelectedValueChanged(object sender, EventArgs e)
        {
            value_departamento_Expedicion = Convert.ToInt32(cbDepartamentoExpedicion.SelectedValue);
            CargarCiudadesExpedicion(value_departamento_Expedicion);
            departamento_Expedicion = Convert.ToString(Departamentos.MostrarDepartamentosNombre(value_departamento_Expedicion));



        }

        private void cbDepartamentoRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            value_departamento_Registro = Convert.ToInt32(cbDepartamentoRegistro.SelectedValue);
            CargarCiudadesRegistro(value_departamento_Registro);
            departamento_Registro = Convert.ToString(Departamentos.MostrarDepartamentosNombre(value_departamento_Registro));
        }

        private void cbDepartamentoResdidencia_SelectedValueChanged(object sender, EventArgs e)
        {
            value_departamento_Residencia = Convert.ToInt32(cbDepartamentoResdidencia.SelectedValue);
            CargarCiudadesResidencia(value_departamento_Residencia);
            departamento_Residencia = Convert.ToString(Departamentos.MostrarDepartamentosNombre(value_departamento_Residencia));
        }

        private void cbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            value_tipo_documento = Convert.ToInt32(cbTipoDocumento.SelectedValue);
            tipo_documento = Convert.ToString(tiposDocumentos.MostrarTipoDocumentosNombre(value_tipo_documento));

        }

        private void cbCiudadExpedicion_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Ciudad_Expedicion = Convert.ToInt32(cbCiudadExpedicion.SelectedValue);
            Ciudad_Expedicion = Convert.ToString(Ciudades.MostrarCiudadesNombre(value_departamento_Expedicion, value_Ciudad_Expedicion));
        }

        private void cbCiudadRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Ciudad_Registro = Convert.ToInt32(cbCiudadRegistro.SelectedValue);
            Ciudad_Registro = Convert.ToString(Ciudades.MostrarCiudadesNombre(value_departamento_Registro, value_Ciudad_Registro));
        }

        private void cbCiudadResidencia_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Ciudad_Residencia = Convert.ToInt32(cbCiudadResidencia.SelectedValue);
            Ciudad_Residencia = Convert.ToString(Ciudades.MostrarCiudadesNombre(value_departamento_Residencia, value_Ciudad_Residencia));
        }

        private void cbTipoRegistro_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Tipo_Registro = Convert.ToInt32(cbTipoRegistro.SelectedValue);
            Tipo_Registro = Convert.ToString(TipoRegistro.MostrarTipoRegistroNombre(value_Tipo_Registro));
        }

        private void cbRedSocial_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Red_Social = Convert.ToInt32(cbRedSocial.SelectedValue);
            Red_Social = Convert.ToString(RedesSociales.MostrarRedesSocialesNombre(value_Red_Social));
        }

        private void cbDispensarioMedico_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Dispensario = Convert.ToInt32(cbDispensarioMedico.SelectedValue);
            Dispensario = Convert.ToString(Dispensarios.MostrarDispensariosNombre(value_Dispensario));
        }

        private void cbBatallon_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Batallon = Convert.ToInt32(cbBatallon.SelectedValue);
            Batallon = Convert.ToString(Batallones.MostrarBatallonesNombre(value_Batallon));
        }

        private void cbFuerza_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Fuerza = Convert.ToInt32(cbFuerza.SelectedValue);
            CargarGrados(value_Fuerza);
            CargarBatallones(value_Fuerza);
            CargarDispensarios(value_Fuerza);
            Fuerza = Convert.ToString(FuerzaV.MostrarFuerzaNombre(value_Fuerza));
        }

        private void cbGrado_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Grado = Convert.ToInt32(cbGrado.SelectedValue);
            Grado = Convert.ToString(Grados.MostrarGradosNombre(value_Fuerza, value_Grado));
        }


        private void txtSegundoNombre_Validated(object sender, EventArgs e)
        {

            //MessageBoxButtons.OK("El cliente se encuentra activo dentro de la fuerza");
        }

        private void cbEstadoProceso_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Estado_Proceso = Convert.ToInt32(cbEstadoProceso.SelectedValue);
            Estado_Proceso = Convert.ToString(EstadosProcesos.MostrarEstadosProcesosNombre(value_Estado_Proceso));
        }

        private void cbEtapaProceso_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Etapa_Proceso = Convert.ToInt32(cbEtapaProceso.SelectedValue);
            Etapa_Proceso = Convert.ToString(EtapasProcesos.MostrarEtapasProcesosNombre(Value_Etapa_Proceso));
        }

        private void cbActivoFuerza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActivoFuerza.Checked == true)
            {
                lblFechaSalida.Visible = true;
                dtpFechaSalida.Visible = true;
            }
            else
            {
                lblFechaSalida.Visible = false;
                dtpFechaSalida.Visible = false;
            }
        }

        //private void txtCodigoFabricante_KeyPress(object sender,
        // KeyPressEventArgs e)
        //{
        //    //Para obligar a que sólo se introduzcan números
        //    if (Char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        //el resto de teclas pulsadas se desactivan
        //        e.Handled = true;
        //    }
        //}

        private void txtTelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAñoContingente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroContingente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 208) || (e.KeyChar >= 210 && e.KeyChar <= 240) || (e.KeyChar >= 242 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 208) || (e.KeyChar >= 210 && e.KeyChar <= 240) || (e.KeyChar >= 242 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtOtroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 208) || (e.KeyChar >= 210 && e.KeyChar <= 240) || (e.KeyChar >= 242 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 208) || (e.KeyChar >= 210 && e.KeyChar <= 240) || (e.KeyChar >= 242 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 208) || (e.KeyChar >= 210 && e.KeyChar <= 240) || (e.KeyChar >= 242 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipo_documento.Equals("Registro Civil") || tipo_documento.Equals("Cédula Extranjeria"))
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Solo letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else
            {

                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }


        //private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        //{
        //    dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
        //    dtpFechaNacimiento.CustomFormat = "yyyy/MM/dd";
        //}

        //private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        //{
        //    dtpFechaIngreso.Format = DateTimePickerFormat.Custom;
        //    dtpFechaIngreso.CustomFormat = "yyyy/MM/dd";
        //}

        //private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        //{
        //    dtpFechaSalida.Format = DateTimePickerFormat.Custom;
        //    dtpFechaSalida.CustomFormat = "yyyy/MM/dd";
        //}

        //private void dtpFechaHechos_ValueChanged(object sender, EventArgs e)
        //{
        //    dtpFechaHechos.Format = DateTimePickerFormat.Custom;
        //    dtpFechaHechos.CustomFormat = "yyyy/MM/dd";
        //}

        //private void dtpFechaAutenticacion_ValueChanged(object sender, EventArgs e)
        //{
        //    dtpFechaAutenticacion.Format = DateTimePickerFormat.Custom;
        //    dtpFechaAutenticacion.CustomFormat = "yyyy/MM/dd";
        //}
    }
}
