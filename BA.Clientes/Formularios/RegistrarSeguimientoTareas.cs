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
    public partial class RegistrarSeguimientoTareas : Form
    {
        public int Id_Perfil;
        public string Usuario;
        public RegistrarSeguimientoTareas(int Id_Perfil, string User, int id_Solicitud)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            Id_Solicitud = id_Solicitud;
            InitializeComponent();
            txtIdSolicitud.Text = Convert.ToString(Id_Solicitud);
            MostrarEstado();
            CargarTarea(Id_Solicitud);

        }

        RegistrarSeguimientoTareaController Seguimiento = new RegistrarSeguimientoTareaController();
        RegistrarSeguimientoViews EntidadSeguimiento = new RegistrarSeguimientoViews();
        RegistrarTareasViews EntidadTareas = new RegistrarTareasViews();
        RegistrarTareasController RegistrarTareas = new RegistrarTareasController();
        RolesController Rol = new RolesController();
        EstadoTareaController EstadoTarea = new EstadoTareaController();
        ParametrosControllers Parametros = new ParametrosControllers();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int Id_Solicitud = 0;
        int numero_archivo = 0;
        int Value_Estado = 0;
        string Nombre_Estado = string.Empty;

        private void RegistrarSeguimientoTareas_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void CargarTarea(int id_Solicitud)
        {

        }

        private void MostrarEstado()
        {
            var Load_Estado = EstadoTarea.MostrarEstadoTareaSeguimiento();
            cbEstado.DisplayMember = "Nombre_Estado";
            cbEstado.ValueMember = "id_Tarea";
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DataSource = Load_Estado;
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
                string documentos = txtIdSolicitud.Text;
                txtNombreArchivo.Text = "Adjunto_Numero_Seguimiento" + "_" + documentos + "_" + año + mes + dia + ".pdf";
            }
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

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            string Ruta_Original = Parametros.MostrarParametro("RegistroSeguimientoTarea");
            string Ruta_Diaria = Ruta_Original + Convert.ToString(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString());
            string documentos = string.Empty;
            string validar_archivo = string.Empty;
            string año = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            string dia = DateTime.Now.Day.ToString();
            documentos = txtIdSolicitud.Text;
            validar_archivo = Ruta_Diaria + "\\" + "Adjunto_Numero_Seguimiento" + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
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
                        validar_archivo = Ruta_Diaria + "\\" + "Adjunto_Numero_Seguimiento" + "_" + documentos + "_" + año + mes + dia + "_" + numero_archivo + ".pdf";
                    }
                    CopyFile(txtRuta.Text, validar_archivo);
                }
                else
                {
                    MessageBox.Show("Si selecciono que adjuntara un archivo por favor cárguelo, de lo contrario desmarque la casilla.");
                    return;
                }
            }
            EntidadSeguimiento.id_Solicitud = Id_Solicitud;
            EntidadSeguimiento.Descripcion = txtDescripcion.Text;
            if (cbAdjuntar.Checked == true)
            {
                EntidadSeguimiento.Adjunto = true;
                EntidadSeguimiento.Ruta = validar_archivo;
                EntidadSeguimiento.Nombre_Archivo = txtNombreArchivo.Text;
            }
            else
            {
                EntidadSeguimiento.Adjunto = false;
                EntidadSeguimiento.Ruta = "";
                EntidadSeguimiento.Nombre_Archivo = "";
            }
            if (cbNotificarCliente.Checked == true)
            {
                EntidadSeguimiento.Notificar_Responsable = true;
            }
            else
            {
                EntidadSeguimiento.Notificar_Responsable = false;
            }
            EntidadSeguimiento.Estado = Nombre_Estado;
            EntidadSeguimiento.Fecha_Seguimiento = System.DateTime.Now;
            EntidadSeguimiento.Usuario_Seguimiento = Usuario_Login;

            validar_guardado = Seguimiento.AgregarSeguimientoTarea(EntidadSeguimiento);
            if (validar_guardado == true)
            {
                lblCreado.Visible = true;
                lblCreado.Text = EntidadSeguimiento.Fecha_Seguimiento.ToString();
                lblModificado.Visible = true;
                lblModificado.Text = EntidadSeguimiento.Usuario_Seguimiento.ToString();
                MessageBox.Show("El seguimiento de la tarea se ha sido registrada correctamente.");

                var Consultar_Solicitud = RegistrarTareas.MostrarTareasPorIDParaSeguimiento(Id_Solicitud);
                foreach (var d in Consultar_Solicitud)
                {
                    EntidadTareas.id_Solicitud = d.id_Solicitud;
                    EntidadTareas.id_Tarea = d.id_Tarea;
                    EntidadTareas.Creador = d.Creador;
                    EntidadTareas.Responsable = d.Responsable;
                    EntidadTareas.Doc_Cliente = d.Doc_Cliente;
                    EntidadTareas.Primer_Nombre = d.Primer_Nombre;
                    EntidadTareas.Segundo_Nombre = d.Segundo_Nombre;
                    EntidadTareas.Primer_Apellido = d.Primer_Apellido;
                    EntidadTareas.Segundo_Apellido = d.Segundo_Apellido;
                    EntidadTareas.Descripcion = d.Descripcion;
                    EntidadTareas.Prioridad = d.Prioridad;
                    EntidadTareas.Estado = Nombre_Estado;
                    EntidadTareas.Adjunto = d.Adjunto;
                    EntidadTareas.Ruta = d.Ruta;
                    EntidadTareas.Nombre_Archivo = d.Nombre_Archivo;
                    EntidadTareas.Notificar_Responsable = d.Notificar_Responsable;
                    EntidadTareas.Area_Creadora = d.Area_Creadora;
                    EntidadTareas.Fecha_Asignado = d.Fecha_Asignado;
                    EntidadTareas.Fecha_Actualizado = EntidadSeguimiento.Fecha_Seguimiento;
                }

                bool Validar_Actualizacion_Tarea = RegistrarTareas.ModificarTarea(EntidadTareas);

                if (validar_guardado == true)
                {
                    MessageBox.Show("La tarea se ha actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La tarea no fue actualizada, por favor comuníquese con el administrador técnico.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("El seguimiento de la tarea no pudo ser registrada, por favor verifique la información y oprima guardar");
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

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Estado = Convert.ToInt32(cbEstado.SelectedValue);
            Nombre_Estado = Convert.ToString(EstadoTarea.MostrarNombreEstadoTarea(Value_Estado));
        }
    }
}
