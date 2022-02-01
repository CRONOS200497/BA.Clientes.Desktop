using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class AudienciasProcuraduriaViews
    {
        public int id_Audiencia_Procuraduria { get; set; }
        public string Doc_Cliente { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Numero_Proceso { get; set; }
        public string Procuraduria { get; set; }
        public System.DateTime Fecha_Audiencia { get; set; }
        public string Abogado { get; set; }
        public string Correo_Abogado { get; set; }
        public string Observaciones { get; set; }
        public bool Adjuntar_Archivo { get; set; }
        public string Ruta { get; set; }
        public string Nombre_Archivo { get; set; }
        public bool Informar_Cliente { get; set; }
        public bool Informar_Abogado { get; set; }
        public System.DateTime Fecha_Subido { get; set; }
        public System.DateTime Fecha_Actualizado { get; set; }
        public string Usuario { get; set; }

    }
}
