using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class RedesSocialesController
    {
        BA.Models.Metodos metodos = new Models.Metodos();
        public List<RedesSocialesViews> MostrarRedesSociales()
        {
            return metodos.MostrarRedesSociales();

        }
        public string MostrarRedesSocialesNombre(int value)

        {
            return metodos.MostrarRedesSociales(value);
        }
        public List<RedesSocialesViews> MostrarRedesSocialesValor(string value)

        {
            return metodos.MostrarRedesSocialesValue(value);
        }

    }
}
