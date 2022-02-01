using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class BatallonesViews
    {
        public int id_Batallon { get; set; }
        public string Nombre_Batallon { get; set; }
        public int Fuerza { get; set; }
        public bool Estado { get; set; }
    }
}
