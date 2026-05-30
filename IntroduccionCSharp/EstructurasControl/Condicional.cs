using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.EstructurasControl
{
    public class Condicional
    {
        public Condicional()
        {
            int edad = 10;
            // if (edad >= 18){
            //     Console.WriteLine("Eres Mayor de Edad");
            // }
            // else
            // {
            //     Console.WriteLine("Eres Menor de Edad");
            // }
            //     Console.WriteLine("-----------------------------");

            if(edad < 13)   Console.WriteLine("Eres un Niño");
            else if(edad < 18)   Console.WriteLine("Eres un Adolescente");
            else if(edad < 65)   Console.WriteLine("Eres un Adulto");
            else  Console.WriteLine("Eres un Adulto Mayor");
            
        }
    }
}