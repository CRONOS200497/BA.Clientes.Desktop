using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class CiudadesController
    {
        Models.Metodos metodos = new Models.Metodos();
        public List<CiudadesViews> MostrarCiudades(int id_Departamento)
        {
            return metodos.MostrarCiudades(id_Departamento);
        }

        public string MostrarCiudadesNombre(int valuedep, int valuecip)
        {
            return metodos.MostrarCiudadesNombre(valuedep,valuecip);
        }

        public List<CiudadesViews> MostrarCiudadesValor(string value, int ciu)
        {
            return metodos.MostrarCiudadesValor(value, ciu);
        }

        public int MostrarCiudadesValor2(string value, int ciu)
        {
            return metodos.MostrarCiudadesValor2(value, ciu);
        }


    }
}
