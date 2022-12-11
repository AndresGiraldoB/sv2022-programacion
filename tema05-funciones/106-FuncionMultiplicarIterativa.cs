//Francis (...)

/*
 * 106. Crea una función "Multiplicar", que calcule y devuelva el producto de dos 
 * números naturales (enteros no negativo) que se indiquen como parámetros, a base 
 * de sumas repetitivas, de forma "iterativa" (no recursiva), usando la orden "for"
 * (por ejemplo, "Multiplicar(3,5)" calculará 3+3+3+3+3 o bien 5+5+5, según decidas
 * plantearlos).
 */

using System;
class FuncionMultiplicar
{
    static int Multiplicar(int num, int multi)
    {
        int producto = 0;
        for (int n = 0; n < multi; n++)
        {
            producto += num;
        }
        
        return producto;
    }

    static void Main()
    {
        int numero = 5;
        int multiplicador = 3;

        Console.WriteLine( Multiplicar(numero, multiplicador) );
    }
}
