using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class JuntasMedicasViews
    {
        public int id_Junta { get; set; }
        public string Doc_Cliente { get; set; }
        public string Fuerza { get; set; }
        public Nullable<System.DateTime> Fecha_Junta { get; set; }
        public string Estado_Junta_Medica { get; set; }
        public string Dispensario { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Otro_Lugar { get; set; }
        public string Direccion { get; set; }
        public bool Adjuntar_Documento { get; set; }
        public string Nombre_Archivo { get; set; }
        public string Ruta { get; set; }
        public bool Informar_Cliente { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime Fecha_Cargado { get; set; }
        public System.DateTime Fecha_Modificado { get; set; }
        public string Usuario { get; set; }

    }
}
