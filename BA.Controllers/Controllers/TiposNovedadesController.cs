using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TiposNovedadesController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<TiposNovedadesViews> MostrarTiposNovedades()
        {
            return metodos.MostrarTiposNovedades();
        }
        public string MostrarTiposNovedadesNombre(int value)

        {
            return metodos.MostrarTiposNovedadesNombre(value);
        }

        public int MostrarTiposNovedadesValor(string value)

        {
            return metodos.MostrarTiposNovedadesValor(value);
        }
    }
}
