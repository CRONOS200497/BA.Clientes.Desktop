using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TelefonosFamiliaController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarTelefonoFamilia(TelefonosFamiliaViews doc)
        {
            tblTelefonosFamilia loadDoc = new tblTelefonosFamilia();
            loadDoc.id_Telefono = doc.id_Telefono;
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Numero_Telefono = doc.Numero_Telefono;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarTelefonoFamilia(loadDoc);
        }

        public bool ModificarTelefonoFamilia(TelefonosFamiliaViews doc)
        {
            tblTelefonosFamilia loadDoc = new tblTelefonosFamilia();
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Numero_Telefono = doc.Numero_Telefono;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarTelefonoFamilia(loadDoc);
        }

        public bool EliminarTelefonoFamilia(TelefonosFamiliaViews doc)
        {
            tblTelefonosFamilia loadDoc = new tblTelefonosFamilia();
            loadDoc.id_Telefono = doc.id_Telefono;
            return metodos.EliminarTelefonoFamilia(loadDoc);
        }

        public List<TelefonosFamiliaViews> ConsultarTelefonosPorFamiliar(string doc_cliente)
        {
            return metodos.ConsultarTelefonosPorFamiliar(doc_cliente);
        }

        public List<TelefonosFamiliaViews> ConsultarTelefonoFamiliaPorId(int id_novedad)
        {
            return metodos.ConsultarTelefonoFamiliaPorId(id_novedad);
        }
    }
}
