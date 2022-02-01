using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class EtapasProcesosController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public List<EtapasProcesosViews> MostrarEtapasProcesos()
        {
            return metodos.MostrarEtapasProcesos();
        }

        public string MostrarEtapasProcesosNombre(int value)

        {
            return metodos.MostrarEtapasProcesosNombre(value);
        }

        public List<EtapasProcesosViews> MostrarEtapasProcesosValor(string value)

        {
            return metodos.MostrarEtapasProcesosValor(value);
        }
    }
}
