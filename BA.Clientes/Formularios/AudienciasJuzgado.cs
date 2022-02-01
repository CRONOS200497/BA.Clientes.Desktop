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
using BA.Models;
using BA.Models.Entidades;
using System.IO;

namespace BA.Clientes.Formularios
{
    public partial class AudienciasJuzgado : Form
    {
        public int Id_Perfil;
        public string Usuario;

        public AudienciasJuzgado(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
        }

        AudienciasJuzgadosController Audiencias = new AudienciasJuzgadosController();
        PerfilesController Perfiles = new PerfilesController();
        RolesController Rol = new RolesController();
        AudienciasJuzgadoViews EntidadJuzgados = new AudienciasJuzgadoViews();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int id_Audiencia = 0;
        int index = 0;

        private void AudienciasJuzgado_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnAudienciasMes_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int mes = Int32.Parse(DateTime.Now.Month.ToString());
            int año = Int32.Parse(DateTime.Now.Year.ToString());
            int diaInicial = 1;
            int diaFinal = 31;
            string FechaInicial = año + "-" + mes + "-" + diaInicial;
            string FechaFinal = año + "-" + mes + "-" + diaFinal;
            DateTime ConsultaInicial = new DateTime(año, mes, diaInicial, 00, 00, 00);
            DateTime ConsultaFinal = new DateTime(año, mes, diaFinal, 23, 59, 59);
            var Consultar_Audiencias_Hoy = Audiencias.ConsultarAudienciasPorMes(ConsultaInicial, ConsultaFinal);
            foreach (var d in Consultar_Audiencias_Hoy)
            {
                dataGridView1.Rows.Add(d.id_Audiencia_Juzgado, d.Doc_Cliente, d.Primer_Nombre, d.Segundo_Nombre, d.Primer_Apellido, d.SegundoApellido, d.Numero_Proceso, d.Juzgado, d.Fecha_Audiencia, d.Abogado, d.Correo_Abogado, d.Observaciones, d.Adjuntar_Archivo, d.Informar_Cliente, d.Informar_Abogado, d.Fecha_Subido, d.Fecha_Actualizado, d.Usuario);
            }
            if (dataGridView1.RowCount > 0)
            {
                return;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna audiencia registrada para el día de hoy.");
            }
        }

        private void BtnBuscarAudienciaPorCliente_Click_1(object sender, EventArgs e)
        {
            if (txtConsultaCliente.Text.Length > 0)
            {
                dataGridView1.Rows.Clear();
                var Consultar_Audiencias_Hoy = Audiencias.ConsultarAudienciasPorCliente(txtConsultaCliente.Text);
                foreach (var d in Consultar_Audiencias_Hoy)
                {
                    dataGridView1.Rows.Add(d.id_Audiencia_Juzgado, d.Doc_Cliente, d.Primer_Nombre, d.Segundo_Nombre, d.Primer_Apellido, d.SegundoApellido, d.Numero_Proceso, d.Juzgado, d.Fecha_Audiencia, d.Abogado, d.Correo_Abogado, d.Observaciones, d.Adjuntar_Archivo, d.Informar_Cliente, d.Informar_Abogado, d.Fecha_Subido, d.Fecha_Actualizado, d.Usuario);
                }
                if (dataGridView1.RowCount > 0)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna audiencia para el número de documento consultado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del cliente o familia ha consultar.");
            }
        }

