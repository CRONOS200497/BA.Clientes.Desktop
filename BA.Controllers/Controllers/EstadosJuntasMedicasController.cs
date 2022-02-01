using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;


namespace BA.Controllers.Controllers
{
   public class EstadosJuntasMedicasController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<EstadosJuntasMedicasViews> MostrarTiposEstadosJuntasMedicas(int value)
        {
            return metodos.MostrarTiposEstadosJuntasMedicas(value);
        }
        public string MostrarTiposEstadosJuntasMedicasNombre(int value_Junta_Medica, int value_Fuerza)

        {
            return metodos.MostrarTiposEstadosJuntasMedicasNombre(value_Junta_Medica, value_Fuerza);
        }

        public int MostrarTiposEstadosJuntasMedicasValor(string value)

        {
            return metodos.MostrarTiposEstadosJuntasMedicasValor(value);
        }

    }
}
