using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosEstadoTarea
    {
        public List<EstadoTareaViews> MostrarEstadoTarea()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosTarea
                             where c.Estado == true
                             select new EstadoTareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Estado = c.Nombre_Estado,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public List<EstadoTareaViews> MostrarEstadoTareaSeguimiento()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosTarea
                             where c.Nombre_Estado != "Registrada"
                             where c.Estado == true
                             select new EstadoTareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Estado = c.Nombre_Estado,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public List<EstadoTareaViews> MostrarEstadoTareaRegistrarTarea()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosTarea
                             where c.Estado == true
                             where c.Nombre_Estado == "Registrada"
                             select new EstadoTareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Estado = c.Nombre_Estado,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public string MostrarNombreEstadoTarea(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosTarea
                             where c.id_Tarea == value
                             select new EstadoTareaViews()
                             {
                                 Nombre_Estado = c.Nombre_Estado,

                             }).ToList();

                string Nombre_Area = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Area = g.Nombre_Estado;
                }
                return Nombre_Area;
            }
        }

        public List<EstadoTareaViews> MostrarEstadoTareaPorNombre(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosTarea
                             where c.Nombre_Estado == value
                             select new EstadoTareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Estado = c.Nombre_Estado
                             }).ToList();
                return query;
            }
        }
        public bool GuardarAreas(tblEstadosTarea bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblEstadosTarea.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public bool ModificarAreas(tblEstadosTarea bat)
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
        public List<EstadoTareaViews> MostrarEstadoTareaPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosTarea
                             where c.id_Tarea == value
                             select new EstadoTareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Estado = c.Nombre_Estado,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public List<EstadoTareaViews> EstadoTareaParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosTarea
                             orderby c.id_Tarea ascending
                             select new EstadoTareaViews()
                             {
                                 id_Tarea = c.id_Tarea,
                                 Nombre_Estado = c.Nombre_Estado,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

    }
}
