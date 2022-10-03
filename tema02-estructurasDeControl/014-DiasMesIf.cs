/* Pregunta al usuario el número de un mes y muestra cuántos días tiene, usando 
"if". Por ejemplo, si el mes es el 3, la respuesta debería ser "31 días". 
(Supon que febrero siempre tiene 28 días). No debes usar 12 casos distintos, 
sino agrupar las condiciones de la manera que consideres más conveniente. 

Creado por: Miguel Ángel (...) */

using System;

class Ejercicio14
{
    static void Main()
    {
        int numero;

        Console.Write("Dime el número del mes: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == 1 || numero == 3 || numero == 5 || numero == 7 || numero == 8
                || numero == 10 || numero == 12)
            Console.WriteLine("31 días");
        else if (numero == 4 || numero == 6 || numero == 9 || numero == 11)
            Console.WriteLine("30 días");
        else if (numero == 2)
            Console.WriteLine("28 días"); 
        else
            Console.WriteLine("Mes desconocido");
    }
}
