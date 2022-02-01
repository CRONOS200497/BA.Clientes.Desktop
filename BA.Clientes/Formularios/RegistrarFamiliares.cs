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


namespace BA.Clientes.Formularios
{
    public partial class RegistrarFamiliares : Form
    {
        public int Perfil_Rol;
        public string Usuario;
        public RegistrarFamiliares(int Id_Perfil, string User)
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
            CargarEtapasProcesos();
            CargarEstadosProcesos();
            CargarTipoFamiliar();
        }

        ClientesController Negocio = new ClientesController();
        DepartamentoController Departamentos = new DepartamentoController();
        CiudadesController Ciudades = new CiudadesController();
        ClientesViews EntidadClientes = new ClientesViews();
        FamiliaViews EntidadFamilia = new FamiliaViews();
        TipoDocumentoController tiposDocumentos = new TipoDocumentoController();
        TipoRegistroController TipoRegistro = new TipoRegistroController();
        RedesSocialesController RedesSociales = new RedesSocialesController();
        EtapasProcesosController EtapasProcesos = new EtapasProcesosController();
        EstadosProcesosController EstadosProcesos = new EstadosProcesosController();
        TipoFamiliarController TipoFamiliar = new TipoFamiliarController();
        FamiliaController Familia = new FamiliaController();
        TelefonosFamiliaController Telefono = new TelefonosFamiliaController();
        CorreosFamiliaController Correos = new CorreosFamiliaController();
        TelefonosFamiliaViews EntidadTelefonos = new TelefonosFamiliaViews();
        CorreosFamiliaViews EntidadCorreos = new CorreosFamiliaViews();

        int value_tipo_documento = 0;
        int value_departamento_Expedicion = 0;
        int value_departamento_Registro = 0;
        int value_departamento_Residencia = 0;
        int value_Ciudad_Expedicion = 0;
        int value_Ciudad_Registro = 0;
        int value_Ciudad_Residencia = 0;
        int value_Tipo_Registro = 0;
        int value_Red_Social = 0;
        int value_parentesco = 0;
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
        string Parentesco = string.Empty;
        string Usuario_Login = string.Empty;
        string Estado_Proceso = string.Empty;
        string Etapa_Proceso = string.Empty;
        int PerfilRol = 0;

        private void CargarTipoFamiliar()
        {
            var Load_Tipo_Familiar = TipoFamiliar.MostrarTipoFamiliar();
            cbParentesco.DisplayMember = "Nombre";
            cbParentesco.ValueMember = "id_Tipo_Familiar";
            cbParentesco.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParentesco.DataSource = Load_Tipo_Familiar;
        }

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
            EntidadFamilia.Numero_Documento_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadFamilia.Parentesco = Parentesco;
            EntidadFamilia.Primer_Nombre = txtPrimerNombre.Text.ToUpper();
            EntidadFamilia.Segundo_Nombre = txtSegundoNombre.Text.ToUpper();
            if (txtOtroNombre.Visible.Equals(true))
            {
                EntidadFamilia.Otro_Nombre = txtOtroNombre.Text.ToUpper();
            }
            else
            {
                EntidadFamilia.Otro_Nombre = "";
            }
            EntidadFamilia.Primer_Apellido = txtPrimerApellido.Text.ToUpper();
            EntidadFamilia.Segundo_Apellido = txtSegundoApellido.Text.ToUpper();
            EntidadFamilia.Tipo_Documento = tipo_documento;
            EntidadFamilia.Numero_Documento = txtNumeroDocumento.Text;
            EntidadFamilia.Departamento_Expedicion = departamento_Expedicion;
            EntidadFamilia.Ciudad_Expedicion = Ciudad_Expedicion;
            if (txtOtroLugarExpedicion.Text.Length > 0)
            {
                EntidadFamilia.Otro_Lugar_Expedicion = txtOtroLugarExpedicion.Text.ToUpper();
            }
            else
            {
                EntidadFamilia.Otro_Lugar_Expedicion = "";
            }
            EntidadFamilia.Fecha_Nacimiento = dtpFechaNacimiento.Value;
            EntidadFamilia.Tipo_Registro = Tipo_Registro;
            EntidadFamilia.Nombre_Lugar_Registro = txtNombreLugarRegistro.Text;
            EntidadFamilia.Departamento_Registro = departamento_Registro;
            EntidadFamilia.Ciudad_Registro = Ciudad_Registro;
            if (txtOtroLugarRegistro.Text.Length > 0)
            {
                EntidadFamilia.Otro_Lugar_Registro = txtOtroLugarRegistro.Text;
            }
            else
            {
                EntidadFamilia.Otro_Lugar_Registro = "";
            }
            EntidadFamilia.Telefono_Fijo = txtTelefonoFijo.Text;
            EntidadFamilia.Telefono_Celular = txtTelefonoCelular.Text;
            EntidadFamilia.Correo = txtCorreo.Text;
            EntidadFamilia.Red_Social = Red_Social;
            EntidadFamilia.Nombre_Red_Social = txtNombreRedSocial.Text;
            if (value_departamento_Residencia == 0)
            {

                MessageBox.Show("Seleccione un departamento de residencia valido");
                return;
            }
            else
            {
                EntidadFamilia.Departamento_Residencia = departamento_Residencia;
            }

