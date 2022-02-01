using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class AreasTareasViews
    {
        public int id { get; set; }
        public string Area { get; set; }
        public string Tipo_Tarea { get; set; }
        public string Tarea { get; set; }
        public int Dias { get; set; }
        public bool Estado { get; set; }
    }
}
