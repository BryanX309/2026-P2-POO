using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IntroduccionCSharp.EstructurasControl
{
    public class CicloForEach
    {
        public CicloForEach()
        {
            // el ciclo For Each itera sobre elementos de una colección sin necesidad de el indice

            string[] productos = {"Laptop", "Mouse", "Teclado", "Monitor"};
            
            int indice = 1;

            foreach(string producto in productos)
            {
                Console.WriteLine($"{indice} - {producto}");
                indice++;
            }
        }
    }
}