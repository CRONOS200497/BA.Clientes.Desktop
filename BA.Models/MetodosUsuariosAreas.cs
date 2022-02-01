using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosUsuariosAreas
    {
        public List<UsuarioAreaViews> MostrarUsuarioArea(string Usuario)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblUsuarioArea
                             where d.Usuario == Usuario
                             orderby d.id ascending
                             select new UsuarioAreaViews()
                             {
                                 id = d.id,
                                 Nombre_Area = d.Nombre_Area,
                                 Usuario = d.Usuario,
                                 Estado = d.Estado
                             }).ToList();
                return query;
            }
        }

        public List<UsuarioAreaViews> MostrarUsuariosAreaSeguimiento(string Usuario, string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblUsuarioArea
                             where d.Usuario == Usuario
                             where d.Nombre_Area == Area
                             orderby d.id ascending
                             select new UsuarioAreaViews()
                             {
                                 id = d.id,                           
                                 Usuario = d.Usuario                              
                             }).ToList();
                return query;
            }
        }

        public List<UsuarioAreaViews> MostrarUsuariosArea(string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblUsuarioArea
                             where d.Nombre_Area == Area
                             orderby d.id ascending
                             select new UsuarioAreaViews()
                             {
                                 id = d.id,
                                 Usuario = d.Usuario
                             }).ToList();
                return query;
            }
        }

        public string MostrarUsuarioPorId(int Id_Usuario)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblUsuarioArea
                             where d.id == Id_Usuario
                             orderby d.id ascending
                             select new UsuarioAreaViews()
                             {
                                 Usuario = d.Usuario
                             }).ToList();

                string Nombre_Usuario = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Usuario = g.Usuario;
                }

                return Nombre_Usuario;
            }
        }
    }
}
