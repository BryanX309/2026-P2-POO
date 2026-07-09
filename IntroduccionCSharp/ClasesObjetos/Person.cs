using System.Security.Cryptography;

namespace IntroduccionCSharp.ClasesObjetos
{

    //Public: Define que la clase es Accesible desde otro Archivo
    public class Person
    {
        public string Name;
        public string LastName;
        public int Age;

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public string GetFullName()
        {
            return $"{Name} {LastName}";
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }

        public string GetInfo()
        {
            return $"{GetFullName()}, {Age} Años";
        }
    }
}