            EntidadFamilia.Ciudad_Residencia = Ciudad_Residencia;
            if (txtOtroLugarResidencia.Text.Length > 0)
            {
                EntidadFamilia.Otro_Lugar_Residencia = txtOtroLugarResidencia.Text.ToUpper();
            }
            else
            {
                EntidadFamilia.Otro_Lugar_Residencia = "";
            }
            if (cbxCasaPropia.Checked == true)
            {
                EntidadFamilia.Casa_Propia = Convert.ToBoolean(cbxCasaPropia.Checked);
            }
            else
            {
                EntidadFamilia.Casa_Propia = false;
            }
            EntidadFamilia.Direccion_Residencia = txtDireccionResidencia.Text;
            EntidadFamilia.Barrio = txtBarrio.Text;
            EntidadFamilia.Estado_Proceso = Estado_Proceso;
            EntidadFamilia.Etapa_Proceso = Etapa_Proceso;
            EntidadFamilia.Fecha_Autenticacion = Convert.ToDateTime(dtpFechaAutenticacion.Text);
            EntidadFamilia.Fecha_Creacion = System.DateTime.Now;
            EntidadFamilia.Fecha_Actualizacion = System.DateTime.Now;
            EntidadFamilia.Usurio = Usuario_Login;
            bool validar_guardado = Familia.Guardar(EntidadFamilia);

            if (validar_guardado == true)
            {
                lblFechaCreacionSoftware.Visible = true;
                lblFechaCreado.Visible = true;
                lblFechaCreado.Text = Convert.ToString(EntidadFamilia.Fecha_Creacion);

                {
                    EntidadTelefonos.Numero_Telefono = txtTelefonoCelular.Text;
                    EntidadTelefonos.Doc_Familiar = txtNumeroDocumento.Text;
                    EntidadTelefonos.Fecha_Insertado = EntidadFamilia.Fecha_Creacion;
                    EntidadTelefonos.Fecha_Actualizado = EntidadFamilia.Fecha_Actualizacion;
                    EntidadTelefonos.Usuario = Usuario_Login;
                    bool ValidarRegistroTelefono = Telefono.GuardarTelefonoFamilia(EntidadTelefonos);
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
                    EntidadTelefonos.Doc_Familiar = txtNumeroDocumento.Text;
                    EntidadTelefonos.Fecha_Insertado = EntidadFamilia.Fecha_Creacion;
                    EntidadTelefonos.Fecha_Actualizado = EntidadFamilia.Fecha_Actualizacion;
                    EntidadTelefonos.Usuario = Usuario_Login;
                    bool ValidarRegistroTelefono = Telefono.GuardarTelefonoFamilia(EntidadTelefonos);
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
                    EntidadCorreos.Doc_Familiar = txtNumeroDocumento.Text;
                    EntidadCorreos.Fecha_Insertado = EntidadFamilia.Fecha_Creacion;
                    EntidadCorreos.Fecha_Actualizado = EntidadFamilia.Fecha_Actualizacion;
                    EntidadCorreos.Usuario = Usuario_Login;
                    bool ValidarRegistroCorreo = Correos.GuardarCorreoFamilia(EntidadCorreos);
                    if (ValidarRegistroCorreo == true)
                    {

                        MessageBox.Show("El Correo ha sido cargado en la agenda correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("El correo no pudo ser cargado en la agenda, por favor diríjase a la agenda y créelo manualmente.");
                    }

                }
                MessageBox.Show("El familiar ha sido asociado correctamente, al cliente con número de identificación: " + txtNumeroIdentificacionCliente.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("El familiar no pudo ser asociado, por favor verifique la información y oprima guardar");
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length > 0)
            {
                bool validar_Cliente_Existe = Negocio.ValidarSiClienteExiste(txtNumeroIdentificacionCliente.Text);

                if (validar_Cliente_Existe == false)
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

                                                                                                                        Guardar();
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
                    MessageBox.Show("El cliente al cual le va a asociar un familiar, no se encuentra registrado.");
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
        }

        private void cbParentesco_SelectedValueChanged(object sender, EventArgs e)
        {
            value_parentesco = Convert.ToInt32(cbParentesco.SelectedValue);
            Parentesco = Convert.ToString(TipoFamiliar.MostrarTipoFamiliarNombre(value_parentesco));
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

        private void txtTelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
