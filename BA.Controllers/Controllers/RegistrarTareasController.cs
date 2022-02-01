using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class RegistrarTareasController
    {
        BA.Models.MetodosRegistrarTareas metodos = new Models.MetodosRegistrarTareas();

        public List<RegistrarTareasViews> MostrarTodasLasTareas()
        {
            return metodos.MostrarTodasLasTareas();
        }

        public List<RegistrarTareasViews> MostrarTareasLiderArea(string Area)
        {
            return metodos.MostrarTareasLiderArea(Area);
        }

        public List<RegistrarTareasViews> MostrarTareasPorArea(string Area_Creadora)
        {
            return metodos.MostrarTareasPorArea(Area_Creadora);
        }

        public List<RegistrarTareasViews> MostrarTareasPorResponsable(string Responsable, string Area)
        {
            return metodos.MostrarTareasPorResponsable(Responsable, Area);
        }

        public List<RegistrarTareasViews> MostrarTareasPorResponsableDiferenteCerrado(string Responsable, string Area)
        {
            return metodos.MostrarTareasPorResponsableDiferenteCerrado(Responsable, Area);
        }

        public List<RegistrarTareasViews> MostrarTareasPorCreador(string Creador)
        {
            return metodos.MostrarTareasPorCreador(Creador);
        }

        public List<RegistrarTareasViews> MostrarTareasPorFechaAsignado(DateTime FechaInicial, DateTime FechaFinal, string Usuario, string Area)
        {
            return metodos.MostrarTareasPorFechaAsignado(FechaInicial, FechaFinal, Usuario, Area);
        }

        public List<RegistrarTareasViews> MostrarTareasPorFechaAsignadoOtraArea(DateTime FechaInicial, DateTime FechaFinal, string Usuario)
        {
            return metodos.MostrarTareasPorFechaAsignadoOtraArea(FechaInicial, FechaFinal, Usuario);
        }

        public List<RegistrarTareasViews> MostrarTareasPorID(int id_Solicitud, string Usuario, string Area)
        {
            return metodos.MostrarTareasPorID(id_Solicitud, Usuario, Area);
        }

        public List<RegistrarTareasViews> MostrarTareasPorIDParaSeguimiento(int id_Solicitud)
        {
            return metodos.MostrarTareasPorIDParaSeguimiento(id_Solicitud);
        }

        public List<RegistrarTareasViews> MostrarTareasPorIDOtrasAreas(int id_Solicitud, string Usuario)
        {
            return metodos.MostrarTareasPorIDOtrasAreas(id_Solicitud, Usuario);
        }

        public List<RegistrarTareasViews> MostrarTareasPorEstado(string Usuario, string Area, string Estado)
        {
            return metodos.MostrarTareasPorEstado(Usuario, Area, Estado);
        }

        public List<RegistrarTareasViews> MostrarTareasHoy(DateTime FechaInicial, DateTime FechaFinal)
        {
            return metodos.MostrarTareasHoy(FechaInicial, FechaFinal);
        }

        public string AbrirDocumentoCliente(int id_Archivo)
        {
            return metodos.AbrirDocumentoCliente(id_Archivo);
        }

        public bool ValidarSiFamiliarExiste(string value_Numero_Documento_Familiar)
        {
            return metodos.ValidarSiFamiliarExiste(value_Numero_Documento_Familiar);
        }

        public bool AgregarTarea(RegistrarTareasViews d)
        {
            tblRegistrarTareas Reg = new tblRegistrarTareas();
            //Reg.id_Solicitud = d.id_Solicitud;
            Reg.id_Tarea = d.id_Tarea;
            Reg.Creador = d.Creador;
            Reg.Responsable = d.Responsable;
            Reg.Doc_Cliente = d.Doc_Cliente;
            Reg.Primer_Nombre = d.Primer_Nombre;
            Reg.Segundo_Nombre = d.Segundo_Nombre;
            Reg.Primer_Apellido = d.Primer_Apellido;
            Reg.Segundo_Apellido = d.Segundo_Apellido;
            Reg.Descripcion = d.Descripcion;
            Reg.Prioridad = d.Prioridad;
            Reg.Estado = d.Estado;
            Reg.Adjunto = d.Adjunto;
            Reg.Ruta = d.Ruta;
            Reg.Nombre_Archivo = d.Nombre_Archivo;
            Reg.Notificar_Responsable = d.Notificar_Responsable;
            Reg.Area_Creadora = d.Area_Creadora;
            Reg.Fecha_Asignado = d.Fecha_Asignado;
            Reg.Fecha_Actualizado = d.Fecha_Actualizado;
            return metodos.AgregarTarea(Reg);
        }
        public bool ModificarTarea(RegistrarTareasViews d)
        {
            tblRegistrarTareas Reg = new tblRegistrarTareas();
            Reg.id_Solicitud = d.id_Solicitud;
            Reg.id_Tarea = d.id_Tarea;
            Reg.Creador = d.Creador;
            Reg.Responsable = d.Responsable;
            Reg.Doc_Cliente = d.Doc_Cliente;
            Reg.Primer_Nombre = d.Primer_Nombre;
            Reg.Segundo_Nombre = d.Segundo_Nombre;
            Reg.Primer_Apellido = d.Primer_Apellido;
            Reg.Segundo_Apellido = d.Segundo_Apellido;
            Reg.Descripcion = d.Descripcion;
            Reg.Prioridad = d.Prioridad;
            Reg.Estado = d.Estado;
            Reg.Adjunto = d.Adjunto;
            Reg.Ruta = d.Ruta;
            Reg.Nombre_Archivo = d.Nombre_Archivo;
            Reg.Notificar_Responsable = d.Notificar_Responsable;
            Reg.Area_Creadora = d.Area_Creadora;
            Reg.Fecha_Asignado = d.Fecha_Asignado;
            Reg.Fecha_Actualizado = d.Fecha_Actualizado;
            return metodos.ModificarTarea(Reg);
        }
        public bool EliminarTarea(RegistrarTareasViews d)
        {
            tblRegistrarTareas Reg = new tblRegistrarTareas();
            Reg.id_Tarea = d.id_Tarea;
            return metodos.EliminarTarea(Reg);
        }
    }
}
