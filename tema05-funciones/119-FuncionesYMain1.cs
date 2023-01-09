/*119. Crea una función "Main" que permita probar estas cuatro últimas 
 * funciones. Debe analizar los parámetros de la línea de comandos 
 * (que pueden estar en mayúsculas, minúsculas o bien con mayúsculas y 
 * minúsculas mezcladas) y debe comportarse de la siguiente manera:

 * - Si el primer parámetro es "primoc", seguido de un número entero 
 * (primoc 87), responderá si ese número es un número primo circular o 
 * no(por ejemplo: "87 no es un número primo circular").
 * 
 * Si el primer parámetro es "mm", seguido de una palabra (mm Ejemplo), 
 * mostrará la cantidad de letras en mayúsculas y minúsculas (por ejemplo,
 * "Mayúsculas: 1, minúsculas: 6").
 * Si el primer parámetro es "centrar", seguido de una palabra, escribirá 
 * esa palabra centrada y subrayada.
 * Si el primer parámetro es "mcd", seguido de dos números, se mostrará su
 * máximo común divisor.
 * Si no se usan parámetros, o si se especifica un primer parámetro 
 * incorrecto, mostrará "Uso: primoc / mm / centrar / mcd".


 Radha, retoques por Nacho */

using System;

class Ejercicio119
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Uso: primoc / mm / centrar / mcd");
        }
        else
        {
            switch(args[0].ToLower())
            {
                case "primoc":
                    int num = Convert.ToInt32(args[1]);
                    if (EsPrimoCircular(num))
                    {
                        Console.Write(num + " es primo circular");
                    }
                    else
                    {
                        Console.Write(num + " no es primo circular");
                    }
                    break;

                case "mcd":
                    int num1 = Convert.ToInt32(args[1]);
                    int num2 = Convert.ToInt32(args[2]);
                    Console.WriteLine("Mcd: " + Mcd(num1, num2));
                    break;

               case "mm":
                    int mays = 0, mins = 0;
                    ContarMm(args[1], ref mays, ref mins);
                    Console.WriteLine("Mayúsculas: " + mays + ", minúsculas: " + mins);
                    break;

               case "centrar":
                    EscribirCentradoYSubrayado(args[1]);
                    break;

               default:
                    Console.WriteLine("Uso: primoc / mm / centrar / mcd");
                    break;
            }
        }
    }


    static long Mcd(long a, long b)
    {
        if (b == 0)
        {
            return a;
        }

        return Mcd(b, a % b);
    }


    static void ContarMm(string texto, ref int mays, ref int mins)
    {
        mins = 0;
        mays = 0;

        for (int i = 0; i < texto.Length; i++)
        {
            if ((texto[i] >= 'a') && (texto[i] <= 'z'))
            {
                mins++;
            }
            if ((texto[i] >= 'A') && (texto[i] <= 'Z'))
            {
                mays++;
            }
        }
    }


    static void EscribirCentradoYSubrayado(string texto)
    {
        for (int i = 0; i < (80-texto.Length)/2; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(texto);
        
        for (int i = 0; i < (80-texto.Length)/2; i++)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < texto.Length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }


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
}
