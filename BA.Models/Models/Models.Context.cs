//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BA.Models.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbBarriosAbogadosEntities : DbContext
    {
        public dbBarriosAbogadosEntities()
            : base("name=dbBarriosAbogadosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblDepartamentos> tblDepartamentos { get; set; }
        public virtual DbSet<tblDocumentosClientes> tblDocumentosClientes { get; set; }
        public virtual DbSet<tblDocumentosFamilia> tblDocumentosFamilia { get; set; }
        public virtual DbSet<tblDocumentosNovedades> tblDocumentosNovedades { get; set; }
        public virtual DbSet<tblEstadosProcesos> tblEstadosProcesos { get; set; }
        public virtual DbSet<tblEtapasProceso> tblEtapasProceso { get; set; }
        public virtual DbSet<tblFuerza> tblFuerza { get; set; }
        public virtual DbSet<tblGrados> tblGrados { get; set; }
        public virtual DbSet<tblRedesSociales> tblRedesSociales { get; set; }
        public virtual DbSet<tblTipoDocumento> tblTipoDocumento { get; set; }
        public virtual DbSet<tblTipoFamiliar> tblTipoFamiliar { get; set; }
        public virtual DbSet<tblTipoRegistro> tblTipoRegistro { get; set; }
        public virtual DbSet<tblTitulosValores> tblTitulosValores { get; set; }
        public virtual DbSet<tblCiudades> tblCiudades { get; set; }
        public virtual DbSet<tblFamilia> tblFamilia { get; set; }
        public virtual DbSet<tblParametros> tblParametros { get; set; }
        public virtual DbSet<tblDocumentosCargados> tblDocumentosCargados { get; set; }
        public virtual DbSet<tblDocumentosCargadosFamilia> tblDocumentosCargadosFamilia { get; set; }
        public virtual DbSet<tblPerfiles> tblPerfiles { get; set; }
        public virtual DbSet<tblRoles> tblRoles { get; set; }
        public virtual DbSet<tblUsuarios> tblUsuarios { get; set; }
        public virtual DbSet<tblTiposSeguimientos> tblTiposSeguimientos { get; set; }
        public virtual DbSet<tblNovedades> tblNovedades { get; set; }
        public virtual DbSet<tblNovedadesFamilia> tblNovedadesFamilia { get; set; }
        public virtual DbSet<tblSeguimientoCliente> tblSeguimientoCliente { get; set; }
        public virtual DbSet<tblSeguimientoFamiliar> tblSeguimientoFamiliar { get; set; }
        public virtual DbSet<tblConceptos> tblConceptos { get; set; }
        public virtual DbSet<tblEstadosCitasMedicas> tblEstadosCitasMedicas { get; set; }
        public virtual DbSet<tblEstadosConceptos> tblEstadosConceptos { get; set; }
        public virtual DbSet<tblEstadosFichasMedicas> tblEstadosFichasMedicas { get; set; }
        public virtual DbSet<tblEstadosJuntasMedicas> tblEstadosJuntasMedicas { get; set; }
        public virtual DbSet<tblConceptosMedicos> tblConceptosMedicos { get; set; }
        public virtual DbSet<tblFichasMedicas> tblFichasMedicas { get; set; }
        public virtual DbSet<tblJuntasMedicas> tblJuntasMedicas { get; set; }
        public virtual DbSet<tblCitasMedicas> tblCitasMedicas { get; set; }
        public virtual DbSet<tblEstadosCuentas> tblEstadosCuentas { get; set; }
        public virtual DbSet<tblCartera> tblCartera { get; set; }
        public virtual DbSet<tblClientes> tblClientes { get; set; }
        public virtual DbSet<tblCorreosClientes> tblCorreosClientes { get; set; }
        public virtual DbSet<tblTelefonosClientes> tblTelefonosClientes { get; set; }
        public virtual DbSet<tblCorreosFamilia> tblCorreosFamilia { get; set; }
        public virtual DbSet<tblTelefonosFamilia> tblTelefonosFamilia { get; set; }
        public virtual DbSet<tblAbogados> tblAbogados { get; set; }
        public virtual DbSet<tblJuzgados> tblJuzgados { get; set; }
        public virtual DbSet<tblProcuradurias> tblProcuradurias { get; set; }
        public virtual DbSet<tblBatallones> tblBatallones { get; set; }
        public virtual DbSet<tblDispensarios> tblDispensarios { get; set; }
        public virtual DbSet<tblAudienciasJuzgado> tblAudienciasJuzgado { get; set; }
        public virtual DbSet<tblAudienciasProcuraduria> tblAudienciasProcuraduria { get; set; }
        public virtual DbSet<tblAreas> tblAreas { get; set; }
        public virtual DbSet<tblAreasTareas> tblAreasTareas { get; set; }
        public virtual DbSet<tblEstadosTarea> tblEstadosTarea { get; set; }
        public virtual DbSet<tblPrioridad> tblPrioridad { get; set; }
        public virtual DbSet<tblRegistrarSeguimiento> tblRegistrarSeguimiento { get; set; }
        public virtual DbSet<tblTarea> tblTarea { get; set; }
        public virtual DbSet<tblTipoTarea> tblTipoTarea { get; set; }
        public virtual DbSet<tblUsuarioArea> tblUsuarioArea { get; set; }
        public virtual DbSet<tblRegistrarTareas> tblRegistrarTareas { get; set; }
    
        public virtual int CopiaTablaClientes(string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaClientes", numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaFamilia(string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaFamilia", numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaAudienciasJuzgado(Nullable<int> id_Audiencia, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_AudienciaParameter = id_Audiencia.HasValue ?
                new ObjectParameter("id_Audiencia", id_Audiencia) :
                new ObjectParameter("id_Audiencia", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaAudienciasJuzgado", id_AudienciaParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaAudienciasProcuraduria(Nullable<int> id_Audiencia, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_AudienciaParameter = id_Audiencia.HasValue ?
                new ObjectParameter("id_Audiencia", id_Audiencia) :
                new ObjectParameter("id_Audiencia", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaAudienciasProcuraduria", id_AudienciaParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaCitasMedicas(Nullable<int> id_Cita, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_CitaParameter = id_Cita.HasValue ?
                new ObjectParameter("id_Cita", id_Cita) :
                new ObjectParameter("id_Cita", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaCitasMedicas", id_CitaParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaConceptosMedicos(Nullable<int> id_Concepto, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_ConceptoParameter = id_Concepto.HasValue ?
                new ObjectParameter("id_Concepto", id_Concepto) :
                new ObjectParameter("id_Concepto", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaConceptosMedicos", id_ConceptoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaCorreosClientes(Nullable<int> id_Correo, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_CorreoParameter = id_Correo.HasValue ?
                new ObjectParameter("id_Correo", id_Correo) :
                new ObjectParameter("id_Correo", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaCorreosClientes", id_CorreoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaCorreosFamilia(Nullable<int> id_Correo, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_CorreoParameter = id_Correo.HasValue ?
                new ObjectParameter("id_Correo", id_Correo) :
                new ObjectParameter("id_Correo", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaCorreosFamilia", id_CorreoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaDocumentosCargados(Nullable<int> id_Archivo, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_ArchivoParameter = id_Archivo.HasValue ?
                new ObjectParameter("id_Archivo", id_Archivo) :
                new ObjectParameter("id_Archivo", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaDocumentosCargados", id_ArchivoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaDocumentosCargadosFamilia(Nullable<int> id_Archivo, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_ArchivoParameter = id_Archivo.HasValue ?
                new ObjectParameter("id_Archivo", id_Archivo) :
                new ObjectParameter("id_Archivo", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaDocumentosCargadosFamilia", id_ArchivoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaFichasMedicas(Nullable<int> id_Ficha, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_FichaParameter = id_Ficha.HasValue ?
                new ObjectParameter("id_Ficha", id_Ficha) :
                new ObjectParameter("id_Ficha", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaFichasMedicas", id_FichaParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaJuntasMedicas(Nullable<int> id_Junta, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_JuntaParameter = id_Junta.HasValue ?
                new ObjectParameter("id_Junta", id_Junta) :
                new ObjectParameter("id_Junta", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaJuntasMedicas", id_JuntaParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaNovedades(Nullable<int> id_Novedad, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_NovedadParameter = id_Novedad.HasValue ?
                new ObjectParameter("id_Novedad", id_Novedad) :
                new ObjectParameter("id_Novedad", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaNovedades", id_NovedadParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaNovedadesFamilia(Nullable<int> id_Novedad, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_NovedadParameter = id_Novedad.HasValue ?
                new ObjectParameter("id_Novedad", id_Novedad) :
                new ObjectParameter("id_Novedad", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaNovedadesFamilia", id_NovedadParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaPerfiles(Nullable<int> id_Perfil, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_PerfilParameter = id_Perfil.HasValue ?
                new ObjectParameter("id_Perfil", id_Perfil) :
                new ObjectParameter("id_Perfil", typeof(int));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaPerfiles", id_PerfilParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaRoles(Nullable<int> id_Rol, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_RolParameter = id_Rol.HasValue ?
                new ObjectParameter("id_Rol", id_Rol) :
                new ObjectParameter("id_Rol", typeof(int));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaRoles", id_RolParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaSeguimientosCliente(Nullable<int> id_Seguimiento, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_SeguimientoParameter = id_Seguimiento.HasValue ?
                new ObjectParameter("id_Seguimiento", id_Seguimiento) :
                new ObjectParameter("id_Seguimiento", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaSeguimientosCliente", id_SeguimientoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaSeguimientosFamiliar(Nullable<int> id_Seguimiento, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_SeguimientoParameter = id_Seguimiento.HasValue ?
                new ObjectParameter("id_Seguimiento", id_Seguimiento) :
                new ObjectParameter("id_Seguimiento", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaSeguimientosFamiliar", id_SeguimientoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaTelefonosClientes(Nullable<int> id_Telefono, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_TelefonoParameter = id_Telefono.HasValue ?
                new ObjectParameter("id_Telefono", id_Telefono) :
                new ObjectParameter("id_Telefono", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaTelefonosClientes", id_TelefonoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaTelefonosFamilia(Nullable<int> id_Telefono, string numero_Documento, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_TelefonoParameter = id_Telefono.HasValue ?
                new ObjectParameter("id_Telefono", id_Telefono) :
                new ObjectParameter("id_Telefono", typeof(int));
    
            var numero_DocumentoParameter = numero_Documento != null ?
                new ObjectParameter("Numero_Documento", numero_Documento) :
                new ObjectParameter("Numero_Documento", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaTelefonosFamilia", id_TelefonoParameter, numero_DocumentoParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    
        public virtual int CopiaTablaUsuarios(Nullable<int> id_Usuario, string login, string usuario, string accion, Nullable<System.DateTime> fecha_Accion)
        {
            var id_UsuarioParameter = id_Usuario.HasValue ?
                new ObjectParameter("id_Usuario", id_Usuario) :
                new ObjectParameter("id_Usuario", typeof(int));
    
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var fecha_AccionParameter = fecha_Accion.HasValue ?
                new ObjectParameter("Fecha_Accion", fecha_Accion) :
                new ObjectParameter("Fecha_Accion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CopiaTablaUsuarios", id_UsuarioParameter, loginParameter, usuarioParameter, accionParameter, fecha_AccionParameter);
        }
    }
}
