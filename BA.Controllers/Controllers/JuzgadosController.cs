using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class JuzgadosController
    {
        BA.Models.MetodosJuzgados metodos = new Models.MetodosJuzgados();

        public List<JuzgadosViews> MostrarJuzgados()
        {
            return metodos.MostrarJuzgados();
        }

        public string MostrarJuzgadosNombre(int value)

        {
            return metodos.MostrarJuzgadosNombre(value);
        }

        public int MostrarJuzgadosValor(string value)

        {
            return metodos.MostrarJuzgadosValor(value);
        }

        public List<JuzgadosViews> MostrarJuzgadoSeleccionado(string value)
        {
            return metodos.MostrarJuzgadoSeleccionado(value);
        }
    }
}
