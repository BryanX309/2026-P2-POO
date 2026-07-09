using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructores
{
    public class Persona
    {
        public string Nombre{get;set;}
        public int Edad{get;set;}
        public string Genero{get;set;}
        public string Nacionalidad{get;set;}

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            
        }

        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Nacionalidad = "HN";
        }

        public Persona(string nombre, int edad, string genero,  string nacionalidad = "HN")
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Nacionalidad = nacionalidad;
        }

        public Persona()
        {
            
        }
    }
}