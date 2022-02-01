using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class AreasTareasController
    {
        BA.Models.MetodosAreasTareas metodos = new Models.MetodosAreasTareas();

        public List<AreasTareasViews> MostrarAreas()
        {
            return metodos.MostrarAreasTareas();
        }

        public string MostrarNombreArea(int value)
        {
            return metodos.MostrarNombreAreaTarea(value);
        }

        public string MostrarNombreTipoTareaPorArea(int value)
        {
            return metodos.MostrarNombreTipoTareaPorArea(value);
        }

        public string MostrarNombreTareaporTipoTarea(int value)
        {
            return metodos.MostrarNombreTareaporTipoTarea(value);
        }

        public List<AreasTareasViews> MostrarsAreasTareasPorNombre(string value)
        {
            return metodos.MostrarsAreasTareasPorNombre(value);
        }

        public int ValidarTiempoTarea(int id_Tarea)
        {
            return metodos.ValidarTiempoTarea(id_Tarea);
        }

        public bool GuardarAreas(AreasTareasViews bat)
        {
            tblAreasTareas tblbat = new tblAreasTareas();
            tblbat.id = bat.id;
            tblbat.Area = bat.Area;
            tblbat.Tipo_Tarea = bat.Tipo_Tarea;
            tblbat.Tarea = bat.Tarea;
            tblbat.Dias = bat.Dias;
            tblbat.Estado = bat.Estado;
            return metodos.GuardarAreasTareas(tblbat);
        }

        public bool ModificarAreas(AreasTareasViews bat)
        {
            tblAreasTareas tblbat = new tblAreasTareas();
            tblbat.id = bat.id;
            tblbat.Area = bat.Area;
            tblbat.Tipo_Tarea = bat.Tipo_Tarea;
            tblbat.Tarea = bat.Tarea;
            tblbat.Dias = bat.Dias;
            tblbat.Estado = bat.Estado;
            return metodos.ModificarAreasTareas(tblbat);
        }

        public List<AreasTareasViews> MostrarAreasTareasPorSeleccion(int value)
        {
            return metodos.MostrarAreasTareasPorSeleccion(value);
        }

        public List<AreasTareasViews> MostrarAreasTareasPorArea(string Area)
        {
            return metodos.MostrarAreasTareasPorArea(Area);
        }

        public List<AreasTareasViews> MostrarAreasTareasPorTipoTarea(string Tipo_Tarea)
        {
            return metodos.MostrarAreasTareasPorTipoTarea(Tipo_Tarea);
        }

        public List<AreasTareasViews> MostrarAreasTareasPorTipoTareaSeguimiento(string Area, string Tipo_Tarea, string Tarea)
        {
            return metodos.MostrarAreasTareasPorTipoTareaSeguimiento(Area, Tipo_Tarea, Tarea);
        }

        public List<AreasTareasViews> MostrarAreasTareasPorTipoTareaSeguimiento(string Area, string Tipo_Tarea)
        {
            return metodos.MostrarAreasTareasPorTipoTareaSeguimiento(Area,Tipo_Tarea);
        }

        public List<AreasTareasViews> AreasTareasParametrizaciones()
        {
            return metodos.AreasTareasParametrizaciones();
        }
    }
}
