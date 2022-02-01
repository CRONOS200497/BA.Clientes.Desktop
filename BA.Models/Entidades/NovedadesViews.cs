using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class NovedadesViews
    {
        public int Id_Novedad { get; set; }
        public string Doc_Cliente { get; set; }
        public string Tipo_Novedad { get; set; }
        public string Descripcion { get; set; }
        public bool Adjuntar_Archivo { get; set; }
        public string Nombre_Archivo { get; set; }
        public string Ruta { get; set; }
        public bool Informar_Cliente { get; set; }
        public System.DateTime Fecha_Subido { get; set; }
        public System.DateTime Fecha_Modificado { get; set; }
        public string Usuario { get; set; }
    }
}
