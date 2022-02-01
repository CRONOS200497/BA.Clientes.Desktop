using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
   public class EstadosFichasMedicasViews
    {
        public int id_Estado_Ficha_Medica { get; set; }
        public string Nombre_Estado { get; set; }
        public int Fuerza { get; set; }
        public bool Estado { get; set; }
    }
}
