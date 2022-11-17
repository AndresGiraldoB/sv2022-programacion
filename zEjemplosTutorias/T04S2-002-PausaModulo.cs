/*
Pausa tras cada 20, usando el resto de la división
*/

using System;

class Pausa
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");

            if (i % 20 == 0)
                Console.ReadLine();
        }
    }
}

