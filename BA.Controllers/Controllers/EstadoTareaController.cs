using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class EstadoTareaController
    {
        BA.Models.MetodosEstadoTarea metodos = new Models.MetodosEstadoTarea();

        public List<EstadoTareaViews> MostrarEstadoTarea()
        {
            return metodos.MostrarEstadoTarea();
        }

        public List<EstadoTareaViews> MostrarEstadoTareaSeguimiento()
        {
            return metodos.MostrarEstadoTareaSeguimiento();
        }

        public List<EstadoTareaViews> MostrarEstadoTareaRegistrarTarea()
        {
            return metodos.MostrarEstadoTareaRegistrarTarea();
        }
        public string MostrarNombreEstadoTarea(int value)
        {
            return metodos.MostrarNombreEstadoTarea(value);
        }

        public List<EstadoTareaViews> MostrarEstadoTareaPorNombre(string value)
        {
            return metodos.MostrarEstadoTareaPorNombre(value);
        }

        public bool GuardarAreas(EstadoTareaViews bat)
        {
            tblEstadosTarea tblbat = new tblEstadosTarea();
            tblbat.id_Tarea = bat.id_Tarea;
            tblbat.Nombre_Estado = bat.Nombre_Estado;
            tblbat.Estado = bat.Estado;
            return metodos.GuardarAreas(tblbat);
        }

        public bool ModificarAreas(EstadoTareaViews bat)
        {
            tblEstadosTarea tblbat = new tblEstadosTarea();

            tblbat.id_Tarea = bat.id_Tarea;
            tblbat.Nombre_Estado = bat.Nombre_Estado;
            tblbat.Estado = bat.Estado;
            return metodos.ModificarAreas(tblbat);
        }

        public List<EstadoTareaViews> MostrarEstadoTareaPorSeleccion(int value)
        {
            return metodos.MostrarEstadoTareaPorSeleccion(value);
        }

        public List<EstadoTareaViews> EstadoTareaParametrizaciones()
        {
            return metodos.EstadoTareaParametrizaciones();
        }
    }
}
