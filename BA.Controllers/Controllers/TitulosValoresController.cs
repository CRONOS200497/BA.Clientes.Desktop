using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TitulosValoresController
    {
        Models.Metodos metodos = new Models.Metodos();

        public List<TitulosValoresViews> MostrarTiposTitulosValores()
        {
            return metodos.MostrarTiposTitulosValores();
        }
        public string MostrarTiposTitulosValoresNombre(int value)

        {
            return metodos.MostrarTiposTitulosValoresNombre(value);
        }

        public int MostrarTiposTitulosValoresValor(string value)

        {
            return metodos.MostrarTiposTitulosValoresValor(value);
        }
    }
}
