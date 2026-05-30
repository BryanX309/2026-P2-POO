using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.EstructurasControl
{
    public class CondicionalSwitch
    {
        public CondicionalSwitch()
        {
            int diaSemana = 4;

            // switch (diaSemana)
            // {
            //     case 1: Console.WriteLine("Lunes"); break;
            //     case 2: Console.WriteLine("Martes"); break;
            //     case 3: Console.WriteLine("Miércoles"); break;
            //     case 4: Console.WriteLine("Jueves"); break;
            //     case 5: Console.WriteLine("Viernes"); break;
            //     case 6: Console.WriteLine("Sábado"); break;
            //     case 7: Console.WriteLine("Domingo"); break;

            //     default: Console.WriteLine("Dia No Valido"); break;
            // }

            // Forma Moderna y mas concisa
            string diaSemanaNombre = diaSemana switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Dia No Valido"
            };

            Console.Write(diaSemanaNombre);

            string tipoDia = diaSemana switch
            {
                1 or 2 or 3 or 4 or 5 => "Dia Laboral",
                6 or 7 => "Fin de Semana",
                _ => "Dia No Valido"
            };

            Console.WriteLine(tipoDia);
        }
    }
}