using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
   public class AreasController
    {

        BA.Models.MetodosAreas metodos = new Models.MetodosAreas();

        public List<AreasViews> MostrarAreas()
        {
            return metodos.MostrarAreas();
        }

        public string MostrarNombreArea(int value)
        {
            return metodos.MostrarNombreArea(value);
        }

        public List<AreasViews>MostrarAreaPorNombre(string value)
        {
            return metodos.MostrarAreaPorNombre(value);
        }

        public bool GuardarAreas(AreasViews bat)
        {
            tblAreas tblbat = new tblAreas();
            tblbat.id_Area = bat.id_Area;
            tblbat.Nombre_Area = bat.Nombre_Area;
            tblbat.Estado = bat.Estado;
            return metodos.GuardarAreas(tblbat);
        }

        public bool ModificarAreas(AreasViews bat)
        {
            tblAreas tblbat = new tblAreas();

            tblbat.id_Area = bat.id_Area;
            tblbat.Nombre_Area = bat.Nombre_Area;
            tblbat.Estado = bat.Estado;
            return metodos.ModificarAreas(tblbat);
        }

        public List<AreasViews> MostrarAreasPorSeleccion(int value)
        {
            return metodos.MostrarAreasPorSeleccion(value);
        }

        public List<AreasViews> AreasParametrizaciones()
        {
            return metodos.AreasParametrizaciones();
        }
    }
}