        private void btnBuscarTodasLasAudiencias_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var Consultar_Audiencias_Hoy = Audiencias.ConsultartodasLasAudiencias();
            foreach (var d in Consultar_Audiencias_Hoy)
            {
                dataGridView1.Rows.Add(d.id_Audiencia_Juzgado, d.Doc_Cliente, d.Primer_Nombre, d.Segundo_Nombre, d.Primer_Apellido, d.SegundoApellido, d.Numero_Proceso, d.Juzgado, d.Fecha_Audiencia, d.Abogado, d.Correo_Abogado, d.Observaciones, d.Adjuntar_Archivo, d.Informar_Cliente, d.Informar_Abogado, d.Fecha_Subido, d.Fecha_Actualizado, d.Usuario);
            }
            if (dataGridView1.RowCount > 0)
            {
                return;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna audiencia registrada.");
            }
        }

        private void btnAudienciasHoy_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int mes = Int32.Parse(DateTime.Now.Month.ToString());
            int año = Int32.Parse(DateTime.Now.Year.ToString());
            int dia = Int32.Parse(DateTime.Now.Day.ToString());
            DateTime ConsultaInicial = new DateTime(año, mes, dia, 00, 00, 00);
            DateTime ConsultaFinal = new DateTime(año, mes, dia, 23, 59, 59);
            var Consultar_Audiencias_Hoy = Audiencias.ConsultarAudienciasHoy(ConsultaInicial, ConsultaFinal);
            foreach (var d in Consultar_Audiencias_Hoy)
            {
                dataGridView1.Rows.Add(d.id_Audiencia_Juzgado, d.Doc_Cliente, d.Primer_Nombre, d.Segundo_Nombre, d.Primer_Apellido, d.SegundoApellido, d.Numero_Proceso, d.Juzgado, d.Fecha_Audiencia, d.Abogado, d.Correo_Abogado, d.Observaciones, d.Adjuntar_Archivo, d.Informar_Cliente, d.Informar_Abogado, d.Fecha_Subido, d.Fecha_Actualizado, d.Usuario);
            }
            if (dataGridView1.RowCount > 0)
            {
                return;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna audiencia registrada para el día de hoy.");
            }
        }

        private void btnConsultarPorRangoDeFechas_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DateTime FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = dtpfinal.Value;
            var Consultar_Audiencias_Rango_Fechas = Audiencias.ConsultarAudienciasPorFechas(FechaInicial, FechaFinal);
            foreach (var d in Consultar_Audiencias_Rango_Fechas)
            {
                dataGridView1.Rows.Add(d.id_Audiencia_Juzgado, d.Doc_Cliente, d.Primer_Nombre, d.Segundo_Nombre, d.Primer_Apellido, d.SegundoApellido, d.Numero_Proceso, d.Juzgado, d.Fecha_Audiencia, d.Abogado, d.Correo_Abogado, d.Observaciones, d.Adjuntar_Archivo, d.Informar_Cliente, d.Informar_Abogado, d.Fecha_Subido, d.Fecha_Actualizado, d.Usuario);
            }
            if (dataGridView1.RowCount > 0)
            {
                return;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna audiencia registrada para el día de hoy.");
            }
        }

        private void btnAgregarAudiencia_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GuardarAudienciasJuzgado";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        AgregarAudienciaJuzgado audienciaJuzgado = new AgregarAudienciaJuzgado(Id_Perfil, Usuario_Login, 0);
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

        private void btnModificarAudiencia_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ModificarAudienciasJuzgado";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        AgregarAudienciaJuzgado audienciaJuzgado = new AgregarAudienciaJuzgado(Id_Perfil, Usuario_Login, id_Audiencia);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[18].Selected)
                {
                    string Nombre_Formulario = "VerDocumentosAudiencias";
                    var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                    if (Roles.Count > 0)
                    {
                        foreach (var d in Roles)
                        {
                            if (d.Nombre_Rol.Equals(Nombre_Formulario))
                            {
                                int id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                                string Ruta = Audiencias.AbrirDocumentoCliente(id_Archivo);
                                if (Ruta.Length > 0)
                                {
                                    VerDocumentosAudiencias ver = new VerDocumentosAudiencias(id_Archivo, PerfilRol, Usuario_Login);
                                    ver.Show();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("La audiencia de juzgado seleccionada no tiene adjunto.");
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
                else if (dataGridView1.Rows[e.RowIndex].Cells[0].Selected)
                {
                    id_Audiencia = Convert.ToInt32(ModificarNovedades());
                    index = dataGridView1.CurrentCell.RowIndex;
                    btnModificarAudiencia.Enabled = true;
                    btnEliminarAudiencia.Enabled = true;
                }
                else
                {
                    btnModificarAudiencia.Enabled = false;
                    btnEliminarAudiencia.Enabled = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnEliminarAudiencia_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "EliminarAudienciasJuzgado";
            var Roles = Rol.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        bool validar_eliminado = false;
                        EntidadJuzgados.id_Audiencia_Juzgado = id_Audiencia;
                        string ruta_eliminar = Audiencias.AbrirDocumentoCliente(id_Audiencia);

                        DialogResult ModificarAdjunto = MessageBox.Show("Oprima si, para eliminar la audiencia seleccionada o No para cancelar la acción.", "¡Alerta!", MessageBoxButtons.YesNo);
                        if (ModificarAdjunto == DialogResult.Yes)
                        {
                            if (File.Exists(ruta_eliminar))
                            {
                                File.Delete(ruta_eliminar);
                                validar_eliminado = Audiencias.EliminarCorreoFamilia(EntidadJuzgados);
                                if (validar_eliminado == true)
                                {
                                    MessageBox.Show("La audiencia ha sido eliminada correctamente.");
                                    dataGridView1.Rows.RemoveAt(index);
                                    if (dataGridView1.RowCount == 0)
                                    {
                                        btnEliminarAudiencia.Enabled = false;
                                        btnModificarAudiencia.Enabled = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La audiencia no pudo ser eliminada, por favor revise la celda seleccionada o comuníquese con el administrador técnico.");
                                }
                            }
                            else
                            {
                                validar_eliminado = Audiencias.EliminarCorreoFamilia(EntidadJuzgados);
                                if (validar_eliminado == true)
                                {
                                    MessageBox.Show("La audiencia ha sido eliminada correctamente.");
                                    dataGridView1.Rows.RemoveAt(index);
                                    if (dataGridView1.RowCount == 0)
                                    {
                                        btnEliminarAudiencia.Enabled = false;
                                        btnModificarAudiencia.Enabled = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La audiencia no pudo ser eliminada, por favor revise la celda seleccionada o comuníquese con el administrador técnico.");
                                }
                            }
                        }
                        else if (ModificarAdjunto == DialogResult.No)
                        {
                            return;
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

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpInicial.Format = DateTimePickerFormat.Custom;
            dtpInicial.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }

        private void dtpfinal_ValueChanged(object sender, EventArgs e)
        {
            dtpfinal.Format = DateTimePickerFormat.Custom;
            dtpfinal.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }
    }
}