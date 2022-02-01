using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class CarteraViews
    {
        public int id_Cartera { get; set; }
        public string Doc_Cliente { get; set; }
        public string Sobre { get; set; }
        public string Titulo_Valor { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public double Valor { get; set; }
        public bool Documento_Activo { get; set; }
        public double Suma_Total { get; set; }
        public Nullable<bool> Adjuntar_Archivo { get; set; }
        public string Nombre_Archivo { get; set; }
        public string Ruta { get; set; }
        public string Estado_Cuenta { get; set; }
        public System.DateTime Fecha_Subido { get; set; }
        public System.DateTime fecha_Actualizado { get; set; }
        public string Usuario { get; set; }
    }
}
