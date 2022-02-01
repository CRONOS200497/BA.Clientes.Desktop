using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosBatallones
    {
        public string MostrarBatallonesNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblBatallones
                             where c.id_Batallon == value
                             select new BatallonesViews()
                             {
                                 Nombre_Batallon = c.Nombre_Batallon,

                             }).ToList();

                string Nombre_Batallones = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Batallones = g.Nombre_Batallon;
                }

                return Nombre_Batallones;
            }
        }

        public List<BatallonesViews> MostrarBatallonesPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblBatallones
                             where c.id_Batallon == value
                             select new BatallonesViews()
                             {
                                 id_Batallon = c.id_Batallon,
                                 Nombre_Batallon = c.Nombre_Batallon,
                                 Fuerza = c.Fuerza,
                                 Estado = c.Estado,
                             }).ToList();

                return query;
            }
        }

        public List<BatallonesViews> MostrarBatallonesValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblBatallones
                             where c.Nombre_Batallon == value
                             select new BatallonesViews()
                             {
                                 id_Batallon = c.id_Batallon,
                                 Nombre_Batallon = c.Nombre_Batallon,
                                 Fuerza = c.Fuerza,
                                 Estado = c.Estado,
                             }).ToList();

                return query;
            }
        }

        public List<BatallonesViews> MostrarBatallones(int fuerza)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblBatallones
                             where c.Fuerza == fuerza
                             where c.Estado == true
                             select new BatallonesViews()
                             {
                                 id_Batallon = c.id_Batallon,
                                 Nombre_Batallon = c.Nombre_Batallon,
                                 Fuerza = c.Fuerza,
                                 Estado = c.Estado
                             }).ToList();

                return query;
            }
        }

        public List<BatallonesViews> BatallonesParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblBatallones
                             orderby c.id_Batallon ascending
                             select new BatallonesViews()
                             {
                                 id_Batallon = c.id_Batallon,
                                 Nombre_Batallon = c.Nombre_Batallon,
                                 Fuerza = c.Fuerza,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }


        public bool GuardarBatallones(tblBatallones bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblBatallones.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }

        public bool ModificarBatallones(tblBatallones bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.Entry(bat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}
