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
    public partial class ModificarClientes : Form
    {
        public string Numero_Documento_Cliente;
        public int Id_Perfil;
        public string Usuario;
        public ModificarClientes(string Numero_Documento_Cliente, int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            this.Numero_Documento_Cliente = Numero_Documento_Cliente;
            if (Numero_Documento_Cliente != null)
            {
                CargarCliente();
                CargarOpcionesModificar();
            }
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
        HistorialController Historial = new HistorialController();

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
        int id = 0;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;

        public void CargarCliente()
        {
            var Load_Cliente = Negocio.ConsultarClienteCedula(Numero_Documento_Cliente);

            foreach (var d in Load_Cliente)
            {
                id = d.id_Cliente;
                txtPrimerNombre.Text = d.Primer_Nombre;
                txtSegundoNombre.Text = d.Segundo_Nombre;
                txtOtroNombre.Text = d.Otro_Nombre;
                txtPrimerApellido.Text = d.Primer_Apellido;
                txtSegundoApellido.Text = d.Segundo_Apellido;
                tipo_documento = d.Tipo_Documento;
                CargarTiposDocumentosGenerado(tipo_documento);
                txtNumeroDocumento.Text = d.Numero_Documento_Cliente;
                departamento_Expedicion = d.Departamento_Expedicion;
                CargarDepartamentosExpedicionGenerado(departamento_Expedicion);
                value_departamento_Expedicion = Departamentos.MostrarDepartamentosValorId(departamento_Expedicion);
                Ciudad_Expedicion = d.Ciudad_Expedicion;
                CargarCiudadesExpedicionGenerado(Ciudad_Expedicion, value_departamento_Expedicion);
                txtOtroLugarExpedicion.Text = d.Otro_Lugar_Expedicion;
                dtpFechaNacimiento.Value = d.Fecha_Nacimiento;
                Tipo_Registro = d.Tipo_Registro;
                CargarTipoRegistroGenerado(Tipo_Registro);
                txtNombreLugarRegistro.Text = d.Nombre_Lugar_Registro;
                departamento_Registro = d.Departamento_Registro;
                CargarDepartamentosRegistroGenerado(departamento_Registro);
                value_departamento_Registro = Departamentos.MostrarDepartamentosValorId(departamento_Registro);
                Ciudad_Registro = d.Ciudad_Registro;
                CargarCiudadesRegistroGenerado(Ciudad_Registro, value_departamento_Registro);
                txtOtroLugarRegistro.Text = d.Otro_Lugar_Registro;
                txtTelefonoFijo.Text = d.Telefono_Fijo;
                txtTelefonoCelular.Text = d.Telefono_Celular;
                txtCorreo.Text = d.Correo;
                Red_Social = d.Red_Social;
                CargarRedesSocialesGenerado(Red_Social);
                txtNombreRedSocial.Text = d.Nombre_Red_Social;
                departamento_Residencia = d.Departamento_Residencia;
                CargarDepartamentosResidenciaGenerado(departamento_Residencia);
                value_departamento_Residencia = Departamentos.MostrarDepartamentosValorId(departamento_Residencia);
                Ciudad_Residencia = d.Ciudad_Residencia;
                CargarCiudadesResidenciaGenerado(Ciudad_Residencia, value_departamento_Residencia);
                txtOtroLugarResidencia.Text = d.Otro_Lugar_Residencia;
                cbxCasaPropia.Checked = d.Casa_Propia;
                txtDireccionResidencia.Text = d.Direccion_Residencia;
                txtBarrio.Text = d.Barrio;
                Fuerza = d.Fuerza;
                CargarFuerzaGenerado(Fuerza);
                Grado = d.Grado;
                CargarGradosGenerado(Grado);
                dtpFechaIngreso.Value = d.Fecha_Ingreso;
                if (d.Fecha_Salida != null)
                {
                    dtpFechaSalida.Value = Convert.ToDateTime(d.Fecha_Salida);
                    dtpFechaSalida.Visible = true;
                    lblFechaSalida.Visible = true;
                }
                else
                {
                    dtpFechaSalida.Value = DateTime.Now;
                }
                txtAñoContingente.Text = d.Año_Contingente.ToString();
                txtNumeroContingente.Text = d.Numero_Contigente.ToString();
                Batallon = d.Batallon;
                CargarBatallonesGenerado(Batallon);
                dtpFechaHechos.Value = Convert.ToDateTime(d.Fecha_Hechos);
                Dispensario = d.Dispensario;
                CargarDispensariosGenerado(Dispensario);
                Estado_Proceso = d.Estado_Proceso;
                CargarEstadosProcesosGenerado(Estado_Proceso);
                Etapa_Proceso = d.Etapa_Proceso;
                CargarEtapasProcesosGenerado(Etapa_Proceso);
                dtpFechaAutenticacion.Value = d.Fecha_Autenticado;
                lblFechaCreado.Text = d.Fecha_Creado.ToString();
                //EntidadClientes.Fecha_Actualizado = System.DateTime.Now;
                EntidadClientes.Usurio = d.Usurio;
            }
        }
        private void CargarOpcionesModificar()
        {
            cbListasModificar.Items.Add("Departamento / Ciudad Expedición");
            cbListasModificar.Items.Add("Departamento / Ciudad Registro");
            cbListasModificar.Items.Add("Departamento / Ciudad Residencia");
            cbListasModificar.Items.Add("Tipo Documento");
            cbListasModificar.Items.Add("Tipo Registro");
            cbListasModificar.Items.Add("Red Social");
            cbListasModificar.Items.Add("Fuerza");
            cbListasModificar.Items.Add("Grado");
            cbListasModificar.Items.Add("Batallon");
            cbListasModificar.Items.Add("Dispensario");
            cbListasModificar.Items.Add("Estado Proceso");
            cbListasModificar.Items.Add("Etapa Proceso");
            cbListasModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarEtapasProcesos()
        {
            var Load_Etapas_Procesos = EtapasProcesos.MostrarEtapasProcesos();
            cbEtapaProceso.DisplayMember = "Nombre_EtapasProceso";
            cbEtapaProceso.ValueMember = "id_EtapasProceso";
            cbEtapaProceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEtapaProceso.DataSource = Load_Etapas_Procesos;
            cbEtapaProceso.Enabled = true;

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
            cbGrado.Enabled = true;
        }
        private void CargarFuerza()
        {
            var Load_Cargar_Fuerza = FuerzaV.MostrarFuerza();
            cbFuerza.DisplayMember = "Nombre_Fuerza";
            cbFuerza.ValueMember = "id_Fuerza";
            cbFuerza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuerza.DataSource = Load_Cargar_Fuerza;
            cbFuerza.Enabled = true;
        }

        private void CargarBatallones(int value_fuerza)
        {
            var Load_Cargar_Batallones = Batallones.MostrarBatallones(value_fuerza);
            cbBatallon.DisplayMember = "Nombre_Batallon";
            cbBatallon.ValueMember = "id_Batallon";
            cbBatallon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatallon.DataSource = Load_Cargar_Batallones;
            cbBatallon.Enabled = true;
        }

        private void CargarDispensarios(int value_fuerza)
        {
            var Load_Cargar_Dispensarios = Dispensarios.MostrarDispensarios(value_fuerza);
            cbDispensarioMedico.DisplayMember = "Nombre_Dispensario";
            cbDispensarioMedico.ValueMember = "id_Dispensario";
            cbDispensarioMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDispensarioMedico.DataSource = Load_Cargar_Dispensarios;
            cbDispensarioMedico.Enabled = true;
        }

        private void CargarRedesSociales()
        {
            var Load_Redes_Sociales = RedesSociales.MostrarRedesSociales();
            cbRedSocial.DisplayMember = "Nombre_Red_Social";
            cbRedSocial.ValueMember = "id_RedSocial";
            cbRedSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRedSocial.DataSource = Load_Redes_Sociales;
            cbRedSocial.Enabled = true;
        }
        private void CargarTipoRegistro()
        {
            var load_TipoRegistro = TipoRegistro.MostrarTipoRegistro();
            cbTipoRegistro.DisplayMember = "Nombre_Tipo_Registro";
            cbTipoRegistro.ValueMember = "id_Tipo_Registro";
            cbTipoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoRegistro.DataSource = load_TipoRegistro;
            cbTipoRegistro.Enabled = true;
        }
        private void CargarTiposDocumentos()
        {
            var Load_TiposDocumentos = tiposDocumentos.MostrarTipoDocumentos();
            cbTipoDocumento.DisplayMember = "Nombre_Tipo_Documento";
            cbTipoDocumento.ValueMember = "id_Tipo_Documento";
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.DataSource = Load_TiposDocumentos;
            cbTipoDocumento.Enabled = true;
        }

        private void CargarDepartamentosExpedicion()
        {
            var Load_Departamentos = Departamentos.MostrarDepartamentos();
            cbDepartamentoExpedicion.DisplayMember = "Nombre_Departamento";
            cbDepartamentoExpedicion.ValueMember = "id_Departamento";
            cbDepartamentoExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoExpedicion.DataSource = Load_Departamentos;
            cbDepartamentoExpedicion.Enabled = true;
        }
        private void CargarDepartamentosRegistro()
        {
            var Load_Departamentos_Registro = Departamentos.MostrarDepartamentos();
            cbDepartamentoRegistro.DisplayMember = "Nombre_Departamento";
            cbDepartamentoRegistro.ValueMember = "id_Departamento";
            cbDepartamentoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoRegistro.DataSource = Load_Departamentos_Registro;
            cbDepartamentoRegistro.Enabled = true;
        }

        private void CargarDepartamentosResidencia()
        {
            var Load_Departamentos_Residencia = Departamentos.MostrarDepartamentos();
            cbDepartamentoResdidencia.DisplayMember = "Nombre_Departamento";
            cbDepartamentoResdidencia.ValueMember = "id_Departamento";
            cbDepartamentoResdidencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoResdidencia.DataSource = Load_Departamentos_Residencia;
            cbDepartamentoResdidencia.Enabled = true;

        }

        private void CargarCiudadesExpedicion(int value)
        {
            var Load_Ciudades_Expedicion = Ciudades.MostrarCiudades(value);
            cbCiudadExpedicion.DisplayMember = "Nombre_Ciudad";
            cbCiudadExpedicion.ValueMember = "id_Ciudad";
            cbCiudadExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadExpedicion.DataSource = Load_Ciudades_Expedicion;
            cbCiudadExpedicion.Enabled = true;
        }

        private void CargarCiudadesRegistro(int value)
        {
            var Load_Ciudades_Registro = Ciudades.MostrarCiudades(value);
            cbCiudadRegistro.DisplayMember = "Nombre_Ciudad";
            cbCiudadRegistro.ValueMember = "id_Ciudad";
            cbCiudadRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadRegistro.DataSource = Load_Ciudades_Registro;
            cbCiudadRegistro.Enabled = true;
        }

        private void CargarCiudadesResidencia(int value)
        {
            var Load_Ciudades_Residencia = Ciudades.MostrarCiudades(value);
            cbCiudadResidencia.DisplayMember = "Nombre_Ciudad";
            cbCiudadResidencia.ValueMember = "id_Ciudad";
            cbCiudadResidencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadResidencia.DataSource = Load_Ciudades_Residencia;
            cbCiudadResidencia.Enabled = true;
        }

        private void CargarEtapasProcesosGenerado(string value)
        {
            var Load_Etapas_Procesos = EtapasProcesos.MostrarEtapasProcesosValor(value);
            cbEtapaProceso.DisplayMember = "Nombre_EtapasProceso";
            cbEtapaProceso.ValueMember = "id_EtapasProceso";
            cbEtapaProceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEtapaProceso.DataSource = Load_Etapas_Procesos;
            cbEtapaProceso.Enabled = false;

        }
        private void CargarEstadosProcesosGenerado(string value)
        {
            var Load_Estados_Procesos = EstadosProcesos.MostrarEstadosProcesosValor(value);
            cbEstadoProceso.DisplayMember = "Nombre_Estado_Proceso";
            cbEstadoProceso.ValueMember = "id_Estado_Proceso";
            cbEstadoProceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoProceso.DataSource = Load_Estados_Procesos;
            cbEstadoProceso.Enabled = false;
        }
        private void CargarGradosGenerado(string value)
        {
            var Load_Cargar_Grados = Grados.MostrarGradosValor(value);
            cbGrado.DisplayMember = "Nombre_Rago";
            cbGrado.ValueMember = "id_grado";
            cbGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrado.DataSource = Load_Cargar_Grados;
            cbGrado.Enabled = false;
        }
        private void CargarFuerzaGenerado(string value)
        {
            var Load_Cargar_Fuerza = FuerzaV.MostrarFuerzaValor(value);
            cbFuerza.DisplayMember = "Nombre_Fuerza";
            cbFuerza.ValueMember = "id_Fuerza";
            cbFuerza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuerza.DataSource = Load_Cargar_Fuerza;
            cbFuerza.Enabled = false;
        }

        private void CargarBatallonesGenerado(string value)
        {
            var Load_Cargar_Batallones = Batallones.MostrarBatallonesValor(value);
            cbBatallon.DisplayMember = "Nombre_Batallon";
            cbBatallon.ValueMember = "id_Batallon";
            cbBatallon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBatallon.DataSource = Load_Cargar_Batallones;
            cbBatallon.Enabled = false;
        }

        private void CargarDispensariosGenerado(string value)
        {
            var Load_Cargar_Dispensarios = Dispensarios.MostrarDispensariosValor(value);
            cbDispensarioMedico.DisplayMember = "Nombre_Dispensario";
            cbDispensarioMedico.ValueMember = "id_Dispensario";
            cbDispensarioMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDispensarioMedico.DataSource = Load_Cargar_Dispensarios;
            cbDispensarioMedico.Enabled = false;
        }

        private void CargarRedesSocialesGenerado(string value)
        {
            var Load_Redes_Sociales = RedesSociales.MostrarRedesSocialesValor(value);
            cbRedSocial.DisplayMember = "Nombre_Red_Social";
            cbRedSocial.ValueMember = "id_RedSocial";
            cbRedSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRedSocial.DataSource = Load_Redes_Sociales;
            cbRedSocial.Enabled = false;
        }
        private void CargarTipoRegistroGenerado(string value)
        {
            var load_TipoRegistro = TipoRegistro.MostrarTipoRegistroValor(value);
            cbTipoRegistro.DisplayMember = "Nombre_Tipo_Registro";
            cbTipoRegistro.ValueMember = "id_Tipo_Registro";
            cbTipoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoRegistro.DataSource = load_TipoRegistro;
            cbTipoRegistro.Enabled = false;
        }
        private void CargarTiposDocumentosGenerado(string value)
        {
            var Load_TiposDocumentos = tiposDocumentos.MostrarTipoDocumentosValor(value);
            cbTipoDocumento.DisplayMember = "Nombre_Tipo_Documento";
            cbTipoDocumento.ValueMember = "id_Tipo_Documento";
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.DataSource = Load_TiposDocumentos;
            cbTipoDocumento.Enabled = false;
        }

        private void CargarDepartamentosExpedicionGenerado(string value)
        {
            var Load_Departamentos = Departamentos.MostrarDepartamentosValor(value);
            cbDepartamentoExpedicion.DisplayMember = "Nombre_Departamento";
            cbDepartamentoExpedicion.ValueMember = "id_Departamento";
            cbDepartamentoExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoExpedicion.DataSource = Load_Departamentos;
            cbDepartamentoExpedicion.Enabled = false;
        }
        private void CargarDepartamentosRegistroGenerado(string value)
        {
            var Load_Departamentos_Registro = Departamentos.MostrarDepartamentosValor(value);
            cbDepartamentoRegistro.DisplayMember = "Nombre_Departamento";
            cbDepartamentoRegistro.ValueMember = "id_Departamento";
            cbDepartamentoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoRegistro.DataSource = Load_Departamentos_Registro;
            cbDepartamentoRegistro.Enabled = false;
        }

        private void CargarDepartamentosResidenciaGenerado(string value)
        {
            var Load_Departamentos_Residencia = Departamentos.MostrarDepartamentosValor(value);
            cbDepartamentoResdidencia.DisplayMember = "Nombre_Departamento";
            cbDepartamentoResdidencia.ValueMember = "id_Departamento";
            cbDepartamentoResdidencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoResdidencia.DataSource = Load_Departamentos_Residencia;
            cbDepartamentoResdidencia.Enabled = false;

        }

        private void CargarCiudadesExpedicionGenerado(string value, int dep)
        {
            var Load_Ciudades_Expedicion = Ciudades.MostrarCiudadesValor(value, dep);
            cbCiudadExpedicion.DisplayMember = "Nombre_Ciudad";
            cbCiudadExpedicion.ValueMember = "id_Ciudad";
            cbCiudadExpedicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadExpedicion.DataSource = Load_Ciudades_Expedicion;
            cbCiudadExpedicion.Enabled = false;
        }
        private void CargarCiudadesRegistroGenerado(string value, int dep)
        {
            var Load_Ciudades_Registro = Ciudades.MostrarCiudadesValor(value, dep);
            cbCiudadRegistro.DisplayMember = "Nombre_Ciudad";
            cbCiudadRegistro.ValueMember = "id_Ciudad";
            cbCiudadRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadRegistro.DataSource = Load_Ciudades_Registro;
            cbCiudadRegistro.Enabled = false;
        }
        private void CargarCiudadesResidenciaGenerado(string value, int dep)
        {
            var Load_Ciudades_Residencia = Ciudades.MostrarCiudadesValor(value, dep);
            cbCiudadResidencia.DisplayMember = "Nombre_Ciudad";
            cbCiudadResidencia.ValueMember = "id_Ciudad";
            cbCiudadResidencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadResidencia.DataSource = Load_Ciudades_Residencia;
            cbCiudadResidencia.Enabled = false;
        }

        private void Guardar()
        {
            bool validar_guardado = false;
            {
                EntidadClientes.id_Cliente = id;
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
                EntidadClientes.Barrio = txtBarrio.Text;
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
                EntidadClientes.Fecha_Autenticado = Convert.ToDateTime(dtpFechaAutenticacion.Text);
                EntidadClientes.Fecha_Creado = Convert.ToDateTime(lblFechaCreado.Text);
                EntidadClientes.Fecha_Actualizado = System.DateTime.Now;
                EntidadClientes.Usurio = EntidadClientes.Usurio;
            }
            bool validar_copia = Historial.HistorialTablaClientes(EntidadClientes.Numero_Documento_Cliente, Usuario_Login, "Modificar", System.DateTime.Now);
            if (validar_copia == true)
            {

                validar_guardado = Negocio.Modificar(EntidadClientes);


                if (validar_guardado == true)
                {
                    lblActualizacion.Visible = true;
                    lblFechaActualizado.Visible = true;
                    lblFechaActualizado.Text = Convert.ToString(EntidadClientes.Fecha_Actualizado);

                    MessageBox.Show("La información del cliente ha sido guardada en la tabla historica.");
                    DialogResult ok = MessageBox.Show("El Cliente ha sido actualizado correctamente, por favor oprima aceptar.", "El Cliente ha sido actualizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (ok == DialogResult.OK)
                    {
                        salir();
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no pudo ser actualizado, por favor verifique la información y oprima guardar cambios");
                }
            }
            else
            {
                MessageBox.Show("La información del cliente no pudo ser guardada en la tabla historica, verifique y vuelva a intentarlo.");
            }
        }

        private void salir()
        {
            this.Close();
            //ModificarClientes ModificarClientes2 = new ModificarClientes(txtNumeroDocumento.Text);
            //ModificarClientes2.ShowDialog();
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
            Fuerza = Convert.ToString(FuerzaV.MostrarFuerzaNombre(value_Fuerza));

        }

        private void cbGrado_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Grado = Convert.ToInt32(cbGrado.SelectedValue);
            Grado = Convert.ToString(Grados.MostrarGradosNombre(value_Fuerza, value_Grado));
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

        private void cbListasModificar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbListasModificar.SelectedItem != null)
            {
                if (cbListasModificar.SelectedItem.Equals("Departamento / Ciudad Expedición"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarDepartamentosExpedicion();
                    }
                    else
                    {
                        return;
                    }

                }
                if (cbListasModificar.SelectedItem.Equals("Departamento / Ciudad Registro"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarDepartamentosRegistro();
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Departamento / Ciudad Residencia"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarDepartamentosResidencia();
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Tipo Documento"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarTiposDocumentos();
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Tipo Registro"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarTipoRegistro();
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Red Social"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarRedesSociales();
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Fuerza"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarFuerza();
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Grado"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        value_Fuerza = value_Fuerza = Convert.ToInt32(cbFuerza.SelectedValue);
                        CargarGrados(value_Fuerza);
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Batallon"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarBatallones(value_Fuerza);
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Dispensario"))
                {

                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarDispensarios(value_Fuerza);
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Estado Proceso"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarEstadosProcesos();
                    }
                    else
                    {
                        return;
                    }
                }
                if (cbListasModificar.SelectedItem.Equals("Etapa Proceso"))
                {
                    DialogResult seleccion = MessageBox.Show("¿esta seguro que quiere modificar la lista: " + cbListasModificar.SelectedItem.ToString() + "?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (seleccion == DialogResult.OK)
                    {
                        CargarEtapasProcesos();
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length > 0)
            {
                bool validar_Cliente_Existe = Negocio.ValidarSiClienteExiste(txtNumeroDocumento.Text);
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
                    MessageBox.Show("El número de documento del cliente que digito, aun no se encuentra registrado en el sistema.");
            }
            else
            {

                MessageBox.Show("El número de documento del cliente es obligatorio,debe tener mínimo un caracter y máximo 18, todos los caracteres tienen que ser númericos sin comas, puntos o algún otro caracter especial.");
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
