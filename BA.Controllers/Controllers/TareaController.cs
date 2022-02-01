using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TareaController
    {
        BA.Models.MetodosTarea metodos = new Models.MetodosTarea();

        public List<TareaViews> MostrarTarea()
        {
            return metodos.MostrarTarea();
        }

        public string MostrarNombreTarea(int value)
        {
            return metodos.MostrarNombreTarea(value);
        }

        public List<TareaViews> MostrarEstadoTarea(string value)
        {
            return metodos.MostrarEstadoTarea(value);
        }

        public bool GuardarPrioridad(TareaViews bat)
        {
            tblTarea tblbat = new tblTarea();
            tblbat.id_Tarea = bat.id_Tarea;
            tblbat.Nombre_Tarea = bat.Nombre_Tarea;
            tblbat.Estado = bat.Estado;
            return metodos.GuardarTarea(tblbat);
        }

        public bool ModificarTarea(TareaViews bat)
        {
            tblTarea tblbat = new tblTarea();

            tblbat.id_Tarea = bat.id_Tarea;
            tblbat.Nombre_Tarea = bat.Nombre_Tarea;
            tblbat.Estado = bat.Estado;
            return metodos.ModificarTarea(tblbat);
        }

        public List<TareaViews> MostrarTareaPorSeleccion(int value)
        {
            return metodos.MostrarTareaPorSeleccion(value);
        }

        public List<TareaViews> TareaParametrizaciones()
        {
            return metodos.TareaParametrizaciones();
        }
    }
}
