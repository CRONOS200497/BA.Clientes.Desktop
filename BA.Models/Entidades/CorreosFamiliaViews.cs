using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class CorreosFamiliaViews
    {
        public int id_Correo { get; set; }
        public string Doc_Familiar { get; set; }
        public string Correo { get; set; }
        public System.DateTime Fecha_Insertado { get; set; }
        public System.DateTime Fecha_Actualizado { get; set; }
        public string Usuario { get; set; }

    }
}
