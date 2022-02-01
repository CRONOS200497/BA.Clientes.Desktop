using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;


namespace BA.Controllers.Controllers
{
   public class ConceptosController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<ConceptosViews> MostrarConceptos()
        {
            return metodos.MostrarConceptos();
        }
        public string MostrarConceptosNombre(int value)

        {
            return metodos.MostrarConceptosNombre(value);
        }

        public int MostrarConceptosValor(string value)

        {
            return metodos.MostrarConceptosValor(value);
        }  

    }
}
