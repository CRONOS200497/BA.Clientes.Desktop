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
    public partial class AgendaFamilia : Form
    {
        public int Id_Perfil;
        public string Usuario;


        public AgendaFamilia(int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
        }

        ClientesController Negocio = new ClientesController();
        FamiliaController Familiar = new FamiliaController();
        TelefonosFamiliaController Telefono = new TelefonosFamiliaController();
        CorreosFamiliaController Correos = new CorreosFamiliaController();
        TelefonosFamiliaViews EntidadTelefonos = new TelefonosFamiliaViews();
        CorreosFamiliaViews EntidadCorreos = new CorreosFamiliaViews();
        RolesController Rol = new RolesController();

        string Usuario_Login = string.Empty;
        int PerfilRol = 0;
        int id_telefono = 0;
        int id_Correo = 0;
        string documento_Cliente = string.Empty;
        string numero_documento = string.Empty;

        private void AgendaClientes_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
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
                        txtTelefono.Enabled = true;
                        txtCorreo.Enabled = true;
                    }
                    CargarTelefonosCliente(txtNumeroIdentificacionCliente.Text);
                    CargarCorreosCliente(txtNumeroIdentificacionCliente.Text);

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

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
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
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            txtCorreo.Clear();
            txtCorreo.Enabled = false;
            txtTelefono.Clear();
            txtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            lblCreadoTelefono.Visible = false;
            lblModificadoTelefono.Visible = false;
            lblSubidoPorTelefono.Visible = false;
            lblCreadoCorreo.Visible = false;
            lblModificadoCorreo.Visible = false;
            lblSubidoPorCorreo.Visible = false;

        }

        private void CargarTelefonosCliente(string doc)
        {
            var load_documentos = Telefono.ConsultarTelefonosPorFamiliar(txtNumeroIdentificacionFamiliar.Text);
            dataGridView1.Rows.Clear();
            if (load_documentos.Count > 0)
            {
                foreach (var d in load_documentos)
                {
                    dataGridView1.Rows.Add(d.id_Telefono, d.Numero_Telefono, d.Fecha_Insertado, d.Fecha_Actualizado, d.Usuario);
                    dataGridView1.Enabled = true;
                    btnGuardar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("El número de documento registrado no tiene ningún télefono.");
                btnGuardar.Enabled = true;
            }
        }

        private void CargarCorreosCliente(string doc)
        {
            var load_documentos = Correos.ConsultarCorreosPorFamilia(txtNumeroIdentificacionFamiliar.Text);
            dataGridView2.Rows.Clear();
            if (load_documentos.Count > 0)
            {
                foreach (var d in load_documentos)
                {
                    dataGridView2.Rows.Add(d.id_Correo, d.Correo, d.Fecha_Insertado, d.Fecha_Actualizado, d.Usuario);
                    dataGridView2.Enabled = true;
                    btnGuardar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("El número de documento registrado no tiene ningún correo.");
                btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "GuardarAgendaFamilia";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {
                        if (txtTelefono.Text.Length > 0)
                        {
                            if (txtTelefono.Text.Length > 0 && txtTelefono.Text.Length <= 18)
                            {
                                GuardarTelefono();
                            }
                            else
                            {
                                MessageBox.Show("El teléfono debe tener entre 1 caracter y 18 caracteres númericos.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor escriba un teléfono, antes de oprimir guardar.");
                        }

                        if (txtCorreo.Text.Length > 0)
                        {
                            if (txtCorreo.Text.Length > 0 && txtCorreo.Text.Length <= 100)
                            {
                                GuardarCorreo();
                            }
                            else
                            {
                                MessageBox.Show("El Correo debe tener entre 1 caracter y 100 caracteres.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor escriba un correo, antes de oprimir guardar.");
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

        public void GuardarTelefono()
        {
            EntidadTelefonos.Numero_Telefono = txtTelefono.Text;
            EntidadTelefonos.Doc_Familiar = txtNumeroIdentificacionFamiliar.Text;
            EntidadTelefonos.Fecha_Insertado = System.DateTime.Now;
            EntidadTelefonos.Fecha_Actualizado = System.DateTime.Now;
            EntidadTelefonos.Usuario = Usuario_Login;
            bool ValidarRegistroTelefono = Telefono.GuardarTelefonoFamilia(EntidadTelefonos);
            if (ValidarRegistroTelefono == true)
            {
                lblCreadoTelefono.Visible = true;
                lblCreadoTelefono.Text = EntidadTelefonos.Fecha_Insertado.ToString();
                lblModificadoTelefono.Visible = true;
                lblModificadoTelefono.Text = EntidadTelefonos.Fecha_Actualizado.ToString();
                lblSubidoPorTelefono.Visible = true;
                lblSubidoPorTelefono.Text = EntidadTelefonos.Usuario.ToString();
                MessageBox.Show("El teléfono ha sido cargado correctamente.");
                CargarTelefonosCliente(txtNumeroIdentificacionCliente.Text);
                PostModificarTelefono();
            }
            else
            {
                MessageBox.Show("El teléfono no pudo ser cargado, por favor verifique la información y oprima guardar");
            }
        }

        public void GuardarCorreo()
        {
            EntidadCorreos.Correo = txtCorreo.Text;
            EntidadCorreos.Doc_Familiar = txtNumeroIdentificacionFamiliar.Text;
            EntidadCorreos.Fecha_Insertado = System.DateTime.Now;
            EntidadCorreos.Fecha_Actualizado = System.DateTime.Now;
            EntidadCorreos.Usuario = Usuario_Login;
            bool ValidarRegistroCorreo = Correos.GuardarCorreoFamilia(EntidadCorreos);
            if (ValidarRegistroCorreo == true)
            {
                lblCreadoCorreo.Visible = true;
                lblCreadoCorreo.Text = EntidadCorreos.Fecha_Insertado.ToString();
                lblModificadoCorreo.Visible = true;
                lblModificadoCorreo.Text = EntidadCorreos.Fecha_Actualizado.ToString();
                lblSubidoPorCorreo.Visible = true;
                lblSubidoPorCorreo.Text = EntidadCorreos.Usuario.ToString();
                MessageBox.Show("El Correo ha sido cargado correctamente.");
                CargarCorreosCliente(txtNumeroIdentificacionCliente.Text);
                PostModificarCorreo();
            }
            else
            {
                MessageBox.Show("El correo no pudo ser cargado, por favor verifique la información y oprima guardar");
            }
        }

        private void PostModificarCorreo()
        {

            txtCorreo.Clear();
            lblCreadoCorreo.Visible = false;
            lblModificadoCorreo.Visible = false;
            lblSubidoPorCorreo.Visible = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void PostModificarTelefono()
        {
            txtTelefono.Clear();
            lblCreadoTelefono.Visible = false;
            lblModificadoTelefono.Visible = false;
            lblSubidoPorTelefono.Visible = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }



        private void PostGuardar()
        {
            txtTelefono.Clear();
            txtCorreo.Clear();
            lblCreadoTelefono.Visible = false;
            lblModificadoTelefono.Visible = false;
            lblSubidoPorTelefono.Visible = false;
            lblCreadoCorreo.Visible = false;
            lblModificadoCorreo.Visible = false;
            lblSubidoPorCorreo.Visible = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            id_Correo = Convert.ToInt32(ModificarNovedadesCorreos());
            var Load_Novedad_Id = Correos.ConsultarCorreoPorIdFamiliar(id_Correo);

            foreach (var d in Load_Novedad_Id)
            {
                txtCorreo.Text = d.Correo;
                lblCreadoCorreo.Text = d.Fecha_Insertado.ToString();
                lblModificadoCorreo.Text = d.Fecha_Actualizado.ToString();
                lblSubidoPorCorreo.Text = d.Usuario.ToString();
                lblCreadoCorreo.Visible = true;
                lblModificadoCorreo.Visible = true;
                lblSubidoPorCorreo.Visible = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id_telefono = Convert.ToInt32(ModificarNovedadesTelefonos());
            var Load_Novedad_Id = Telefono.ConsultarTelefonoFamiliaPorId(id_telefono);

            foreach (var d in Load_Novedad_Id)
            {
                txtTelefono.Text = d.Numero_Telefono;
                lblCreadoTelefono.Text = d.Fecha_Insertado.ToString();
                lblModificadoTelefono.Text = d.Fecha_Actualizado.ToString();
                lblSubidoPorTelefono.Text = d.Usuario.ToString();
                lblCreadoTelefono.Visible = true;
                lblModificadoTelefono.Visible = true;
                lblSubidoPorTelefono.Visible = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }


        private string ModificarNovedadesTelefonos()
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

        private string ModificarNovedadesCorreos()
        {
            try
            {
                return dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "ModificarAgendaFamilia";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (txtTelefono.Text.Length > 0)
                    {
                        DialogResult Confirmar_Modificacion_Telefono = MessageBox.Show("¿Esta seguro que desea modificar el teléfono?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion_Telefono == DialogResult.OK)
                        {

                            if (txtTelefono.Text.Length > 0 && txtTelefono.Text.Length <= 18)
                            {
                                ModificarTelefono();
                            }
                            else
                            {
                                MessageBox.Show("El teléfono debe tener entre 1 caracter y 18 caracteres númericos.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor escriba un teléfono, antes de oprimir guardar.");
                    }

                    if (txtCorreo.Text.Length > 0)
                    {
                        DialogResult Confirmar_Modificacion_Telefono = MessageBox.Show("¿Esta seguro que desea modificar este correo?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion_Telefono == DialogResult.OK)
                        {

                            if (txtCorreo.Text.Length > 0 && txtCorreo.Text.Length <= 100)
                            {

                                ModificarCorreo();
                            }
                            else
                            {
                                MessageBox.Show("El Correo debe tener entre 1 caracter y 100 caracteres.");
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("Por favor escriba un correo, antes de oprimir guardar.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para esta opción, de requerirla por favor solicítela con el administrador del sistema.");
            }
        }

        public void ModificarTelefono()
        {
            EntidadTelefonos.id_Telefono = id_telefono;
            EntidadTelefonos.Numero_Telefono = txtTelefono.Text;
            EntidadTelefonos.Doc_Familiar = txtNumeroIdentificacionFamiliar.Text;
            EntidadTelefonos.Fecha_Insertado = Convert.ToDateTime(lblCreadoTelefono.Text);
            EntidadTelefonos.Fecha_Actualizado = System.DateTime.Now;
            EntidadTelefonos.Usuario = lblSubidoPorTelefono.Text;
            bool ValidarRegistroTelefono = Telefono.ModificarTelefonoFamilia(EntidadTelefonos);
            if (ValidarRegistroTelefono == true)
            {
                lblCreadoTelefono.Visible = true;
                lblCreadoTelefono.Text = EntidadTelefonos.Fecha_Insertado.ToString();
                lblModificadoTelefono.Visible = true;
                lblModificadoTelefono.Text = EntidadTelefonos.Fecha_Actualizado.ToString();
                lblSubidoPorTelefono.Visible = true;
                lblSubidoPorTelefono.Text = EntidadTelefonos.Usuario.ToString();
                MessageBox.Show("El teléfono ha sido modificado correctamente.");
                CargarTelefonosCliente(txtNumeroIdentificacionCliente.Text);
                PostModificarTelefono();
            }
            else
            {
                MessageBox.Show("El telefono no pudo ser modificado, por favor verifique la información y oprima guardar");
            }
        }

        public void ModificarCorreo()
        {
            EntidadCorreos.id_Correo = id_Correo;
            EntidadCorreos.Correo = txtCorreo.Text;
            EntidadCorreos.Doc_Familiar = txtNumeroIdentificacionFamiliar.Text;
            EntidadCorreos.Fecha_Insertado = Convert.ToDateTime(lblCreadoCorreo.Text);
            EntidadCorreos.Fecha_Actualizado = System.DateTime.Now;
            EntidadCorreos.Usuario = lblSubidoPorCorreo.Text;
            bool ValidarRegistroCorreo = Correos.ModificarCorreoFamilia(EntidadCorreos);
            if (ValidarRegistroCorreo == true)
            {
                lblCreadoCorreo.Visible = true;
                lblCreadoCorreo.Text = EntidadCorreos.Fecha_Insertado.ToString();
                lblModificadoCorreo.Visible = true;
                lblModificadoCorreo.Text = EntidadCorreos.Fecha_Actualizado.ToString();
                lblSubidoPorCorreo.Visible = true;
                lblSubidoPorCorreo.Text = EntidadCorreos.Usuario.ToString();
                MessageBox.Show("El Correo ha sido modificado correctamente.");
                CargarCorreosCliente(txtNumeroIdentificacionCliente.Text);
                PostModificarCorreo();
            }
            else
            {
                MessageBox.Show("El correo no pudo ser modificado, por favor verifique la información y oprima guardar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Nombre_Formulario = "EliminarAgendaFamilia";
            var Roles = Rol.ConsultarRolesPorPerfil(PerfilRol, Nombre_Formulario);
            if (Roles.Count > 0)
            {
                foreach (var d in Roles)
                {
                    if (d.Nombre_Rol.Equals(Nombre_Formulario))
                    {

                        DialogResult Confirmar_Modificacion_Telefono = MessageBox.Show("¿Esta seguro que desea eliminar este teléfono?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion_Telefono == DialogResult.OK)
                        {

                            id_telefono = Convert.ToInt32(ModificarNovedadesTelefonos());

                            if (id_telefono >= 0)
                            {

                                EntidadTelefonos.id_Telefono = id_telefono;

                                bool confirmar_eliminacion = Telefono.EliminarTelefonoFamilia(EntidadTelefonos);

                                if (confirmar_eliminacion == true)
                                {
                                    MessageBox.Show("El teléfono ha sido eliminado correctamente.");
                                    CargarTelefonosCliente(txtNumeroIdentificacionCliente.Text);
                                    PostGuardar();
                                }
                                else
                                {
                                    MessageBox.Show("El teléfono no pudo ser eliminado, por favor verifique la información y oprima guardar");
                                }
                            }
                            else
                            {

                                MessageBox.Show("Seleccione la fila del teléfono ha eliminar.");
                            }
                        }

                        DialogResult Confirmar_Modificacion_Correo = MessageBox.Show("¿Esta seguro que desea eliminar este correo?", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (Confirmar_Modificacion_Correo == DialogResult.OK)
                        {

                            id_Correo = Convert.ToInt32(ModificarNovedadesCorreos());

                            if (id_Correo >= 0)
                            {
                                EntidadCorreos.id_Correo = id_Correo;

                                bool confirmar_eliminacion = Correos.EliminarCorreoFamilia(EntidadCorreos);

                                if (confirmar_eliminacion == true)
                                {
                                    MessageBox.Show("El Correo ha sido eliminado correctamente.");
                                    CargarCorreosCliente(txtNumeroIdentificacionCliente.Text);
                                    PostGuardar();
                                }
                                else
                                {
                                    MessageBox.Show("El correo no pudo ser eliminado, por favor verifique la información y oprima guardar");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione la fila del correo ha eliminar.");
                            }
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtNumeroIdentificacionFamiliar.Text.Length > 0)
            {
                bool validar_Familiar_Existe = Familiar.ValidarSiFamiliarExiste(txtNumeroIdentificacionFamiliar.Text);
                if (validar_Familiar_Existe == false)
                {
                    var Load_Familiar = Familiar.ConsultarFamiliarNumeroDocumento(txtNumeroIdentificacionFamiliar.Text);
                    foreach (var c in Load_Familiar)
                    {
                        txtNumeroIdentificacionFamiliar.Text = c.Numero_Documento_Cliente;
                        txtPrimerNombreFamiliar.Text = c.Primer_Nombre;
                        txtSegundoNombreFamiliar.Text = c.Segundo_Nombre;
                        txtPrimerApellidoFamiliar.Text = c.Primer_Apellido;
                        txtSegundoApellidoFamiliar.Text = c.Segundo_Apellido;
                        txtNumeroIdentificacionFamiliar.Enabled = false;
                        txtPrimerNombreFamiliar.Enabled = false;
                        txtSegundoNombreFamiliar.Enabled = false;
                        txtPrimerApellidoFamiliar.Enabled = false;
                        txtSegundoApellidoFamiliar.Enabled = false;
                        txtTelefono.Enabled = true;
                        txtCorreo.Enabled = true;
                        documento_Cliente = c.Numero_Documento_Cliente;
                    }
                    var Load_Cliente = Negocio.ConsultarClienteAsociarFamilia(documento_Cliente);
                    foreach (var c in Load_Cliente)
                    {
                        txtNumeroIdentificacionCliente.Text = c.Numero_Documento_Cliente;
                        txtPrimerNombreCliente.Text = c.Primer_Nombre;
                        txtSegundoNombreCliente.Text = c.Segundo_Nombre;
                        txtPrimerApellidoCliente.Text = c.Primer_Apellido;
                        txtSegundoApellidoCliente.Text = c.Segundo_Apellido;
                    }
                    CargarTelefonosCliente(txtNumeroIdentificacionFamiliar.Text);
                    CargarCorreosCliente(txtNumeroIdentificacionFamiliar.Text);
                }
                else
                {
                    MessageBox.Show("El número de documento digitado, no corresponde a ninguno de los familiares registrados, por favor verifique la información y vuelva a intentar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor digite el número de documento del cliente a buscar");
            }
        }

        private void btnNuevaBusqueda_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            txtNumeroIdentificacionCliente.Clear();
            txtPrimerNombreCliente.Clear();
            txtSegundoNombreCliente.Clear();
            txtPrimerApellidoCliente.Clear();
            txtSegundoApellidoCliente.Clear();
            txtNumeroIdentificacionFamiliar.Clear();
            txtPrimerNombreFamiliar.Clear();
            txtSegundoNombreFamiliar.Clear();
            txtPrimerApellidoFamiliar.Clear();
            txtSegundoApellidoFamiliar.Clear();
            txtNumeroIdentificacionFamiliar.Enabled = true;
            txtPrimerNombreFamiliar.Enabled = true;
            txtSegundoNombreFamiliar.Enabled = true;
            txtPrimerApellidoFamiliar.Enabled = true;
            txtSegundoApellidoFamiliar.Enabled = true;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            txtCorreo.Clear();
            txtCorreo.Enabled = false;
            txtTelefono.Clear();
            txtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            lblCreadoTelefono.Visible = false;
            lblModificadoTelefono.Visible = false;
            lblSubidoPorTelefono.Visible = false;
            lblCreadoCorreo.Visible = false;
            lblModificadoCorreo.Visible = false;
            lblSubidoPorCorreo.Visible = false;
        }

        private void AgendaFamilia_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
