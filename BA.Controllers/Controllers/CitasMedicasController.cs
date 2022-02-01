using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class CitasMedicasController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarCita(CitasMedicasViews doc)
        {
            tblCitasMedicas loadDoc = new tblCitasMedicas();

            loadDoc.id_Cita = doc.id_Cita;
            loadDoc.id_Concepto = doc.id_Concepto;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Tipo_Cita = doc.Tipo_Cita;
            loadDoc.Fecha_Cita = doc.Fecha_Cita;
            loadDoc.Dispensario = doc.Dispensario;
            loadDoc.Nombre_Doctor = doc.Nombre_Doctor;
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Estado_Cita = doc.Estado_Cita;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarCita(loadDoc);
        }

        public bool ModificarCita(CitasMedicasViews doc)
        {
            tblCitasMedicas loadDoc = new tblCitasMedicas();

            loadDoc.id_Cita = doc.id_Cita;
            loadDoc.id_Concepto = doc.id_Concepto;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Tipo_Cita = doc.Tipo_Cita;
            loadDoc.Fecha_Cita = doc.Fecha_Cita;
            loadDoc.Dispensario = doc.Dispensario;
            loadDoc.Nombre_Doctor = doc.Nombre_Doctor;
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Estado_Cita = doc.Estado_Cita;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarCita(loadDoc);
        }

        public bool EliminarCita(CitasMedicasViews doc)
        {
            tblCitasMedicas loadDoc = new tblCitasMedicas();

            loadDoc.id_Cita = doc.id_Cita;
            return metodos.EliminarCita(loadDoc);
        }

        public List<CitasMedicasViews> ConsultarCitaPorCliente(string doc_cliente)
        {
            return metodos.ConsultarCitaPorCliente(doc_cliente);
        }

        public List<CitasMedicasViews> ConsultarCitapPorId(int id_novedad)
        {
            return metodos.ConsultarCitapPorId(id_novedad);
        }
        public string AbrirAdjuntoCita(int id_novedad)
        {
            return metodos.AbrirAdjuntoCita(id_novedad);
        }
    }
}
