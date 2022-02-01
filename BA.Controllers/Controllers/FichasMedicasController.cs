using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class FichasMedicasController
    {
        BA.Models.Metodos metodos = new Models.Metodos();

        public bool GuardarFichas(FichasMedicasViews doc)
        {
            tblFichasMedicas loadDoc = new tblFichasMedicas();

            loadDoc.id_Ficha = doc.id_Ficha;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Estado_Ficha_Medica = doc.Estado_Ficha_Medica;
            loadDoc.Dispensario = doc.Dispensario;
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Fecha_Salida = doc.Fecha_Salida;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.GuardarFichas(loadDoc);
        }

        public bool ModificarFichas(FichasMedicasViews doc)
        {
            tblFichasMedicas loadDoc = new tblFichasMedicas();

            loadDoc.id_Ficha = doc.id_Ficha;
            loadDoc.Doc_Cliente = doc.Doc_Cliente;
            loadDoc.Fuerza = doc.Fuerza;
            loadDoc.Estado_Ficha_Medica = doc.Estado_Ficha_Medica;
            loadDoc.Dispensario = doc.Dispensario;
            loadDoc.Departamento = doc.Departamento;
            loadDoc.Ciudad = doc.Ciudad;
            loadDoc.Otro_Lugar = doc.Otro_Lugar;
            loadDoc.Fecha_Salida = doc.Fecha_Salida;
            loadDoc.Adjuntar_Documento = doc.Adjuntar_Documento;
            loadDoc.Nombre_Archivo = doc.Nombre_Archivo;
            loadDoc.Ruta = doc.Ruta;
            loadDoc.Informar_Cliente = doc.Informar_Cliente;
            loadDoc.Observaciones = doc.Observaciones;
            loadDoc.Fecha_Cargado = doc.Fecha_Cargado;
            loadDoc.Fecha_Modificado = doc.Fecha_Modificado;
            loadDoc.Usuario = doc.Usuario;
            return metodos.ModificarFichas(loadDoc);
        }

        public bool EliminarFichas(FichasMedicasViews doc)
        {
            tblFichasMedicas loadDoc = new tblFichasMedicas();

            loadDoc.id_Ficha = doc.id_Ficha;
            return metodos.EliminarFichas(loadDoc);
        }

        public List<FichasMedicasViews> ConsultarFichasPorCliente(string doc_cliente)
        {
            return metodos.ConsultarFichasPorCliente(doc_cliente);
        }

        public List<FichasMedicasViews> ConsultarFichaPorId(int id_novedad)
        {
            return metodos.ConsultarFichaPorId(id_novedad);
        }

        public string AbrirAdjuntoFicha(int id_novedad)
        {
            return metodos.AbrirAdjuntoFicha(id_novedad);
        }
    }
}
