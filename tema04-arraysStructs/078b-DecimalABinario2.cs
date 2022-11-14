// Inspirado por Nissi

/*78. Crea un programa que pida al usuario un número entero positivo y muestre
su equivalente en forma binaria, usando un array como paso intermedio para
guardar los resultados temporales. Supondremos que el número cabe en 8 bits (un
byte). El algoritmo es el siguiente: divide el número entre 2 tantas veces como
sea posible hasta que el número se convierta en uno, y toma todos los restos en
orden inverso: */

using System;

class Recomendado78
{
    static void Main()
    {
        Console.WriteLine("Indica el número que quieres convertir: ");
        byte numero = Convert.ToByte(Console.ReadLine());
        int[] bits = new int[8];

        for(int i = 7; i >= 0; i--)
        {
            bits[i] = numero % 2;
            Console.WriteLine("{0} : 2, resto {1}",numero, bits[i] );
            numero /= 2;
        }
        Console.WriteLine("Terminado");

        foreach (int bit in bits)
            Console.Write(bit);
    }
}
