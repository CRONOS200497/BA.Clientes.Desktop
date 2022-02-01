using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class RegistrarTareasViews
    {
        public int id_Solicitud { get; set; }
        public int id_Tarea { get; set; }
        public string Creador { get; set; }
        public string Responsable { get; set; }
        public string Doc_Cliente { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
        public bool Adjunto { get; set; }
        public string Ruta { get; set; }
        public string Nombre_Archivo { get; set; }
        public bool Notificar_Responsable { get; set; }
        public string Area_Creadora { get; set; }
        public System.DateTime Fecha_Asignado { get; set; }
        public System.DateTime Fecha_Actualizado { get; set; }
    }
}
