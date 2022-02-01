using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosDispensarios
    {

        public List<DispensariosViews> MostrarDispensarios(int fuerza)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDispensarios
                             where c.Fuerza == fuerza
                             where c.Estado == true

                             select new DispensariosViews()
                             {
                                 id_Dispensario = c.id_Dispensario,
                                 Nombre_Dispensario = c.Nombre_Dispensario,
                                 Estado = c.Estado
                             }).ToList();

                return query;
            }
        }

        public string MostrarDispensariosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDispensarios
                             where c.id_Dispensario == value
                             select new DispensariosViews()
                             {
                                 Nombre_Dispensario = c.Nombre_Dispensario,
                             }).ToList();

                string Nombre_Dispensarios = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Dispensarios = g.Nombre_Dispensario;
                }

                return Nombre_Dispensarios;
            }
        }

        public List<DispensariosViews> MostrarDispensariosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDispensarios
                             where c.Nombre_Dispensario == value
                             select new DispensariosViews()
                             {
                                 id_Dispensario = c.id_Dispensario,
                                 Nombre_Dispensario = c.Nombre_Dispensario,
                                 Estado = c.Estado,
                             }).ToList();

                return query;
            }
        }

        public int MostrarDispensariosValor2(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDispensarios
                             where c.Nombre_Dispensario == value
                             select new DispensariosViews()
                             {
                                 id_Dispensario = c.id_Dispensario,
                                 Nombre_Dispensario = c.Nombre_Dispensario,
                                 Estado = c.Estado,
                             }).ToList();

                int id_Dispensario = 0;

                foreach (var g in query)
                {
                    id_Dispensario = g.id_Dispensario;
                }
                return id_Dispensario;
            }
        }

        public bool GuardarDispensarios(tblDispensarios bat)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblDispensarios.Add(bat);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }

        public bool ModificarDispensarioss(tblDispensarios bat)
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

        public List<DispensariosViews> MostrarDispensariosPorSeleccion(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDispensarios
                             where c.id_Dispensario == value
                             select new DispensariosViews()
                             {
                                 id_Dispensario = c.id_Dispensario,
                                 Nombre_Dispensario = c.Nombre_Dispensario,
                                 Fuerza = c.Fuerza,
                                 Estado = c.Estado,
                             }).ToList();

                return query;
            }
        }

        public List<DispensariosViews> DispensariosParametrizaciones()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDispensarios
                             orderby c.id_Dispensario ascending
                             select new DispensariosViews()
                             {
                                 id_Dispensario = c.id_Dispensario,
                                 Nombre_Dispensario = c.Nombre_Dispensario,
                                 Fuerza = c.Fuerza,
                                 Estado = c.Estado
                             }).ToList();
                return query;
            }
        }

    }
}
