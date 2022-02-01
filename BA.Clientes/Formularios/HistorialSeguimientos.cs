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
    public partial class HistorialSeguimientos : Form
    {
        public int Id_Perfil;
        public string Usuario;

        public HistorialSeguimientos(int Id_Perfil, string User, int id_Solicitud)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            Id_Solicitud = id_Solicitud;
            InitializeComponent();
            txtIdSolicitud.Text = Convert.ToString(Id_Solicitud);
            CargarSeguimientos(Id_Solicitud);
        }

        RegistrarSeguimientoTareaController Seguimiento = new RegistrarSeguimientoTareaController();
        RolesController Rol = new RolesController();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int Id_Solicitud = 0;

        private void CargarSeguimientos(int id_Solicitud)
        {
            var Seguimiento_Tarea = Seguimiento.MostrarTodasLasTareas(id_Solicitud);
            if (Seguimiento_Tarea.Count() > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (var e in Seguimiento_Tarea)
                {
                    dataGridView1.Rows.Add(e.id_Seguimiento, e.id_Solicitud, e.Descripcion, e.Adjunto, e.Nombre_Archivo, e.Notificar_Responsable, e.Estado, e.Fecha_Seguimiento, e.Usuario_Seguimiento);
                }
            }
            else
            {
                MessageBox.Show("La tarea seleccionada no se le ha realizado ningún seguimiento.");
            }
        }

        private void HistorialSeguimientos_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[9].Selected)
                {
                    string Nombre_Formulario = "VerDocumentosSeguimientoTareas";
                    var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                    if (Roles.Count > 0)
                    {
                        foreach (var d in Roles)
                        {
                            if (d.Nombre_Rol.Equals(Nombre_Formulario))
                            {
                                int id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                                string Ruta = Seguimiento.AbrirDocumentoCliente(id_Archivo);
                                if (Ruta.Length > 0)
                                {

                                    VerDocumentosSeguimientosTareas ver = new VerDocumentosSeguimientosTareas(id_Archivo, PerfilRol, Usuario_Login);
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
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
