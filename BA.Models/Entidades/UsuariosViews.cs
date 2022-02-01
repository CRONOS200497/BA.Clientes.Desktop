using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class UsuariosViews
    {
        public int id_Usuario { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string login { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string perfil { get; set; }
        public bool estado { get; set; }
        public System.DateTime fecha_creado { get; set; }
    }
}
