using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class ProcuraduriasController
    {
        BA.Models.MetodosProcuradurias metodos = new Models.MetodosProcuradurias();

        public List<ProcuraduriaViews> MostrarProcuradurias()
        {
            return metodos.MostrarProcuradurias();
        }

        public string MostrarProcuraduriasNombre(int value)

        {
            return metodos.MostrarProcuraduriasNombre(value);
        }

        public int MostrarProcuraduriasValor(string value)

        {
            return metodos.MostrarProcuraduriasValor(value);
        }

        public List<ProcuraduriaViews> MostrarJuzgadoSeleccionado(string value)
        {
            return metodos.MostrarJuzgadoSeleccionado(value);
        }
    }
}
