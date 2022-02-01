using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class FamiliaController
    {
        Models.Metodos metodos = new Models.Metodos();

        public bool Guardar(FamiliaViews fal)
        {
            tblFamilia familia = new tblFamilia();

            familia.id_Familiar = fal.id_Familiar;
            familia.Numero_Documento_Cliente = fal.Numero_Documento_Cliente;
            familia.Parentesco = fal.Parentesco;
            familia.Primer_Nombre = fal.Primer_Nombre;
            familia.Segundo_Nombre = fal.Segundo_Nombre;
            familia.Otro_Nombre = fal.Otro_Nombre;
            familia.Primer_Apellido = fal.Primer_Apellido;
            familia.Segundo_Apellido = fal.Segundo_Apellido;
            familia.Tipo_Documento = fal.Tipo_Documento;
            familia.Numero_Documento = fal.Numero_Documento;
            familia.Departamento_Expedicion = fal.Departamento_Expedicion;
            familia.Ciudad_Expedicion = fal.Ciudad_Expedicion;
            familia.Otro_Lugar_Expedicion = fal.Otro_Lugar_Expedicion;
            familia.Fecha_Nacimiento = fal.Fecha_Nacimiento;
            familia.Tipo_Registro = fal.Tipo_Registro;
            familia.Nombre_Lugar_Registro = fal.Nombre_Lugar_Registro;
            familia.Departamento_Registro = fal.Departamento_Registro;
            familia.Ciudad_Registro = fal.Ciudad_Registro;
            familia.Otro_Lugar_Registro = fal.Otro_Lugar_Registro;
            familia.Telefono_Fijo = fal.Telefono_Fijo;
            familia.Telefono_Celular = fal.Telefono_Celular;
            familia.Correo = fal.Correo;
            familia.Red_Social = fal.Red_Social;
            familia.Nombre_Red_Social = fal.Nombre_Red_Social;
            familia.Departamento_Residencia = fal.Departamento_Residencia;
            familia.Ciudad_Residencia = fal.Ciudad_Residencia;
            familia.Otro_Lugar_Residencia = fal.Otro_Lugar_Residencia;
            familia.Casa_Propia = fal.Casa_Propia;
            familia.Direccion_Residencia = fal.Direccion_Residencia;
            familia.Barrio = fal.Barrio;
            familia.Estado_Proceso = fal.Estado_Proceso;
            familia.Etapa_Proceso = fal.Etapa_Proceso;
            familia.Fecha_Autenticacion = fal.Fecha_Autenticacion;
            familia.Fecha_Creacion = fal.Fecha_Creacion;
            familia.Fecha_Actualizacion = fal.Fecha_Actualizacion;
            familia.Usurio = fal.Usurio;
            return metodos.GuardarFamiliar(familia);
        }

        public bool Modificar(FamiliaViews fal)
        {
            tblFamilia familia = new tblFamilia();

            familia.id_Familiar = fal.id_Familiar;
            familia.Numero_Documento_Cliente = fal.Numero_Documento_Cliente;
            familia.Parentesco = fal.Parentesco;
            familia.Primer_Nombre = fal.Primer_Nombre;
            familia.Segundo_Nombre = fal.Segundo_Nombre;
            familia.Otro_Nombre = fal.Otro_Nombre;
            familia.Primer_Apellido = fal.Primer_Apellido;
            familia.Segundo_Apellido = fal.Segundo_Apellido;
            familia.Tipo_Documento = fal.Tipo_Documento;
            familia.Numero_Documento = fal.Numero_Documento;
            familia.Departamento_Expedicion = fal.Departamento_Expedicion;
            familia.Ciudad_Expedicion = fal.Ciudad_Expedicion;
            familia.Otro_Lugar_Expedicion = fal.Otro_Lugar_Expedicion;
            familia.Fecha_Nacimiento = fal.Fecha_Nacimiento;
            familia.Tipo_Registro = fal.Tipo_Registro;
            familia.Nombre_Lugar_Registro = fal.Nombre_Lugar_Registro;
            familia.Departamento_Registro = fal.Departamento_Registro;
            familia.Ciudad_Registro = fal.Ciudad_Registro;
            familia.Otro_Lugar_Registro = fal.Otro_Lugar_Registro;
            familia.Telefono_Fijo = fal.Telefono_Fijo;
            familia.Telefono_Celular = fal.Telefono_Celular;
            familia.Correo = fal.Correo;
            familia.Red_Social = fal.Red_Social;
            familia.Nombre_Red_Social = fal.Nombre_Red_Social;
            familia.Departamento_Residencia = fal.Departamento_Residencia;
            familia.Ciudad_Residencia = fal.Ciudad_Residencia;
            familia.Otro_Lugar_Residencia = fal.Otro_Lugar_Residencia;
            familia.Casa_Propia = fal.Casa_Propia;
            familia.Direccion_Residencia = fal.Direccion_Residencia;
            familia.Barrio = fal.Barrio;
            familia.Estado_Proceso = fal.Estado_Proceso;
            familia.Etapa_Proceso = fal.Etapa_Proceso;
            familia.Fecha_Autenticacion = fal.Fecha_Autenticacion;
            familia.Fecha_Creacion = fal.Fecha_Creacion;
            familia.Fecha_Actualizacion = fal.Fecha_Actualizacion;
            familia.Usurio = fal.Usurio;

             return metodos.ModificarFamiliar(familia);
        }

        public List<FamiliaViews> ConsultarTodosLosFamiliares()
        {

            return metodos.ConsultarTodosLosFamiliares();

        }

        public List<FamiliaViews> ConsultarFamiliarNumeroDocumento(string value)
        {
            return metodos.ConsultarFamiliarNumeroDocumento(value);
        }

        public List<FamiliaViews> ConsultarFamiliaresPorCliente(string value)
        {
            return metodos.ConsultarFamiliaresPorCliente(value);
        }

        public bool ValidarSiFamiliarExiste(string value_Numero_Documento_Familiar)
        {
            return metodos.ValidarSiFamiliarExiste(value_Numero_Documento_Familiar);

        }

    }
}
