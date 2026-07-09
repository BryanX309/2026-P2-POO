using Microsoft.VisualBasic;

namespace IntroduccionCSharp.POO
{
    public class Employee
    {
        //Campos Privados
        private decimal salary;

        //Campos publicos con control de Acceso
        public decimal Salary
        {
            get {return salary;}
            set
            {
                //validar que el salario no sea negativo

                if(value < 0)
                {
                    throw new ArgumentException("El salario no puede ser negativo");
                
                }

                salary = value;
            }
        }

        public int ID { get; set; }

        public string Name { get; set; }

    }
}