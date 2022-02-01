using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Models.Entidades;
using BA.Models.Models;

namespace BA.Controllers.Controllers
{
    public class ClientesController
    {

        Models.Metodos metodos = new Models.Metodos();

        public bool Guardar(ClientesViews cli)
        {
            tblClientes tblC = new tblClientes();

            //tblC.id_Cliente = cli.id_Cliente;
            tblC.Primer_Nombre = cli.Primer_Nombre;
            tblC.Segundo_Nombre = cli.Segundo_Nombre;
            tblC.Otro_Nombre = cli.Otro_Nombre;
            tblC.Primer_Apellido = cli.Primer_Apellido;
            tblC.Segundo_Apellido = cli.Segundo_Apellido;
            tblC.Tipo_Documento = cli.Tipo_Documento;
            tblC.Numero_Documento_Cliente = cli.Numero_Documento_Cliente;
            tblC.Departamento_Expedicion = cli.Departamento_Expedicion;
            tblC.Ciudad_Expedicion = cli.Ciudad_Expedicion;
            tblC.Otro_Lugar_Expedicion = cli.Otro_Lugar_Expedicion;
            tblC.Fecha_Nacimiento = cli.Fecha_Nacimiento;
            tblC.Tipo_Registro = cli.Tipo_Registro;
            tblC.Nombre_Lugar_Registro = cli.Nombre_Lugar_Registro;
            tblC.Departamento_Registro = cli.Departamento_Registro;
            tblC.Ciudad_Registro = cli.Ciudad_Registro;
            tblC.Otro_Lugar_Registro = cli.Otro_Lugar_Registro;
            tblC.Telefono_Fijo = cli.Telefono_Fijo;
            tblC.Telefono_Celular = cli.Telefono_Celular;
            tblC.Correo = cli.Correo;
            tblC.Red_Social = cli.Red_Social;
            tblC.Nombre_Red_Social = cli.Nombre_Red_Social;
            tblC.Departamento_Residencia = cli.Departamento_Residencia;
            tblC.Ciudad_Residencia = cli.Ciudad_Residencia;
            tblC.Otro_Lugar_Residencia = cli.Otro_Lugar_Residencia;
            tblC.Casa_Propia = cli.Casa_Propia;
            tblC.Direccion_Residencia = cli.Direccion_Residencia;
            tblC.Barrio = cli.Barrio;
            tblC.Fuerza = cli.Fuerza;
            tblC.Grado = cli.Grado;
            tblC.Fecha_Ingreso = cli.Fecha_Ingreso;
            tblC.Fecha_Salida = cli.Fecha_Salida;
            tblC.Año_Contingente = cli.Año_Contingente;
            tblC.Numero_Contigente = cli.Numero_Contigente;
            tblC.Batallon = cli.Batallon;
            tblC.Fecha_Hechos = cli.Fecha_Hechos;
            tblC.Dispensario = cli.Dispensario;
            tblC.Estado_Proceso = cli.Estado_Proceso;
            tblC.Etapa_Proceso = cli.Etapa_Proceso;
            tblC.Fecha_Autenticado = cli.Fecha_Autenticado;
            tblC.Fecha_Creado = cli.Fecha_Creado;
            tblC.Fecha_Actualizado = cli.Fecha_Actualizado;
            tblC.Usurio = cli.Usurio;

            return metodos.Guardar(tblC);
        }

        public bool Modificar(ClientesViews cli)
        {
            tblClientes tblC = new tblClientes();

            tblC.id_Cliente = cli.id_Cliente;
            tblC.Primer_Nombre = cli.Primer_Nombre;
            tblC.Segundo_Nombre = cli.Segundo_Nombre;
            tblC.Otro_Nombre = cli.Otro_Nombre;
            tblC.Primer_Apellido = cli.Primer_Apellido;
            tblC.Segundo_Apellido = cli.Segundo_Apellido;
            tblC.Tipo_Documento = cli.Tipo_Documento;
            tblC.Numero_Documento_Cliente = cli.Numero_Documento_Cliente;
            tblC.Departamento_Expedicion = cli.Departamento_Expedicion;
            tblC.Ciudad_Expedicion = cli.Ciudad_Expedicion;
            tblC.Otro_Lugar_Expedicion = cli.Otro_Lugar_Expedicion;
            tblC.Fecha_Nacimiento = cli.Fecha_Nacimiento;
            tblC.Tipo_Registro = cli.Tipo_Registro;
            tblC.Nombre_Lugar_Registro = cli.Nombre_Lugar_Registro;
            tblC.Departamento_Registro = cli.Departamento_Registro;
            tblC.Ciudad_Registro = cli.Ciudad_Registro;
            tblC.Otro_Lugar_Registro = cli.Otro_Lugar_Registro;
            tblC.Telefono_Fijo = cli.Telefono_Fijo;
            tblC.Telefono_Celular = cli.Telefono_Celular;
            tblC.Correo = cli.Correo;
            tblC.Red_Social = cli.Red_Social;
            tblC.Nombre_Red_Social = cli.Nombre_Red_Social;
            tblC.Departamento_Residencia = cli.Departamento_Residencia;
            tblC.Ciudad_Residencia = cli.Ciudad_Residencia;
            tblC.Otro_Lugar_Residencia = cli.Otro_Lugar_Residencia;
            tblC.Casa_Propia = cli.Casa_Propia;
            tblC.Direccion_Residencia = cli.Direccion_Residencia;
            tblC.Barrio = cli.Barrio;
            tblC.Fuerza = cli.Fuerza;
            tblC.Grado = cli.Grado;
            tblC.Fecha_Ingreso = cli.Fecha_Ingreso;
            tblC.Fecha_Salida = cli.Fecha_Salida;
            tblC.Año_Contingente = cli.Año_Contingente;
            tblC.Numero_Contigente = cli.Numero_Contigente;
            tblC.Batallon = cli.Batallon;
            tblC.Fecha_Hechos = cli.Fecha_Hechos;
            tblC.Dispensario = cli.Dispensario;
            tblC.Estado_Proceso = cli.Estado_Proceso;
            tblC.Etapa_Proceso = cli.Etapa_Proceso;
            tblC.Fecha_Autenticado = cli.Fecha_Autenticado;
            tblC.Fecha_Creado = cli.Fecha_Creado;
            tblC.Fecha_Actualizado = cli.Fecha_Actualizado;
            tblC.Usurio = cli.Usurio;

            return metodos.Modificar(tblC);
        }

        public bool ValidarSiClienteExiste(string value_Numero_Documento_Cliente)
        {
            return metodos.ValidarSiClienteExiste(value_Numero_Documento_Cliente);
        }

        public List<ClientesViews> ConsultarClienteCedula(string value_cliente)
        {
            return metodos.ConsultarClienteCedula(value_cliente);
        }
        public List<ClientesViews> ConsultarTodosLosClientes()
        {
            return metodos.ConsultarTodosLosClientes();
        }
        
            public List<ClientesViews> ConsultarClienteAsociarFamilia(string value_cliente)
        {
            return metodos.ConsultarClienteAsociarFamilia(value_cliente);
        }

        public string ObtenerCorreo (string Documento_Cliente)
        {

            return metodos.ObtenerCorreo(Documento_Cliente);

        }


    }
}
