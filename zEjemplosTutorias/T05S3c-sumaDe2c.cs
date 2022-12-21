// Parámetros de Main 3: leer dos parámetros de línea de comandos y comprobar cantidad

using System;

class SumaDe2c
{
    static void Main(string[] args)
    {
        int n1, n2;

        if (args.Length == 2)
        {

            n1 = Convert.ToInt32(args[0]);
            n2 = Convert.ToInt32(args[1]);

            Console.WriteLine("Su suma es " + (n1 + n2));
        }
        else 
        {
            Console.WriteLine("Uso: suma n1 n2");
            Console.WriteLine("Ej.: suma 23 45");
        }
    }
}
