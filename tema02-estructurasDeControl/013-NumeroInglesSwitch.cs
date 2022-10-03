// Mismo ejercicio que Recomendado 4 , pero con switch:

// Crea un programa en C# que pida un número del 1 al 10 al usuario 
// y muestre su nombre en inglés, usando "if". 
// Por ejemplo, si el usuario introduce el número 5, 
// tu programa deberá responder "Five". 
// Si introduce un número no válido (el 14 o el -5, por ejemplo) 
// le responderá "No conozco ese número".
 
// Nisi (...)

using System;

class Recomendado5
{
    static void Main()
    {
        int num;
        
        Console.WriteLine("Elige un número del 1 al 10: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        switch (num) 
        {
            case 1 : Console.WriteLine("One"); break;
            case 2 : Console.WriteLine("Two"); break;
            case 3 : Console.WriteLine("Three"); break;
            case 4 : Console.WriteLine("Four"); break;
            case 5 : Console.WriteLine("Five"); break;
            case 6 : Console.WriteLine("Six"); break;
            case 7 : Console.WriteLine("Seven"); break;
            case 8 : Console.WriteLine("Eight"); break;
            case 9 : Console.WriteLine("Nine"); break;
            case 10 : Console.WriteLine("Ten"); break;
            default : Console.WriteLine("No conozco ese número."); break;
        }
    }
}
