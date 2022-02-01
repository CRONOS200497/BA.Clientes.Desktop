using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class NovedadesFamiliaController
    {
        Models.Metodos metodos = new Models.Metodos();

        public bool GuardarNovedadFamiliar(NovedadesFamiliaViews doc)
        {
            tblNovedadesFamilia loadDoc = new tblNovedadesFamilia();

            loadDoc.Id_Novedad = doc.Id_Novedad;
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Tipo_Novedad = doc.Tipo_Novedad;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarNovedadFamiliar(loadDoc);
        }

        public bool ModificarNovedadFamiliar(NovedadesFamiliaViews doc)
        {
            tblNovedadesFamilia loadDoc = new tblNovedadesFamilia();

            loadDoc.Id_Novedad = doc.Id_Novedad;
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Tipo_Novedad = doc.Tipo_Novedad;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Subido = doc.Fecha_Subido;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarNovedadFamiliar(loadDoc);
        }
        public bool EliminarNovedadesFamiliar(NovedadesFamiliaViews doc)
        {
            tblNovedadesFamilia loadDoc = new tblNovedadesFamilia();

            loadDoc.Id_Novedad = doc.Id_Novedad;
            return metodos.EliminarNovedadesFamiliar(loadDoc);
        }

        public List<NovedadesFamiliaViews> ConsultarNovedadesPorFamiliar(string doc_cliente)
        {
            return metodos.ConsultarNovedadesPorFamiliar(doc_cliente);

        }

        public List<NovedadesFamiliaViews> ConsultarNovedadPorIdFamiliar(int id_novedad)
        {
            return metodos.ConsultarNovedadPorIdFamiliar(id_novedad);
        }
        public string AbrirAdjuntoNovedadFamiliar(int id_novedad)
        {
            return metodos.AbrirAdjuntoNovedadFamiliar(id_novedad);
        }

    }
}
