//Ejercicio 30 - Cristina (...)

//Este programa pide un número del 0 al 10 y muestra su tabla de multiplicar.
//Usando "for"

using System;

class Ejercicio30
{
    static void Main()
    {
        int numero, multiplicador;

        Console.WriteLine("Dime un número del 1 al 10 y te diré su tabla de multiplicar: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        if ((numero<1)||(numero>10))
        {
            Console.WriteLine("El número escogido no es válido.");
        }
        else
        {
            for (multiplicador=0; multiplicador<=10; multiplicador++)
            {
                Console.WriteLine("{0} x {1} = {2}",
                    numero, multiplicador, numero*multiplicador);
            }
        }
    }
}
