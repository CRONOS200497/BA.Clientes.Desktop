using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class Metodos
    {
        public bool EliminarTelefonoFamilia(tblTelefonosFamilia doc)
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

        public List<TelefonosFamiliaViews> ConsultarTelefonoFamiliaPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblTelefonosFamilia
                             where d.id_Telefono == id_novedad
                             select new TelefonosFamiliaViews()
                             {
                                 id_Telefono = d.id_Telefono,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Numero_Telefono = d.Numero_Telefono,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<TelefonosFamiliaViews> ConsultarTelefonosPorFamiliar(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblTelefonosFamilia
                             where d.Doc_Familiar == doc_cliente
                             select new TelefonosFamiliaViews()
                             {
                                 id_Telefono = d.id_Telefono,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Numero_Telefono = d.Numero_Telefono,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarTelefonoFamilia(tblTelefonosFamilia doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblTelefonosFamilia.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarTelefonoFamilia(tblTelefonosFamilia doc)
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

        public bool EliminarCorreoFamilia(tblCorreosFamilia doc)
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

        public List<CorreosFamiliaViews> ConsultarCorreoPorIdFamiliar(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCorreosFamilia
                             where d.id_Correo == id_novedad
                             select new CorreosFamiliaViews()
                             {
                                 id_Correo = d.id_Correo,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Correo = d.Correo,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<CorreosFamiliaViews> ConsultarCorreosPorFamilia(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCorreosFamilia
                             where d.Doc_Familiar == doc_cliente
                             select new CorreosFamiliaViews()
                             {
                                 id_Correo = d.id_Correo,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Correo = d.Correo,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarCorreoFamilia(tblCorreosFamilia doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblCorreosFamilia.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarCorreoFamilia(tblCorreosFamilia doc)
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































        public bool EliminarTelefono(tblTelefonosClientes doc)
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

        public List<TelefonosClientesViews> ConsultarTelefonoPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblTelefonosClientes
                             where d.id_Telefono == id_novedad
                             select new TelefonosClientesViews()
                             {
                                 id_Telefono = d.id_Telefono,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Numero_Telefono = d.Numero_Telefono,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<TelefonosClientesViews> ConsultarTelefonosPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblTelefonosClientes
                             where d.Doc_Cliente == doc_cliente
                             select new TelefonosClientesViews()
                             {
                                 id_Telefono = d.id_Telefono,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Numero_Telefono = d.Numero_Telefono,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarTelefono(tblTelefonosClientes doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblTelefonosClientes.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarTelefono(tblTelefonosClientes doc)
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

        public bool EliminarCorreo(tblCorreosClientes doc)
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

        public List<CorreosClientesViews> ConsultarCorreoPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCorreosClientes
                             where d.id_Correo == id_novedad
                             select new CorreosClientesViews()
                             {
                                 id_Correo = d.id_Correo,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Correo = d.Correo,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<CorreosClientesViews> ConsultarCorreosPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCorreosClientes
                             where d.Doc_Cliente == doc_cliente
                             select new CorreosClientesViews()
                             {
                                 id_Correo = d.id_Correo,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Correo = d.Correo,
                                 Fecha_Insertado = d.Fecha_Insertado,
                                 Fecha_Actualizado = d.Fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarCorreo(tblCorreosClientes doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblCorreosClientes.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarCorreo(tblCorreosClientes doc)
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






























        public string AbrirAdjuntoCartera(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblCartera
                             where c.id_Cartera == id_Archivo
                             select new CarteraViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();

                string Ruta_Adjunto_Cartera = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Adjunto_Cartera = g.Ruta;
                }
                return Ruta_Adjunto_Cartera;
            }
        }

        public bool EliminarCartera(tblCartera doc)
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

        public bool ConsultarEstadoDocumento(int id_doc)
        {

            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCartera
                             where d.id_Cartera == id_doc
                             select new CarteraViews()
                             {
                                 Documento_Activo = d.Documento_Activo,
                             }).ToList();

                bool Documento_Activo = false;
                foreach (var d in query)
                {
                    Documento_Activo = d.Documento_Activo;
                }

                if (Documento_Activo == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<CarteraViews> ConsultarCarterapPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCartera
                             where d.id_Cartera == id_novedad
                             select new CarteraViews()
                             {
                                 id_Cartera = d.id_Cartera,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Sobre = d.Sobre,
                                 Titulo_Valor = d.Titulo_Valor,
                                 Descripcion = d.Descripcion,
                                 Fecha = d.Fecha,
                                 Valor = d.Valor,
                                 Documento_Activo = d.Documento_Activo,
                                 Suma_Total = d.Suma_Total,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Estado_Cuenta = d.Estado_Cuenta,
                                 Fecha_Subido = d.Fecha_Subido,
                                 fecha_Actualizado = d.fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<CarteraViews> ConsultarCarteraPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCartera
                             where d.Doc_Cliente == doc_cliente
                             orderby d.fecha_Actualizado descending
                             select new CarteraViews()
                             {
                                 id_Cartera = d.id_Cartera,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Sobre = d.Sobre,
                                 Titulo_Valor = d.Titulo_Valor,
                                 Descripcion = d.Descripcion,
                                 Fecha = d.Fecha,
                                 Valor = d.Valor,
                                 Documento_Activo = d.Documento_Activo,
                                 Suma_Total = d.Suma_Total,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Estado_Cuenta = d.Estado_Cuenta,
                                 Fecha_Subido = d.Fecha_Subido,
                                 fecha_Actualizado = d.fecha_Actualizado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarCartera(tblCartera doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblCartera.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarCartera(tblCartera doc)
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

        public List<EstadosCuentaViews> MostrarTiposEstadosCuentas()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblEstadosCuentas
                             where d.estado == true
                             select new EstadosCuentaViews()
                             {
                                 id_Estado_Cartera = d.id_Estado_Cartera,
                                 Nombre_Estado_Cartera = d.Nombre_Estado_Cartera,
                                 estado = d.estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTiposEstadosCuentasNombre(int value_estado)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosCuentas
                             where d.id_Estado_Cartera == value_estado

                             select new EstadosCuentaViews()
                             {
                                 id_Estado_Cartera = d.id_Estado_Cartera,
                                 Nombre_Estado_Cartera = d.Nombre_Estado_Cartera,
                                 estado = d.estado,
                             }).ToList();

                string Nombre_Estado_Cartera = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Estado_Cartera = g.Nombre_Estado_Cartera;
                }

                return Nombre_Estado_Cartera;
            }
        }

        public int MostrarTiposEstadosCuentasValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosCuentas
                             where d.Nombre_Estado_Cartera == value
                             select new EstadosCuentaViews()
                             {
                                 id_Estado_Cartera = d.id_Estado_Cartera,
                                 Nombre_Estado_Cartera = d.Nombre_Estado_Cartera,
                                 estado = d.estado,
                             }).ToList();

                int id_Estado_Cartera = 0;

                foreach (var g in query)
                {
                    id_Estado_Cartera = g.id_Estado_Cartera;
                }
                return id_Estado_Cartera;
            }
        }

        public List<TitulosValoresViews> MostrarTiposTitulosValores()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblTitulosValores
                             select new TitulosValoresViews()
                             {
                                 id_Titulos_Valores = d.id_Titulos_Valores,
                                 Nombre_Titulo_Valor = d.Nombre_Titulo_Valor,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTiposTitulosValoresNombre(int value_estado)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblTitulosValores
                             where d.id_Titulos_Valores == value_estado

                             select new TitulosValoresViews()
                             {
                                 id_Titulos_Valores = d.id_Titulos_Valores,
                                 Nombre_Titulo_Valor = d.Nombre_Titulo_Valor,

                             }).ToList();

                string Nombre_Titulo_Valor = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Titulo_Valor = g.Nombre_Titulo_Valor;
                }
                return Nombre_Titulo_Valor;
            }
        }

        public int MostrarTiposTitulosValoresValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblTitulosValores
                             where d.Nombre_Titulo_Valor == value
                             select new TitulosValoresViews()
                             {
                                 id_Titulos_Valores = d.id_Titulos_Valores,
                                 Nombre_Titulo_Valor = d.Nombre_Titulo_Valor,

                             }).ToList();
                int id_Titulos_Valores = 0;
                foreach (var g in query)
                {
                    id_Titulos_Valores = g.id_Titulos_Valores;
                }
                return id_Titulos_Valores;
            }
        }

        public List<EstadosFichasMedicasViews> MostrarTiposEstadosFichasMedicas(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblEstadosFichasMedicas
                             where d.Estado == true
                             where d.Fuerza == value
                             select new EstadosFichasMedicasViews()
                             {
                                 id_Estado_Ficha_Medica = d.id_Estado_Ficha_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Fuerza = d.Fuerza,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTiposEstadosFichasMedicasNombre(int value_estado, int value_fuerza)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosFichasMedicas
                             where d.id_Estado_Ficha_Medica == value_estado
                             where d.Fuerza == value_fuerza
                             select new EstadosFichasMedicasViews()
                             {
                                 id_Estado_Ficha_Medica = d.id_Estado_Ficha_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Fuerza = d.Fuerza,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Tipo_Estado_Ficha_Medicas = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Estado_Ficha_Medicas = g.Nombre_Estado;
                }

                return Nombre_Tipo_Estado_Ficha_Medicas;
            }
        }

        public int MostrarTiposEstadosFichasMedicasValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosFichasMedicas
                             where d.Nombre_Estado == value
                             select new EstadosFichasMedicasViews()
                             {
                                 id_Estado_Ficha_Medica = d.id_Estado_Ficha_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Fuerza = d.Fuerza,
                                 Estado = d.Estado,
                             }).ToList();

                int id_Tipo_Estado_Ficha_Medica = 0;

                foreach (var g in query)
                {
                    id_Tipo_Estado_Ficha_Medica = g.id_Estado_Ficha_Medica;
                }
                return id_Tipo_Estado_Ficha_Medica;
            }
        }

        public List<EstadosJuntasMedicasViews> MostrarTiposEstadosJuntasMedicas(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblEstadosJuntasMedicas
                             where d.Estado == true
                             where d.Fuerza == value
                             select new EstadosJuntasMedicasViews()
                             {
                                 id_Estado_Junta_Medica = d.id_Estado_Junta_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Fuerza = d.Fuerza,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTiposEstadosJuntasMedicasNombre(int value_Junta_Medica, int value_Fuerza)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosJuntasMedicas
                             where d.id_Estado_Junta_Medica == value_Junta_Medica
                             where d.Fuerza == value_Fuerza
                             select new EstadosJuntasMedicasViews()
                             {
                                 id_Estado_Junta_Medica = d.id_Estado_Junta_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Fuerza = d.Fuerza,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Tipo_Estado_Juntas_Medicas = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Estado_Juntas_Medicas = g.Nombre_Estado;
                }

                return Nombre_Tipo_Estado_Juntas_Medicas;
            }
        }

        public int MostrarTiposEstadosJuntasMedicasValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosJuntasMedicas
                             where d.Nombre_Estado == value
                             select new EstadosJuntasMedicasViews()
                             {
                                 id_Estado_Junta_Medica = d.id_Estado_Junta_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Fuerza = d.Fuerza,
                                 Estado = d.Estado,
                             }).ToList();

                int id_Tipo_Estado_Junta_Medica = 0;

                foreach (var g in query)
                {
                    id_Tipo_Estado_Junta_Medica = g.id_Estado_Junta_Medica;
                }
                return id_Tipo_Estado_Junta_Medica;
            }
        }

        public string AbrirAdjuntoFicha(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFichasMedicas
                             where c.id_Ficha == id_Archivo
                             select new FichasMedicasViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();

                string Ruta_Adjunto_Ficha = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Adjunto_Ficha = g.Ruta;
                }
                return Ruta_Adjunto_Ficha;
            }
        }

        public bool EliminarFichas(tblFichasMedicas doc)
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

        public List<FichasMedicasViews> ConsultarFichaPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblFichasMedicas
                             where d.id_Ficha == id_novedad
                             select new FichasMedicasViews()
                             {
                                 id_Ficha = d.id_Ficha,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Estado_Ficha_Medica = d.Estado_Ficha_Medica,
                                 Dispensario = d.Dispensario,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Fecha_Salida = d.Fecha_Salida,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<FichasMedicasViews> ConsultarFichasPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblFichasMedicas
                             where d.Doc_Cliente == doc_cliente
                             select new FichasMedicasViews()
                             {
                                 id_Ficha = d.id_Ficha,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Estado_Ficha_Medica = d.Estado_Ficha_Medica,
                                 Dispensario = d.Dispensario,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Fecha_Salida = d.Fecha_Salida,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarFichas(tblFichasMedicas doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblFichasMedicas.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarFichas(tblFichasMedicas doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.Entry(doc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public string AbrirAdjuntoJunta(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblJuntasMedicas
                             where c.id_Junta == id_Archivo
                             select new JuntasMedicasViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();

                string Ruta_Adjunto_Junta = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Adjunto_Junta = g.Ruta;
                }
                return Ruta_Adjunto_Junta;
            }
        }

        public bool EliminarJunta(tblJuntasMedicas doc)
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

        public List<JuntasMedicasViews> ConsultarJuntaPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblJuntasMedicas
                             where d.id_Junta == id_novedad
                             select new JuntasMedicasViews()
                             {
                                 id_Junta = d.id_Junta,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Fecha_Junta = d.Fecha_Junta,
                                 Estado_Junta_Medica = d.Estado_Junta_Medica,
                                 Dispensario = d.Dispensario,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Direccion = d.Direccion,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<JuntasMedicasViews> ConsultarJuntaPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblJuntasMedicas
                             where d.Doc_Cliente == doc_cliente
                             select new JuntasMedicasViews()
                             {
                                 id_Junta = d.id_Junta,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Fecha_Junta = d.Fecha_Junta,
                                 Estado_Junta_Medica = d.Estado_Junta_Medica,
                                 Dispensario = d.Dispensario,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Direccion = d.Direccion,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarJunta(tblJuntasMedicas doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblJuntasMedicas.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool ModificarJunta(tblJuntasMedicas doc)
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
        public List<ConceptosViews> MostrarConceptos()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblConceptos
                             where d.Estado == true
                             select new ConceptosViews()
                             {
                                 id_Concepto = d.id_Concepto,
                                 Nombre_Concepto = d.Nombre_Concepto,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarConceptosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblConceptos
                             where d.id_Concepto == value
                             select new ConceptosViews()
                             {
                                 id_Concepto = d.id_Concepto,
                                 Nombre_Concepto = d.Nombre_Concepto,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Tipo_Concepto = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Concepto = g.Nombre_Concepto;
                }

                return Nombre_Tipo_Concepto;
            }
        }

        public int MostrarConceptosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblConceptos
                             where d.Nombre_Concepto == value
                             select new ConceptosViews()
                             {
                                 id_Concepto = d.id_Concepto,
                                 Nombre_Concepto = d.Nombre_Concepto,
                                 Estado = d.Estado,
                             }).ToList();

                int id_Tipo_Estado_Concepto = 0;

                foreach (var g in query)
                {
                    id_Tipo_Estado_Concepto = g.id_Concepto;
                }
                return id_Tipo_Estado_Concepto;
            }
        }

        public List<EstadosCitasMedicasViews> MostrarTiposEstadosCitasMedicas()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblEstadosCitasMedicas
                             where d.Estado == true
                             select new EstadosCitasMedicasViews()
                             {
                                 id_Estado_Cita_Medica = d.id_Estado_Cita_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTiposEstadosCitasMedicasNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosCitasMedicas
                             where d.id_Estado_Cita_Medica == value
                             select new EstadosCitasMedicasViews()
                             {
                                 id_Estado_Cita_Medica = d.id_Estado_Cita_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Tipo_Estado_Cita_Medicas = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Estado_Cita_Medicas = g.Nombre_Estado;
                }

                return Nombre_Tipo_Estado_Cita_Medicas;
            }
        }

        public int MostrarTiposEstadosCitasMedicasValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosCitasMedicas
                             where d.Nombre_Estado == value
                             select new EstadosCitasMedicasViews()
                             {
                                 id_Estado_Cita_Medica = d.id_Estado_Cita_Medica,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Estado = d.Estado,
                             }).ToList();

                int id_Tipo_Estado_Cita_Medica = 0;

                foreach (var g in query)
                {
                    id_Tipo_Estado_Cita_Medica = g.id_Estado_Cita_Medica;
                }
                return id_Tipo_Estado_Cita_Medica;
            }
        }

        public List<EstadosConceptosViews> MostrarTiposEstadosConceptos()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblEstadosConceptos
                             where d.Estado == true

                             select new EstadosConceptosViews()
                             {
                                 id_Estado_Concepto = d.id_Estado_Concepto,
                                 Nombre_Estado = d.Nombre_Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTiposEstadosConceptosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosConceptos
                             where d.id_Estado_Concepto == value
                             select new EstadosConceptosViews()
                             {
                                 id_Estado_Concepto = d.id_Estado_Concepto,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Tipo_Estado_Concepto = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Estado_Concepto = g.Nombre_Estado;
                }

                return Nombre_Tipo_Estado_Concepto;
            }
        }

        public int MostrarTiposEstadosConceptosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblEstadosConceptos
                             where d.Nombre_Estado == value
                             select new EstadosConceptosViews()
                             {
                                 id_Estado_Concepto = d.id_Estado_Concepto,
                                 Nombre_Estado = d.Nombre_Estado,
                                 Estado = d.Estado,
                             }).ToList();

                int id_Tipo_Estado_Concepto = 0;

                foreach (var g in query)
                {
                    id_Tipo_Estado_Concepto = g.id_Estado_Concepto;
                }
                return id_Tipo_Estado_Concepto;
            }
        }
        public string AbrirAdjuntoCita(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblCitasMedicas
                             where c.id_Cita == id_Archivo
                             select new NovedadesFamiliaViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();

                string Ruta_Adjunto_Cita = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Adjunto_Cita = g.Ruta;
                }
                return Ruta_Adjunto_Cita;
            }
        }

        public bool EliminarCita(tblCitasMedicas doc)
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

        public List<CitasMedicasViews> ConsultarCitapPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCitasMedicas
                             where d.id_Cita == id_novedad
                             select new CitasMedicasViews()
                             {
                                 id_Cita = d.id_Cita,
                                 id_Concepto = d.id_Concepto,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Tipo_Cita = d.Tipo_Cita,
                                 Fecha_Cita = d.Fecha_Cita,
                                 Dispensario = d.Dispensario,
                                 Nombre_Doctor = d.Nombre_Doctor,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Estado_Cita = d.Estado_Cita,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<CitasMedicasViews> ConsultarCitaPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblCitasMedicas
                             where d.Doc_Cliente == doc_cliente
                             select new CitasMedicasViews()
                             {
                                 id_Cita = d.id_Cita,
                                 id_Concepto = d.id_Concepto,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Tipo_Cita = d.Tipo_Cita,
                                 Fecha_Cita = d.Fecha_Cita,
                                 Dispensario = d.Dispensario,
                                 Nombre_Doctor = d.Nombre_Doctor,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Estado_Cita = d.Estado_Cita,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarCita(tblCitasMedicas doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblCitasMedicas.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarCita(tblCitasMedicas doc)
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

        public string AbrirAdjuntoConcepto(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblConceptosMedicos
                             where c.id_Concepto == id_Archivo
                             select new NovedadesFamiliaViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();

                string Ruta_Adjunto_Concepto = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Adjunto_Concepto = g.Ruta;
                }
                return Ruta_Adjunto_Concepto;
            }
        }

        public bool EliminarConcepto(tblConceptosMedicos doc)
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

        public List<ConceptosMedicosViews> ConsultarConceptopPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblConceptosMedicos
                             where d.id_Concepto == id_novedad
                             select new ConceptosMedicosViews()
                             {
                                 id_Concepto = d.id_Concepto,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Tipo_Concepto = d.Tipo_Concepto,
                                 Fecha_Emision = d.Fecha_Emision,
                                 Dispensario = d.Dispensario,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Estado_Concepto = d.Estado_Concepto,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<ConceptosMedicosViews> ConsultarConceptoPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblConceptosMedicos
                             where d.Doc_Cliente == doc_cliente
                             select new ConceptosMedicosViews()
                             {
                                 id_Concepto = d.id_Concepto,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Fuerza = d.Fuerza,
                                 Tipo_Concepto = d.Tipo_Concepto,
                                 Fecha_Emision = d.Fecha_Emision,
                                 Dispensario = d.Dispensario,
                                 Departamento = d.Departamento,
                                 Ciudad = d.Ciudad,
                                 Otro_Lugar = d.Otro_Lugar,
                                 Adjuntar_Documento = d.Adjuntar_Documento,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Estado_Concepto = d.Estado_Concepto,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Observaciones = d.Observaciones,
                                 Fecha_Cargado = d.Fecha_Cargado,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public List<ConceptosMedicosViews> ConsultarConceptoParaAsignarCita(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblConceptosMedicos
                             where d.Doc_Cliente == doc_cliente
                             select new ConceptosMedicosViews()
                             {
                                 id_Concepto = d.id_Concepto,
                                 Tipo_Concepto = d.Tipo_Concepto,
                             }).ToList();

                return query;
            }
        }


        public bool GuardarConcepto(tblConceptosMedicos doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblConceptosMedicos.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarConcepto(tblConceptosMedicos doc)
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

        public string AbrirAdjuntoSeguimientoFamiliar(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblSeguimientoFamiliar
                             where c.ID_Seguimiento == id_Archivo
                             select new NovedadesFamiliaViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();
                string Ruta_Adjunto_Seguimiento = string.Empty;
                foreach (var g in query)
                {
                    Ruta_Adjunto_Seguimiento = g.Ruta;
                }
                return Ruta_Adjunto_Seguimiento;
            }
        }

        public bool EliminarSeguimientoFamiliar(tblSeguimientoFamiliar doc)
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

        public List<SeguimientoFamiliarViews> ConsultarSeguimientoPorIdFamiliar(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblSeguimientoFamiliar
                             where d.ID_Seguimiento == id_novedad
                             select new SeguimientoFamiliarViews()
                             {
                                 ID_Seguimiento = d.ID_Seguimiento,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Tipo_Seguimiento = d.Tipo_Seguimiento,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Seguimiento = d.Fecha_Seguimiento,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<SeguimientoFamiliarViews> ConsultarSeguimientoPorFamiliar(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblSeguimientoFamiliar
                             where d.Doc_Familiar == doc_cliente
                             select new SeguimientoFamiliarViews()
                             {
                                 ID_Seguimiento = d.ID_Seguimiento,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Tipo_Seguimiento = d.Tipo_Seguimiento,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Seguimiento = d.Fecha_Seguimiento,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarSeguimientoFamiliar(tblSeguimientoFamiliar doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblSeguimientoFamiliar.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool ModificarSeguimientoFamiliar(tblSeguimientoFamiliar doc)
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

        public string AbrirAdjuntoNovedad(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblNovedades
                             where c.Id_Novedad == id_Archivo
                             select new NovedadesViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();

                string Ruta_Adjunto_Novedad = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Adjunto_Novedad = g.Ruta;
                }

                return Ruta_Adjunto_Novedad;

            }
        }

        public bool EliminarNovedades(tblNovedades doc)
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

        public List<NovedadesViews> ConsultarNovedadPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblNovedades
                             where d.Id_Novedad == id_novedad
                             select new NovedadesViews()
                             {
                                 Id_Novedad = d.Id_Novedad,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Tipo_Novedad = d.Tipo_Novedad,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<NovedadesViews> ConsultarNovedadesPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblNovedades
                             where d.Doc_Cliente == doc_cliente
                             select new NovedadesViews()
                             {
                                 Id_Novedad = d.Id_Novedad,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Tipo_Novedad = d.Tipo_Novedad,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarNovedad(tblNovedades doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblNovedades.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarNovedad(tblNovedades doc)
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

        public string AbrirAdjuntoNovedadFamiliar(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblNovedadesFamilia
                             where c.Id_Novedad == id_Archivo
                             select new NovedadesFamiliaViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();
                string Ruta_Adjunto_Novedad = string.Empty;
                foreach (var g in query)
                {
                    Ruta_Adjunto_Novedad = g.Ruta;
                }
                return Ruta_Adjunto_Novedad;
            }
        }

        public bool EliminarNovedadesFamiliar(tblNovedadesFamilia doc)
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

        public List<NovedadesFamiliaViews> ConsultarNovedadPorIdFamiliar(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblNovedadesFamilia
                             where d.Id_Novedad == id_novedad
                             select new NovedadesFamiliaViews()
                             {
                                 Id_Novedad = d.Id_Novedad,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Tipo_Novedad = d.Tipo_Novedad,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();

                return query;
            }
        }

        public List<NovedadesFamiliaViews> ConsultarNovedadesPorFamiliar(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblNovedadesFamilia
                             where d.Doc_Familiar == doc_cliente
                             select new NovedadesFamiliaViews()
                             {
                                 Id_Novedad = d.Id_Novedad,
                                 Doc_Familiar = d.Doc_Familiar,
                                 Tipo_Novedad = d.Tipo_Novedad,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Subido = d.Fecha_Subido,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarNovedadFamiliar(tblNovedadesFamilia doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblNovedadesFamilia.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarNovedadFamiliar(tblNovedadesFamilia doc)
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

        public string AbrirAdjuntoSeguimiento(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblSeguimientoCliente
                             where c.ID_Seguimiento == id_Archivo
                             select new NovedadesViews()
                             {
                                 Ruta = c.Ruta

                             }).ToList();

                string Ruta_Adjunto_Seguimiento = string.Empty;
                foreach (var g in query)
                {
                    Ruta_Adjunto_Seguimiento = g.Ruta;
                }
                return Ruta_Adjunto_Seguimiento;
            }
        }

        public bool EliminarSeguimiento(tblSeguimientoCliente doc)
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

        public List<SeguimientoClienteViews> ConsultarSeguimientoPorId(int id_novedad)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblSeguimientoCliente
                             where d.ID_Seguimiento == id_novedad
                             select new SeguimientoClienteViews()
                             {
                                 ID_Seguimiento = d.ID_Seguimiento,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Tipo_Seguimiento = d.Tipo_Seguimiento,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Seguimiento = d.Fecha_Seguimiento,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public List<SeguimientoClienteViews> ConsultarSeguimientoPorCliente(string doc_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblSeguimientoCliente
                             where d.Doc_Cliente == doc_cliente
                             select new SeguimientoClienteViews()
                             {
                                 ID_Seguimiento = d.ID_Seguimiento,
                                 Doc_Cliente = d.Doc_Cliente,
                                 Tipo_Seguimiento = d.Tipo_Seguimiento,
                                 Descripcion = d.Descripcion,
                                 Adjuntar_Archivo = d.Adjuntar_Archivo,
                                 Nombre_Archivo = d.Nombre_Archivo,
                                 Ruta = d.Ruta,
                                 Informar_Cliente = d.Informar_Cliente,
                                 Fecha_Seguimiento = d.Fecha_Seguimiento,
                                 Fecha_Modificado = d.Fecha_Modificado,
                                 Usuario = d.Usuario,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarSeguimiento(tblSeguimientoCliente doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblSeguimientoCliente.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarSeguimiento(tblSeguimientoCliente doc)
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

        public List<TiposNovedadesViews> MostrarTiposNovedades()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosNovedades
                             where d.estado == true
                             select new TiposNovedadesViews()
                             {
                                 id_Documento_Novedad = d.id_Documento_Novedad,
                                 Nombre_Documento_Novedad = d.Nombre_Documento_Novedad,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTiposNovedadesNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblDocumentosNovedades
                             where d.id_Documento_Novedad == value
                             select new TiposNovedadesViews()
                             {
                                 id_Documento_Novedad = d.id_Documento_Novedad,
                                 Nombre_Documento_Novedad = d.Nombre_Documento_Novedad,
                             }).ToList();

                string Nombre_Tipo_Novedad = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Novedad = g.Nombre_Documento_Novedad;
                }

                return Nombre_Tipo_Novedad;
            }
        }

        public int MostrarTiposNovedadesValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblDocumentosNovedades
                             where d.Nombre_Documento_Novedad == value
                             select new TiposNovedadesViews()
                             {
                                 id_Documento_Novedad = d.id_Documento_Novedad,
                                 Nombre_Documento_Novedad = d.Nombre_Documento_Novedad,
                             }).ToList();

                int id_Tipo_Novedad = 0;

                foreach (var g in query)
                {
                    id_Tipo_Novedad = g.id_Documento_Novedad;
                }
                return id_Tipo_Novedad;
            }
        }

        public List<TiposSeguimientosViews> MostrarTiposSeguimientos()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblTiposSeguimientos
                             select new TiposSeguimientosViews()
                             {
                                 Id_Tipo_Seguimiento = d.Id_Tipo_Seguimiento,
                                 Nombre_Tipo_Seguimiento = d.Nombre_Tipo_Seguimiento,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTipoSeguimientosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblTiposSeguimientos
                             where d.Id_Tipo_Seguimiento == value
                             select new TiposSeguimientosViews()
                             {
                                 Id_Tipo_Seguimiento = d.Id_Tipo_Seguimiento,
                                 Nombre_Tipo_Seguimiento = d.Nombre_Tipo_Seguimiento,
                             }).ToList();

                string Nombre_Tipo_Seguimiento = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Tipo_Seguimiento = g.Nombre_Tipo_Seguimiento;
                }

                return Nombre_Tipo_Seguimiento;
            }
        }

        public int MostrarTipoSeguimientosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblTiposSeguimientos
                             where d.Nombre_Tipo_Seguimiento == value
                             select new TiposSeguimientosViews()
                             {
                                 Id_Tipo_Seguimiento = d.Id_Tipo_Seguimiento,
                                 Nombre_Tipo_Seguimiento = d.Nombre_Tipo_Seguimiento,
                             }).ToList();

                int id_Tipo_Seguimiento = 0;

                foreach (var g in query)
                {
                    id_Tipo_Seguimiento = g.Id_Tipo_Seguimiento;
                }
                return id_Tipo_Seguimiento;
            }
        }

        public List<RolesViews> ConsultarRolesPorPerfil(int Id_Perfil, string Nombre_Formulario)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblRoles
                             where d.Id_Perfil == Id_Perfil
                             where d.Nombre_Rol == Nombre_Formulario
                             where d.Estado_Rol == true
                             select new RolesViews()
                             {
                                 Id_Perfil = d.Id_Rol,
                                 Nombre_Rol = d.Nombre_Rol,
                                 Id_Rol = d.Id_Rol,
                                 Estado_Rol = d.Estado_Rol,
                             }).ToList();

                return query;

            }
        }
        public int ConsultarIDPerfil(string Perfil_Por_Usuario)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblPerfiles
                             where d.Nombre_Perfil == Perfil_Por_Usuario
                             select new PerfilesViews()
                             {
                                 id_perfil = d.id_perfil,
                             }).ToList();

                int id_perfil = 0;

                foreach (var g in query)
                {
                    id_perfil = g.id_perfil;
                }
                return id_perfil;
            }
        }


        public List<UsuariosViews> ConsultarPerfilPorUsuario(string User)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblUsuarios
                             where d.login == User
                             select new UsuariosViews()
                             {
                                 perfil = d.perfil,
                             }).ToList();

                return query;
            }
        }
        public bool Validar_Usuario(string Usuario, string contrasena)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblUsuarios
                             where d.login == Usuario
                             where d.Contrasena == contrasena
                             select new UsuariosViews()
                             {
                                 id_Usuario = d.id_Usuario,
                                 Primer_Nombre = d.Primer_Nombre,
                                 Segundo_Nombre = d.Segundo_Nombre,
                                 Primer_Apellido = d.Primer_Apellido,
                                 Segundo_Apellido = d.Segundo_Apellido,
                                 login = d.login,
                                 Contrasena = d.Contrasena,
                                 Correo = d.Contrasena,
                                 perfil = d.perfil,
                                 fecha_creado = d.fecha_creado,
                                 estado = d.estado,
                             }).ToList();
                string usu = string.Empty;
                string con = string.Empty;

                foreach (var g in query)
                {
                    usu = g.login;
                    con = g.Contrasena;
                }

                if (Usuario == usu)
                {
                    if (contrasena == con)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }

        public List<DocumentosFamiliaresViews> MostrarDocumentosFamiliaValue(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosFamilia
                             where d.Nombre_Documento_Familia == value
                             select new DocumentosFamiliaresViews()
                             {
                                 id_documento_Familia = d.id_documento_Familia,
                                 Nombre_Documento_Familia = d.Nombre_Documento_Familia,
                             }).ToList();
                return query;
            }
        }

        public string MostrarTipoDocumentoFamiliaNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDocumentosFamilia
                             where c.id_documento_Familia == value
                             select new DocumentosFamiliaresViews()
                             {
                                 Nombre_Documento_Familia = c.Nombre_Documento_Familia

                             }).ToList();

                string Nombre_TiposDocumentos = string.Empty;

                foreach (var g in query)
                {
                    Nombre_TiposDocumentos = g.Nombre_Documento_Familia;
                }

                return Nombre_TiposDocumentos;
            }
        }

        public List<DocumentosFamiliaresViews> ConsultarDocumentosFamilia()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosFamilia
                             where d.Estado == true
                             select new DocumentosFamiliaresViews()
                             {
                                 id_documento_Familia = d.id_documento_Familia,
                                 Nombre_Documento_Familia = d.Nombre_Documento_Familia,
                             }).ToList();
                return query;
            }
        }

        public bool GuardarDocumentosFamilia(tblDocumentosCargadosFamilia doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblDocumentosCargadosFamilia.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarDocumentosFamilia(tblDocumentosCargadosFamilia doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                db.Entry(doc).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public List<DocumentosCargadosFamiliaViews> ConsultarDocumentosFamilia(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosCargadosFamilia
                             where d.doc_cliente == value
                             select new DocumentosCargadosFamiliaViews()
                             {
                                 id_Archivo = d.id_Archivo,
                                 doc_cliente = d.doc_cliente,
                                 tipo_doc = d.tipo_doc,
                                 nombre_archivo = d.nombre_archivo,
                                 ruta = d.ruta,
                                 fecha_subido = d.fecha_subido,
                                 fecha_actualizado = d.fecha_actualizado,
                                 informar_cliente = d.informar_cliente,
                                 usuario = d.usuario
                             }).ToList();
                return query;
            }
        }

        public string AbrirDocumentoFamilia(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDocumentosCargadosFamilia
                             where c.id_Archivo == id_Archivo
                             select new DocumentosCargadosFamiliaViews()
                             {
                                 ruta = c.ruta

                             }).ToList();

                string Ruta_Archivo = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Archivo = g.ruta;
                }

                return Ruta_Archivo;

            }
        }

        public List<DocumentosCargadosFamiliaViews> ConsultarDocumentoFamiliaID(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosCargadosFamilia
                             where d.id_Archivo == value
                             select new DocumentosCargadosFamiliaViews()
                             {
                                 id_Archivo = d.id_Archivo,
                                 doc_cliente = d.doc_cliente,
                                 tipo_doc = d.tipo_doc,
                                 nombre_archivo = d.nombre_archivo,
                                 ruta = d.ruta,
                                 fecha_subido = d.fecha_subido,
                                 fecha_actualizado = d.fecha_actualizado,
                                 informar_cliente = d.informar_cliente,
                                 usuario = d.usuario
                             }).ToList();
                return query;
            }
        }


        public string AbrirDocumentoCliente(int id_Archivo)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDocumentosCargados
                             where c.id_Archivo == id_Archivo
                             select new DocumentosCargadosViews()
                             {
                                 ruta = c.ruta

                             }).ToList();

                string Ruta_Archivo = string.Empty;

                foreach (var g in query)
                {
                    Ruta_Archivo = g.ruta;
                }

                return Ruta_Archivo;

            }
        }

        public List<DocumentosClientesViews> MostrarDocumentosClientesValue(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosClientes
                             where d.Nombre_Documento == value
                             select new DocumentosClientesViews()
                             {
                                 id_documento = d.id_documento,
                                 Nombre_Documento = d.Nombre_Documento,
                             }).ToList();
                return query;
            }
        }


        public List<DocumentosClientesViews> ConsultarDocumentosClientes()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosClientes
                             where d.estado == true
                             select new DocumentosClientesViews()
                             {
                                 id_documento = d.id_documento,
                                 Nombre_Documento = d.Nombre_Documento,
                             }).ToList();
                return query;
            }
        }

        public string MostrarParametro(string parametro)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblParametros
                             where c.Nombre_Parametro == parametro
                             select new ParametrosViews()
                             {
                                 Descripcion = c.Descripcion
                             }).ToList();

                string DescripcionParametro = string.Empty;

                foreach (var g in query)
                {
                    DescripcionParametro = g.Descripcion;
                }

                return DescripcionParametro;
            }
        }

        public string MostrarTipoDocumentoClientesNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblDocumentosClientes
                             where c.id_documento == value
                             select new DocumentosClientesViews()
                             {
                                 Nombre_Documento = c.Nombre_Documento

                             }).ToList();

                string Nombre_TiposDocumentos = string.Empty;

                foreach (var g in query)
                {
                    Nombre_TiposDocumentos = g.Nombre_Documento;
                }

                return Nombre_TiposDocumentos;
            }
        }
        public bool EliminarDocumentosClientes(tblDocumentosCargados doc)
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

        public bool EliminarDocumentosFamilia(tblDocumentosCargadosFamilia doc)
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


        public bool GuardarDocumentosClientes(tblDocumentosCargados doc)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblDocumentosCargados.Add(doc);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarDocumentosClientes(tblDocumentosCargados doc)
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

        public List<DocumentosCargadosViews> ConsultarDocumentosClientes(string value)
        {

            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosCargados
                             where d.doc_cliente == value
                             select new DocumentosCargadosViews()
                             {
                                 id_Archivo = d.id_Archivo,
                                 doc_cliente = d.doc_cliente,
                                 tipo_doc = d.tipo_doc,
                                 nombre_archivo = d.nombre_archivo,
                                 ruta = d.ruta,
                                 fecha_subido = d.fecha_subido,
                                 fecha_actualizado = d.fecha_actualizado,
                                 informar_cliente = d.informar_cliente,
                                 usuario = d.usuario
                             }).ToList();
                return query;
            }
        }

        public List<DocumentosCargadosViews> ConsultarDocumentoClienteID(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDocumentosCargados
                             where d.id_Archivo == value
                             select new DocumentosCargadosViews()
                             {
                                 id_Archivo = d.id_Archivo,
                                 doc_cliente = d.doc_cliente,
                                 tipo_doc = d.tipo_doc,
                                 nombre_archivo = d.nombre_archivo,
                                 ruta = d.ruta,
                                 fecha_subido = d.fecha_subido,
                                 fecha_actualizado = d.fecha_actualizado,
                                 informar_cliente = d.informar_cliente,
                                 usuario = d.usuario
                             }).ToList();
                return query;
            }
        }

        public bool Guardar(tblClientes cli)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblClientes.Add(cli);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool GuardarFamiliar(tblFamilia fal)
        {

            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.tblFamilia.Add(fal);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }
            }
        }
        public bool Modificar(tblClientes cli)
        {

            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool ModificarFamiliar(tblFamilia fal)
        {

            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.Entry(fal).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public List<DepartamentosViews> MostarDepartamentos()
        {

            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDepartamentos
                             select new DepartamentosViews()
                             {
                                 id_Departamento = d.id_Departamento,
                                 Nombre_Departamento = d.Nombre_Departamento

                             }).ToList();

                return query;
            }
        }

        public List<CiudadesViews> MostrarCiudades(int id_departamento)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblCiudades
                             join d in db.tblDepartamentos on c.id_Departamento equals d.id_Departamento
                             where c.id_Departamento == id_departamento
                             select new CiudadesViews()
                             {
                                 id_Ciudad = c.id_Ciudad,
                                 Nombre_Ciudad = c.Nombre_Ciudad,
                                 id_Departamento = c.id_Departamento

                             }).ToList();
                return query;
            }
        }

        public bool ValidarSiClienteExiste(string value_Numero_Documento_Cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblClientes
                             where d.Numero_Documento_Cliente == value_Numero_Documento_Cliente
                             select new ClientesViews()
                             {
                                 Numero_Documento_Cliente = d.Numero_Documento_Cliente,


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

        public List<ClientesViews> ConsultarClienteCedula(string value_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblClientes
                             where c.Numero_Documento_Cliente == value_cliente
                             select new ClientesViews()
                             {
                                 id_Cliente = c.id_Cliente,
                                 Primer_Nombre = c.Primer_Nombre,
                                 Segundo_Nombre = c.Segundo_Nombre,
                                 Otro_Nombre = c.Otro_Nombre,
                                 Primer_Apellido = c.Primer_Apellido,
                                 Segundo_Apellido = c.Segundo_Apellido,
                                 Tipo_Documento = c.Tipo_Documento,
                                 Numero_Documento_Cliente = c.Numero_Documento_Cliente,
                                 Departamento_Expedicion = c.Departamento_Expedicion,
                                 Ciudad_Expedicion = c.Ciudad_Expedicion,
                                 Otro_Lugar_Expedicion = c.Otro_Lugar_Expedicion,
                                 Fecha_Nacimiento = c.Fecha_Nacimiento,
                                 Tipo_Registro = c.Tipo_Registro,
                                 Nombre_Lugar_Registro = c.Nombre_Lugar_Registro,
                                 Departamento_Registro = c.Departamento_Registro,
                                 Ciudad_Registro = c.Ciudad_Registro,
                                 Otro_Lugar_Registro = c.Otro_Lugar_Registro,
                                 Telefono_Fijo = c.Telefono_Fijo,
                                 Telefono_Celular = c.Telefono_Celular,
                                 Correo = c.Correo,
                                 Red_Social = c.Red_Social,
                                 Nombre_Red_Social = c.Nombre_Red_Social,
                                 Departamento_Residencia = c.Departamento_Residencia,
                                 Ciudad_Residencia = c.Ciudad_Residencia,
                                 Otro_Lugar_Residencia = c.Otro_Lugar_Residencia,
                                 Casa_Propia = c.Casa_Propia,
                                 Direccion_Residencia = c.Direccion_Residencia,
                                 Barrio = c.Barrio,
                                 Fuerza = c.Fuerza,
                                 Grado = c.Grado,
                                 Fecha_Ingreso = c.Fecha_Ingreso,
                                 Fecha_Salida = c.Fecha_Salida,
                                 Año_Contingente = c.Año_Contingente,
                                 Numero_Contigente = c.Numero_Contigente,
                                 Batallon = c.Batallon,
                                 Fecha_Hechos = c.Fecha_Hechos,
                                 Dispensario = c.Dispensario,
                                 Estado_Proceso = c.Estado_Proceso,
                                 Etapa_Proceso = c.Etapa_Proceso,
                                 Fecha_Autenticado = c.Fecha_Autenticado,
                                 Fecha_Creado = c.Fecha_Creado,
                                 Fecha_Actualizado = c.Fecha_Actualizado,
                                 Usurio = c.Usurio,
                             }).ToList();
                return query;
            }

        }

        public List<ClientesViews> ConsultarClienteAsociarFamilia(string value_cliente)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblClientes
                             where c.Numero_Documento_Cliente == value_cliente
                             select new ClientesViews()
                             {
                                 Numero_Documento_Cliente = c.Numero_Documento_Cliente,
                                 Primer_Nombre = c.Primer_Nombre,
                                 Segundo_Nombre = c.Segundo_Nombre,
                                 Primer_Apellido = c.Primer_Apellido,
                                 Segundo_Apellido = c.Segundo_Apellido,
                                 Fuerza = c.Fuerza,
                                 Fecha_Salida = c.Fecha_Salida,
                             }).ToList();
                return query;
            }
        }

        public string ObtenerCorreo(string documento_Cliente)
        {

            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblClientes
                             where c.Numero_Documento_Cliente == documento_Cliente
                             select new ClientesViews()
                             {
                                 Correo = c.Correo
                             }).ToList();


                string Correo = string.Empty;

                foreach (var g in query)
                {
                    Correo = g.Correo;
                }

                return Correo;
            }
        }



        public List<ClientesViews> ConsultarTodosLosClientes()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblClientes
                             orderby c.id_Cliente ascending
                             select new ClientesViews()
                             {
                                 id_Cliente = c.id_Cliente,
                                 Primer_Nombre = c.Primer_Nombre,
                                 Segundo_Nombre = c.Segundo_Nombre,
                                 Otro_Nombre = c.Otro_Nombre,
                                 Primer_Apellido = c.Primer_Apellido,
                                 Segundo_Apellido = c.Segundo_Apellido,
                                 Tipo_Documento = c.Tipo_Documento,
                                 Numero_Documento_Cliente = c.Numero_Documento_Cliente,
                                 Departamento_Expedicion = c.Departamento_Expedicion,
                                 Ciudad_Expedicion = c.Ciudad_Expedicion,
                                 Otro_Lugar_Expedicion = c.Otro_Lugar_Expedicion,
                                 Fecha_Nacimiento = c.Fecha_Nacimiento,
                                 Tipo_Registro = c.Tipo_Registro,
                                 Nombre_Lugar_Registro = c.Nombre_Lugar_Registro,
                                 Departamento_Registro = c.Departamento_Registro,
                                 Ciudad_Registro = c.Ciudad_Registro,
                                 Otro_Lugar_Registro = c.Otro_Lugar_Registro,
                                 Telefono_Fijo = c.Telefono_Fijo,
                                 Telefono_Celular = c.Telefono_Celular,
                                 Correo = c.Correo,
                                 Red_Social = c.Red_Social,
                                 Nombre_Red_Social = c.Nombre_Red_Social,
                                 Departamento_Residencia = c.Departamento_Residencia,
                                 Ciudad_Residencia = c.Ciudad_Residencia,
                                 Otro_Lugar_Residencia = c.Otro_Lugar_Residencia,
                                 Casa_Propia = c.Casa_Propia,
                                 Direccion_Residencia = c.Direccion_Residencia,
                                 Barrio = c.Barrio,
                                 Fuerza = c.Fuerza,
                                 Grado = c.Grado,
                                 Fecha_Ingreso = c.Fecha_Ingreso,
                                 Fecha_Salida = c.Fecha_Salida,
                                 Año_Contingente = c.Año_Contingente,
                                 Numero_Contigente = c.Numero_Contigente,
                                 Batallon = c.Batallon,
                                 Fecha_Hechos = c.Fecha_Hechos,
                                 Dispensario = c.Dispensario,
                                 Estado_Proceso = c.Estado_Proceso,
                                 Etapa_Proceso = c.Etapa_Proceso,
                                 Fecha_Autenticado = c.Fecha_Autenticado,
                                 Fecha_Creado = c.Fecha_Creado,
                                 Fecha_Actualizado = c.Fecha_Actualizado,
                                 Usurio = c.Usurio,
                             }).ToList();
                return query;
            }
        }

        public List<TipoDocumentosViews> MostrarTipoDocumentos()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoDocumento

                             select new TipoDocumentosViews()
                             {
                                 id_Tipo_Documento = c.id_Tipo_Documento,
                                 Nombre_Tipo_Documento = c.Nombre_Tipo_Documento
                             }).ToList();
                return query;
            }
        }

        public List<TipoRegistroViews> MostrarTipoRegistro()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoRegistro

                             select new TipoRegistroViews()
                             {
                                 id_Tipo_Registro = c.id_Tipo_Registro,
                                 Nombre_Tipo_Registro = c.Nombre_Tipo_Registro
                             }).ToList();
                return query;
            }
        }
        public List<RedesSocialesViews> MostrarRedesSociales()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblRedesSociales

                             select new RedesSocialesViews()
                             {
                                 id_RedSocial = c.id_RedSocial,
                                 Nombre_Red_Social = c.Nombre_Red_Social
                             }).ToList();
                return query;
            }
        }

       

     

     

        public List<GradosViews> MostrarGrados(int value_fuerza)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblGrados
                             where c.id_fuerza == value_fuerza
                             select new GradosViews()
                             {
                                 id_grado = c.id_grado,
                                 Nombre_Rago = c.Nombre_Rago,

                             }).ToList();

                return query;
            }
        }

        public List<EstadosProcesosViews> MostrarEstadosProcesos()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosProcesos
                             select new EstadosProcesosViews()
                             {
                                 id_Estado_Proceso = c.id_Estado_Proceso,
                                 Nombre_Estado_Proceso = c.Nombre_Estado_Proceso,
                                 Cantidad_Dias_Minimos = c.Cantidad_Dias_Minimos,
                                 Cantidad_Dias_Maximos = c.Cantidad_Dias_Maximos
                             }).ToList();

                return query;
            }
        }
        public List<EtapasProcesosViews> MostrarEtapasProcesos()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEtapasProceso
                             select new EtapasProcesosViews()
                             {
                                 id_EtapasProceso = c.id_EtapasProceso,
                                 Nombre_EtapasProceso = c.Nombre_EtapasProceso
                             }).ToList();

                return query;
            }
        }

        //
        public string MostarDepartamentosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDepartamentos
                             where d.id_Departamento == value
                             select new DepartamentosViews()
                             {
                                 id_Departamento = d.id_Departamento,
                                 Nombre_Departamento = d.Nombre_Departamento

                             }).ToList();

                string Nombre_Departamento = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Departamento = g.Nombre_Departamento;
                }


                return Nombre_Departamento;
            }
        }
        public string MostrarCiudadesNombre(int valuedep, int valueciu)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblCiudades
                             where c.id_Departamento == valuedep
                             where c.id_Ciudad == valueciu
                             select new CiudadesViews()
                             {
                                 id_Ciudad = c.id_Ciudad,
                                 Nombre_Ciudad = c.Nombre_Ciudad,
                                 id_Departamento = c.id_Departamento

                             }).ToList();

                string Nombre_Ciudad = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Ciudad = g.Nombre_Ciudad;
                }

                return Nombre_Ciudad;
            }
        }

        public string MostrarTipoDocumentosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoDocumento
                             where c.id_Tipo_Documento == value
                             select new TipoDocumentosViews()
                             {
                                 Nombre_Tipo_Documento = c.Nombre_Tipo_Documento
                             }).ToList();

                string Nombre_TiposDocumentos = string.Empty;

                foreach (var g in query)
                {
                    Nombre_TiposDocumentos = g.Nombre_Tipo_Documento;
                }

                return Nombre_TiposDocumentos;
            }
        }
        public string MostrarTipoRegistroNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoRegistro
                             where c.id_Tipo_Registro == value
                             select new TipoRegistroViews()
                             {
                                 Nombre_Tipo_Registro = c.Nombre_Tipo_Registro
                             }).ToList();

                string Nombre_TiposNombres = string.Empty;

                foreach (var g in query)
                {
                    Nombre_TiposNombres = g.Nombre_Tipo_Registro;
                }

                return Nombre_TiposNombres;
            }
        }

        public string MostrarRedesSociales(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblRedesSociales
                             where c.id_RedSocial == value
                             select new RedesSocialesViews()
                             {
                                 Nombre_Red_Social = c.Nombre_Red_Social
                             }).ToList();

                string Nombre_RedesSociales = string.Empty;

                foreach (var g in query)
                {
                    Nombre_RedesSociales = g.Nombre_Red_Social;
                }

                return Nombre_RedesSociales;
            }
        }

      

      

        public string MostrarGradosNombre(int value_fuerza, int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblGrados
                             where c.id_fuerza == value_fuerza
                             where c.id_grado == value
                             select new GradosViews()
                             {
                                 id_grado = c.id_grado,
                                 Nombre_Rago = c.Nombre_Rago,
                                 id_fuerza = c.id_fuerza
                             }).ToList();
                string Nombre_Grado = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Grado = g.Nombre_Rago;
                }

                return Nombre_Grado;
            }
        }

        public string MostrarEstadosProcesosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosProcesos
                             where c.id_Estado_Proceso == value
                             select new EstadosProcesosViews()
                             {
                                 Nombre_Estado_Proceso = c.Nombre_Estado_Proceso,
                             }).ToList();
                string Nombre_EstadoProcesos = string.Empty;

                foreach (var g in query)
                {
                    Nombre_EstadoProcesos = g.Nombre_Estado_Proceso;
                }

                return Nombre_EstadoProcesos;
            }
        }

        public string MostrarEtapasProcesosNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEtapasProceso
                             where c.id_EtapasProceso == value
                             select new EtapasProcesosViews()
                             {
                                 Nombre_EtapasProceso = c.Nombre_EtapasProceso

                             }).ToList();
                string Nombre_EtapaProcesos = string.Empty;

                foreach (var g in query)
                {
                    Nombre_EtapaProcesos = g.Nombre_EtapasProceso;
                }

                return Nombre_EtapaProcesos;
            }
        }

    

        public List<DepartamentosViews> MostarDepartamentosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDepartamentos
                             where d.Nombre_Departamento == value
                             select new DepartamentosViews()
                             {
                                 id_Departamento = d.id_Departamento,
                                 Nombre_Departamento = d.Nombre_Departamento

                             }).ToList();
                return query;

            }
        }
        public List<CiudadesViews> MostrarCiudadesValor(string value, int ciu)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblCiudades
                             where c.Nombre_Ciudad == value
                             where c.id_Departamento == ciu
                             select new CiudadesViews()
                             {
                                 id_Ciudad = c.id_Ciudad,
                                 Nombre_Ciudad = c.Nombre_Ciudad,
                                 id_Departamento = c.id_Departamento

                             }).ToList();

                return query;

            }
        }

        public int MostrarCiudadesValor2(string value, int ciu)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblCiudades
                             where c.Nombre_Ciudad == value
                             where c.id_Departamento == ciu
                             select new CiudadesViews()
                             {
                                 id_Ciudad = c.id_Ciudad,
                                 Nombre_Ciudad = c.Nombre_Ciudad,
                                 id_Departamento = c.id_Departamento

                             }).ToList();

                int id_Ciudad = 0;

                foreach (var g in query)
                {
                    id_Ciudad = g.id_Ciudad;
                }
                return id_Ciudad;

            }
        }

        public int MostarDepartamentosValorId(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblDepartamentos
                             where d.Nombre_Departamento == value
                             select new DepartamentosViews()
                             {
                                 id_Departamento = d.id_Departamento,
                                 Nombre_Departamento = d.Nombre_Departamento

                             }).ToList();

                int Valor = 0;

                foreach (var d in query)
                {
                    Valor = d.id_Departamento;
                }

                return Valor;
            }
        }

        public List<TipoDocumentosViews> MostrarTipoDocumentosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoDocumento
                             where c.Nombre_Tipo_Documento == value
                             select new TipoDocumentosViews()
                             {
                                 id_Tipo_Documento = c.id_Tipo_Documento,
                                 Nombre_Tipo_Documento = c.Nombre_Tipo_Documento,
                             }).ToList();

                return query;
            }
        }


        public List<TipoRegistroViews> MostrarTipoRegistroValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoRegistro
                             where c.Nombre_Tipo_Registro == value
                             select new TipoRegistroViews()
                             {
                                 id_Tipo_Registro = c.id_Tipo_Registro,
                                 Nombre_Tipo_Registro = c.Nombre_Tipo_Registro
                             }).ToList();

                return query;
            }
        }

        public List<RedesSocialesViews> MostrarRedesSocialesValue(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblRedesSociales
                             where c.Nombre_Red_Social == value
                             select new RedesSocialesViews()
                             {
                                 id_RedSocial = c.id_RedSocial,
                                 Nombre_Red_Social = c.Nombre_Red_Social
                             }).ToList();
                return query;
            }
        }

     

     

       

        public int MostrarFuerzaValor2(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFuerza
                             where c.Nombre_Fuerza == value
                             select new FuerzaViews()
                             {
                                 id_Fuerza = c.id_Fuerza,
                                 Nombre_Fuerza = c.Nombre_Fuerza,
                             }).ToList();

                int id_Fuerza = 0;

                foreach (var g in query)
                {
                    id_Fuerza = g.id_Fuerza;
                }
                return id_Fuerza;


            }
        }



        public List<GradosViews> MostrarGradosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblGrados
                             where c.Nombre_Rago == value
                             select new GradosViews()
                             {
                                 id_grado = c.id_grado,
                                 Nombre_Rago = c.Nombre_Rago,
                                 id_fuerza = c.id_fuerza
                             }).ToList();

                return query;
            }
        }

        public List<EstadosProcesosViews> MostrarEstadosProcesosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEstadosProcesos
                             where c.Nombre_Estado_Proceso == value
                             select new EstadosProcesosViews()
                             {
                                 id_Estado_Proceso = c.id_Estado_Proceso,
                                 Nombre_Estado_Proceso = c.Nombre_Estado_Proceso,
                             }).ToList();

                return query;
            }
        }

        public List<EtapasProcesosViews> MostrarEtapasProcesosValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblEtapasProceso
                             where c.Nombre_EtapasProceso == value
                             select new EtapasProcesosViews()
                             {
                                 id_EtapasProceso = c.id_EtapasProceso,
                                 Nombre_EtapasProceso = c.Nombre_EtapasProceso
                             }).ToList();

                return query;
            }
        }

        public List<TipoFamiliarViews> MostrarTipoFamiliarValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoFamiliar
                             where c.Nombre == value
                             select new TipoFamiliarViews()
                             {
                                 id_Tipo_Familiar = c.id_Tipo_Familiar,
                                 Nombre = c.Nombre
                             }).ToList();

                return query;
            }
        }


        public List<TipoFamiliarViews> MostrarTipoFamiliar()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoFamiliar
                             select new TipoFamiliarViews()
                             {
                                 id_Tipo_Familiar = c.id_Tipo_Familiar,
                                 Nombre = c.Nombre
                             }).ToList();

                return query;

            }
        }
        public string MostrarTipoFamiliarNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblTipoFamiliar
                             where c.id_Tipo_Familiar == value
                             select new TipoFamiliarViews()
                             {
                                 id_Tipo_Familiar = c.id_Tipo_Familiar,
                                 Nombre = c.Nombre
                             }).ToList();

                string Nombre_TipoFamiliar = string.Empty;

                foreach (var g in query)
                {
                    Nombre_TipoFamiliar = g.Nombre;
                }

                return Nombre_TipoFamiliar;
            }
        }

        public List<FamiliaViews> ConsultarTodosLosFamiliares()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFamilia
                             orderby c.id_Familiar ascending
                             select new FamiliaViews()
                             {
                                 id_Familiar = c.id_Familiar,
                                 Numero_Documento_Cliente = c.Numero_Documento_Cliente,
                                 Parentesco = c.Parentesco,
                                 Primer_Nombre = c.Primer_Nombre,
                                 Segundo_Nombre = c.Segundo_Nombre,
                                 Otro_Nombre = c.Otro_Nombre,
                                 Primer_Apellido = c.Primer_Apellido,
                                 Segundo_Apellido = c.Segundo_Apellido,
                                 Tipo_Documento = c.Tipo_Documento,
                                 Numero_Documento = c.Numero_Documento,
                                 Departamento_Expedicion = c.Departamento_Expedicion,
                                 Ciudad_Expedicion = c.Ciudad_Expedicion,
                                 Otro_Lugar_Expedicion = c.Otro_Lugar_Expedicion,
                                 Fecha_Nacimiento = c.Fecha_Nacimiento,
                                 Tipo_Registro = c.Tipo_Registro,
                                 Nombre_Lugar_Registro = c.Nombre_Lugar_Registro,
                                 Departamento_Registro = c.Departamento_Registro,
                                 Ciudad_Registro = c.Ciudad_Registro,
                                 Otro_Lugar_Registro = c.Otro_Lugar_Registro,
                                 Telefono_Fijo = c.Telefono_Fijo,
                                 Telefono_Celular = c.Telefono_Celular,
                                 Correo = c.Correo,
                                 Red_Social = c.Red_Social,
                                 Nombre_Red_Social = c.Nombre_Red_Social,
                                 Departamento_Residencia = c.Departamento_Residencia,
                                 Ciudad_Residencia = c.Ciudad_Residencia,
                                 Otro_Lugar_Residencia = c.Otro_Lugar_Residencia,
                                 Casa_Propia = c.Casa_Propia,
                                 Direccion_Residencia = c.Direccion_Residencia,
                                 Barrio = c.Barrio,
                                 Estado_Proceso = c.Estado_Proceso,
                                 Etapa_Proceso = c.Etapa_Proceso,
                                 Fecha_Autenticacion = c.Fecha_Autenticacion,
                                 Fecha_Creacion = c.Fecha_Creacion,
                                 Fecha_Actualizacion = c.Fecha_Actualizacion,
                                 Usurio = c.Usurio,
                             }).ToList();

                return query;
            }
        }

        public List<FamiliaViews> ConsultarFamiliarNumeroDocumento(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFamilia
                             where c.Numero_Documento == value
                             orderby c.id_Familiar ascending
                             select new FamiliaViews()
                             {
                                 id_Familiar = c.id_Familiar,
                                 Numero_Documento_Cliente = c.Numero_Documento_Cliente,
                                 Parentesco = c.Parentesco,
                                 Primer_Nombre = c.Primer_Nombre,
                                 Segundo_Nombre = c.Segundo_Nombre,
                                 Otro_Nombre = c.Otro_Nombre,
                                 Primer_Apellido = c.Primer_Apellido,
                                 Segundo_Apellido = c.Segundo_Apellido,
                                 Tipo_Documento = c.Tipo_Documento,
                                 Numero_Documento = c.Numero_Documento,
                                 Departamento_Expedicion = c.Departamento_Expedicion,
                                 Ciudad_Expedicion = c.Ciudad_Expedicion,
                                 Otro_Lugar_Expedicion = c.Otro_Lugar_Expedicion,
                                 Fecha_Nacimiento = c.Fecha_Nacimiento,
                                 Tipo_Registro = c.Tipo_Registro,
                                 Nombre_Lugar_Registro = c.Nombre_Lugar_Registro,
                                 Departamento_Registro = c.Departamento_Registro,
                                 Ciudad_Registro = c.Ciudad_Registro,
                                 Otro_Lugar_Registro = c.Otro_Lugar_Registro,
                                 Telefono_Fijo = c.Telefono_Fijo,
                                 Telefono_Celular = c.Telefono_Celular,
                                 Correo = c.Correo,
                                 Red_Social = c.Red_Social,
                                 Nombre_Red_Social = c.Nombre_Red_Social,
                                 Departamento_Residencia = c.Departamento_Residencia,
                                 Ciudad_Residencia = c.Ciudad_Residencia,
                                 Otro_Lugar_Residencia = c.Otro_Lugar_Residencia,
                                 Casa_Propia = c.Casa_Propia,
                                 Direccion_Residencia = c.Direccion_Residencia,
                                 Barrio = c.Barrio,
                                 Estado_Proceso = c.Estado_Proceso,
                                 Etapa_Proceso = c.Etapa_Proceso,
                                 Fecha_Autenticacion = c.Fecha_Autenticacion,
                                 Fecha_Creacion = c.Fecha_Creacion,
                                 Fecha_Actualizacion = c.Fecha_Actualizacion,
                                 Usurio = c.Usurio,
                             }).ToList();

                return query;
            }
        }

        public List<FamiliaViews> ConsultarFamiliaresPorCliente(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from c in db.tblFamilia
                             where c.Numero_Documento_Cliente == value
                             orderby c.id_Familiar ascending
                             select new FamiliaViews()
                             {
                                 id_Familiar = c.id_Familiar,
                                 Numero_Documento_Cliente = c.Numero_Documento_Cliente,
                                 Parentesco = c.Parentesco,
                                 Primer_Nombre = c.Primer_Nombre,
                                 Segundo_Nombre = c.Segundo_Nombre,
                                 Otro_Nombre = c.Otro_Nombre,
                                 Primer_Apellido = c.Primer_Apellido,
                                 Segundo_Apellido = c.Segundo_Apellido,
                                 Tipo_Documento = c.Tipo_Documento,
                                 Numero_Documento = c.Numero_Documento,
                                 Departamento_Expedicion = c.Departamento_Expedicion,
                                 Ciudad_Expedicion = c.Ciudad_Expedicion,
                                 Otro_Lugar_Expedicion = c.Otro_Lugar_Expedicion,
                                 Fecha_Nacimiento = c.Fecha_Nacimiento,
                                 Tipo_Registro = c.Tipo_Registro,
                                 Nombre_Lugar_Registro = c.Nombre_Lugar_Registro,
                                 Departamento_Registro = c.Departamento_Registro,
                                 Ciudad_Registro = c.Ciudad_Registro,
                                 Otro_Lugar_Registro = c.Otro_Lugar_Registro,
                                 Telefono_Fijo = c.Telefono_Fijo,
                                 Telefono_Celular = c.Telefono_Celular,
                                 Correo = c.Correo,
                                 Red_Social = c.Red_Social,
                                 Nombre_Red_Social = c.Nombre_Red_Social,
                                 Departamento_Residencia = c.Departamento_Residencia,
                                 Ciudad_Residencia = c.Ciudad_Residencia,
                                 Otro_Lugar_Residencia = c.Otro_Lugar_Residencia,
                                 Casa_Propia = c.Casa_Propia,
                                 Direccion_Residencia = c.Direccion_Residencia,
                                 Barrio = c.Barrio,
                                 Estado_Proceso = c.Estado_Proceso,
                                 Etapa_Proceso = c.Etapa_Proceso,
                                 Fecha_Autenticacion = c.Fecha_Autenticacion,
                                 Fecha_Creacion = c.Fecha_Creacion,
                                 Fecha_Actualizacion = c.Fecha_Actualizacion,
                                 Usurio = c.Usurio,
                             }).ToList();

                return query;
            }
        }
    }
}