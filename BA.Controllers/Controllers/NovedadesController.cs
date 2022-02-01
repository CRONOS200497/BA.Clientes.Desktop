using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class NovedadesController
    {
        Models.Metodos metodos = new Models.Metodos();

        public bool GuardarNovedad(NovedadesViews doc)
        {
            tblNovedades loadDoc = new tblNovedades();

            loadDoc.Id_Novedad = doc.Id_Novedad;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Tipo_Novedad = doc.Tipo_Novedad;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarNovedad(loadDoc);
        }

        public bool ModificarNovedad(NovedadesViews doc)
        {
            tblNovedades loadDoc = new tblNovedades();

            loadDoc.Id_Novedad = doc.Id_Novedad;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Tipo_Novedad = doc.Tipo_Novedad;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarNovedad(loadDoc);
        }

        public bool EliminarNovedades(NovedadesViews doc)
        {
            tblNovedades loadDoc = new tblNovedades();

            loadDoc.Id_Novedad = doc.Id_Novedad;
            return metodos.EliminarNovedades(loadDoc);
        }

        public List<NovedadesViews> ConsultarNovedadesPorCliente(string doc_cliente)
        {
            return metodos.ConsultarNovedadesPorCliente(doc_cliente);

        }

        public List<NovedadesViews> ConsultarNovedadPorId(int id_novedad)
        {
            return metodos.ConsultarNovedadPorId(id_novedad);
        }
        public string AbrirAdjuntoNovedad(int id_novedad)
        {
            return metodos.AbrirAdjuntoNovedad(id_novedad);
        }
    }
}
