using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class CarteraController
    {
        BA.Models.Metodos metodos = new Models.Metodos();
        public bool GuardarCartera(CarteraViews doc)
        {
            tblCartera loadDoc = new tblCartera();

            loadDoc.id_Cartera = doc.id_Cartera;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Sobre = doc.Sobre;
            loadDoc.Titulo_Valor = doc.Titulo_Valor;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Fecha = doc.Fecha;
            loadDoc.Valor = doc.Valor;
            loadDoc.Documento_Activo = doc.Documento_Activo;
            loadDoc.Suma_Total = doc.Suma_Total;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Estado_Cuenta = doc.Estado_Cuenta;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.fecha_Actualizado = doc.fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarCartera(loadDoc);
        }

        public bool ModificarCartera(CarteraViews doc)
        {
            tblCartera loadDoc = new tblCartera();

            loadDoc.id_Cartera = doc.id_Cartera;        
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Sobre = doc.Sobre;
            loadDoc.Titulo_Valor = doc.Titulo_Valor;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Fecha = doc.Fecha;
            loadDoc.Valor = doc.Valor;
            loadDoc.Documento_Activo = doc.Documento_Activo;
            loadDoc.Suma_Total = doc.Suma_Total;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Estado_Cuenta = doc.Estado_Cuenta;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.fecha_Actualizado = doc.fecha_Actualizado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarCartera(loadDoc);
        }

        public bool EliminarCartera(CarteraViews doc)
        {
            tblCartera loadDoc = new tblCartera();

            loadDoc.id_Cartera = doc.id_Cartera;
            return metodos.EliminarCartera(loadDoc);
        }

        public bool ConsultarEstadoDocumento(int id_doc)
        {           
            return metodos.ConsultarEstadoDocumento(id_doc);
        }

        public List<CarteraViews> ConsultarCarteraPorCliente(string doc_cliente)
        {
            return metodos.ConsultarCarteraPorCliente(doc_cliente);
        }

        public List<CarteraViews> ConsultarCarterapPorId(int id_novedad)
        {
            return metodos.ConsultarCarterapPorId(id_novedad);
        }
        public string AbrirAdjuntoCartera(int id_novedad)
        {
            return metodos.AbrirAdjuntoCartera(id_novedad);
        }

    }
}
