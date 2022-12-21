// Parámetros de Main 1: acercamiento, planteamiento convencional

using System;

class SumaDe2a
{
    static void Main()
    {
        int n1, n2;

        Console.WriteLine("Dime un número a sumar");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime otro número a sumar");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Su suma es "+ (n1+n2));
    }
}
