namespace IntroduccionCSharp.POO.Herencia
{
    public class Empleado : Persona
    {
        public decimal Salario { get; set; }
        public string Departamento { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Empleado(string nombre, string apellidos, decimal salario)
            :base(nombre, apellidos) //invocamos el método Constructor de la Clase Padre (Persona) y le pasamos los datos que comparte con el CTOR de empleado
        {
            Salario = salario;
        }

        public int GetYearsOfServise()
        {
            return (int)(DateTime.Now - FechaIngreso).TotalDays / 365;
        }

        public override void PrintInfo() //override: Sobreescribe el codigo del metodo virtual de la Clase Padre
        {
            base.PrintInfo(); //Ejecuta el Codigo Original del Metodo de la Clase Padre
            Console.WriteLine($"Salario: {Salario:C2}"); //C2 Devuelve el valor en la moneda configurada en la computadora
        }
    }
}