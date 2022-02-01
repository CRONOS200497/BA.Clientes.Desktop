using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Correos;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos Metodos = new Metodos();

            string cedula = "1234";

            Metodos.EnviarCorreoDeBienvenida(cedula);
                        
        }
    }
}
