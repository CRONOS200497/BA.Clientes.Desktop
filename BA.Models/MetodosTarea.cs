using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosTarea
    {
        public List<TareaViews> MostrarTarea()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTarea
                             where c.Estado == true
                             select new TareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Tarea = c.Nombre_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public string MostrarNombreTarea(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTarea
                             where c.id_Tarea == value
                             select new TareaViews()
                             {
                                 Nombre_Tarea = c.Nombre_Tarea,

                             }).ToList();

                string Nombre_Area = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Area = g.Nombre_Tarea;
                }
                return Nombre_Area;
            }
        }

        public List<TareaViews> MostrarEstadoTarea(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTarea
                             where c.Nombre_Tarea == value
                             select new TareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Tarea = c.Nombre_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }
        public bool GuardarTarea(tblTarea bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblTarea.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public bool ModificarTarea(tblTarea bat)
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
        public List<TareaViews> MostrarTareaPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTarea
                             where c.id_Tarea == value
                             select new TareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Tarea = c.Nombre_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public List<TareaViews> TareaParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTarea
                             orderby c.id_Tarea ascending
                             select new TareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Tarea = c.Nombre_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }
    }
}
