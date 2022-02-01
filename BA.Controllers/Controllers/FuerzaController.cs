using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class FuerzaController
    {
        Models.MetodosFuerza metodos = new Models.MetodosFuerza();

        public List<FuerzaViews> MostrarFuerza()
        {
            return metodos.MostrarFuerza();
        }
        public string MostrarFuerzaNombre(int value)

        {
            return metodos.MostrarFuerzaNombre(value);
        }
        public List<FuerzaViews> MostrarFuerzaValor(string value)

        {
            return metodos.MostrarFuerzaValor(value);
        }

        public int MostrarFuerzaValor2(string value)

        {
            return metodos.MostrarFuerzaValor2(value);
        }

        public List<FuerzaViews> MostrarSoloNombreFuerza()
        {
            return metodos.MostrarSoloNombreFuerza();
        }

    }
}
