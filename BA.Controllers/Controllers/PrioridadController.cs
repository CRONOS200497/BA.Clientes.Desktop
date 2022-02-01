using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class PrioridadController
    {
        BA.Models.MetodosPrioridad metodos = new Models.MetodosPrioridad();

        public List<PrioridadViews> MostrarPrioridad()
        {
            return metodos.MostrarPrioridad();
        }

        public string MostrarNombrePrioridad(int value)
        {
            return metodos.MostrarNombrePrioridad(value);
        }

        public List<PrioridadViews> MostrarEstadoPrioridad(string value)
        {
            return metodos.MostrarEstadoPrioridad(value);
        }

        public bool GuardarPrioridad(PrioridadViews bat)
        {
            tblPrioridad tblbat = new tblPrioridad();
            tblbat.id = bat.id;
            tblbat.Prioridad = bat.Prioridad;
            tblbat.Estado = bat.Estado;
            return metodos.GuardarPrioridad(tblbat);
        }

        public bool ModificarPrioridad(PrioridadViews bat)
        {
            tblPrioridad tblbat = new tblPrioridad();

            tblbat.id = bat.id;
            tblbat.Prioridad = bat.Prioridad;
            tblbat.Estado = bat.Estado;
            return metodos.ModificarPrioridad(tblbat);
        }

        public List<PrioridadViews> MostrarPrioridadPorSeleccion(int value)
        {
            return metodos.MostrarPrioridadPorSeleccion(value);
        }

        public List<PrioridadViews> PrioridadParametrizaciones()
        {
            return metodos.PrioridadParametrizaciones();
        }
    }
}
