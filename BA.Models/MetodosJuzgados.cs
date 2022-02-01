using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosJuzgados
    {    
        public List<JuzgadosViews> MostrarJuzgados()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblJuzgados
                             where d.Estado == true
                             select new JuzgadosViews()
                             {
                                 id_Juzgado = d.id_Juzgado,
                                 Nombre_Juzgado = d.Nombre_Juzgado,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarJuzgadosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblJuzgados
                             where d.id_Juzgado == value
                             select new JuzgadosViews()
                             {
                                 id_Juzgado = d.id_Juzgado,
                                 Nombre_Juzgado = d.Nombre_Juzgado,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Juzgado = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Juzgado = g.Nombre_Juzgado;
                }

                return Nombre_Juzgado;
            }
        }

        public int MostrarJuzgadosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblJuzgados
                             where d.Nombre_Juzgado == value
                             select new JuzgadosViews()
                             {
                                 id_Juzgado = d.id_Juzgado,
                                 Nombre_Juzgado = d.Nombre_Juzgado,
                                 Estado = d.Estado,
                             }).ToList();

                int id_Juzgado = 0;

                foreach (var g in query)
                {
                    id_Juzgado = g.id_Juzgado;
                }
                return id_Juzgado;
            }
        }

        public List<JuzgadosViews> MostrarJuzgadoSeleccionado(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblJuzgados
                             where d.Nombre_Juzgado == value
                             select new JuzgadosViews()
                             {
                                 id_Juzgado = d.id_Juzgado,
                                 Nombre_Juzgado = d.Nombre_Juzgado,
                                 Estado = d.Estado,
                             }).ToList();

                return query;
            }
        }

    }
}
