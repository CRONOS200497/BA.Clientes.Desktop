using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class SeguimientoFamiliarController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarSeguimientoFamiliar(SeguimientoFamiliarViews doc)
        {
            tblSeguimientoFamiliar loadDoc = new tblSeguimientoFamiliar();

            loadDoc.ID_Seguimiento = doc.ID_Seguimiento;
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Tipo_Seguimiento = doc.Tipo_Seguimiento;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Seguimiento = doc.Fecha_Seguimiento;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarSeguimientoFamiliar(loadDoc);
        }

        public bool ModificarSeguimientoFamiliar(SeguimientoFamiliarViews doc)
        {
            tblSeguimientoFamiliar loadDoc = new tblSeguimientoFamiliar();

            loadDoc.ID_Seguimiento = doc.ID_Seguimiento;
            loadDoc.Doc_Familiar = doc.Doc_Familiar;
            loadDoc.Tipo_Seguimiento = doc.Tipo_Seguimiento;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Seguimiento = doc.Fecha_Seguimiento;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;

            return metodos.ModificarSeguimientoFamiliar(loadDoc);
        }
        public bool EliminarSeguimientoFamiliar(SeguimientoFamiliarViews doc)
        {
            tblSeguimientoFamiliar loadDoc = new tblSeguimientoFamiliar();

            loadDoc.ID_Seguimiento = doc.ID_Seguimiento;
            return metodos.EliminarSeguimientoFamiliar(loadDoc);
        }

        public List<SeguimientoFamiliarViews> ConsultarSeguimientoPorFamiliar(string doc_cliente)
        {
            return metodos.ConsultarSeguimientoPorFamiliar(doc_cliente);

        }

        public List<SeguimientoFamiliarViews> ConsultarSeguimientoPorIdFamiliar(int id_novedad)
        {
            return metodos.ConsultarSeguimientoPorIdFamiliar(id_novedad);
        }
        public string AbrirAdjuntoSeguimientoFamiliar(int id_novedad)
        {
            return metodos.AbrirAdjuntoSeguimientoFamiliar(id_novedad);
        }

    }
}
