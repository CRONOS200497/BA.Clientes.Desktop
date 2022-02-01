using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class EstadosCitasMedicasController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<EstadosCitasMedicasViews> MostrarTiposEstadosCitasMedicas()
        {
            return metodos.MostrarTiposEstadosCitasMedicas();
        }
        public string MostrarTiposEstadosCitasMedicasNombre(int value)

        {
            return metodos.MostrarTiposEstadosCitasMedicasNombre(value);
        }

        public int MostrarTiposEstadosCitasMedicasValor(string value)

        {
            return metodos.MostrarTiposEstadosCitasMedicasValor(value);
        }
    }
}
