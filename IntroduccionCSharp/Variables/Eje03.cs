namespace IntroduccionCSharp.Variables;

public class Eje03
{
    public Eje03()
    {
        /** Conversion de Tipos **/
        // Conversion Implícita

        int entero = 100;

        long largo = entero;
        double doble = entero;

        // Conversion Explicita (cast; puede perder datos)
        double pi = 3.141592;
        int truncado = (int)pi; //3

        //Metodos de Conversion
        string numeroStr="42";
        int numero = int.Parse(numeroStr);

        int otroNumero = Convert.ToInt32(numeroStr);

        if(int.TryParse("2", out int resultado))
        {
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("la cadena de texto no es un numero valido");
        }

        //int numeroX = int.Parse("dos");

        //Console.WriteLine(numero);
    }
}