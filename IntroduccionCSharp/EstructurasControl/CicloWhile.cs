namespace IntroduccionCSharp.EstructurasControl
{
    public class CicloWhile
    {
        public CicloWhile()
        {
            //Repite mientras la condición sea verdadera, puede no ejecutarse nunca si la condición es falsa desde el inicio

            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine($"el contador va en {contador}");
                contador++;
            }
        }
    }
}