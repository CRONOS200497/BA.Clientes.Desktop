using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class UsuariosController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool Validar_Usuario(string Usuario, string contrasena)
        {
            return metodos.Validar_Usuario(Usuario, contrasena);
        }

        public List<UsuariosViews> ConsultarPerfilPorUsuario(string User)
        {
            return metodos.ConsultarPerfilPorUsuario(User);
        }

    }
}
