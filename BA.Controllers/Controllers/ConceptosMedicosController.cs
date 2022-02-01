using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class ConceptosMedicosController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarConcepto(ConceptosMedicosViews doc)
        {
            tblConceptosMedicos loadDoc = new tblConceptosMedicos();

            loadDoc.id_Concepto = doc.id_Concepto;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Tipo_Concepto = doc.Tipo_Concepto;
            loadDoc.Fecha_Emision = doc.Fecha_Emision;
            loadDoc.Dispensario = doc.Dispensario;
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Estado_Concepto = doc.Estado_Concepto;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarConcepto(loadDoc);
        }

        public bool ModificarConcepto(ConceptosMedicosViews doc)
        {
            tblConceptosMedicos loadDoc = new tblConceptosMedicos();

            loadDoc.id_Concepto = doc.id_Concepto;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Tipo_Concepto = doc.Tipo_Concepto;
            loadDoc.Fecha_Emision = doc.Fecha_Emision;
            loadDoc.Dispensario = doc.Dispensario;
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Estado_Concepto = doc.Estado_Concepto;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarConcepto(loadDoc);
        }

        public bool EliminarConcepto(ConceptosMedicosViews doc)
        {
            tblConceptosMedicos loadDoc = new tblConceptosMedicos();

            loadDoc.id_Concepto = doc.id_Concepto;
            return metodos.EliminarConcepto(loadDoc);
        }

        public List<ConceptosMedicosViews> ConsultarConceptoPorCliente(string doc_cliente)
        {
            return metodos.ConsultarConceptoPorCliente(doc_cliente);
        }

        public List<ConceptosMedicosViews> ConsultarConceptoParaAsignarCita(string doc_cliente)
        {
            return metodos.ConsultarConceptoParaAsignarCita(doc_cliente);
        }

        public List<ConceptosMedicosViews> ConsultarConceptopPorId(int id_novedad)
        {
            return metodos.ConsultarConceptopPorId(id_novedad);
        }
        public string AbrirAdjuntoConcepto(int id_novedad)
        {
            return metodos.AbrirAdjuntoConcepto(id_novedad);
        }
    }
}
