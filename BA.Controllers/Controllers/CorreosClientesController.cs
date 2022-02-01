using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class CorreosClientesController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarCorreo(CorreosClientesViews doc)
        {
            tblCorreosClientes loadDoc = new tblCorreosClientes();

            loadDoc.id_Correo = doc.id_Correo;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Correo = doc.Correo;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarCorreo(loadDoc);
        }

        public bool ModificarCorreo(CorreosClientesViews doc)
        {
            tblCorreosClientes loadDoc = new tblCorreosClientes();

            loadDoc.id_Correo = doc.id_Correo;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Correo = doc.Correo;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarCorreo(loadDoc);
        }

        public bool EliminarCorreo(CorreosClientesViews doc)
        {
            tblCorreosClientes loadDoc = new tblCorreosClientes();

            loadDoc.id_Correo = doc.id_Correo;
            return metodos.EliminarCorreo(loadDoc);
        }

        public List<CorreosClientesViews> ConsultarCorreosPorCliente(string doc_cliente)
        {
            return metodos.ConsultarCorreosPorCliente(doc_cliente);
        }

        public List<CorreosClientesViews> ConsultarCorreoPorId(int id_novedad)
        {
            return metodos.ConsultarCorreoPorId(id_novedad);
        }
    }
}
