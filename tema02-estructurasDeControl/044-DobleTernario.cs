using System;
class Ejercicio44
{
    static void Main()
    {
        /*44. Pide al usuario dos números, que guardarás en
         variables "n1" y "n2". Dale a una variable llamada 
        "pares" el valor 2 si los dos son pares, 1 si sólo uno 
        es par o 0 si ninguno es par. Hazlo de dos formas:
        primeros con dos "if" encadenados y luego con dos 
        operadores ternarios encadenados.*/

        //Francisco de Borja (...)

        int n1, n2, pares;

        Console.WriteLine("Introduce un primero número");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce un segundo número");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        // Versión con "if"

        if ((n1 % 2 == 0) && (n2 % 2 == 0))
        {
            pares = 2;
        }
        else if ((n1 % 2 == 0)||(n2 % 2 == 0))
        {
            pares = 1;
        }
        else
        {
            pares = 0;
        }
        Console.WriteLine(pares);
        
        // Versión con operador ternario

        pares = (n1 % 2 == 0) && (n2 % 2 == 0) ? 2 : 
            (n1 % 2 == 0) || (n2 % 2 == 0) ? 1 : 
            0;

        Console.WriteLine(pares);
    }
}
