using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TipoDocumentoController
    {
        BA.Models.Metodos metodos = new Models.Metodos();
        public List<TipoDocumentosViews> MostrarTipoDocumentos()
        {
            return metodos.MostrarTipoDocumentos();
        }
        public string MostrarTipoDocumentosNombre(int value)

        {
            return metodos.MostrarTipoDocumentosNombre(value);
        }

        public List<TipoDocumentosViews> MostrarTipoDocumentosValor(string value)

        {
            return metodos.MostrarTipoDocumentosValor(value);
        }

    }
}
