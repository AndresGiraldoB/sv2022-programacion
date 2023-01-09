/*118. Crea una función EsPrimoCircular, que devuelva true si el número 
 * entero largo pasado como parámetro es un primo circular 
 * (http://en.wikipedia.org/wiki/Circular_prime) (puedes ayudarte de una
 * función auxiliar EsPrimo, si te parece razonable): 

if (EsPrimoCircular(117))
    Console.Write("117 es primo circular");
if (! EsPrimoCircular(23))
    Console.Write("23 no es primo circular");


 Radha */

using System;

class Ejercicio118
{
    static bool EsPrimo(long numero)
    {
        int divisores = 0;
        bool esPrimo = false;
        for (long i = 1; i <= numero; i++)
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
    
    
    static bool EsPrimoCircular(long numero)
    {
        int contadorPrimos = 0;
        if(EsPrimo(numero))
        {
            string numAux = Convert.ToString(numero);
            for (int i = 0; i < numAux.Length; i++)
            {
                numAux = numAux[numAux.Length - 1] +
                    numAux.Substring(0, numAux.Length - 1);

                if (EsPrimo(Convert.ToInt64(numAux)))
                {
                    contadorPrimos++;
                }
            }

            return contadorPrimos == numAux.Length;
        }
        else
        {
            return false;
        }
    }
    
    
    static void Main()
    {
        long numero = PedirNumeroLargo();

        if(EsPrimoCircular(numero))
        {
            Console.Write(numero + " es primo circular");
        }        
        else
        {
            Console.Write(numero + " no es primo circular");
        }

    }
    static long PedirNumeroLargo()
    {
        Console.Write("Introduce un número: ");
        return Convert.ToInt64(Console.ReadLine());
    }
}
