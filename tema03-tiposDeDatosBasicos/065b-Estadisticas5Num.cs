// Francisco (...) 1ºDAM Semipresencial

/* 
 * 65. Escribe un programa que pida al usuario 5 números reales de doble 
 * precisión y muestre su máximo, mínimo, suma y media.
 */

using System;
class maxMinSumaMedia
{
    static void Main()
    {
        const byte totalNumeros = 5;
        double num, max, min, suma, media;

        Console.Write("1. Escribe un número: ");
        num = Convert.ToDouble(Console.ReadLine());

        max = min = suma = media = num;

        Console.WriteLine("Máximo: {0}, Mínimo: {1}, Suma: {2}, Media: {3}",
            max, min, suma, media);

        for (int i = 2; i <= totalNumeros; i++)
        {
            Console.Write("{0}. Escribe un número: ", i);
            num = Convert.ToDouble(Console.ReadLine());

            if (num > max)
                max = num;

            if (num < min)
                min = num;

            suma += num;
            media = suma / i;

            Console.WriteLine("Máximo: {0}, Mínimo: {1}, Suma: {2}, Media: {3}",
                max, min, suma, media);
        }
    }
}
