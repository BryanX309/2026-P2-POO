using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.ClasesObjetos
{
    public class Client
    {
        //Propiedades Automáticas

        //Sintaxis Corta para Propiedades cuando no se necesita lógica
        //al leer o establecer el valor de la propiedad o campo
        public int Id {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
        public bool IsActive {get;set;} =true;
    }
}