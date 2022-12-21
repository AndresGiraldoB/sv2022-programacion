// Parámetros de Main 4: 
// - leer dos parámetros de línea de comandos y comprobar cantidad
// - devolver código de resultado al sistema operativo

using System;

class SumaDe2d
{
    static int Main(string[] args)
    {
        int n1, n2;

        if (args.Length == 2)
        {
            try
            {
                n1 = Convert.ToInt32(args[0]);
                n2 = Convert.ToInt32(args[1]);

                Console.WriteLine("Su suma es " + (n1 + n2));
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("No es un número");
                return 2;
            }
        }
        else 
        {
            Console.WriteLine("Uso: suma n1 n2");
            Console.WriteLine("Ej.: suma 23 45");
            return 1;
        }
    }
}
