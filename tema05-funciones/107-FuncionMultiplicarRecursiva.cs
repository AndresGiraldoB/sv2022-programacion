//Francis (...)

/*
 * 107. Crea una función "MultiplicarR", que calcule y devuelva el producto 
 * de dos números naturales que se indiquen como parámetros, de forma recursiva 
 * (por ejemplo, puede tomar como caso base que el segundo número sea 0).
 */

using System;
class FuncionMultiplicarR
{
    static int MultiplicarR(int num, int multi)
    {
        if (multi == 0)
            return 0;
        else
            return num + MultiplicarR(num, multi - 1);
    }

    static void Main()
    {
        int numero = 5;
        int multiplcador = 3;

        Console.WriteLine( MultiplicarR(numero, multiplcador) );
    }
}
