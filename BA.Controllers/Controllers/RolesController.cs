using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class RolesController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public IList<RolesViews> ConsultarRolesPorPerfil(int Id_Perfil, string Nombre_Formulario)
        {

            return metodos.ConsultarRolesPorPerfil(Id_Perfil, Nombre_Formulario);

        }



    }
}
