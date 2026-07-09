using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.EstructurasControl
{
    public class CicloWhileTabla
    {
        public CicloWhileTabla(int numero, int tabla)
        {
            int i = 1;

            Console.WriteLine($"\nTabla de Multiplicacion del {numero}\n");
            while(i <= tabla)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                i++;
            }
        }
    }
}