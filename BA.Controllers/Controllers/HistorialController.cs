using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class HistorialController
    {
        BA.Models.Historiales metodos = new Models.Historiales();

        public bool HistorialTablaClientes(string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            return metodos.HistorialTablaClientes(numero_documento, Usuario, Accion, Fecha);
        }

        public bool HistorialTablaFamilia(string numero_documento, string Usuario, string Accion, DateTime Fecha)
        {
            return metodos.HistorialTablaFamilia(numero_documento, Usuario, Accion, Fecha);
        }

    }
}
