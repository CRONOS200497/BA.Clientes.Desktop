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
    public partial class VerDocumentosJuntas : Form
    {
        public int id_Archivo;
        public int Id_Perfil;
        public string Usuario;
        JuntasMedicasController Documentos = new JuntasMedicasController();        
        string ruta = string.Empty;

        public VerDocumentosJuntas(int id_Archivo, int Id_Perfil, string User)
        {
            Usuario_Login = User;
            PerfilRol = Id_Perfil;
            InitializeComponent();
            CargarDocumento(id_Archivo);
        }

        string Usuario_Login = string.Empty;
        int PerfilRol = 0;

        private void CargarDocumento(int id_Archivo)
        {
            ruta = Documentos.AbrirAdjuntoJunta(id_Archivo);
            VisualizarPDF1.src = ruta;

            //VisualizarPDF.LoadFile(ruta);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            VisualizarPDF1.printAll();
        }

        private void VerDocumentosJuntas_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
