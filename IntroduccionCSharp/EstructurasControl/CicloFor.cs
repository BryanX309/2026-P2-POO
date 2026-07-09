using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.EstructurasControl
{
    public class CicloFor
    {
        public CicloFor()
        {
            Console.WriteLine("Ciclo For del 1 al 5");
            for(int i = 1;i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Ciclo For Inverso 5 - 1");
            for (int i = 5; i >=1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}