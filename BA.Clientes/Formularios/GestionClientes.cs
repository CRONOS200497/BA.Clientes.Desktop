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
    public partial class GestionClientes : Form
    {
        public int Perfil_Rol;
        public string Usuario;

        public GestionClientes(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
        }

        ClientesController ConsultarClientes = new ClientesController();
        RolesController Rol = new RolesController();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtConsultaCliente.Text.Length > 0)
            {
                var Load_Cliente = ConsultarClientes.ConsultarClienteCedula(txtConsultaCliente.Text);
                dataGridView1.ReadOnly = false;
                dataGridView1.DataSource = Load_Cliente;
                btnEditar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del cliente a buscar");
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            var Load_Cliente = ConsultarClientes.ConsultarTodosLosClientes();
            dataGridView1.DataSource = Load_Cliente;
            btnEditar.Enabled = true;
        }

        private string ModificarCliente()
        {
            try
            {
                return dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            }
            catch
            {
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Numero_Documento_Cliente = ModificarCliente();
            if (Numero_Documento_Cliente != null)
            {
                string Nombre_Formulario = "ModificarClientes";
                var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                if (Roles.Count > 0)
                {
                    foreach (var d in Roles)
                    {
                        if (d.Nombre_Rol.Equals(Nombre_Formulario))
                        {
                            ModificarClientes ModificarClientes = new ModificarClientes(Numero_Documento_Cliente, PerfilRol, Usuario_Login);
                            ModificarClientes.ShowDialog();
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
            else
            {
                MessageBox.Show("Seleccione la fila del cliente a modificar");
            }
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}

