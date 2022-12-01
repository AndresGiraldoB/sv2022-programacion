using System;

class EjemploEjercicio94
{
    static bool EsPrimo(int n)
    {
        int divisores = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                divisores++;
        }
        if (divisores == 2)
            return true;
        else
            return false;
    }

    static void Main()
    {
        if (EsPrimo(5)) Console.WriteLine("5 es primo");
        
        if (EsPrimo(15)) 
            Console.WriteLine("15 es primo");
        else
            Console.WriteLine("15 no es primo");
        
        if (EsPrimo(157)) Console.WriteLine("157 es primo");
    }
}
