using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosTipoTarea
    {
        public List<TipoTareaViews> MostrarTipoTarea()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoTarea
                             where c.Estado == true
                             select new TipoTareaViews()
                             {
                                 id_Tipo_Tarea = c.id_Tipo_Tarea,
                                 Nombre_Tipo_Tarea = c.Nombre_Tipo_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public string MostrarNombreTipoTarea(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoTarea
                             where c.id_Tipo_Tarea == value
                             select new TipoTareaViews()
                             {
                                 Nombre_Tipo_Tarea = c.Nombre_Tipo_Tarea,

                             }).ToList();

                string Nombre_Area = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Area = g.Nombre_Tipo_Tarea;
                }
                return Nombre_Area;
            }
        }

        public List<TipoTareaViews> MostrarTipoTarea(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoTarea
                             where c.Nombre_Tipo_Tarea == value
                             select new TipoTareaViews()
                             {
                                 id_Tipo_Tarea = c.id_Tipo_Tarea,
                                 Nombre_Tipo_Tarea = c.Nombre_Tipo_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }
        public bool GuardarTipoTarea(tblTipoTarea bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblTipoTarea.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public bool ModificarTipoTarea(tblTipoTarea bat)
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
        public List<TipoTareaViews> MostrarTipoTareaPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoTarea
                             where c.id_Tipo_Tarea == value
                             select new TipoTareaViews()
                             {
                                 id_Tipo_Tarea = c.id_Tipo_Tarea,
                                 Nombre_Tipo_Tarea = c.Nombre_Tipo_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

        public List<TipoTareaViews> TipoTareaParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoTarea
                             orderby c.id_Tipo_Tarea ascending
                             select new TipoTareaViews()
                             {
                                 id_Tipo_Tarea = c.id_Tipo_Tarea,
                                 Nombre_Tipo_Tarea = c.Nombre_Tipo_Tarea,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }
    }
}
