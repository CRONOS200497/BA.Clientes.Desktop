using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;


namespace BA.Controllers.Controllers
{
    public class AudienciasJuzgadosController
    {
        BA.Models.MetodosAudienciasJuzgados metodos = new Models.MetodosAudienciasJuzgados();

        public List<AudienciasJuzgadoViews> ConsultarAudienciasPorCliente(string doc_cliente)
        {
            return metodos.MostrarAudienciaporCliente(doc_cliente);
        }

        public List<AudienciasJuzgadoViews> ConsultartodasLasAudiencias()
        {
            return metodos.ConsultartodasLasAudiencias();
        }
        
        public List<AudienciasJuzgadoViews> ConsultarAudienciasHoy(DateTime ConsultaInicial, DateTime ConsultaFinal)
        {
            return metodos.ConsultarAudienciasHoy(ConsultaInicial, ConsultaFinal);
        }

        public List<AudienciasJuzgadoViews> ConsultarAudienciasPorMes(DateTime FechaInicial, DateTime FechaFinal)
        {
            return metodos.ConsultarAudienciasPorMes(FechaInicial, FechaFinal);
        }

        public List<AudienciasJuzgadoViews> ConsultarAudienciasPorFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            return metodos.ConsultarAudienciasPorFechas(FechaInicial, FechaFinal);
        }

        public List<AudienciasJuzgadoViews> ConsultarAudienciaPorID(int id_Audiencia)
        {
            return metodos.ConsultarAudienciaPorID(id_Audiencia);
        }

        public string AbrirDocumentoCliente(int id_Archivo)
        {
            return metodos.AbrirDocumentoCliente(id_Archivo);
        }

        public bool AgregarAudiencia(AudienciasJuzgadoViews doc)
        {
            tblAudienciasJuzgado loadDoc = new tblAudienciasJuzgado();

            loadDoc.id_Audiencia_Juzgado = doc.id_Audiencia_Juzgado;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Primer_Nombre = doc.Primer_Nombre;
            loadDoc.Segundo_Nombre = doc.Segundo_Nombre;
            loadDoc.Primer_Apellido = doc.Primer_Apellido;
            loadDoc.SegundoApellido = doc.SegundoApellido;
            loadDoc.Numero_Proceso = doc.Numero_Proceso;
            loadDoc.Juzgado = doc.Juzgado;
            loadDoc.Fecha_Audiencia = doc.Fecha_Audiencia;
            loadDoc.Abogado = doc.Abogado;
            loadDoc.Correo_Abogado = doc.Correo_Abogado;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Informar_Abogado = doc.Informar_Abogado;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.AgregarAudiencia(loadDoc);
        }

        public bool ModificarAudiencia(AudienciasJuzgadoViews doc)
        {
            tblAudienciasJuzgado loadDoc = new tblAudienciasJuzgado();

            loadDoc.id_Audiencia_Juzgado = doc.id_Audiencia_Juzgado;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Primer_Nombre = doc.Primer_Nombre;
            loadDoc.Segundo_Nombre = doc.Segundo_Nombre;
            loadDoc.Primer_Apellido = doc.Primer_Apellido;
            loadDoc.SegundoApellido = doc.SegundoApellido;
            loadDoc.Numero_Proceso = doc.Numero_Proceso;
            loadDoc.Juzgado = doc.Juzgado;
            loadDoc.Fecha_Audiencia = doc.Fecha_Audiencia;
            loadDoc.Abogado = doc.Abogado;
            loadDoc.Correo_Abogado = doc.Correo_Abogado;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Informar_Abogado = doc.Informar_Abogado;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarAudiencia(loadDoc);
        }

        public bool EliminarCorreoFamilia(AudienciasJuzgadoViews doc)
        {
            tblAudienciasJuzgado loadDoc = new tblAudienciasJuzgado();

            loadDoc.id_Audiencia_Juzgado = doc.id_Audiencia_Juzgado;
            return metodos.EliminarAudiencia(loadDoc);
        }

        public bool ValidarSiFamiliarExiste(string value_Numero_Documento_Familiar)
        {
            return metodos.ValidarSiFamiliarExiste(value_Numero_Documento_Familiar);

        }
    }
}
