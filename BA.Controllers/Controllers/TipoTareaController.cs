using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TipoTareaController
    {
        BA.Models.MetodosTipoTarea metodos = new Models.MetodosTipoTarea();

        public List<TipoTareaViews> MostrarTipoTarea()
        {
            return metodos.MostrarTipoTarea();
        }

        public string MostrarNombreTipoTarea(int value)
        {
            return metodos.MostrarNombreTipoTarea(value);
        }

        public List<TipoTareaViews> MostrarTipoTarea(string value)
        {
            return metodos.MostrarTipoTarea(value);
        }

        public bool GuardarTipoTarea(TipoTareaViews bat)
        {
            tblTipoTarea tblbat = new tblTipoTarea();
            tblbat.id_Tipo_Tarea = bat.id_Tipo_Tarea;
            tblbat.Nombre_Tipo_Tarea = bat.Nombre_Tipo_Tarea;
            tblbat.Estado = bat.Estado;
            return metodos.GuardarTipoTarea(tblbat);
        }

        public bool ModificarTipoTarea(TipoTareaViews bat)
        {
            tblTipoTarea tblbat = new tblTipoTarea();
            tblbat.id_Tipo_Tarea = bat.id_Tipo_Tarea;
            tblbat.Nombre_Tipo_Tarea = bat.Nombre_Tipo_Tarea;
            tblbat.Estado = bat.Estado;
            return metodos.ModificarTipoTarea(tblbat);
        }

        public List<TipoTareaViews> MostrarTipoTareaPorSeleccion(int value)
        {
            return metodos.MostrarTipoTareaPorSeleccion(value);
        }

        public List<TipoTareaViews> TipoTareaParametrizaciones()
        {
            return metodos.TipoTareaParametrizaciones();
        }
    }
}
