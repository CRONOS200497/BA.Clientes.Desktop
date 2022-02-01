using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosAreas
    {
        public List<AreasViews> MostrarAreas()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreas
                             where c.Estado == true
                             select new AreasViews()
                             {
                                 id_Area = c.id_Area,
                                 Nombre_Area = c.Nombre_Area,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public string MostrarNombreArea(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreas
                             where c.id_Area == value
                             select new AreasViews()
                             {
                                 Nombre_Area = c.Nombre_Area,

                             }).ToList();

                string Nombre_Area = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Area = g.Nombre_Area;
                }
                return Nombre_Area;
            }
        }

        public List<AreasViews> MostrarAreaPorNombre(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreas
                             where c.Nombre_Area == value
                             select new AreasViews()
                             {
                                 id_Area = c.id_Area,
                                 Nombre_Area = c.Nombre_Area                                 
                             }).ToList();
                return query;
            }
        }

        public bool GuardarAreas(tblAreas bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblAreas.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public bool ModificarAreas(tblAreas bat)
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
        public List<AreasViews> MostrarAreasPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreas
                             where c.id_Area == value
                             select new AreasViews()
                             {
                                 id_Area = c.id_Area,
                                 Nombre_Area = c.Nombre_Area,
                                 Estado = c.Estado,
                             }).ToList();
                return query;
            }
        }

        public List<AreasViews> AreasParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreas
                             orderby c.id_Area ascending
                             select new AreasViews()
                             {
                                 id_Area = c.id_Area,
                                 Nombre_Area = c.Nombre_Area,
                                 Estado = c.Estado,
                             }).ToList();
                return query;
            }
        }

    }
}
