using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using BA.Controllers.Controllers;


namespace BA.Correos
{
    public class Metodos
    {

        ParametrosControllers Parametros = new ParametrosControllers();
        ClientesController Clientes = new ClientesController();


        public bool EnviarCorreoDeBienvenida(string Documento_Cliente)
        {
            string ParametroCorreo = string.Empty;
            ParametroCorreo = "CorreoOrigen";
            string Origen = string.Empty;
            Origen = Parametros.MostrarParametro(ParametroCorreo);
            string ParametroContraseña = string.Empty;
            ParametroContraseña = "Contraseña";
            string ContraseñaCorreo = string.Empty;
            ContraseñaCorreo = Parametros.MostrarParametro(ParametroContraseña);
            string ParametroAsunto = string.Empty;
            ParametroAsunto = "AsuntoCorreoBienvenida";
            string AsuntoCorreo = string.Empty;
            AsuntoCorreo = Parametros.MostrarParametro(ParametroAsunto);
            string ParametroServidorCorreo = string.Empty;
            ParametroServidorCorreo = "ServidorCorreo";
            string NombreServidorCorreo = string.Empty;
            NombreServidorCorreo = Parametros.MostrarParametro(ParametroServidorCorreo);
            string ParametroPuertoCorreo = string.Empty;
            ParametroPuertoCorreo = "PuertoCorreo";
            string PuertoCorreo = string.Empty;
            PuertoCorreo = Parametros.MostrarParametro(ParametroPuertoCorreo);
            string Destino = string.Empty;
            Destino = Clientes.ObtenerCorreo(Documento_Cliente);
            string ParametroCorreoCopia = string.Empty;
            ParametroCorreoCopia = "CorreoCopia";
            string Copia = string.Empty;
            Copia = Parametros.MostrarParametro(ParametroCorreoCopia);

            Destino = Destino + ";" + Copia;



            if (Destino.Length > 0)
            {
                MailMessage MensajeCorreo = new MailMessage(Origen, Destino, AsuntoCorreo, "HOLA HOLA HOLA HOLA HOLA HOLA");
                MensajeCorreo.IsBodyHtml = true;
                MensajeCorreo.Priority = MailPriority.Normal;


                SmtpClient ServidorCorreo = new SmtpClient(NombreServidorCorreo,int.Parse(PuertoCorreo));
                ServidorCorreo.EnableSsl = true;
                ServidorCorreo.UseDefaultCredentials = true;
                //ServidorCorreo.Port = int.Parse(PuertoCorreo);
                ServidorCorreo.Credentials = new System.Net.NetworkCredential(Origen, ContraseñaCorreo);
                
                try
                {
                    ServidorCorreo.Send(MensajeCorreo);

                    ServidorCorreo.Dispose();
                    return true;

                } catch (Exception ex)
                {
                    return false;                    

                }          
            }
            else
            {
                return false;
            }
        }
    }
}
