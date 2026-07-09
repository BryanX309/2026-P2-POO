namespace IntroduccionCSharp.ClasesObjetos
{
    public class BankAccount
    {
        // Campo Privado

        private decimal balance;

        // Propiedad de Clase
        public decimal Balance
        {
            get {return balance;} //Leer el Valor de Balance que esta Privado
            set {balance = value;} //Escribir o Asignar un valor a balance que se encuentra privado
        }

        public string AccountNumber{get; set;}
        public string HolderName
        {
            get{return field.ToUpper();} // en este caso devuelve o muestra el Holdername en Mayusculas, solo devuelve el valor no cuando lo recibe
            set;
        }
    }
}

/*
Saldo Neto = 1,000.00
Saldo Disponible = 100.00
Saldo Flotante = 500.00
Saldo Pignorado = 200.00
Saldo Congelado = 200.00
*/