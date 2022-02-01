using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;


namespace BA.Controllers.Controllers
{
   public class EstadosFichasMedicasController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<EstadosFichasMedicasViews> MostrarTiposEstadosFichasMedicas(int value)
        {
            return metodos.MostrarTiposEstadosFichasMedicas(value);
        }
        public string MostrarTiposEstadosFichasMedicasNombre(int value_Ficha_Medica, int value_fuerza)

        {
            return metodos.MostrarTiposEstadosFichasMedicasNombre(value_Ficha_Medica, value_fuerza);
        }

        public int MostrarTiposEstadosFichasMedicasValor(string value)

        {
            return metodos.MostrarTiposEstadosFichasMedicasValor(value);
        }

    }
}
