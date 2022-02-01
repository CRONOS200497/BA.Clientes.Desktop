using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class UsuariosAreaController
    {
        BA.Models.MetodosUsuariosAreas metodos = new Models.MetodosUsuariosAreas();

        public List<UsuarioAreaViews> MostrarUsuarioArea(string Usuario)
        {
            return metodos.MostrarUsuarioArea(Usuario);
        }

        public List<UsuarioAreaViews> MostrarUsuariosAreaSeguimiento(string Usuario, string Area)
        {
            return metodos.MostrarUsuariosAreaSeguimiento(Usuario,Area);
        }

        public List<UsuarioAreaViews> MostrarUsuariosArea(string Area)
        {
            return metodos.MostrarUsuariosArea(Area);
        }

        public string MostrarUsuarioPorId(int Id_Usuario)
        {
            return metodos.MostrarUsuarioPorId(Id_Usuario);
        }
    }
}
