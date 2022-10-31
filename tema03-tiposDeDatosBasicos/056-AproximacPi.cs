
/*56. Haz un programa para calcular una aproximación para PI usando la expresión
 * pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ...  
 * El usuario indicará cuántos términos se deben usar (por ejemplo, 
 * si responde que 2, tu programa calcularía 1/1 - 1/3, que tendrá 
 * como resultado algo cercano a 0.666666, 
 * luego el valor de PI sería 4 * 0.666666 = 2.666666). 
 * Nota 1: debes usar el tipo de datos "double".  
 * Nota 2: Este método se llama "fórmula de Leibniz
 
   Manuel Jesús (...) */
   
using System;


class AproxPi
{
    static void Main()
    {
        long numerocifras; 
        long denominador = 1;
        double piEntre4 =0;
        int signo = 1;
        
        Console.WriteLine("¿Cuantos términos vamos a usar?");
        numerocifras = Convert.ToInt64(Console.ReadLine());
        
        for (int i = 1; i <= numerocifras; i++)
        {
            piEntre4 += signo * (1 / (double) denominador);
            
            denominador += 2;
            signo *= -1;
        }

        Console.WriteLine("Mi aproximación de pi es {0}", 4 * piEntre4);
    }
}
