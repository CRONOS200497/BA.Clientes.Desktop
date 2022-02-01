using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class GradosController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public List<GradosViews> MostrarGrados(int value_fuerza)
        {
            return metodos.MostrarGrados(value_fuerza);

        }

        public string MostrarGradosNombre(int fuerza, int value)

        {
            return metodos.MostrarGradosNombre(fuerza, value);
        }

        public List<GradosViews> MostrarGradosValor(string value)
        {
            return metodos.MostrarGradosValor(value);
        }

    }
}
