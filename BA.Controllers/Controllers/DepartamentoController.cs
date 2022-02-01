using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class DepartamentoController
    {
        Models.Metodos metodos = new Models.Metodos();
        public List<DepartamentosViews> MostrarDepartamentos()
        {

            return metodos.MostarDepartamentos();
        }
        public string MostrarDepartamentosNombre(int value)

        {
            return metodos.MostarDepartamentosNombre(value);
        }

        public List<DepartamentosViews> MostrarDepartamentosValor(string value)

        {
            return metodos.MostarDepartamentosValor(value);
        }

        public int MostrarDepartamentosValorId(string value)

        {
            return metodos.MostarDepartamentosValorId(value);
        }

    }
}
