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

namespace BA.Clientes.Formularios
{
    public partial class MenuPrincipal : Form
    {
        public string usuario;
        PerfilesController Perfiles = new PerfilesController();
        RolesController Rol = new RolesController();
        UsuariosController Usuarios = new UsuariosController();
        RegistrarTareasController Tarea = new RegistrarTareasController();
        UsuariosAreaController UsuarioArea = new UsuariosAreaController();
        AreasTareasController AreasTareas = new AreasTareasController();
        EstadoTareaController EstadosTarea = new EstadoTareaController();
        string User = string.Empty;
        string Perfil_Por_Usuario = string.Empty;
        int Id_Perfil = 0;
        int index = 0;
        int Value_Estado_Tarea = 0;
        string Nombre_Estado_Tarea = string.Empty;
        int id_Solicitud = 0;

        public MenuPrincipal(string Usuario)
        {
            InitializeComponent();
            User = Usuario;
            ConsultarPerfil(User);
            CargarTareasUsuario(User);
            CargarEstadosTarea();
        }

        private void ConsultarPerfil(string User)
        {
            var Load_Perfil = Usuarios.ConsultarPerfilPorUsuario(User);
            foreach (var d in Load_Perfil)
            {
                Perfil_Por_Usuario = d.perfil;
            }
            Id_Perfil = Perfiles.ConsultarIDPerfil(Perfil_Por_Usuario);
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "RegistrarClientes";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        RegistrarClientes Registrar = new RegistrarClientes(Id_Perfil, User);
                        Registrar.ShowDialog();
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

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GestionClientes";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        GestionClientes Gestion = new GestionClientes(Id_Perfil, User);
                        Gestion.ShowDialog();
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
        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "RegistrarFamiliares";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        RegistrarFamiliares RegistrarFamiliares = new RegistrarFamiliares(Id_Perfil, User);
                        RegistrarFamiliares.ShowDialog();
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

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GestionFamiliares";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        GestionFamiliares GestionFamiliares = new GestionFamiliares(Id_Perfil, User);
                        GestionFamiliares.ShowDialog();
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

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "DocumentosCliente";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        DocumentosCliente DocumentosClientes = new DocumentosCliente(Id_Perfil, User);
                        DocumentosClientes.ShowDialog();
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

        private void documentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "DocumentosFamilia";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        DocumentosFamilia DocumentosFamilia = new DocumentosFamilia(Id_Perfil, User);
                        DocumentosFamilia.ShowDialog();
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            string Nombre_Formulario = "VerCartera";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        CarteraStripMenuItem2.Visible = true;
                    }
                }
            }

            string Nombre_Formulario_2 = "LiderArea";
            var Roles_2 = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario_2);
            if (Roles_2.Count > 0)
            {
                foreach (var d in Roles_2)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario_2))
                    {
                        btnTodasLasSolicitudes.Visible = true;
                        btnLiderArea.Enabled = true;
                    }
                }
            }
        }

        private void novedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "NovedadesClientes";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        NovedadesCliente NovedadesClientes = new NovedadesCliente(Id_Perfil, User);
                        NovedadesClientes.ShowDialog();
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

        private void novedadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "NovedadesFamilia";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        NovedadesFamiliares NovedadesFamiliares = new NovedadesFamiliares(Id_Perfil, User);
                        NovedadesFamiliares.ShowDialog();
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

        private void seguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "SeguimientoClientes";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        SeguimientoCliente SeguimientoCliente = new SeguimientoCliente(Id_Perfil, User);
                        SeguimientoCliente.ShowDialog();
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

        private void seguimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "SeguimientoFamiliares";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        SeguimientoFamiliares SeguimientoFamiliar = new SeguimientoFamiliares(Id_Perfil, User);
                        SeguimientoFamiliar.ShowDialog();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fichasMedicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "FichaMedica";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        FichasMedicas FichaMedica = new FichasMedicas(Id_Perfil, User);
                        FichaMedica.ShowDialog();
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

        private void juntasMedicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "JuntaMedica";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        JuntasMedicas JuntasMedicas = new JuntasMedicas(Id_Perfil, User);
                        JuntasMedicas.ShowDialog();
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

        private void conceptosMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ConceptosMedicos";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        ConceptosMedicos ConceptosMedicos = new ConceptosMedicos(Id_Perfil, User);
                        ConceptosMedicos.ShowDialog();
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

        private void citasMedicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "CitasMedicas";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        CitasMedicas CitasMedicas = new CitasMedicas(Id_Perfil, User);
                        CitasMedicas.ShowDialog();
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

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            string Nombre_Formulario = "Cartera";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        Cartera Cartera = new Cartera(Id_Perfil, User);
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

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string Nombre_Formulario = "AgendaCliente";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        AgendaClientes AgendaClientes = new AgendaClientes(Id_Perfil, User);
                        AgendaClientes.ShowDialog();
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

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "AgendaFamilia";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        AgendaFamilia AgendaFamilia = new AgendaFamilia(Id_Perfil, User);
                        AgendaFamilia.ShowDialog();
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

        private void parametrizacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "Parametrizaciones";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        Parametrizacion Parametrizacion = new Parametrizacion(Id_Perfil, User);
                        Parametrizacion.ShowDialog();
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

        private void audienciasJuzgadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "AudienciasJuzgado";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        AudienciasJuzgado audienciaJuzgado = new AudienciasJuzgado(Id_Perfil, User);
                        audienciaJuzgado.ShowDialog();
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

        private void audienciasProcuraduriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "AudienciasProcuraduria";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        AudienciasProcuraduria AudienciaProcuraduria = new AudienciasProcuraduria(Id_Perfil, User);
                        AudienciaProcuraduria.ShowDialog();
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

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "RegistrarSeguimientoTarea";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        int id_solicitud = id_Solicitud;
                        Tareas RegistrarTareas = new Tareas(Id_Perfil, User, id_solicitud);
                        RegistrarTareas.ShowDialog();
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

        public void CargarTareasUsuario(string Usuario)
        {
            dataGridView1.Rows.Clear();
            int indice = 0;
            var Area_Usuario = UsuarioArea.MostrarUsuarioArea(Usuario);
            if (Area_Usuario.Count() > 0)
            {
                foreach (var d in Area_Usuario)
                {
                    var Tareas_Usuario_Area = Tarea.MostrarTareasPorResponsable(Usuario, d.Nombre_Area);

                    foreach (var e in Tareas_Usuario_Area)
                    {
                        dataGridView1.Rows.Add(e.id_Solicitud, e.id_Tarea, e.Creador, e.Responsable, e.Doc_Cliente, e.Primer_Nombre, e.Segundo_Nombre, e.Primer_Apellido, e.Segundo_Apellido, e.Descripcion, e.Prioridad, e.Estado, e.Adjunto, e.Nombre_Archivo, e.Notificar_Responsable, e.Area_Creadora, e.Fecha_Asignado, e.Fecha_Actualizado);
                        int id_Tarea = e.id_Tarea;

                        int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);

                        if (Validar_Tiempo_Tarea == 0)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                            if (ValidacionHoy >= e.Fecha_Asignado & ValidacionHoy <= e.Fecha_Asignado)
                            {
                                if (e.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (e.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }
                        }
                        else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion1_5 = e.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= e.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                            {
                                if (e.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (e.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                //int sol = ColorCelda();
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }
                        }
                        else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion6_15 = e.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= e.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                            {
                                if (e.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (e.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                //int sol = ColorCelda();
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }

                        }
                        else if (Validar_Tiempo_Tarea >= 15 && Validar_Tiempo_Tarea <= 30)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion15_30 = e.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= e.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                            {
                                if (e.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (e.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                //int sol = ColorCelda();
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }

                        }
                        else
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion_30 = e.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= e.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                            {
                                if (e.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (e.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                //int sol = ColorCelda();
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene un área asignada, por favor solicítela a su jefe inmediato.");
            }
        }

        private int ColorCelda()
        {
            try
            {
                index = dataGridView1.TabIndex;
                return index;
            }
            catch
            {
                return 0;
            }
        }

        private void CargarEstadosTarea()
        {
            var Load_Estados_Tarea = EstadosTarea.MostrarEstadoTarea();
            if (Load_Estados_Tarea.Count() > 0)
            {
                cbEstados.DisplayMember = "Nombre_Estado";
                cbEstados.ValueMember = "id_Tarea";
                cbEstados.DropDownStyle = ComboBoxStyle.DropDownList;
                cbEstados.DataSource = Load_Estados_Tarea;
            }
            else
            {
                cbEstados = null;
            }
        }
        private void btnEstadosTarea_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ConsultarTareasPorEstado";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        dataGridView1.Rows.Clear();
                        int indice = 0;
                        var Area_Usuario = UsuarioArea.MostrarUsuarioArea(User);
                        if (Area_Usuario.Count() > 0)
                        {
                            foreach (var g in Area_Usuario)
                            {
                                var Tareas_Usuario_Area = Tarea.MostrarTareasPorEstado(User, g.Nombre_Area, Nombre_Estado_Tarea);
                                if (Tareas_Usuario_Area.Count() > 0)
                                {
                                    foreach (var r in Tareas_Usuario_Area)
                                    {
                                        dataGridView1.Rows.Add(r.id_Solicitud, r.id_Tarea, r.Creador, r.Responsable, r.Doc_Cliente, r.Primer_Nombre, r.Segundo_Nombre, r.Primer_Apellido, r.Segundo_Apellido, r.Descripcion, r.Prioridad, r.Estado, r.Adjunto, r.Nombre_Archivo, r.Notificar_Responsable, r.Area_Creadora, r.Fecha_Asignado, r.Fecha_Actualizado);
                                        int id_Tarea = r.id_Tarea;
                                        if (r.Estado != "Cerrada")
                                        {
                                            int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);

                                            if (Validar_Tiempo_Tarea == 0)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= r.Fecha_Asignado)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion1_5 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion6_15 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }

                                            }
                                            else if (Validar_Tiempo_Tarea >= 15 | Validar_Tiempo_Tarea <= 30)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());
                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion15_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.White;
                                            indice = indice + 1;

                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay tareas con el filtro utilizado.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene un área asignada, por favor solicítela a su jefe inmediato.");
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

        private void cbEstados_SelectedValueChanged(object sender, EventArgs e)
        {
            Value_Estado_Tarea = Convert.ToInt32(cbEstados.SelectedValue);
            Nombre_Estado_Tarea = Convert.ToString(EstadosTarea.MostrarNombreEstadoTarea(Value_Estado_Tarea));
        }

        private string IdSolicitud()
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

        private void btnConsultarPorId_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ConsultarTareasPorId";
            string id_solicitud = txtIdSolicitud.Text;
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        dataGridView1.Rows.Clear();
                        int indice = 0;
                        var Area_Usuario = UsuarioArea.MostrarUsuarioArea(User);
                        if (Area_Usuario.Count() > 0)
                        {
                            foreach (var g in Area_Usuario)
                            {
                                var Tareas_Usuario_Area = Tarea.MostrarTareasPorID(Convert.ToInt32(id_solicitud), User, g.Nombre_Area);
                                Tareas_Usuario_Area = Tarea.MostrarTareasPorIDOtrasAreas(Convert.ToInt32(id_solicitud), User);
                                if (Tareas_Usuario_Area.Count() > 0)
                                {
                                    foreach (var r in Tareas_Usuario_Area)
                                    {
                                        dataGridView1.Rows.Add(r.id_Solicitud, r.id_Tarea, r.Creador, r.Responsable, r.Doc_Cliente, r.Primer_Nombre, r.Segundo_Nombre, r.Primer_Apellido, r.Segundo_Apellido, r.Descripcion, r.Prioridad, r.Estado, r.Adjunto, r.Nombre_Archivo, r.Notificar_Responsable, r.Area_Creadora, r.Fecha_Asignado, r.Fecha_Actualizado);
                                        int id_Tarea = r.id_Tarea;
                                        if (r.Estado != "Cerrada")
                                        {
                                            int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);

                                            if (Validar_Tiempo_Tarea == 0)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= r.Fecha_Asignado)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion1_5 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion6_15 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }

                                            }
                                            else if (Validar_Tiempo_Tarea >= 15 | Validar_Tiempo_Tarea <= 30)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());
                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion15_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.White;
                                            indice = indice + 1;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay tareas con el filtro utilizado.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene un área asignada, por favor solicítela a su jefe inmediato.");
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

        private void btnMisTareas_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "MisTareas";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        dataGridView1.Rows.Clear();
                        int indice = 0;
                        var Area_Usuario = UsuarioArea.MostrarUsuarioArea(User);
                        if (Area_Usuario.Count() > 0)
                        {
                            foreach (var g in Area_Usuario)
                            {
                                var Tareas_Usuario_Area = Tarea.MostrarTareasPorResponsableDiferenteCerrado(User, g.Nombre_Area);

                                if (Tareas_Usuario_Area.Count() > 0)
                                {
                                    foreach (var r in Tareas_Usuario_Area)
                                    {
                                        dataGridView1.Rows.Add(r.id_Solicitud, r.id_Tarea, r.Creador, r.Responsable, r.Doc_Cliente, r.Primer_Nombre, r.Segundo_Nombre, r.Primer_Apellido, r.Segundo_Apellido, r.Descripcion, r.Prioridad, r.Estado, r.Adjunto, r.Nombre_Archivo, r.Notificar_Responsable, r.Area_Creadora, r.Fecha_Asignado, r.Fecha_Actualizado);
                                        int id_Tarea = r.id_Tarea;

                                        int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);

                                        if (Validar_Tiempo_Tarea == 0)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= r.Fecha_Asignado)
                                            {
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                        else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion1_5 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                                            {
                                                //int sol = ColorCelda();
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                        else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion6_15 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                                            {
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }

                                        }
                                        else if (Validar_Tiempo_Tarea >= 15 | Validar_Tiempo_Tarea <= 30)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());
                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion15_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                                            {
                                                //int sol = ColorCelda();
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                        else
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                                            {
                                                //int sol = ColorCelda();
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay tareas con el filtro utilizado.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene un área asignada, por favor solicítela a su jefe inmediato.");
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

        private void btnAsignadas_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "Asignadas";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        dataGridView1.Rows.Clear();
                        int indice = 0;
                        var Area_Usuario = UsuarioArea.MostrarUsuarioArea(User);
                        if (Area_Usuario.Count() > 0)
                        {
                            foreach (var g in Area_Usuario)
                            {
                                var Tareas_Usuario_Area = Tarea.MostrarTareasPorCreador(User);
                                if (Tareas_Usuario_Area.Count() > 0)
                                {
                                    foreach (var r in Tareas_Usuario_Area)
                                    {
                                        dataGridView1.Rows.Add(r.id_Solicitud, r.id_Tarea, r.Creador, r.Responsable, r.Doc_Cliente, r.Primer_Nombre, r.Segundo_Nombre, r.Primer_Apellido, r.Segundo_Apellido, r.Descripcion, r.Prioridad, r.Estado, r.Adjunto, r.Nombre_Archivo, r.Notificar_Responsable, r.Area_Creadora, r.Fecha_Asignado, r.Fecha_Actualizado);
                                        int id_Tarea = r.id_Tarea;

                                        int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);

                                        if (Validar_Tiempo_Tarea == 0)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= r.Fecha_Asignado)
                                            {
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                        else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion1_5 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                                            {
                                                //int sol = ColorCelda();
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                        else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion6_15 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                                            {
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }

                                        }
                                        else if (Validar_Tiempo_Tarea >= 15 | Validar_Tiempo_Tarea <= 30)
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());
                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion15_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                                            {
                                                //int sol = ColorCelda();
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                        else
                                        {
                                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                            DateTime Validacion_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                                            {
                                                //int sol = ColorCelda();
                                                if (r.Prioridad == "Alta")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                    indice = indice + 1;
                                                }

                                                else if (r.Prioridad == "Media")
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                    indice = indice + 1;
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                //int sol = ColorCelda();
                                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                indice = indice + 1;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay tareas con el filtro utilizado.");

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene un área asignada, por favor solicítela a su jefe inmediato.");
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

        private void btnLiderArea_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "LiderArea";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        dataGridView1.Rows.Clear();
                        int indice = 0;
                        var Area_Usuario = UsuarioArea.MostrarUsuarioArea(User);
                        if (Area_Usuario.Count() > 0)
                        {
                            foreach (var g in Area_Usuario)
                            {
                                var Tareas_Usuario_Area = Tarea.MostrarTareasLiderArea(g.Nombre_Area);
                                if (Tareas_Usuario_Area.Count() > 0)
                                {
                                    foreach (var r in Tareas_Usuario_Area)
                                    {
                                        dataGridView1.Rows.Add(r.id_Solicitud, r.id_Tarea, r.Creador, r.Responsable, r.Doc_Cliente, r.Primer_Nombre, r.Segundo_Nombre, r.Primer_Apellido, r.Segundo_Apellido, r.Descripcion, r.Prioridad, r.Estado, r.Adjunto, r.Nombre_Archivo, r.Notificar_Responsable, r.Area_Creadora, r.Fecha_Asignado, r.Fecha_Actualizado);
                                        int id_Tarea = r.id_Tarea;
                                        if (r.Estado != "Cerrada")
                                        {
                                            int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);

                                            if (Validar_Tiempo_Tarea == 0)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= r.Fecha_Asignado)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion1_5 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion6_15 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }

                                            }
                                            else if (Validar_Tiempo_Tarea >= 15 | Validar_Tiempo_Tarea <= 30)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());
                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion15_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.White;
                                            indice = indice + 1;

                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay tareas con el filtro utilizado.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene un área asignada, por favor solicítela a su jefe inmediato.");
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

        private void btnTodasLasSolicitudes_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int indice = 0;
            var Tareas_Usuario_Area = Tarea.MostrarTodasLasTareas();
            if (Tareas_Usuario_Area.Count() > 0)
            {
                foreach (var r in Tareas_Usuario_Area)
                {
                    dataGridView1.Rows.Add(r.id_Solicitud, r.id_Tarea, r.Creador, r.Responsable, r.Doc_Cliente, r.Primer_Nombre, r.Segundo_Nombre, r.Primer_Apellido, r.Segundo_Apellido, r.Descripcion, r.Prioridad, r.Estado, r.Adjunto, r.Nombre_Archivo, r.Notificar_Responsable, r.Area_Creadora, r.Fecha_Asignado, r.Fecha_Actualizado);
                    int id_Tarea = r.id_Tarea;
                    if (r.Estado != "Cerrada")
                    {
                        int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);
                        if (Validar_Tiempo_Tarea == 0)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= r.Fecha_Asignado)
                            {
                                if (r.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (r.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }
                        }
                        else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion1_5 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                            {
                                //int sol = ColorCelda();
                                if (r.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (r.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                //int sol = ColorCelda();
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }
                        }
                        else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion6_15 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                            {
                                if (r.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (r.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                //int sol = ColorCelda();
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }

                        }
                        else if (Validar_Tiempo_Tarea >= 15 | Validar_Tiempo_Tarea <= 30)
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());
                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion15_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                            {
                                //int sol = ColorCelda();
                                if (r.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (r.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                //int sol = ColorCelda();
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }
                        }
                        else
                        {
                            int mes = Int32.Parse(DateTime.Now.Month.ToString());
                            int año = Int32.Parse(DateTime.Now.Year.ToString());
                            int dia = Int32.Parse(DateTime.Now.Day.ToString());
                            int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                            int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                            int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                            int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                            DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                            DateTime Validacion_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                            if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                            {
                                //int sol = ColorCelda();
                                if (r.Prioridad == "Alta")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                    indice = indice + 1;
                                }

                                else if (r.Prioridad == "Media")
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                    indice = indice + 1;
                                }
                                else
                                {
                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                    indice = indice + 1;
                                }
                            }
                            else
                            {
                                dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                indice = indice + 1;
                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.White;
                        indice = indice + 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay tareas con el filtro utilizado.");
            }
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ConsultarTareasPorFechas";
            DateTime FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = dtpFinal.Value;
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        dataGridView1.Rows.Clear();
                        int indice = 0;
                        var Area_Usuario = UsuarioArea.MostrarUsuarioArea(User);
                        if (Area_Usuario.Count() > 0)
                        {
                            foreach (var g in Area_Usuario)
                            {
                                var Tareas_Usuario_Area = Tarea.MostrarTareasPorFechaAsignado(FechaInicial, FechaFinal, User, g.Nombre_Area);
                                Tareas_Usuario_Area = Tarea.MostrarTareasPorFechaAsignadoOtraArea(FechaInicial, FechaFinal, User);

                                if (Tareas_Usuario_Area.Count() > 0)
                                {
                                    foreach (var r in Tareas_Usuario_Area)
                                    {
                                        dataGridView1.Rows.Add(r.id_Solicitud, r.id_Tarea, r.Creador, r.Responsable, r.Doc_Cliente, r.Primer_Nombre, r.Segundo_Nombre, r.Primer_Apellido, r.Segundo_Apellido, r.Descripcion, r.Prioridad, r.Estado, r.Adjunto, r.Nombre_Archivo, r.Notificar_Responsable, r.Area_Creadora, r.Fecha_Asignado, r.Fecha_Actualizado);
                                        int id_Tarea = r.id_Tarea;
                                        if (r.Estado != "Cerrada")
                                        {
                                            int Validar_Tiempo_Tarea = AreasTareas.ValidarTiempoTarea(id_Tarea);

                                            if (Validar_Tiempo_Tarea == 0)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= r.Fecha_Asignado)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 1 && Validar_Tiempo_Tarea <= 5)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion1_5 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion1_5)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else if (Validar_Tiempo_Tarea >= 6 && Validar_Tiempo_Tarea <= 15)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion6_15 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion6_15)
                                                {
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }

                                            }
                                            else if (Validar_Tiempo_Tarea >= 15 | Validar_Tiempo_Tarea <= 30)
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());
                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion15_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion15_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                            else
                                            {
                                                int mes = Int32.Parse(DateTime.Now.Month.ToString());
                                                int año = Int32.Parse(DateTime.Now.Year.ToString());
                                                int dia = Int32.Parse(DateTime.Now.Day.ToString());
                                                int hora = Int32.Parse(DateTime.Now.Hour.ToString());
                                                int minuto = Int32.Parse(DateTime.Now.Minute.ToString());
                                                int segundo = Int32.Parse(DateTime.Now.Second.ToString());
                                                int milisegundo = Int32.Parse(DateTime.Now.Millisecond.ToString());

                                                DateTime ValidacionHoy = new DateTime(año, mes, dia, hora, minuto, segundo, milisegundo);
                                                DateTime Validacion_30 = r.Fecha_Asignado.AddDays(Validar_Tiempo_Tarea);

                                                if (ValidacionHoy >= r.Fecha_Asignado & ValidacionHoy <= Validacion_30)
                                                {
                                                    //int sol = ColorCelda();
                                                    if (r.Prioridad == "Alta")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Orange;
                                                        indice = indice + 1;
                                                    }

                                                    else if (r.Prioridad == "Media")
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                                                        indice = indice + 1;
                                                    }
                                                    else
                                                    {
                                                        dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Green;
                                                        indice = indice + 1;
                                                    }
                                                }
                                                else
                                                {
                                                    //int sol = ColorCelda();
                                                    dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                                                    indice = indice + 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            dataGridView1.Rows[indice].DefaultCellStyle.BackColor = Color.White;
                                            indice = indice + 1;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay tareas con el filtro utilizado.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene un área asignada, por favor solicítela a su jefe inmediato.");
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtpInicial.Format = DateTimePickerFormat.Custom;
            dtpInicial.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpFinal.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }

        private void btnRegistrarTarea_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "RegistrarTareas";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        int id_solicitud = 0;
                        Tareas RegistrarTareas = new Tareas(Id_Perfil, User, id_solicitud);
                        RegistrarTareas.ShowDialog();
                        btnAsignadas_Click(sender, e);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[18].Selected)
                {
                    string Nombre_Formulario = "VerDocumentosRegistroTareas";
                    var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
                    if (Roles.Count > 0)
                    {
                        foreach (var d in Roles)
                        {
                            if (d.Nombre_Rol.Equals(Nombre_Formulario))
                            {
                                int id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                                string Ruta = Tarea.AbrirDocumentoCliente(id_Archivo);
                                if (Ruta.Length > 0)
                                {

                                    VerDocumentosRegistroTarea ver = new VerDocumentosRegistroTarea(id_Archivo, Id_Perfil, User);
                                    ver.Show();
                                    return;
                                }
                                else
                                {

                                    MessageBox.Show("La tarea seleccionada no tiene adjunto.");
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
                else if (dataGridView1.Rows[e.RowIndex].Cells[19].Selected)
                {
                    string Nombre_Formulario = "VerSeguimientosTareas";
                    var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
                    if (Roles.Count > 0)
                    {
                        foreach (var d in Roles)
                        {
                            if (d.Nombre_Rol.Equals(Nombre_Formulario))
                            {
                                int id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                                HistorialSeguimientos Seguimientos = new HistorialSeguimientos(Id_Perfil, User, id_Archivo);
                                Seguimientos.Show();
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

                else if (dataGridView1.Rows[e.RowIndex].Cells[0].Selected)
                {
                    id_Solicitud = Convert.ToInt32(ModificarNovedades());
                    index = dataGridView1.CurrentCell.RowIndex;
                    btnAbrir.Enabled = true;
                    btnSeguimiento.Enabled = true;
                }
                else
                {
                    btnAbrir.Enabled = false;
                    btnSeguimiento.Enabled = false;
                }
            }
            catch (Exception)
            {
                return;
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

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "RegistrarSeguimientoTarea";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        int id_solicitud = id_Solicitud;
                        RegistrarSeguimientoTareas SeguimientoTareas = new RegistrarSeguimientoTareas(Id_Perfil, User, id_solicitud);
                        SeguimientoTareas.Show();

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
    }
}









