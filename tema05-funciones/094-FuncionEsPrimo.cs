/* José Manuel (...)
94. Crea una función booleana llamada "EsPrimo", que devolverá true si el 
parámetro (un entero largo) es un número primo, o false en caso contrario. 
Empléala en un programa que muestre los números primos entre el 1 y el 100.
*/

using System;

class Ejercicio_94
{
    static bool EsPrimo(int numero)
    {
        int divisores = 0;
        bool esPrimo = false;
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            esPrimo = true;
        }

        return esPrimo;
    }
    
    static void Main()
    {
        Console.Write("Dime un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(EsPrimo(numero) ? "El número es primo" : 
            "El número no es primo");
    }
}
