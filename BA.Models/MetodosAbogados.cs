using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosAbogados
    {
        public List<AbogadosViews> MostrarAbogados()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAbogados
                             where d.Estado == true
                             select new AbogadosViews()
                             {
                                 id_Abogados = d.id_Abogados,
                                 Nombre_Abogado = d.Nombre_Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarAbogadosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblAbogados
                             where d.id_Abogados == value
                             select new AbogadosViews()
                             {
                                 id_Abogados = d.id_Abogados,
                                 Nombre_Abogado = d.Nombre_Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Abogado = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Abogado = g.Nombre_Abogado;
                }
                return Nombre_Abogado;
            }
        }

        public int MostrarAbogadosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblAbogados
                             where d.Nombre_Abogado == value
                             select new AbogadosViews()
                             {
                                 id_Abogados = d.id_Abogados,
                                 Nombre_Abogado = d.Nombre_Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Estado = d.Estado,

                             }).ToList();

                int id_Abogados = 0;

                foreach (var g in query)
                {
                    id_Abogados = g.id_Abogados;
                }
                return id_Abogados;
            }
        }

        public string MostrarCorreoAbogado(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblAbogados
                             where d.id_Abogados == value
                             select new AbogadosViews()
                             {
                                 id_Abogados = d.id_Abogados,
                                 Nombre_Abogado = d.Nombre_Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Estado = d.Estado,
                             }).ToList();

                string Correo_Abogado = string.Empty;

                foreach (var g in query)
                {
                    Correo_Abogado = g.Correo_Abogado;
                }
                return Correo_Abogado;
            }
        }

        public List<AbogadosViews> MostrarAbogadoSeleccionado(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAbogados
                             where d.Nombre_Abogado == value
                             select new AbogadosViews()
                             {
                                 id_Abogados = d.id_Abogados,
                                 Nombre_Abogado = d.Nombre_Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

    }
}
