using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosFuerza
    {
        public List<FuerzaViews> MostrarFuerza()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFuerza
                             select new FuerzaViews()
                             {
                                 id_Fuerza = c.id_Fuerza,
                                 Nombre_Fuerza = c.Nombre_Fuerza,

                             }).ToList();

                return query;
            }
        }
        public string MostrarFuerzaNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFuerza
                             where c.id_Fuerza == value
                             select new FuerzaViews()
                             {
                                 Nombre_Fuerza = c.Nombre_Fuerza,
                             }).ToList();
                string Nombre_Fuerza = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Fuerza = g.Nombre_Fuerza;
                }

                return Nombre_Fuerza;
            }
        }

        public List<FuerzaViews> MostrarFuerzaValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFuerza
                             where c.Nombre_Fuerza == value
                             select new FuerzaViews()
                             {
                                 id_Fuerza = c.id_Fuerza,
                                 Nombre_Fuerza = c.Nombre_Fuerza,
                             }).ToList();


                return query;
            }
        }

        public int MostrarFuerzaValor2(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFuerza
                             where c.Nombre_Fuerza == value
                             select new FuerzaViews()
                             {
                                 id_Fuerza = c.id_Fuerza,
                                 Nombre_Fuerza = c.Nombre_Fuerza,
                             }).ToList();

                int id_Fuerza = 0;

                foreach (var g in query)
                {
                    id_Fuerza = g.id_Fuerza;
                }
                return id_Fuerza;


            }
        }

        public List<FuerzaViews> MostrarSoloNombreFuerza()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFuerza
                             select new FuerzaViews()
                             {
                                 Nombre_Fuerza = c.Nombre_Fuerza,
                             }).ToList();

                return query;
            }
        }

    }
}
