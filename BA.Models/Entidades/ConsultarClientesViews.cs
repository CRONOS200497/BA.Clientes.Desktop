using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class ConsultarClientesViews
    {
        public int id_Cliente { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Otro_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Tipo_Documento { get; set; }
        public string Numero_Documento_Cliente { get; set; }
        public string Departamento_Expedicion { get; set; }
        public string Ciudad_Expedicion { get; set; }
        public string Otro_Lugar_Expedicion { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Tipo_Registro { get; set; }
        public string Nombre_Lugar_Registro { get; set; }
        public string Departamento_Registro { get; set; }
        public string Ciudad_Registro { get; set; }
        public string Otro_Lugar_Registro { get; set; }
        public string Telefono_Fijo { get; set; }
        public string Telefono_Celular { get; set; }
        public string Correo { get; set; }
        public string Red_Social { get; set; }
        public string Nombre_Red_Social { get; set; }
        public string Departamento_Residencia { get; set; }
        public string Ciudad_Residencia { get; set; }
        public string Otro_Lugar_Residencia { get; set; }
        public bool Casa_Propia { get; set; }
        public string Direccion_Residencia { get; set; }
        public string Barrio { get; set; }
        public string Fuerza { get; set; }
        public string Grado { get; set; }
        public System.DateTime Fecha_Ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_Salida { get; set; }
        public int Año_Contingente { get; set; }
        public int Numero_Contigente { get; set; }
        public string Batallon { get; set; }
        public System.DateTime Fecha_Hechos { get; set; }
        public string Dispensario { get; set; }
        public string Estado_Proceso { get; set; }
        public string Etapa_Proceso { get; set; }
        public System.DateTime Fecha_Autenticado { get; set; }
        public System.DateTime Fecha_Creado { get; set; }
        public System.DateTime Fecha_Actualizado { get; set; }
        public string Usurio { get; set; }


    }
}
