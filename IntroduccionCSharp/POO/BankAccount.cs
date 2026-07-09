using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IntroduccionCSharp.POO
{
    public class BankAccount
    {
        /*
            ENCAPSULAMIENTO
            - Es el principio d Ocultar los detalles internos de un Objeto y exponer solo lo necesario
                
                * Proteger los datos de accesos indebidos
                * Validar los cambios antes de aplicarlos
                * Mantener la consistencia del estado interno

            Modificadores de Acceso

            - public - se puede acceder desde cualquier lugar
            - private - Solo se puede acceder desde la misma Clase
            - protected - solo lo puede acceder la Clase y sus sub Clases
            - Internal - Cualquier lugar dentro del mismo proyecto
            - protected internal - Acceso para la Clase, subclases o cualquier clase del mismo proyecto
            - private protected - Accede la Clase p SubClases dentro del mismo proyecto
        */

        private decimal balance;
        private string pin;
        public string AccountNumber;
        public string HolderName;

        public BankAccount(string pin)
        {
            this.pin = pin;
        }

        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
            }
        }

        public bool Withdraw(decimal amount, string enteredPin)
        {
            if(enteredPin != pin) return false;
            if(amount > balance) return false;

            balance -= amount;

            return true;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}