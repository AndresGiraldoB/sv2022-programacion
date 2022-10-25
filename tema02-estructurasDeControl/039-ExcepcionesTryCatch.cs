/* 39 Pide al usuario tres números enteros llamados a, b y c,
y muestre el resultado de (a+b)/c. Usa excepciones para comprobar
los posibles errores.*/

// --- Mariano (...)

using System;

class T02sem4
{
    static void Main()
    {
        int a, b, c;

        try
        { 
            Console.WriteLine("Dime un primer número");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime un segundo número");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime un tercer número");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("El resultado de su operación es: ");
            Console.WriteLine((a + b) / c);
        }
    
        catch (FormatException)
        {
            Console.WriteLine("El valor introducido no es numérico entero. ");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir por 0. ");
        }
        catch (Exception error)
        {
            Console.WriteLine("Esto no debería haber pasado: {0} ",
                error.Message);
        }
        Console.WriteLine("....");
    }
}
