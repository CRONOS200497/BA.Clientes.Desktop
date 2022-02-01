using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Models;
using BA.Models.Entidades;

namespace BA.Controllers.Controllers
{
    public class DocumentosFamiliaresController
    {
        Models.Metodos metodos = new Models.Metodos();
        public List<DocumentosFamiliaresViews> ConsultarDocumentosFamilia()
        {
            return metodos.ConsultarDocumentosFamilia();
        }

        public string MostrarTipoDocumentoFamiliaNombre(int value)

        {
            return metodos.MostrarTipoDocumentoFamiliaNombre(value);
        }

        public List<DocumentosFamiliaresViews> MostrarDocumentosFamiliaValue(string value)
        {
            return metodos.MostrarDocumentosFamiliaValue(value);
        }
    }
}
