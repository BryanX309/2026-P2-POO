using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.EstructurasControl
{
    public class Ternario
    {
        public Ternario()
        {
            //El Ternario se utiliza en 
            int edad = 10;

            string mensaje = (edad >= 18) ? "Mayor de Edad" : "Menor de Edad";

            Console.WriteLine(mensaje);
        }
    }
}