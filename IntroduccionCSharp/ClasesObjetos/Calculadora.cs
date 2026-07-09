using IntroduccionCSharp.EstructurasControl;

namespace IntroduccionCSharp.ClasesObjetos
{
    public class Calculadora
    {
        // Suma
        public int Suma(int n1, int n2)
        {
            return n1 + n2;
        }
        
        // Resta
        public int Resta(int n1, int n2)
        {
            return n1 - n2;
        }
        
        // Multiplicar
        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
        
        // Division
        public (int cociente, int residuo) Division(int n1, int n2)
        {
            int cociente = n1 / n2;
            int residuo = n1 % n2;

            return (cociente,residuo);
        }
    }
}