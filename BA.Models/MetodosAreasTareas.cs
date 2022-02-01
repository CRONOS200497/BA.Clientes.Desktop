using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosAreasTareas
    {
        public List<AreasTareasViews> MostrarAreasTareas()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.Estado == true
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Area = c.Area,
                                 Tipo_Tarea = c.Tipo_Tarea,
                                 Tarea = c.Tarea,
                                 Dias = c.Dias,
                             }).ToList();
                return query;
            }
        }

        public string MostrarNombreAreaTarea(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.id == value
                             select new AreasTareasViews()
                             {
                                 Area = c.Area,
                             }).ToList();

                string Nombre_Area = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Area = g.Area;
                }
                return Nombre_Area;
            }
        }

        public string MostrarNombreTipoTareaPorArea(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.id == value
                             select new AreasTareasViews()
                             {
                                 Tipo_Tarea = c.Tipo_Tarea,
                             }).ToList();

                string Nombre_Tipo_Tarea = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Tarea = g.Tipo_Tarea;
                }
                return Nombre_Tipo_Tarea;
            }
        }

        public string MostrarNombreTareaporTipoTarea(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.id == value
                             select new AreasTareasViews()
                             {
                                 Tarea = c.Tarea,
                             }).ToList();

                string Nombre_Tarea = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tarea = g.Tarea;
                }
                return Nombre_Tarea;
            }
        }

        public List<AreasTareasViews> MostrarsAreasTareasPorNombre(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.Area == value
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Area = c.Area,
                                 Tipo_Tarea = c.Tipo_Tarea,
                                 Tarea = c.Tarea,
                                 Dias = c.Dias,
                             }).ToList();
                return query;
            }
        }

        public int ValidarTiempoTarea(int id_Tarea)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.id == id_Tarea
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Area = c.Area,
                                 Tipo_Tarea = c.Tipo_Tarea,
                                 Tarea = c.Tarea,
                                 Dias = c.Dias,
                             }).ToList();
                int Dias_Tarea = 0;
                foreach (var d in query)
                {
                    Dias_Tarea = d.Dias;
                }
                return Dias_Tarea;
            }
        }

        public bool GuardarAreasTareas(tblAreasTareas bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblAreasTareas.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public bool ModificarAreasTareas(tblAreasTareas bat)
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

        public List<AreasTareasViews> MostrarAreasTareasPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.id == value
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Area = c.Area,
                                 Tipo_Tarea = c.Tipo_Tarea,
                                 Tarea = c.Tarea,
                                 Dias = c.Dias,
                             }).ToList();
                return query;
            }
        }

        public List<AreasTareasViews> MostrarAreasTareasPorArea(string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.Area == Area
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Tipo_Tarea = c.Tipo_Tarea
                             }).ToList();
                return query;
            }
        }

        public List<AreasTareasViews> MostrarAreasTareasPorTipoTarea(string Tipo_Tarea)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.Tipo_Tarea == Tipo_Tarea
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Tarea = c.Tarea
                             }).ToList();
                return query;
            }
        }

        public List<AreasTareasViews> MostrarAreasTareasPorTipoTareaSeguimiento(string Area, string Tipo_Tarea, string Tarea)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.Area == Area                            
                             where c.Tipo_Tarea == Tipo_Tarea
                             where c.Tarea == Tarea
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Tarea = c.Tarea
                             }).ToList();
                return query;
            }
        }

        public List<AreasTareasViews> MostrarAreasTareasPorTipoTareaSeguimiento(string Area, string Tipo_Tarea)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             where c.Area == Area
                             where c.Tipo_Tarea == Tipo_Tarea
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Tipo_Tarea = c.Tipo_Tarea
                             }).ToList();
                return query;
            }
        }

        public List<AreasTareasViews> AreasTareasParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAreasTareas
                             orderby c.id ascending
                             select new AreasTareasViews()
                             {
                                 id = c.id,
                                 Area = c.Area,
                                 Tipo_Tarea = c.Tipo_Tarea,
                                 Tarea = c.Tarea,
                                 Dias = c.Dias,
                             }).ToList();
                return query;
            }
        }
    }
}
