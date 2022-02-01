using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosRegistrarSeguimientoTarea
    {
        public List<RegistrarSeguimientoViews> MostrarTodasLasTareas(int Id_Solicitud)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarSeguimiento
                             where d.id_Solicitud == Id_Solicitud
                             orderby d.Fecha_Seguimiento ascending
                             select new RegistrarSeguimientoViews()
                             {
                                 id_Seguimiento = d.id_Seguimiento,
                                 id_Solicitud = d.id_Solicitud,
                                 Descripcion = d.Descripcion,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Estado = d.Estado,
                                 Fecha_Seguimiento = d.Fecha_Seguimiento,
                                 Usuario_Seguimiento = d.Usuario_Seguimiento 
                             }).ToList();
                return query;
            }
        }
        public string AbrirDocumentoCliente(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblRegistrarSeguimiento
                             where c.id_Seguimiento == id_Archivo
                             select new RegistrarTareasViews()
                             {
                                 Ruta = c.Ruta
                             }).ToList();
                string Ruta_Archivo = string.Empty;
                foreach (var g in query)
                {
                    Ruta_Archivo = g.Ruta;
                }
                return Ruta_Archivo;
            }
        }

        public bool AgregarSeguimientoTarea(tblRegistrarSeguimiento doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblRegistrarSeguimiento.Add(doc);
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
