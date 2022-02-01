﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Models.Entidades
{
    public class CitasMedicasViews
    {
        public int id_Cita { get; set; }
        public int id_Concepto { get; set; }
        public string Doc_Cliente { get; set; }
        public string Fuerza { get; set; }
        public string Tipo_Cita { get; set; }
        public System.DateTime Fecha_Cita { get; set; }
        public string Dispensario { get; set; }
        public string Nombre_Doctor { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Otro_Lugar { get; set; }
        public bool Adjuntar_Documento { get; set; }
        public string Nombre_Archivo { get; set; }
        public string Ruta { get; set; }
        public string Estado_Cita { get; set; }
        public bool Informar_Cliente { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime Fecha_Cargado { get; set; }
        public System.DateTime Fecha_Modificado { get; set; }
        public string Usuario { get; set; }

    }
}
