using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class DispensariosControllers
    {
        BA.Models.MetodosDispensarios metodos = new Models.MetodosDispensarios();

        public List<DispensariosViews> MostrarDispensarios(int fuerza)
        {
            return metodos.MostrarDispensarios(fuerza);
        }


        public string MostrarDispensariosNombre(int value)
        {
            return metodos.MostrarDispensariosNombre(value);
        }

        public List<DispensariosViews> MostrarDispensariosValor(string value)
        {
            return metodos.MostrarDispensariosValor(value);
        }

        public int MostrarDispensariosValor2(string value)
        {
            return metodos.MostrarDispensariosValor2(value);
        }

        public bool GuardarDispensarios(DispensariosViews bat)
        {
            tblDispensarios tblbat = new tblDispensarios();

            tblbat.id_Dispensario = bat.id_Dispensario;
            tblbat.Nombre_Dispensario = bat.Nombre_Dispensario;
            tblbat.Fuerza = bat.Fuerza;
            tblbat.Estado = bat.Estado;

            return metodos.GuardarDispensarios(tblbat);

        }

        public bool ModificarDispensarios(DispensariosViews bat)
        {
            tblDispensarios tblbat = new tblDispensarios();

            tblbat.id_Dispensario = bat.id_Dispensario;
            tblbat.Nombre_Dispensario = bat.Nombre_Dispensario;
            tblbat.Fuerza = bat.Fuerza;
            tblbat.Estado = bat.Estado;

            return metodos.ModificarDispensarioss(tblbat);

        }

        public List<DispensariosViews> MostrarDispensariosPorSeleccion(int value)
        {
            return metodos.MostrarDispensariosPorSeleccion(value);

        }

        public List<DispensariosViews> DispensariosParametrizaciones()
        {
            return metodos.DispensariosParametrizaciones();
        }

    }
}
