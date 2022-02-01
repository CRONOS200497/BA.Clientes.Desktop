using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class SeguimientoClienteController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarSeguimiento(SeguimientoClienteViews doc)
        {
            tblSeguimientoCliente loadDoc = new tblSeguimientoCliente();

            loadDoc.ID_Seguimiento = doc.ID_Seguimiento;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Tipo_Seguimiento = doc.Tipo_Seguimiento;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Seguimiento = doc.Fecha_Seguimiento;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarSeguimiento(loadDoc);
        }

        public bool ModificarSeguimiento(SeguimientoClienteViews doc)
        {
            tblSeguimientoCliente loadDoc = new tblSeguimientoCliente();

            loadDoc.ID_Seguimiento = doc.ID_Seguimiento;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Tipo_Seguimiento = doc.Tipo_Seguimiento;
            loadDoc.Descripcion = doc.Descripcion;
            loadDoc.Adjuntar_Archivo = doc.Adjuntar_Archivo;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Fecha_Seguimiento = doc.Fecha_Seguimiento;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarSeguimiento(loadDoc);
        }

        public bool EliminarSeguimiento(SeguimientoClienteViews doc)
        {
            tblSeguimientoCliente loadDoc = new tblSeguimientoCliente();

            loadDoc.ID_Seguimiento = doc.ID_Seguimiento;
            return metodos.EliminarSeguimiento(loadDoc);
        }

        public List<SeguimientoClienteViews> ConsultarSeguimientoPorCliente(string doc_cliente)
        {
            return metodos.ConsultarSeguimientoPorCliente(doc_cliente);
        }

        public List<SeguimientoClienteViews> ConsultarSeguimientoPorId(int id_novedad)
        {
            return metodos.ConsultarSeguimientoPorId(id_novedad);
        }
        public string AbrirAdjuntoSeguimiento(int id_novedad)
        {
            return metodos.AbrirAdjuntoSeguimiento(id_novedad);
        }
    }
}
