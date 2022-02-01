using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class DocumentosClientesViews
    {
        public int id_documento { get; set; }
        public string Nombre_Documento { get; set; }
        public bool estado { get; set; }
    }
}
