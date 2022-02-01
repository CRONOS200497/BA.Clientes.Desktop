using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class ParametrosControllers
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public string MostrarParametro(string parametro)
        {
            return metodos.MostrarParametro(parametro);
        }
    }
}
