using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
   public class TipoRegistroController
    {

        BA.Models.Metodos metodos = new Models.Metodos();

        public List<TipoRegistroViews> MostrarTipoRegistro()
        {

            return metodos.MostrarTipoRegistro();
        }

        public string MostrarTipoRegistroNombre(int value)

        {
            return metodos.MostrarTipoRegistroNombre(value);
        }

        public List<TipoRegistroViews> MostrarTipoRegistroValor(string value)

        {
            return metodos.MostrarTipoRegistroValor(value);
        }

    }
}
