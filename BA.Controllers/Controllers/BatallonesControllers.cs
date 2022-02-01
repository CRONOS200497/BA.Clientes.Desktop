using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class BatallonesControllers
    {
        BA.Models.MetodosBatallones metodos = new Models.MetodosBatallones();

        public List<BatallonesViews> MostrarBatallones(int fuerza)
        {
            return metodos.MostrarBatallones(fuerza);
        }
    
        public string MostrarBatallonesNombre(int value)
        {
            return metodos.MostrarBatallonesNombre(value);
        }

        public List<BatallonesViews> MostrarBatallonesValor(string value)
        {
            return metodos.MostrarBatallonesValor(value);
        }

        public bool GuardarBatallones(BatallonesViews bat)
        {
            tblBatallones tblbat = new tblBatallones();

            tblbat.id_Batallon = bat.id_Batallon;
            tblbat.Nombre_Batallon = bat.Nombre_Batallon;
            tblbat.Fuerza = bat.Fuerza;
            tblbat.Estado = bat.Estado;

            return metodos.GuardarBatallones(tblbat);

        }

        public bool ModificarBatallones(BatallonesViews bat)
        {
            tblBatallones tblbat = new tblBatallones();

            tblbat.id_Batallon = bat.id_Batallon;
            tblbat.Nombre_Batallon = bat.Nombre_Batallon;
            tblbat.Fuerza = bat.Fuerza;
            tblbat.Estado = bat.Estado;
            return metodos.ModificarBatallones(tblbat);
        }

        public List<BatallonesViews> MostrarBatallonesPorSeleccion(int value)
        {
            return metodos.MostrarBatallonesPorSeleccion(value);

        }

        public List<BatallonesViews> BatallonesParametrizaciones()
        {

            return metodos.BatallonesParametrizaciones();

        }

    }
}
