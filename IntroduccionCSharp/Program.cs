/*
* namespace => Agrupar clases que tienen un dominio Relacionado
* class => Define una Plantilla de objeto
* Main => Punto de Entrada del Programa
* Colose.Whriteline => Imprimir Texto en la Consola
*/

// using System.Collections.Concurrent;
// using System.Text.Json;
// using Constructores;
using IntroduccionCSharp.POO;
using IntroduccionCSharp.POO.Herencia;
// using IntroduccionCSharp.EstructurasControl;
// using IntroduccionCSharp.Variables;

namespace IntroduccionCSharp
{
    class Program // pascal case ClientDetails - snake case client_details - camelcase clientDetails
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /**Console.WriteLine("¡Hola Mundo!");*/

            //Eje01 eje01 = new Eje01();
            //Eje03 eje03 = new Eje03();
            //Eje04 eje04 = new Eje04();
            // Condicional c = new Condicional();
            //Ternario t = new Ternario();
            // CondicionalSwitch s = new CondicionalSwitch();
            //CicloFor f = new CicloFor();

            /*Console.WriteLine("Ingrese el numero de Tabla que quiere ver");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Limite de la tabla");
            int n2 = int.Parse(Console.ReadLine());

            CicloForTabla ft = new CicloForTabla(n1,n2);*/

            //CicloForEach fe = new CicloForEach();
            //CicloWhile w = new CicloWhile();

            // Console.WriteLine("Ingrese el numero de Tabla que quiere ver");
            // int.TryParse(Console.ReadLine(), out int n1);
            // Console.WriteLine("Ingrese el Limite de la tabla");
            // int.TryParse(Console.ReadLine(), out int n2);

            // CicloWhileTabla wt = new CicloWhileTabla(n1, n2);

            //Person persona1 = new Person("Bryan", "Cruz", 23);

            //Console.WriteLine(persona1.GetFullName());
            // Console.WriteLine(persona1.IsAdult() ? "Es Mayor de Edad" : "Es Menor de Edad");

            // Console.WriteLine(persona1.GetInfo());

            // Person persona2 = new Person("Maria", "Mejia", 23);
            // Person persona3 = new Person("Pedro", "Lopez", 15);


            // Product product1 = new Product("Semitas", 15.5m, 100);
            // Product product2 = new Product("Cafe", 60);

            // BankAccount bank = new BankAccount();
            // bank.AccountNumber="1001";
            // bank.HolderName="Juan Perez";
            // bank.Balance=100.50m;

            // string json = JsonSerializer.Serialize(bank);
            // Console.WriteLine(json);

            // Calculadora cal = new Calculadora();
            // Console.WriteLine($"Suma 2 + 2 = {cal.Suma(2,2)}");
            // Console.WriteLine($"Resta 4 - 2 = {cal.Resta(4,2)}");
            // Console.WriteLine($"Multiplicar 4 x 2 = {cal.Multiplicar(4,2)}");
            // Console.WriteLine($"Dividir 4 / 2 = {cal.Division(4,2)} ");

            // Persona p1 = new Persona("Juan Perez", 21);
            // Persona p2 = new Persona();
            // Persona p3 = new Persona("Juan Perez", 21, "M");
            // Persona p4 = new Persona("Juan Perez", 21, "M", "Mex");

            // BankAccount cuenta = new BankAccount("1234");
            // cuenta.AccountNumber = "1001";
            // cuenta.Deposit(1000m);

            // Console.WriteLine($"La Cuenta {cuenta.AccountNumber} tiene un saldo de {cuenta.GetBalance()}");

            // if(cuenta.Withdraw(1200m, "1234"))
            // {
            // Console.WriteLine($"TRANSACCION EXITOSA");    
            // Console.WriteLine($"La Cuenta {cuenta.AccountNumber} tiene un saldo de {cuenta.GetBalance()}");
            // }
            // else Console.WriteLine($"TRANSACCION DENEGADA");

            // Employee employee1 = new Employee();
            // employee1.Salary = 12000m;

            // Console.WriteLine($"{employee1.Salary}");

            // Employee employee2 = new Employee();
            // employee2.Salary = -12000m;

            // Console.WriteLine($"{employee2.Salary}");

            Empleado empleado1 = new Empleado("Juan", "Perez", 12000m);
            // empleado1.Nombre = "Juan";
            // empleado1.Apellidos = "Perez";
            empleado1.FechaNacimiento = DateTime.Parse("2002/09/30");
            empleado1.FechaIngreso = DateTime.Parse("2020/04/1");
            // empleado1.Salario = 12000;
            empleado1.Departamento = "Ventas";
            
            // Console.WriteLine($"Empleado Nombre Completo {empleado1.GetFullName()}");
            // Console.WriteLine($"Con edad de {empleado1.GetAge()} años");
            // Console.WriteLine($"y lleva {empleado1.GetYearsOfServise()} años trabajando");

            empleado1.PrintInfo();
            Console.WriteLine("-----------------------");
        }
    }
}