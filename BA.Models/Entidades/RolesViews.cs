using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class RolesViews
    {
        public int Id_Rol { get; set; }
        public string Nombre_Rol { get; set; }
        public int Id_Perfil { get; set; }
        public bool Estado_Rol { get; set; }

    }
}
