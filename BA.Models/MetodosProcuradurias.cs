using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Models
{
    public class MetodosProcuradurias
    {
        public List<ProcuraduriaViews> MostrarProcuradurias()
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblProcuradurias
                             where d.Estado == true
                             select new ProcuraduriaViews()
                             {
                                 id_Procuraduria = d.id_Procuraduria,
                                 Nombre_Procuraduria = d.Nombre_Procuraduria,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

        public string MostrarProcuraduriasNombre(int value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblProcuradurias
                             where d.id_Procuraduria == value
                             select new ProcuraduriaViews()
                             {
                                 id_Procuraduria = d.id_Procuraduria,
                                 Nombre_Procuraduria = d.Nombre_Procuraduria,
                                 Estado = d.Estado,
                             }).ToList();

                string Nombre_Procuraduria = string.Empty;

                foreach (var g in query)
                {
                    Nombre_Procuraduria = g.Nombre_Procuraduria;
                }

                return Nombre_Procuraduria;
            }
        }

        public int MostrarProcuraduriasValor(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {

                var query = (from d in db.tblProcuradurias
                             where d.Nombre_Procuraduria == value
                             select new ProcuraduriaViews()
                             {
                                 id_Procuraduria = d.id_Procuraduria,
                                 Nombre_Procuraduria = d.Nombre_Procuraduria,
                                 Estado = d.Estado,

                             }).ToList();

                int id_Procuraduria = 0;

                foreach (var g in query)
                {
                    id_Procuraduria = g.id_Procuraduria;
                }
                return id_Procuraduria;
            }
        }

        public List<ProcuraduriaViews> MostrarJuzgadoSeleccionado(string value)
        {
            using (dbBarriosAbogadosEntities db = new dbBarriosAbogadosEntities())
            {
                var query = (from d in db.tblProcuradurias
                             where d.Nombre_Procuraduria == value
                             select new ProcuraduriaViews()
                             {
                                 id_Procuraduria = d.id_Procuraduria,
                                 Nombre_Procuraduria = d.Nombre_Procuraduria,
                                 Estado = d.Estado,
                             }).ToList();
                return query;
            }
        }

    }
}
