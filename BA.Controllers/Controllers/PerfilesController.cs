using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
        public class PerfilesController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public int ConsultarIDPerfil(string Perfil_Por_Usuario)
        {
            return metodos.ConsultarIDPerfil(Perfil_Por_Usuario);

        }

    }





}
