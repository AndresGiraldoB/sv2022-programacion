//19.Pide al usuario un número, que guardarás en una variable "n".
//Dale a una variable llamada "par" el valor 1 si "n" es par, o un valor 0 si "n" es impar.
//Hazlo de dos formas: primero con "if" y luego con el operador ternario.
//Ambas comprobaciones serán parte del mismo programa, que pedirá el dato "n"
//una única vez y mostrará la respuesta dos veces(una vez con "if" y otra vez con el "operador ternario").

// Francisco (...)

using System;
class Ejercicio19
{
    static void Main()
    {
        int n, par;

        Console.WriteLine("Escribe un número");
        n = Convert.ToInt32(Console.ReadLine());

        // Versión con "if"
        if (n %2==0)
        {
            par =1;
        }
        else
        {
            par = 0;
        }
        Console.WriteLine(par);

        // Versión con ternario
        par = (n % 2 == 0) ? 1 : 0;
        Console.WriteLine(par);
    }
}
