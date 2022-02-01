using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
   public class JuntasMedicasController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarJunta(JuntasMedicasViews doc)
        {
            tblJuntasMedicas loadDoc = new tblJuntasMedicas();

            loadDoc.id_Junta = doc.id_Junta;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Fecha_Junta = doc.Fecha_Junta;
            loadDoc.Estado_Junta_Medica = doc.Estado_Junta_Medica;
            loadDoc.Dispensario = doc.Dispensario;            
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Direccion = doc.Direccion;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarJunta(loadDoc);
        }

        public bool ModificarJunta(JuntasMedicasViews doc)
        {
            tblJuntasMedicas loadDoc = new tblJuntasMedicas();

            loadDoc.id_Junta = doc.id_Junta;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Fecha_Junta = doc.Fecha_Junta;
            loadDoc.Estado_Junta_Medica = doc.Estado_Junta_Medica;
            loadDoc.Dispensario = doc.Dispensario;
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Direccion = doc.Direccion;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarJunta(loadDoc);
        }

        public bool EliminarJunta(JuntasMedicasViews doc)
        {
            tblJuntasMedicas loadDoc = new tblJuntasMedicas();

            loadDoc.id_Junta = doc.id_Junta;
            return metodos.EliminarJunta(loadDoc);
        }

        public List<JuntasMedicasViews> ConsultarJuntaPorCliente(string doc_cliente)
        {
            return metodos.ConsultarJuntaPorCliente(doc_cliente);
        }

        public List<JuntasMedicasViews> ConsultarJuntaPorId(int id_novedad)
        {
            return metodos.ConsultarJuntaPorId(id_novedad);
        }
        public string AbrirAdjuntoJunta(int id_novedad)
        {
            return metodos.AbrirAdjuntoJunta(id_novedad);
        }
    }
}
