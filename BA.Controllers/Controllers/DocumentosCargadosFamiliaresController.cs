using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class DocumentosCargadosFamiliaresController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarDocumentosFamilia(DocumentosCargadosFamiliaViews doc)
        {

            tblDocumentosCargadosFamilia loadDoc = new tblDocumentosCargadosFamilia();

            loadDoc.id_Archivo = doc.id_Archivo;
            loadDoc.doc_cliente = doc.doc_cliente;
            loadDoc.tipo_doc = doc.tipo_doc;
            loadDoc.nombre_archivo = doc.nombre_archivo;
            loadDoc.ruta = doc.ruta;
            loadDoc.fecha_subido = doc.fecha_subido;
            loadDoc.fecha_actualizado = doc.fecha_actualizado;
            loadDoc.informar_cliente = doc.informar_cliente;
            loadDoc.usuario = doc.usuario;
            return metodos.GuardarDocumentosFamilia(loadDoc);

        }

        public bool ModificarDocumentosFamilia(DocumentosCargadosFamiliaViews doc)
        {
            tblDocumentosCargadosFamilia loadDoc = new tblDocumentosCargadosFamilia();

            loadDoc.id_Archivo = doc.id_Archivo;
            loadDoc.doc_cliente = doc.doc_cliente;
            loadDoc.tipo_doc = doc.tipo_doc;
            loadDoc.nombre_archivo = doc.nombre_archivo;
            loadDoc.ruta = doc.ruta;
            loadDoc.fecha_subido = doc.fecha_subido;
            loadDoc.fecha_actualizado = doc.fecha_actualizado;
            loadDoc.informar_cliente = doc.informar_cliente;
            loadDoc.usuario = doc.usuario;
            return metodos.ModificarDocumentosFamilia(loadDoc);
        }

        public List<DocumentosCargadosFamiliaViews> ConsultarDocumentosFamilia(string value)
        {
            return metodos.ConsultarDocumentosFamilia(value);
        }

        public string AbrirDocumentoFamilia(int id_Archivo)
        {
            return metodos.AbrirDocumentoFamilia(id_Archivo);
        }

        public bool EliminarDocumentosFamilia(int id_archivo)
        {
            tblDocumentosCargadosFamilia loadDoc = new tblDocumentosCargadosFamilia();
            loadDoc.id_Archivo = id_archivo;
            return metodos.EliminarDocumentosFamilia(loadDoc);
        }

        public List<DocumentosCargadosFamiliaViews> ConsultarDocumentoFamiliaID(int value)
        {
            return metodos.ConsultarDocumentoFamiliaID(value);
        }
    }
}
