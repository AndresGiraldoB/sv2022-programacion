// Ejercicio 9
// 9. Crea un programa en C# que pida al usuario un número entero y responda si 
// es múltiplo de 10 o no lo es. Pista: deberás usar el "operador módulo" (%).


// Autor: Omar (...)

using System;

class Multiplo10
{
    static void Main()
    {
        int numero;
        
        Console.Write("Introduce un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        if (numero % 10 == 0)
            Console.WriteLine("El número '{0}' es múltiplo de 10.",numero);
        else
            Console.WriteLine("El número '{0}' NO es múltiplo de 10.",numero);
    }
}
