using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;
namespace BA.Models
{
    public class MetodosRegistrarTareas
    {
        public List<RegistrarTareasViews> MostrarTodasLasTareas()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasLiderArea(string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Area_Creadora == Area
                             where d.Estado != "Cerrada"
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }


        public List<RegistrarTareasViews> MostrarTareasPorArea(string Area_Creadora)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Area_Creadora == Area_Creadora
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorResponsable(string Responsable, string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Responsable == Responsable
                             where d.Area_Creadora == Area
                             where d.Estado != "Cerrada"
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorResponsableDiferenteCerrado(string Responsable, string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Responsable == Responsable
                             where d.Area_Creadora == Area
                             where d.Estado != "Cerrada"
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorCreador(string Creador)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Creador == Creador
                             where d.Estado != "Cerrada"
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorFechaAsignado(DateTime FechaInicial, DateTime FechaFinal, string Usuario, string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Fecha_Asignado >= FechaInicial
                             where d.Fecha_Asignado <= FechaFinal
                             where d.Creador == Usuario | d.Responsable == Usuario
                             where d.Area_Creadora == Area
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorFechaAsignadoOtraArea(DateTime FechaInicial, DateTime FechaFinal, string Usuario)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Fecha_Asignado >= FechaInicial
                             where d.Fecha_Asignado <= FechaFinal
                             where d.Creador == Usuario | d.Responsable == Usuario
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorID(int id_Solicitud, string Usuario, string Area)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.id_Solicitud == id_Solicitud
                             where d.Responsable == Usuario | d.Creador == Usuario
                             where d.Area_Creadora == Area
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorIDParaSeguimiento(int id_Solicitud)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.id_Solicitud == id_Solicitud                            
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorIDOtrasAreas(int id_Solicitud, string Usuario)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.id_Solicitud == id_Solicitud
                             where d.Responsable == Usuario | d.Creador == Usuario
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public List<RegistrarTareasViews> MostrarTareasPorEstado(string Usuario, string Area, string Estado)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Responsable == Usuario
                             where d.Area_Creadora == Area
                             where d.Estado == Estado
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }
        public List<RegistrarTareasViews> MostrarTareasHoy(DateTime FechaInicial, DateTime FechaFinal)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRegistrarTareas
                             where d.Fecha_Asignado >= FechaInicial
                             where d.Fecha_Asignado <= FechaFinal
                             orderby d.Fecha_Asignado ascending
                             select new RegistrarTareasViews()
                             {
                                 id_Solicitud = d.id_Solicitud,
                                 id_Tarea = d.id_Tarea,
                                 Creador = d.Creador,
                                 Responsable = d.Responsable,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 Descripcion = d.Descripcion,
                                 Prioridad = d.Prioridad,
                                 Estado = d.Estado,
                                 Adjunto = d.Adjunto,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Notificar_Responsable = d.Notificar_Responsable,
                                 Area_Creadora = d.Area_Creadora,
                                 Fecha_Asignado = d.Fecha_Asignado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                             }).ToList();
                return query;
            }
        }

        public string AbrirDocumentoCliente(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblRegistrarTareas
                             where c.id_Solicitud == id_Archivo
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

        public bool ValidarSiFamiliarExiste(string value_Numero_Documento_Familiar)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblFamilia
                             where d.Numero_Documento == value_Numero_Documento_Familiar
                             select new FamiliaViews()
                             {
                                 Numero_Documento = d.Numero_Documento,
                             }).ToList();

                if (query.Count == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool AgregarTarea(tblRegistrarTareas doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblRegistrarTareas.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarTarea(tblRegistrarTareas doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.Entry(doc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool EliminarTarea(tblRegistrarTareas doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.Entry(doc).State = System.Data.Entity.EntityState.Deleted;
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
