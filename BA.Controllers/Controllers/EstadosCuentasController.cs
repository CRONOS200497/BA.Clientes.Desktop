using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class EstadosCuentasController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<EstadosCuentaViews> MostrarTiposEstadosCuentas()
        {
            return metodos.MostrarTiposEstadosCuentas();
        }
        public string MostrarTiposEstadosCuentasNombre(int value)

        {
            return metodos.MostrarTiposEstadosCuentasNombre(value);
        }

        public int MostrarTiposEstadosCuentasValor(string value)

        {
            return metodos.MostrarTiposEstadosCuentasValor(value);
        }



    }
}
