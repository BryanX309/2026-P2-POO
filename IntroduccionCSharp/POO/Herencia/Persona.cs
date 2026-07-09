namespace IntroduccionCSharp.POO
{
    public class Persona
    {
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public DateTime FechaNacimiento {get;set;}

        public Persona(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public string GetFullName() => $"{Nombre} {Apellidos}";

        public int GetAge()
        {
            var today = DateTime.Today;
            int age = today.Year - FechaNacimiento.Year;

            if(FechaNacimiento.Date > today.AddDays(-age)) age--;

            return age;
        }

        public virtual void PrintInfo() //Virtual: en algun momento podremos sobreescribir la logica del metodo
        {
            Console.WriteLine($"INFORMACION\n=======================================\n");
            Console.WriteLine($"Nombre: {GetFullName()}");
            Console.WriteLine($"Edad: {GetAge()}");
        }
    }
}