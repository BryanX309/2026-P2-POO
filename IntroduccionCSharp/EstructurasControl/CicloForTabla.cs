using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.EstructurasControl
{
    public class CicloForTabla
    {
        public CicloForTabla(int tabla, int limite=12)
        {

            Console.WriteLine($"\nTabla del {tabla}\n");
            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine($"{tabla} x {i} = {tabla*i}");
            }
        }
    }
}