/* Juan Manuel (...) 1º DAM Semipresencial */

/*
65. Escribe un programa que pida al usuario 5 números reales de doble
precisión y muestre su máximo, mínimo, suma y media.
*/


using System;

class Ejercicio65
{
    static void Main()
    {
        const byte NUMERO_LECTURAS = 5;
        double numeroLeido = 0, minimo = 0, maximo = 0, suma = 0, media = 0;

        for (int i = 1; i <= NUMERO_LECTURAS; i++)
        {
            Console.Write("Deme un número ("+i+" de "+NUMERO_LECTURAS+"): ");
            numeroLeido = Convert.ToDouble(Console.ReadLine());
            if (i == 1) //inicializamos los valores
            {
                minimo = maximo = suma = numeroLeido;
            }
            else
            {
                if (numeroLeido < minimo)
                {
                    minimo = numeroLeido;
                }
                if (numeroLeido > maximo)
                {
                    maximo = numeroLeido;
                }
                suma += numeroLeido;
                media = suma / i;
            }
        }
        Console.WriteLine("Max = {0}, Min = {1}, Suma = {2}, Media = {3}",
            maximo, minimo, suma, media);
    }
}

