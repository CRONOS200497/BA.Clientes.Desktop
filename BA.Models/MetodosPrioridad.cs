using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
  public class MetodosPrioridad
    {
        public List<PrioridadViews> MostrarPrioridad()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblPrioridad
                             where c.Estado == true
                             select new PrioridadViews()
                             {
                                 id = c.id,
                                 Prioridad = c.Prioridad,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }  

        public string MostrarNombrePrioridad(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblPrioridad
                             where c.id == value
                             select new PrioridadViews()
                             {
                                 Prioridad = c.Prioridad,

                             }).ToList();

                string Nombre_Area = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Area = g.Prioridad;
                }
                return Nombre_Area;
            }
        }

        public List<PrioridadViews> MostrarEstadoPrioridad(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblPrioridad
                             where c.Prioridad == value
                             select new PrioridadViews()
                             {
                                 id = c.id,
                                 Prioridad = c.Prioridad    
                             }).ToList();
                return query;
            }
        }
        public bool GuardarPrioridad(tblPrioridad bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblPrioridad.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public bool ModificarPrioridad(tblPrioridad bat)
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
        public List<PrioridadViews> MostrarPrioridadPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblPrioridad
                             where c.id == value
                             select new PrioridadViews()
                             {
                                 id = c.id,
                                 Prioridad = c.Prioridad,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public List<PrioridadViews> PrioridadParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblPrioridad
                             orderby c.id ascending
                             select new PrioridadViews()
                             {
                                 id = c.id,
                                 Prioridad = c.Prioridad,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }
    }
}
