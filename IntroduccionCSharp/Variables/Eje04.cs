using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.Variables;
public class Eje04
    {
        public Eje04(){
            /*
            Interpolación de Strings           
            */
            string nombre = "Juan";
            int edad = 18;
            decimal salario = 19000.50m;

            //Concatenacion de Strings
            //Console.WriteLine("Hola "+nombre+". Tienes " + edad + " años");

            //Format String
            string mensaje = string.Format("{0} tiene {1} años y gana {2:c2}",nombre, edad, salario);
            Console.WriteLine(mensaje);

            //String Literales
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Salario {salario}");
        }
    }