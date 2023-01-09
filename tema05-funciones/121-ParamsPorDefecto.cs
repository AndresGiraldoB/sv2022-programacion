//Francis (,,,) 1ºDAM Semipresencial

/*
 * 121. Crea una nueva versión de la función EscribirCentradoYSubrayado 
 * (ejercicio 115), en la que también se pueda indicar, opcionalmente, un símbolo 
 * distinto de los guiones para subrayar. Crea un Main que te permita probar la 
 * función de tres formas distintas: con dos parámetros en su orden normal, con 
 * un solo parámetro, y con dos parámetros en orden invertido.
 */

using System;

class FuncionParamsPorDefecto
{
    static void EscribirCentradoYSubrayado(string texto, char simbolo = '-')
    {
        Console.Write(new string(' ', 40 - texto.Length / 2));
        Console.WriteLine(texto);

        Console.Write(new string(' ', 40 - texto.Length / 2));
        for (int i = 0; i < texto.Length; i++)
        {
            Console.Write(simbolo);
        }

        Console.WriteLine();
    }

    static void Main()
    {
        EscribirCentradoYSubrayado("Texto de prueba 1", '*');
        Console.WriteLine();
        
        EscribirCentradoYSubrayado("Segundo texto de prueba");
        Console.WriteLine();
        
        EscribirCentradoYSubrayado(simbolo: '*', texto:"Prueba3");
        Console.WriteLine();
    }
}
