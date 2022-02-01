using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class RegistrarSeguimientoTareaController
    {
        BA.Models.MetodosRegistrarSeguimientoTarea metodos = new Models.MetodosRegistrarSeguimientoTarea();

        public List<RegistrarSeguimientoViews> MostrarTodasLasTareas(int Id_Solicitud)
        {
            return metodos.MostrarTodasLasTareas(Id_Solicitud);
        }

        public string AbrirDocumentoCliente(int id_Archivo)
        {
            return metodos.AbrirDocumentoCliente(id_Archivo);
        }
        public bool AgregarSeguimientoTarea(RegistrarSeguimientoViews d)
        {
            tblRegistrarSeguimiento Reg = new tblRegistrarSeguimiento();
            //Reg.id_Solicitud = d.id_Solicitud;
            Reg.id_Solicitud = d.id_Solicitud;   
            Reg.Descripcion = d.Descripcion;                
            Reg.Adjunto = d.Adjunto;
            Reg.Ruta = d.Ruta;
            Reg.Nombre_Archivo = d.Nombre_Archivo;
            Reg.Notificar_Responsable = d.Notificar_Responsable;
            Reg.Estado = d.Estado;
            Reg.Fecha_Seguimiento = d.Fecha_Seguimiento;
            Reg.Usuario_Seguimiento = d.Usuario_Seguimiento;    
            return metodos.AgregarSeguimientoTarea(Reg);
        }

    }
}
