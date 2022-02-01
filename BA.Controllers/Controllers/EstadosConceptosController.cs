using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class EstadosConceptosController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<EstadosConceptosViews> MostrarTiposEstadosConceptos()
        {
            return metodos.MostrarTiposEstadosConceptos();
        }
        public string MostrarTiposEstadosConceptosNombre(int value)

        {
            return metodos.MostrarTiposEstadosConceptosNombre(value);
        }

        public int MostrarTiposEstadosConceptosValor(string value)

        {
            return metodos.MostrarTiposEstadosConceptosValor(value);
        }

    }
}
