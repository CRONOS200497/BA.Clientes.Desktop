using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class CorreosFamiliaController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarCorreoFamilia(CorreosFamiliaViews doc)
        {
            tblCorreosFamilia loadDoc = new tblCorreosFamilia();

            loadDoc.id_Correo = doc.id_Correo;
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Correo = doc.Correo;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarCorreoFamilia(loadDoc);
        }

        public bool ModificarCorreoFamilia(CorreosFamiliaViews doc)
        {
            tblCorreosFamilia loadDoc = new tblCorreosFamilia();

            loadDoc.id_Correo = doc.id_Correo;
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Correo = doc.Correo;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarCorreoFamilia(loadDoc);
        }

        public bool EliminarCorreoFamilia(CorreosFamiliaViews doc)
        {
            tblCorreosFamilia loadDoc = new tblCorreosFamilia();

            loadDoc.id_Correo = doc.id_Correo;
            return metodos.EliminarCorreoFamilia(loadDoc);
        }

        public List<CorreosFamiliaViews> ConsultarCorreosPorFamilia(string doc_cliente)
        {
            return metodos.ConsultarCorreosPorFamilia(doc_cliente);
        }

        public List<CorreosFamiliaViews> ConsultarCorreoPorIdFamiliar(int id_novedad)
        {
            return metodos.ConsultarCorreoPorIdFamiliar(id_novedad);
        }

    }
}
