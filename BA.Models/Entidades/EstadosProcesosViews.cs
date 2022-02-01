using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class EstadosProcesosViews
    {
        public int id_Estado_Proceso { get; set; }
        public string Nombre_Estado_Proceso { get; set; }
        public int Cantidad_Dias_Minimos { get; set; }
        public int Cantidad_Dias_Maximos { get; set; }
    }
}
