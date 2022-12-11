//Francis (...)

/*
 * 104. Crea una variante del ejercicio 103, que no use 
 * parámetros "ref", sino parámetros "out".
 */

using System;

class FuncionGetMaxMinOut
{
    static void GetMaxMin(double[] nums, out double max, out double min)
    {
        max = min = nums[0];

        for (int n = 1; n < nums.Length; n++)
        {
            if (max < nums[n]) { max = nums[n]; }
            if (min > nums[n]) { min = nums[n]; }
        }
    }

    static void Main()
    {
        double maximo, minimo;

        double[] numeros = { 12.3, 123.4, 56.234, 909.88, 1092.5402 };
        GetMaxMin(numeros, out maximo, out minimo);
        Console.WriteLine("Max: " + maximo + "; Min: " + minimo);

        /*double[] SinNumeros = {};
        GetMaxMin(SinNumeros);*/
    }
}
