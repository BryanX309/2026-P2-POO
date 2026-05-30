namespace IntroduccionCSharp.Variables;
/**
VARIABLE: es un espacio en la memoria RAM con un nombre que almacena un valor

para definir una variable en C# 

tipoDeDato nombreVariable = Valor Opcional
string nombre = "Juan Perez";
int edad = 20;

Tipo:   Descripcion     Tamaño

int     Entero          32 bits
long    Entero Grande   64 bits
float   Decimal Simple  32 bits
double  Decimal doble   64 bits
decimal Decimal Exacto  128 bits
bool    boleano         8 bits
char    Caracter        16 bits
string  Texto           variable

*/
public class Eje01
{
    public Eje01()
    /**Metodo Constructor: debe llamarse igual a la clase, debe ser publico y no puede retornar nada*/
    {
        float f = 0.1f;
        double d = 0.1;
        decimal m = 0.1m;

        Console.WriteLine(f + f + f + f + f); // 0.5
        Console.WriteLine(d + d + d + d + d); // 0.5
        Console.WriteLine(m + m + m + m + m); // 0.5
    }
}
