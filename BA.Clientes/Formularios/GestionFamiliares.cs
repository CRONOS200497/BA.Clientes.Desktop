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
    public partial class GestionFamiliares : Form
    {

        public int Perfil_Rol;
        public string Usuario;

        public GestionFamiliares(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
        }

        FamiliaController ConsultarFamiliar = new FamiliaController();
        RolesController Rol = new RolesController();
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            var Load_Familiares = ConsultarFamiliar.ConsultarTodosLosFamiliares(); ;
            dataGridView1.DataSource = Load_Familiares;
            btnEditar.Enabled = true;
        }

        private string ModificarCliente()
        {
            try
            {
                return dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
            }
            catch
            {
                return null;
            }
        }

        private void btnBuscarFamiliar_Click(object sender, EventArgs e)
        {
            if (txtConsultaCliente.Text.Length > 0)
            {

                string value = txtConsultaCliente.Text;
                var result = ConsultarFamiliar.ConsultarFamiliarNumeroDocumento(value);
                dataGridView1.DataSource = result;
                btnEditar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del familiar a buscar.");
            }

        }

        private void BtnBuscarFamiliarPorCliente_Click(object sender, EventArgs e)
        {

            if (txtConsultaCliente.Text.Length > 0)
            {

                string value = txtConsultaCliente.Text;
                var result = ConsultarFamiliar.ConsultarFamiliaresPorCliente(value);
                dataGridView1.DataSource = result;
                btnEditar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del cliente, para consultar todos los familiares asociados.");
            }

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            string Numero_Documento_Cliente = ModificarCliente();
            if (Numero_Documento_Cliente != null)
            {
                string Nombre_Formulario = "ModificarFamiliares";
                var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
                if (Roles.Count > 0)
                {
                    foreach (var d in Roles)
                    {
                        if (d.Nombre_Rol.Equals(Nombre_Formulario))
                        {
                            ModificarFamiliares ModificarFamiliares = new ModificarFamiliares(Numero_Documento_Cliente, PerfilRol, Usuario_Login);
                            ModificarFamiliares.ShowDialog();
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

        private void GestionFamiliares_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}

