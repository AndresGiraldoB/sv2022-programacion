/*112. Crea un programa llamado "calcular", que reciba tres parámetros
 en la línea de comandos (dos números enteros y un operador de entre
+, -, *, /) y muestre el resultado de la operación,
como en este ejemplo:

    calcular 5 * 3
    15
A pesar de que los datos sean enteros, la división se calcular con
decimales, de modo que otro ejemplo de ejecución podría ser:

calcular 15 / 2
7,5

 Radha */

using System;

class Calcular
{
    static void Main(string[] args)
    {
        int n1, n2;
        char operador;
        
        if (args.Length < 3)
        {
            Console.WriteLine("Ejemplo de uso: calcular 2 + 3");
        }
        else
        {
            n1 = Convert.ToInt32(args[0]);
            operador = Convert.ToChar(args[1]);
            n2 = Convert.ToInt32(args[2]);

            switch(operador)
            {
                case '*':
                    Console.WriteLine(n1 * n2);
                    break;
                case '/':
                    Console.WriteLine((double)n1 / n2);
                    break;
                case '+':
                    Console.WriteLine(n1 + n2);
                    break;
                case '-':
                    Console.WriteLine(n1 - n2);
                    break;
            }
        }
    }
}
