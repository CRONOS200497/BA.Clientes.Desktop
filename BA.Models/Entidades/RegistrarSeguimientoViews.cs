using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
   public class RegistrarSeguimientoViews
    {
        public int id_Seguimiento { get; set; }
        public int id_Solicitud { get; set; }
        public string Descripcion { get; set; }
        public bool Adjunto { get; set; }
        public string Ruta { get; set; }
        public string Nombre_Archivo { get; set; }
        public bool Notificar_Responsable { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha_Seguimiento { get; set; }
        public string Usuario_Seguimiento { get; set; }
    }
}
