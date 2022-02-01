using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class DocumentosCargadosController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarDocumentosClientes(DocumentosCargadosViews doc)
        {

            tblDocumentosCargados loadDoc = new tblDocumentosCargados();
            loadDoc.id_Archivo = doc.id_Archivo;
            loadDoc.doc_cliente = doc.doc_cliente;
            loadDoc.tipo_doc = doc.tipo_doc;
            loadDoc.nombre_archivo = doc.nombre_archivo;
            loadDoc.ruta = doc.ruta;
            loadDoc.fecha_subido = doc.fecha_subido;
            loadDoc.fecha_actualizado = doc.fecha_actualizado;
            loadDoc.informar_cliente = doc.informar_cliente;
            loadDoc.usuario = doc.usuario;

            return metodos.GuardarDocumentosClientes(loadDoc);

        }

        public bool ModificarDocumentosClientes(DocumentosCargadosViews doc)
        {
            tblDocumentosCargados loadDoc = new tblDocumentosCargados();
            loadDoc.id_Archivo = doc.id_Archivo;
            loadDoc.doc_cliente = doc.doc_cliente;
            loadDoc.tipo_doc = doc.tipo_doc;
            loadDoc.nombre_archivo = doc.nombre_archivo;
            loadDoc.ruta = doc.ruta;
            loadDoc.fecha_subido = doc.fecha_subido;
            loadDoc.fecha_actualizado = doc.fecha_actualizado;
            loadDoc.informar_cliente = doc.informar_cliente;
            loadDoc.usuario = doc.usuario;

            return metodos.ModificarDocumentosClientes(loadDoc);
        }

        public List<DocumentosCargadosViews> ConsultarDocumentosClientes(string value)
        {
            return metodos.ConsultarDocumentosClientes(value);
        }

        public string AbrirDocumentoCliente(int id_Archivo)
        {
            return metodos.AbrirDocumentoCliente(id_Archivo);

        }

        public bool EliminarDocumentosClientes(int id_archivo)
        {

            tblDocumentosCargados loadDoc = new tblDocumentosCargados();

            loadDoc.id_Archivo = id_archivo;
          
            return metodos.EliminarDocumentosClientes(loadDoc);

        }

        public List<DocumentosCargadosViews> ConsultarDocumentoClienteID(int value)
        {
            return metodos.ConsultarDocumentoClienteID(value);
        }
    }
}