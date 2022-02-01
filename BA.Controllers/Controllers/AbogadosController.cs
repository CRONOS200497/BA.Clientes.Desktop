using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class AbogadosController
    {
        BA.Models.MetodosAbogados metodos = new Models.MetodosAbogados();

        public List<AbogadosViews> MostrarAbogados()
        {
            return metodos.MostrarAbogados();
        }

        public string MostrarAbogadosNombre(int value)

        {
            return metodos.MostrarAbogadosNombre(value);
        }

        public int MostrarAbogadosValor(string value)

        {
            return metodos.MostrarAbogadosValor(value);
        }

        public string MostrarCorreoAbogado(int value)

        {
            return metodos.MostrarCorreoAbogado(value);
        }

        public List<AbogadosViews> MostrarAbogadoSeleccionado(string value)
        {
            return metodos.MostrarAbogadoSeleccionado(value);
        }
    }
}
