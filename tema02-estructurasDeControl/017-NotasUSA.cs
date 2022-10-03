/*
17.En el sistema de notas norteamericano se usan letras como A, B, C o F para 
expresar si el resultado de un examen es bueno o no. Suponiendo la equivalencia 
10=A+, 9=A, 8=A-, 7=B+, 6=B, 5=C, suspenso=F, crea un programa que te pida la 
nota numérica y responda escribiendo la calificación americana correspondiente. 
Por ejemplo, para una nota 8, tu programa escribirá A-. Hazlo dos veces como 
parte del mismo programa, primero con "if" y luego con "switch". Pedirás al 
usuario la nota sólo una vez y le darás dos repuestas (la que obtengas con "if" 
y la que obtengas con "switch", que deberían coincidir).
*/

using System;

class Ejercicio17
{
    static void Main()
    {
        int numero;
        Console.WriteLine("Introduce un número");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bucle IF");
        if (numero == 10)
            Console.WriteLine("A+");
        else if (numero == 9)
            Console.WriteLine("A");
        else if (numero == 8)
            Console.WriteLine("A-");
        else if (numero == 7)
            Console.WriteLine("B+");
        else if (numero == 6)
            Console.WriteLine("B");
        else if (numero == 5)
            Console.WriteLine("C");
        else if (numero <= 5 && numero >= 0)
            Console.WriteLine("F");
        else
            Console.WriteLine("????");

        Console.WriteLine("Bucle Switch");
        switch (numero)
        {
            case 10: Console.WriteLine("A+"); break;
            case 9: Console.WriteLine("A"); break;
            case 8: Console.WriteLine("A-"); break;
            case 7: Console.WriteLine("B+"); break;
            case 6: Console.WriteLine("B"); break;
            case 5: Console.WriteLine("C"); break;
            case 4: 
            case 3: 
            case 2: 
            case 1: 
            case 0: 
                Console.WriteLine("F"); break;
            default: Console.WriteLine("????"); break;
        }
    }
}
