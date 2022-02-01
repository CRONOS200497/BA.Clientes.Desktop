using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosAudienciasJuzgados
    {
        public List<AudienciasJuzgadoViews> MostrarAudienciaporCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAudienciasJuzgado
                             where d.Doc_Cliente == doc_cliente
                             orderby d.Fecha_Audiencia ascending
                             select new AudienciasJuzgadoViews()
                             {
                                 id_Audiencia_Juzgado = d.id_Audiencia_Juzgado,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 SegundoApellido = d.SegundoApellido,
                                 Numero_Proceso = d.Numero_Proceso,
                                 Juzgado = d.Juzgado,
                                 Fecha_Audiencia = d.Fecha_Audiencia,
                                 Abogado = d.Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Observaciones = d.Observaciones,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Informar_Abogado = d.Informar_Abogado,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario
                             }).ToList();
                return query;
            }
        }

        public string AbrirDocumentoCliente(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblAudienciasJuzgado
                             where c.id_Audiencia_Juzgado == id_Archivo
                             select new AudienciasJuzgadoViews()
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

        public List<AudienciasJuzgadoViews> ConsultarAudienciaPorID(int id_Audiencia)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAudienciasJuzgado
                             where d.id_Audiencia_Juzgado == id_Audiencia
                             select new AudienciasJuzgadoViews()
                             {
                                 id_Audiencia_Juzgado = d.id_Audiencia_Juzgado,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 SegundoApellido = d.SegundoApellido,
                                 Numero_Proceso = d.Numero_Proceso,
                                 Juzgado = d.Juzgado,
                                 Fecha_Audiencia = d.Fecha_Audiencia,
                                 Abogado = d.Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Observaciones = d.Observaciones,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Informar_Abogado = d.Informar_Abogado,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario
                             }).ToList();
                return query;
            }
        }

        public List<AudienciasJuzgadoViews> ConsultartodasLasAudiencias()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAudienciasJuzgado
                             orderby d.Fecha_Audiencia ascending
                             select new AudienciasJuzgadoViews()
                             {
                                 id_Audiencia_Juzgado = d.id_Audiencia_Juzgado,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 SegundoApellido = d.SegundoApellido,
                                 Numero_Proceso = d.Numero_Proceso,
                                 Juzgado = d.Juzgado,
                                 Fecha_Audiencia = d.Fecha_Audiencia,
                                 Abogado = d.Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Observaciones = d.Observaciones,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Informar_Abogado = d.Informar_Abogado,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario
                             }).ToList();
                return query;
            }
        }

        public List<AudienciasJuzgadoViews> ConsultarAudienciasHoy(DateTime ConsultaInicial, DateTime ConsultaFinal)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAudienciasJuzgado
                             where d.Fecha_Audiencia >= ConsultaInicial
                             where d.Fecha_Audiencia <= ConsultaFinal
                             orderby d.Fecha_Audiencia ascending
                             select new AudienciasJuzgadoViews()
                             {
                                 id_Audiencia_Juzgado = d.id_Audiencia_Juzgado,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 SegundoApellido = d.SegundoApellido,
                                 Numero_Proceso = d.Numero_Proceso,
                                 Juzgado = d.Juzgado,
                                 Fecha_Audiencia = d.Fecha_Audiencia,
                                 Abogado = d.Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Observaciones = d.Observaciones,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Informar_Abogado = d.Informar_Abogado,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario
                             }).ToList();
                return query;
            }
        }

        public List<AudienciasJuzgadoViews> ConsultarAudienciasPorMes(DateTime FechaInicial, DateTime FechaFinal)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAudienciasJuzgado
                             where d.Fecha_Audiencia >= FechaInicial
                             where d.Fecha_Audiencia <= FechaFinal
                             orderby d.Fecha_Audiencia ascending
                             select new AudienciasJuzgadoViews()
                             {
                                 id_Audiencia_Juzgado = d.id_Audiencia_Juzgado,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 SegundoApellido = d.SegundoApellido,
                                 Numero_Proceso = d.Numero_Proceso,
                                 Juzgado = d.Juzgado,
                                 Fecha_Audiencia = d.Fecha_Audiencia,
                                 Abogado = d.Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Observaciones = d.Observaciones,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Informar_Abogado = d.Informar_Abogado,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario
                             }).ToList();
                return query;
            }
        }

        public List<AudienciasJuzgadoViews> ConsultarAudienciasPorFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblAudienciasJuzgado
                             where d.Fecha_Audiencia >= FechaInicial
                             where d.Fecha_Audiencia <= FechaFinal
                             orderby d.Fecha_Audiencia ascending
                             select new AudienciasJuzgadoViews()
                             {
                                 id_Audiencia_Juzgado = d.id_Audiencia_Juzgado,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 SegundoApellido = d.SegundoApellido,
                                 Numero_Proceso = d.Numero_Proceso,
                                 Juzgado = d.Juzgado,
                                 Fecha_Audiencia = d.Fecha_Audiencia,
                                 Abogado = d.Abogado,
                                 Correo_Abogado = d.Correo_Abogado,
                                 Observaciones = d.Observaciones,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Ruta = d.Ruta,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Informar_Abogado = d.Informar_Abogado,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario
                             }).ToList();
                return query;
            }
        }


        public bool AgregarAudiencia(tblAudienciasJuzgado doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblAudienciasJuzgado.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarAudiencia(tblAudienciasJuzgado doc)
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

        public bool EliminarAudiencia(tblAudienciasJuzgado doc)
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
