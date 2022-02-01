using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Models;
using BA.Models.Entidades;


namespace BA.Controllers.Controllers
{
    public class DocumentosClientesController
    {
        Models.Metodos metodos = new Models.Metodos();
        public List<DocumentosClientesViews> ConsultarDocumentosClientes()
        {
            return metodos.ConsultarDocumentosClientes();

        }

        public string MostrarTipoDocumentoClientesNombre(int value)

        {
            return metodos.MostrarTipoDocumentoClientesNombre(value);
        }

        public List<DocumentosClientesViews> MostrarDocumentosClientesValue(string value)
        {
            return metodos.MostrarDocumentosClientesValue(value);

        }
        
    }
}