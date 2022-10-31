using System;
class Ejercicio53
{
    static void Main()
    {
        /*53. Pide al usuario dos números enteros cortos y muestra todos
         * los números entre ellos, en hexadecimal, en la misma línea, 
         * separados por un espacio. 
         * Por ejemplo, si introduce 8 y 11, deberás mostrar "8 9 a b". 
         * El programa se debe comportar correctamente si introduce 
         * los números en orden contrario, es decir, 
         * si primero indica 11 y 8 en vez de 8 y 11.*/

        //Francisco de Borja (...)

        byte numero1, numero2, menor, mayor;

        Console.WriteLine("Escribe los 2 numeros limites " +
            "de los que quieres saber su rango de valores en hexadecimal");
        numero1 = Convert.ToByte(Console.ReadLine());
        numero2 = Convert.ToByte(Console.ReadLine());

        menor = (numero1<numero2) ? numero1 : numero2;
        mayor = (numero1>numero2) ? numero1 : numero2;
        
        for(int i = menor; i <= mayor; i++)
        {
            Console.Write("{0} ", Convert.ToString(i, 16));
        }

    }
}
