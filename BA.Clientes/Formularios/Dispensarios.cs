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


namespace BA.Clientes.Formularios
{
    public partial class Dispensarios : Form
    {
        public int Perfil_Rol;
        public string Usuario;

        public Dispensarios(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            CargarFuerza();
            CargarOpcionesModificar();
            CargarDispensarios();

        }

        RolesController Rol = new RolesController();
        FuerzaController FuerzaV = new FuerzaController();
        DispensariosViews EntidadDispensarios = new DispensariosViews();
        DispensariosControllers Dispensarios2 = new DispensariosControllers();


        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int value_Fuerza = 0;
        string Fuerza = string.Empty;
        bool Estado = false;
        string NombreDispensario = string.Empty;
        int id_novedad = 0;

        private void CargarFuerza()
        {
            var Load_Cargar_Fuerza = FuerzaV.MostrarFuerza();
            cbFuerza.DisplayMember = "Nombre_Fuerza";
            cbFuerza.ValueMember = "id_Fuerza";
            cbFuerza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuerza.DataSource = Load_Cargar_Fuerza;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Fuerza = Convert.ToInt32(cbFuerza.SelectedValue);
            Fuerza = Convert.ToString(FuerzaV.MostrarFuerzaNombre(value_Fuerza));
        }

        private void CargarOpcionesModificar()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            cbEstado.SelectedIndex = 0;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GuardarDispensario";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (txtNombreDispensario.Text.Length > 0 || 160 <= txtNombreDispensario.Text.Length)
                    {
                        NombreDispensario = txtNombreDispensario.Text;
                        Guardar();
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir un nombre de dispensario, de mínimo un carácter máximo 160 caracteres.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
            }
        }

        public void Guardar()
        {

            EntidadDispensarios.Nombre_Dispensario = NombreDispensario.ToUpper();
            EntidadDispensarios.Fuerza = value_Fuerza;
            EntidadDispensarios.Estado = Estado;
            bool Validar_Guardado = Dispensarios2.GuardarDispensarios(EntidadDispensarios);

            if (Validar_Guardado == true)
            {

                MessageBox.Show("El dispensario fue creado correctamente.");
                CargarDispensarios();
                PostGuardado();
            }
            else
            {
                MessageBox.Show("El dispensario no pudo ser creado correctamente, por favor verifique la información y vuélvalo a intentar.");
                return;
            }
        }

        public void PostGuardado()
        {
            txtIdBatallon.Clear();
            txtNombreDispensario.Clear();
            CargarFuerza();
            CargarOpcionesModificar();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id_novedad = Convert.ToInt32(ModificarNovedades());
            var Load_Novedad_Id = Dispensarios2.MostrarDispensariosPorSeleccion(id_novedad);

            foreach (var d in Load_Novedad_Id)
            {
                txtIdBatallon.Text = Convert.ToString(d.id_Dispensario);
                txtNombreDispensario.Text = Convert.ToString(d.Nombre_Dispensario);
                if (d.Estado == true)
                {
                    cbEstado.SelectedIndex = 0;
                    Estado = true;
                }
                else
                {
                    cbEstado.SelectedIndex = 1;
                    Estado = false;
                }
                cbFuerza.SelectedValue = d.Fuerza;
                btnModificar.Enabled = true;
                btnLimpiar.Enabled = true;
                btnGuardar.Enabled = false;
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

        private void CargarFuerzaGenerado(int value)
        {
            var Load_Cargar_Fuerza = FuerzaV.MostrarFuerzaNombre(value);
            cbFuerza.DisplayMember = "Nombre_Fuerza";
            cbFuerza.ValueMember = "id_Fuerza";
            cbFuerza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuerza.DataSource = Load_Cargar_Fuerza;
            cbFuerza.Enabled = false;
        }

        //private void CargarListaFuerza()
        //{
        //    ListaFuerza = FuerzaV.MostrarFuerza();
        //    Fuerza.Equals(ListaFuerza); 

        //}

        private void CargarDispensarios()
        {
            var Cargar_Batallones = Dispensarios2.DispensariosParametrizaciones();
            dataGridView1.Rows.Clear();
            if (Cargar_Batallones.Count > 0)
            {
                foreach (var d in Cargar_Batallones)
                {
                    value_Fuerza = d.Fuerza;
                    Fuerza = FuerzaV.MostrarFuerzaNombre(value_Fuerza);
                    dataGridView1.Rows.Add(d.id_Dispensario, d.Nombre_Dispensario, Fuerza, d.Estado);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra ningún dispensario registrado.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ModificarDispesario";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (txtNombreDispensario.Text.Length > 0 || 160 <= txtNombreDispensario.Text.Length)
                    {
                        NombreDispensario = txtNombreDispensario.Text.ToUpper();
                        Modificar();
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir un nombre de dispensario, de mínimo un carácter máximo 160 caracteres.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
            }
        }

        public void Modificar()
        {
            EntidadDispensarios.id_Dispensario = Convert.ToInt32(txtIdBatallon.Text);
            EntidadDispensarios.Nombre_Dispensario = NombreDispensario.ToUpper();
            EntidadDispensarios.Fuerza = value_Fuerza;
            EntidadDispensarios.Estado = Estado;
            bool Validar_Guardado = Dispensarios2.ModificarDispensarios(EntidadDispensarios);
            if (Validar_Guardado == true)
            {

                MessageBox.Show("El dispensario ha sido modificado correctamente.");
                CargarDispensarios();
                PostGuardado();
            }
            else
            {
                MessageBox.Show("El dispensario no pudo ser modificado correctamente, por favor verifique la información y vuélvalo a intentar.");
                return;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PostGuardado();
            CargarDispensarios();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedIndex == 0)
            {
                Estado = true;
            }
            else
            {
                Estado = false;
            }
        }

        private void Dispensarios_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
