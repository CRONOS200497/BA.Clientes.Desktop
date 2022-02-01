using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Models;
using BA.Models.Entidades;

namespace BA.Models
{
    public class Historiales
    {

        public bool HistorialTablaClientes(string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaClientes(numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialTablaFamilia(string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaFamilia(numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialAudienciaJuzjado(int id_Audiencia, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaAudienciasJuzgado(id_Audiencia,numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialAudienciaProcuraduria(int id_Audiencia, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaAudienciasProcuraduria(id_Audiencia, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialCitasMedicas(int id_Cita, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaCitasMedicas(id_Cita, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialConceptosMedicos(int id_Conceptos, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaConceptosMedicos(id_Conceptos, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialCorreosClientes(int id_Correo, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaCorreosClientes(id_Correo, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialCorreosFamilia(int id_Correo, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaCorreosFamilia(id_Correo, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialDocumentosCargados(int id_Archivo, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaDocumentosCargados(id_Archivo, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialDocumentosCargadosFamilia(int id_Archivo, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaDocumentosCargadosFamilia(id_Archivo, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialFichasMedicas(int id_Ficha, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaFichasMedicas(id_Ficha, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialJuntasMedicas(int id_Junta, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaJuntasMedicas(id_Junta, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialNovedades(int id_Novedad, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaNovedades(id_Novedad, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialNovedadesFamilia(int id_Novedad, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaNovedadesFamilia(id_Novedad, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialPerfiles(int id_Perfil, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaPerfiles(id_Perfil, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialRoles(int id_Rol, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaRoles(id_Rol, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialSeguimientosCliente(int id_Seguimiento, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaSeguimientosCliente(id_Seguimiento, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialSeguimientosFamiliar(int id_Seguimiento, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaSeguimientosFamiliar(id_Seguimiento, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialTelefonosCliente(int id_Telefono, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaTelefonosClientes(id_Telefono, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialTelefonosFamilia(int id_Telefono, string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaTelefonosFamilia(id_Telefono, numero_documento, Usuario, Accion, Fecha);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool HistorialUsuarios(int id_Usuario, string Login, string Usuario, string Accion, DateTime Fecha)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                try
                {
                    db.CopiaTablaUsuarios(id_Usuario, Login, Usuario, Accion, Fecha);
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
