using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class TelefonosClientesController
    {

        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarTelefono(TelefonosClientesViews doc)
        {
            tblTelefonosClientes loadDoc = new tblTelefonosClientes();

            loadDoc.id_Telefono = doc.id_Telefono;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Numero_Telefono = doc.Numero_Telefono;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarTelefono(loadDoc);
        }

        public bool ModificarTelefono(TelefonosClientesViews doc)
        {
            tblTelefonosClientes loadDoc = new tblTelefonosClientes();

            loadDoc.id_Telefono = doc.id_Telefono;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Numero_Telefono = doc.Numero_Telefono;
            loadDoc.Fecha_Insertado = doc.Fecha_Insertado;
            loadDoc.Fecha_Actualizado = doc.Fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarTelefono(loadDoc);
        }

        public bool EliminarTelefono(TelefonosClientesViews doc)
        {
            tblTelefonosClientes loadDoc = new tblTelefonosClientes();
            loadDoc.id_Telefono = doc.id_Telefono;
            return metodos.EliminarTelefono(loadDoc);
        }

        public List<TelefonosClientesViews> ConsultarTelefonosPorCliente(string doc_cliente)
        {
            return metodos.ConsultarTelefonosPorCliente(doc_cliente);
        }

        public List<TelefonosClientesViews> ConsultarTelefonoPorId(int id_novedad)
        {
            return metodos.ConsultarTelefonoPorId(id_novedad);
        }

    }
}
