/*
Pausa tras cada 20, usando un contador
*/

using System;

class Pausa
{
    static void Main()
    {
        int lineasImpresas = 0;
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");

            lineasImpresas++;

            if (lineasImpresas == 20)
            {
                Console.ReadLine();
                lineasImpresas = 0;
            }
        }
    }
}
