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
    public partial class Batallones : Form
    {
        public int Perfil_Rol;
        public string Usuario;

        public Batallones(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            CargarFuerza();
            CargarOpcionesModificar();
            CargarBatallones();

        }

        RolesController Rol = new RolesController();
        FuerzaController FuerzaV = new FuerzaController();
        BatallonesViews EntidadBatallones = new BatallonesViews();
        BatallonesControllers Batallones2 = new BatallonesControllers();
        List<FuerzaViews> ListaFuerza = null;
        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int value_Fuerza = 0;
        string Fuerza = string.Empty;
        bool Estado = false;
        string NombreBatallon = string.Empty;
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
            string Nombre_Formulario = "GuardarBatallon";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (txtNombreBatallon.Text.Length > 0 || 160 <= txtNombreBatallon.Text.Length)
                    {
                        NombreBatallon = txtNombreBatallon.Text;
                        Guardar();
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir un nombre de batallón, de mínimo un carácter máximo 160 caracteres.");
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

            EntidadBatallones.Nombre_Batallon = NombreBatallon.ToUpper();
            EntidadBatallones.Fuerza = value_Fuerza;
            EntidadBatallones.Estado = Estado;
            bool Validar_Guardado = Batallones2.GuardarBatallones(EntidadBatallones);

            if (Validar_Guardado == true)
            {

                MessageBox.Show("El batallon fue creado correctamente.");
                CargarBatallones();
                PostGuardado();
            }
            else
            {
                MessageBox.Show("El batallón no pudo ser creado correctamente, por favor verifique la información y vuélvalo a intentar.");
                return;
            }
        }

        public void PostGuardado()
        {
            txtIdBatallon.Clear();
            txtNombreBatallon.Clear();
            CargarFuerza();
            CargarOpcionesModificar();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id_novedad = Convert.ToInt32(ModificarNovedades());
            var Load_Novedad_Id = Batallones2.MostrarBatallonesPorSeleccion(id_novedad);

            foreach (var d in Load_Novedad_Id)
            {
                txtIdBatallon.Text = Convert.ToString(d.id_Batallon);
                txtNombreBatallon.Text = Convert.ToString(d.Nombre_Batallon);
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

        private void CargarBatallones()
        {
            var Cargar_Batallones = Batallones2.BatallonesParametrizaciones();
            dataGridView1.Rows.Clear();
            if (Cargar_Batallones.Count > 0)
            {
                foreach (var d in Cargar_Batallones)
                {
                    value_Fuerza = d.Fuerza;
                    Fuerza = FuerzaV.MostrarFuerzaNombre(value_Fuerza);
                    dataGridView1.Rows.Add(d.id_Batallon, d.Nombre_Batallon, Fuerza, d.Estado);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra ningún batallon registrado.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ModificarBatallon";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (txtNombreBatallon.Text.Length > 0 || 160 <= txtNombreBatallon.Text.Length)
                    {
                        NombreBatallon = txtNombreBatallon.Text.ToUpper();
                        Modificar();
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir un nombre de batallón, de mínimo un carácter máximo 160 caracteres.");
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
            EntidadBatallones.id_Batallon = Convert.ToInt32(txtIdBatallon.Text);
            EntidadBatallones.Nombre_Batallon = NombreBatallon.ToUpper();
            EntidadBatallones.Fuerza = value_Fuerza;
            EntidadBatallones.Estado = Estado;
            bool Validar_Guardado = Batallones2.ModificarBatallones(EntidadBatallones);
            if (Validar_Guardado == true)
            {

                MessageBox.Show("El batallon ha sido modificado correctamente.");
                CargarBatallones();
                PostGuardado();
            }
            else
            {
                MessageBox.Show("El batallón no pudo ser modificado correctamente, por favor verifique la información y vuélvalo a intentar.");
                return;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PostGuardado();
            CargarBatallones();
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

        private void Batallones_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
