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
    public partial class DocumentosCliente : Form
    {
        public int Id_Perfil;
        public string Usuario;
        public DocumentosCliente(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            dataGridView1.Enabled = false;
        }

        ClientesController Negocio = new ClientesController();
        DocumentosCargadosController Documentos = new DocumentosCargadosController();
        DocumentosCargadosViews EntidadDocumentos = new DocumentosCargadosViews();
        RolesController Rol = new RolesController();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;

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
                    CargarDocumentosClientes(txtNumeroIdentificacionCliente.Text);

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

        private void CargarDocumentosClientes(string doc)
        {
            var load_documentos = Documentos.ConsultarDocumentosClientes(txtNumeroIdentificacionCliente.Text);
            dataGridView1.Rows.Clear();
            if (load_documentos.Count > 0)
            {
                foreach (var d in load_documentos)
                {
                    dataGridView1.Rows.Add(d.id_Archivo, d.tipo_doc, d.nombre_archivo, d.fecha_subido, d.fecha_actualizado, d.informar_cliente, d.usuario);
                    dataGridView1.Enabled = true;
                    btnNuevoDocumento.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("El número de documento registrado no tiene documentos cargados.");
                btnNuevoDocumento.Enabled = true;
            }
        }

        private void btnNuevoDocumento_Click(object sender, EventArgs e)
        {
            string numero_documento = txtNumeroIdentificacionCliente.Text;

            if (numero_documento.Length > 0)
            {
                bool validar_Cliente_Existe = Negocio.ValidarSiClienteExiste(numero_documento);
                if (validar_Cliente_Existe == false)
                {

                    string Nombre_Formulario = "CargarDocumentoNuevo";
                    var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                    foreach (var d in Roles)
                    {
                        if (d.Nombre_Rol.Equals(Nombre_Formulario))
                        {
                            CargarDocumentoNuevo Documentoclientenuevo = new CargarDocumentoNuevo(numero_documento, PerfilRol, Usuario_Login);
                            Documentoclientenuevo.ShowDialog();
                            btnBuscar_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El número de documento digitado, no corresponde a ninguno de los clientes registrados, por favor verifique la información y vuelva a intentar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor primero seleccione un cliente.");
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
            btnNuevoDocumento.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void DocumentosCliente_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Selected)
                {
                    string Nombre_Formulario = "VerDocumentosClientes";
                    var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                    if (Roles.Count > 0)
                    {
                        foreach (var d in Roles)
                        {
                            if (d.Nombre_Rol.Equals(Nombre_Formulario))
                            {
                                int id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                                VerDocumentosClientes ver = new VerDocumentosClientes(id_Archivo, PerfilRol, Usuario_Login);
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

                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Selected)
                {

                    string Nombre_Formulario = "ModificarDocumento";
                    var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                    if (Roles.Count > 0)
                    {
                        foreach (var d in Roles)
                        {
                            if (d.Nombre_Rol.Equals(Nombre_Formulario))
                            {
                                EntidadDocumentos.id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                                int id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                                ModificarDocumento ModificarDocumento = new ModificarDocumento(EntidadDocumentos.id_Archivo, PerfilRol, Usuario_Login);
                                ModificarDocumento.ShowDialog();
                                btnBuscar_Click(sender, e);
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
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Selected)
                {
                    string Nombre_Formulario = "EliminarDocumentoCliente";
                    var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                    if (Roles.Count > 0)
                    {
                        foreach (var d in Roles)
                        {
                            if (d.Nombre_Rol.Equals(Nombre_Formulario))
                            {
                                EntidadDocumentos.id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                                int id_Archivo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                                string ruta = Documentos.AbrirDocumentoCliente(id_Archivo);

                                bool Validar_Eliminado_Registro = Documentos.EliminarDocumentosClientes(EntidadDocumentos.id_Archivo);

                                if (Validar_Eliminado_Registro == true)
                                {
                                    System.IO.File.Delete(ruta);
                                    MessageBox.Show("El documento se ha eliminado correctamente");
                                    btnBuscar_Click(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("El documento no se ha eliminado correctamente, por favor revise si la fila se eliminó, si así fue comuníquese con el administrador del sistema, pero si la fila no fue eliminada cierre el PDF del documento que va a eliminar.");
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
            catch
            {
                return;
            }
        }
    }
}
