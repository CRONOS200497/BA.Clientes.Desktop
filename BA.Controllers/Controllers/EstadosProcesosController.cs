using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class EstadosProcesosController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public List<EstadosProcesosViews> MostrarEstadosProcesos()
        {
            return metodos.MostrarEstadosProcesos();
        }
        public string MostrarEstadosProcesosNombre(int value)

        {
            return metodos.MostrarEstadosProcesosNombre(value);
        }
        public List<EstadosProcesosViews> MostrarEstadosProcesosValor(string value)

        {
            return metodos.MostrarEstadosProcesosValor(value);
        }

    }
}
