using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class DocumentosCargadosFamiliaViews
    {
        public int id_Archivo { get; set; }
        public string doc_cliente { get; set; }
        public string tipo_doc { get; set; }
        public string nombre_archivo { get; set; }
        public string ruta { get; set; }
        public System.DateTime fecha_subido { get; set; }
        public System.DateTime fecha_actualizado { get; set; }
        public bool informar_cliente { get; set; }
        public string usuario { get; set; }
    }
}
