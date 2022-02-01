using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;
namespace BA.Controllers.Controllers
{
    public class TipoFamiliarController
    {
        BA.Models.Metodos metodos = new Models.Metodos();
        public List<TipoFamiliarViews> MostrarTipoFamiliar()
        {
            return metodos.MostrarTipoFamiliar();

        }
        public string MostrarTipoFamiliarNombre(int value)
        {
            return metodos.MostrarTipoFamiliarNombre(value);

        }

        public List<TipoFamiliarViews> MostrarTipoFamiliarValor(string value)
        {
            return metodos.MostrarTipoFamiliarValor(value);

        }


    }
}
