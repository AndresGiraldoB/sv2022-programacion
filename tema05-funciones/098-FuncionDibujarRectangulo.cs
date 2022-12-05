/*
Crea una función llamada "DibujarRectangulo", que mostrará un rectángulo con el 
ancho, la altura y el carácter que se indiquen como parámetros. Añade un "Main" 
de prueba. La función deberá aparecer después de "Main".
*/

// Fátima (...)

using System;

class Ejercicio98
{
    static void Main()
    {
        int altura, ancho;
        char caracter;

        Console.Write("Dime la altura: ");
        altura = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime el ancho: ");
        ancho = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime el carácter: ");
        caracter = Convert.ToChar(Console.ReadLine());

        DibujarRectangulo(altura, ancho, caracter);
    }

    static void DibujarRectangulo(int alt, int anc, char car)
    {
        for (int i = 1; i <= alt; i++)
        {
            for (int j = 1; j <= anc; j++)
            {
                Console.Write(car);
            }
            Console.WriteLine();
        }
    }
}
