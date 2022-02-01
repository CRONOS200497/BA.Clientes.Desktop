using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TiposSeguimientosController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<TiposSeguimientosViews> MostrarTiposSeguimientos()
        {
            return metodos.MostrarTiposSeguimientos();
        }
        public string MostrarTipoSeguimientosNombre(int value)

        {
            return metodos.MostrarTipoSeguimientosNombre(value);
        }

        public int MostrarTipoSeguimientosValor(string value)

        {
            return metodos.MostrarTipoSeguimientosValor(value);
        }
        
    }
}
