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
    public partial class Tareas : Form
    {
        public int Id_Perfil;
        public string Usuario;
        public Tareas(int Id_Perfil, string User, int id_Solicitud)
        {
            if (id_Solicitud == 0)
            {
                Usuario_Login = User;
                PerfilRol = Id_Perfil;
                InitializeComponent();
                MostrarAreas();
                MostrarPrioridad();
                MostrarEstado();
                btnGuardar.Enabled = true;
            }
            else
            {
                Usuario_Login = User;
                PerfilRol = Id_Perfil;
                Id_Solicitud = id_Solicitud;
                InitializeComponent();
                Id_Solicitud = id_Solicitud;
                CargarTarea(id_Solicitud);
            }
        }

        ClientesController Negocio = new ClientesController();
        FamiliaController Familiar = new FamiliaController();
        RegistrarTareasController RegistrarTareas = new RegistrarTareasController();
        AreasController Areas = new AreasController();
        TipoTareaController TipoTareas = new TipoTareaController();
        AreasTareasController AreasTarea = new AreasTareasController();
        UsuariosAreaController UsuarioArea = new UsuariosAreaController();
        PrioridadController Prioridad = new PrioridadController();
        EstadoTareaController EstadoTarea = new EstadoTareaController();
        RegistrarTareasViews EntidadTareas = new RegistrarTareasViews();
        RolesController Rol = new RolesController();
        ParametrosControllers Parametros = new ParametrosControllers();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int Value_Area = 0;
        string Nombre_Area = string.Empty;
        int Value_Tipo_Tarea = 0;
        string Nombre_Tipo_Tarea = string.Empty;
        int Value_Tarea = 0;
        string Nombre_Tarea = string.Empty;
        int Value_Responsable = 0;
        string Nombre_Responsable = string.Empty;
        int Value_Prioridad = 0;
        string Nombre_Prioridad = string.Empty;
        int Value_Estado = 0;
        string Nombre_Estado = string.Empty;
        int numero_archivo = 0;
        int Id_Solicitud = 0;
        int Id_Tarea = 0;
        string Creador = string.Empty;
        string Responsable_Sol_Seguimiento = string.Empty;
        string Ruta_Archivo_Oculta = string.Empty;


        private void Tareas_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void CargarTarea(int id_Solicitud)
        {
            var Consultar_Solicitud = RegistrarTareas.MostrarTareasPorIDParaSeguimiento(id_Solicitud);
            foreach (var e in Consultar_Solicitud)
            {
                Id_Solicitud = e.id_Solicitud;
                Nombre_Area = e.Area_Creadora;
                MostrarAreas_Seguimiento(Nombre_Area);
                Id_Tarea = e.id_Tarea;
                MostrarTipoTarea_Tarea(Id_Tarea);
                MostrarTipoTarea_Seguimiento(Nombre_Area, Nombre_Tipo_Tarea);
                MostrarTareas_Seguimiento(Nombre_Area, Nombre_Tipo_Tarea, Nombre_Tarea);
                Responsable_Sol_Seguimiento = e.Responsable;
                Responsable_Seguimiento(Nombre_Responsable, Nombre_Area);
                Creador = e.Creador;
                txtNumeroIdentificacionCliente.Text = e.Doc_Cliente;
                txtPrimerNombreCliente.Text = e.Primer_Nombre;
                txtSegundoNombreCliente.Text = e.Segundo_Nombre;
                txtPrimerApellidoCliente.Text = e.Primer_Apellido;
                txtSegundoApellidoCliente.Text = e.Segundo_Apellido;
                txtDescripcion.Text = e.Descripcion;
                Nombre_Prioridad = e.Prioridad;
                MostrarPrioridad_Seguimiento(Nombre_Prioridad);
                Nombre_Estado = e.Estado;
                MostrarEstado_Seguimiento(Nombre_Estado);
                cbAdjuntar.Checked = e.Adjunto;
                cbNotificarCliente.Checked = e.Notificar_Responsable;
                //txtRuta.Text = e.Ruta;
                Ruta_Archivo_Oculta = e.Ruta;
                if (Ruta_Archivo_Oculta.Length > 0)
                {
                    btnAdjunto.Enabled = true;
                }
                else
                {
                    btnAdjunto.Enabled = false;
                }
                txtNombreArchivo.Text = e.Nombre_Archivo;
                lblCreado.Text = e.Fecha_Asignado.ToString();
                lblModificado.Text = e.Fecha_Actualizado.ToString();
                txtNumeroIdentificacionCliente.Enabled = false;
                txtPrimerNombreCliente.Enabled = false;
                txtSegundoNombreCliente.Enabled = false;
                txtPrimerApellidoCliente.Enabled = false;
                txtSegundoApellidoCliente.Enabled = false;
                btnBuscar.Enabled = false;
                btnNuevaBusqueda.Enabled = false;
                lblCreado.Visible = true;
                lblModificado.Visible = true;
                btnGuardar.Enabled = false;
                cbArea.Enabled = false;
                cbTipoTarea.Enabled = false;
                cbTarea.Enabled = false;
                cbResponsable.Enabled = false;
                cbPrioridad.Enabled = false;
                cbEstado.Enabled = false;
                cbAdjuntar.Enabled = false;
                cbNotificarCliente.Enabled = false;
                btnAdjuntarDocumento.Enabled = false;
                txtDescripcion.Enabled = false;
                btnSeguimiento.Enabled = true;
                btnAdjunto.Enabled = true;
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
                        btnGuardar.Enabled = true;
                        btnSeguimiento.Enabled = false;
                        btnBuscar.Enabled = false;
                    }
                }
                else if (validar_Cliente_Existe == true)
                {
                    bool validar_Familiar_Existe = RegistrarTareas.ValidarSiFamiliarExiste(txtNumeroIdentificacionCliente.Text);
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
                            btnGuardar.Enabled = true;
                            btnSeguimiento.Enabled = false;
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
            cbAdjuntar.Checked = false;
            txtRuta.Clear();
            txtNombreArchivo.Clear();
            txtDescripcion.Clear();
            btnGuardar.Enabled = true;
            btnSeguimiento.Enabled = false;
            btnBuscar.Enabled = true;
            cbTipoTarea.Enabled = true;
            cbTarea.Enabled = true;
            cbResponsable.Enabled = true;
        }

        private void cbAdjuntar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdjuntar.Checked == true)
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

        private void MostrarTipoTarea_Tarea(int id_Tarea)
        {
            var Load_TipoTarea_Tarea = AreasTarea.MostrarAreasTareasPorSeleccion(id_Tarea);
            foreach (var e in Load_TipoTarea_Tarea)
            {
                Nombre_Area = e.Area;
                Nombre_Tipo_Tarea = e.Tipo_Tarea;
                Nombre_Tarea = e.Tarea;
            }
        }


        private void MostrarAreas()
        {
            var Load_Mostrar_Areas = Areas.MostrarAreas();
            cbArea.DisplayMember = "Nombre_Area";
            cbArea.ValueMember = "id_Area";
            cbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArea.DataSource = Load_Mostrar_Areas;
        }

        private void MostrarAreas_Seguimiento(string Area)
        {
            var Load_Mostrar_Areas = Areas.MostrarAreaPorNombre(Area);
            cbArea.DisplayMember = "Nombre_Area";
            cbArea.ValueMember = "id_Area";
            cbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArea.DataSource = Load_Mostrar_Areas;
        }

        private void MostrarTipoTarea(string Area)
        {
            var Load_Tipo_Tareas = AreasTarea.MostrarAreasTareasPorArea(Area);
            cbTipoTarea.DisplayMember = "Tipo_Tarea";
            cbTipoTarea.ValueMember = "id";
            cbTipoTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTarea.DataSource = Load_Tipo_Tareas;
        }

        private void MostrarTipoTarea_Seguimiento(string Area, string Tipo_Tarea)
        {
            var Load_Tipo_Tareas = AreasTarea.MostrarAreasTareasPorTipoTareaSeguimiento(Area, Tipo_Tarea);
            cbTipoTarea.DisplayMember = "Tipo_Tarea";
            cbTipoTarea.ValueMember = "id";
            cbTipoTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoTarea.DataSource = Load_Tipo_Tareas;
        }

        private void MostrarTareas(string Tipo_Tarea)
        {
            var Load_Tareas = AreasTarea.MostrarAreasTareasPorTipoTarea(Tipo_Tarea);
            cbTarea.DisplayMember = "Tarea";
            cbTarea.ValueMember = "id";
            cbTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTarea.DataSource = Load_Tareas;
        }

        private void MostrarTareas_Seguimiento(string Area, string Tipo_Tarea, string Tarea)
        {
            var Load_Tareas = AreasTarea.MostrarAreasTareasPorTipoTareaSeguimiento(Area, Tipo_Tarea, Tarea);
            cbTarea.DisplayMember = "Tarea";
            cbTarea.ValueMember = "id";
            cbTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTarea.DataSource = Load_Tareas;
        }

        private void Responsable(string Area)
        {
            var Load_Responsables = UsuarioArea.MostrarUsuariosArea(Area);
            cbResponsable.DisplayMember = "Usuario";
            cbResponsable.ValueMember = "id";
            cbResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResponsable.DataSource = Load_Responsables;
        }

        private void Responsable_Seguimiento(string Nombre_Responsable, string Area)
        {
            var Load_Responsables = UsuarioArea.MostrarUsuariosAreaSeguimiento(Nombre_Responsable, Area);
            cbResponsable.DisplayMember = "Usuario";
            cbResponsable.ValueMember = "id";
            cbResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResponsable.DataSource = Load_Responsables;
        }


        private void MostrarPrioridad()
        {
            var Load_Prioridad = Prioridad.MostrarPrioridad();
            cbPrioridad.DisplayMember = "Prioridad";
            cbPrioridad.ValueMember = "id";
            cbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrioridad.DataSource = Load_Prioridad;
        }

        private void MostrarPrioridad_Seguimiento(string Nombre_Prioridad)
        {
            var Load_Prioridad = Prioridad.MostrarEstadoPrioridad(Nombre_Prioridad);
            cbPrioridad.DisplayMember = "Prioridad";
            cbPrioridad.ValueMember = "id";
            cbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrioridad.DataSource = Load_Prioridad;
        }

        private void MostrarEstado()
        {
            var Load_Estado = EstadoTarea.MostrarEstadoTareaRegistrarTarea();
            cbEstado.DisplayMember = "Nombre_Estado";
            cbEstado.ValueMember = "id_Tarea";
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DataSource = Load_Estado;
        }

        private void MostrarEstado_Seguimiento(string Estado)
        {
            var Load_Estado = EstadoTarea.MostrarEstadoTareaPorNombre(Estado);
            cbEstado.DisplayMember = "Nombre_Estado";
            cbEstado.ValueMember = "id_Tarea";
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DataSource = Load_Estado;

        }

        private void cbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Area = Convert.ToInt32(cbArea.SelectedValue);
            Nombre_Area = Convert.ToString(Areas.MostrarNombreArea(Value_Area));
            MostrarTipoTarea(Nombre_Area);

        }

        private void cbTipoTarea_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Tipo_Tarea = Convert.ToInt32(cbTipoTarea.SelectedValue);
            Nombre_Tipo_Tarea = Convert.ToString(AreasTarea.MostrarNombreTipoTareaPorArea(Value_Tipo_Tarea));

            MostrarTareas(Nombre_Tipo_Tarea);

        }

        private void cbTarea_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Tarea = Convert.ToInt32(cbTarea.SelectedValue);
            Nombre_Tarea = Convert.ToString(AreasTarea.MostrarNombreTareaporTipoTarea(Value_Tipo_Tarea));

            Responsable(Nombre_Area);
        }

        private void cbResponsable_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Responsable = Convert.ToInt32(cbResponsable.SelectedValue);
            Nombre_Responsable = Convert.ToString(UsuarioArea.MostrarUsuarioPorId(Value_Tipo_Tarea));
        }

        private void cbPrioridad_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Prioridad = Convert.ToInt32(cbPrioridad.SelectedValue);
            Nombre_Prioridad = Convert.ToString(Prioridad.MostrarNombrePrioridad(Value_Prioridad));
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Estado = Convert.ToInt32(cbEstado.SelectedValue);
            Nombre_Estado = Convert.ToString(EstadoTarea.MostrarNombreEstadoTarea(Value_Estado));
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
                string documentos = Nombre_Tarea;
                if (txtNombreArchivo.Text.Length > 0)
                {
                    txtNombreArchivo.Text = txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + ".pdf";
                }
                else
                {
                    txtNombreArchivo.Text = documentos + "_" + año + mes + dia + ".pdf";
                }

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
            string Ruta_Original = Parametros.MostrarParametro("RegistroTarea");
            string Ruta_Diaria = Ruta_Original + Convert.ToString(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            string documentos = string.Empty;
            string validar_archivo = string.Empty;
            string año = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            string dia = DateTime.Now.Day.ToString();
            documentos = Nombre_Tarea;
            if (txtNumeroIdentificacionCliente.Text.Length > 0)
            {
                validar_archivo = Ruta_Diaria + "\\" + txtNumeroIdentificacionCliente.Text + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
            }
            else
            {
                validar_archivo = Ruta_Diaria + "\\" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
            }
            bool validar_guardado = false;

            if (cbAdjuntar.Checked == true)
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
            EntidadTareas.id_Tarea = Value_Tarea;
            EntidadTareas.Creador = Usuario_Login;
            EntidadTareas.Responsable = Nombre_Responsable;
            EntidadTareas.Doc_Cliente = txtNumeroIdentificacionCliente.Text;
            EntidadTareas.Primer_Nombre = txtPrimerNombreCliente.Text;
            EntidadTareas.Segundo_Nombre = txtSegundoNombreCliente.Text;
            EntidadTareas.Primer_Apellido = txtPrimerApellidoCliente.Text;
            EntidadTareas.Segundo_Apellido = txtSegundoApellidoCliente.Text;
            EntidadTareas.Descripcion = txtDescripcion.Text;
            EntidadTareas.Prioridad = Nombre_Prioridad;
            EntidadTareas.Estado = Nombre_Estado;
            if (cbAdjuntar.Checked == true)
            {
                EntidadTareas.Adjunto = true;
                EntidadTareas.Ruta = validar_archivo;
                EntidadTareas.Nombre_Archivo = txtNombreArchivo.Text;
            }
            else
            {
                EntidadTareas.Adjunto = false;
                EntidadTareas.Ruta = "";
                EntidadTareas.Nombre_Archivo = "";
            }

            if (cbNotificarCliente.Checked == true)
            {
                EntidadTareas.Notificar_Responsable = true;
            }
            else
            {
                EntidadTareas.Notificar_Responsable = false;
            }
            EntidadTareas.Area_Creadora = Nombre_Area;
            EntidadTareas.Fecha_Asignado = System.DateTime.Now;
            EntidadTareas.Fecha_Actualizado = System.DateTime.Now;
            validar_guardado = RegistrarTareas.AgregarTarea(EntidadTareas);
            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadTareas.Fecha_Asignado.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadTareas.Fecha_Actualizado.ToString();
                MessageBox.Show("La tarea ha sido registrada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("La tarea no pudo ser registrada, por favor verifique la información y oprima guardar");
            }
        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "VerDocumentosRegistroTareas";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        int id_Archivo = Id_Solicitud;
                        VerDocumentosRegistroTarea ver = new VerDocumentosRegistroTarea(id_Archivo, PerfilRol, Usuario_Login);
                        ver.Show();
                        return;
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

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Archivo = Id_Solicitud;
                RegistrarSeguimientoTareas SeguimientoTareas = new RegistrarSeguimientoTareas(PerfilRol,Usuario_Login, id_Archivo);
                SeguimientoTareas.Show();
                return;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
