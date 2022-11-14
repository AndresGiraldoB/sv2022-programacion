/* 
 * 69. Crea un array que contenga los nombres de los días de la semana, indicando los datos iniciales del array
 * entre llaves. Muestra todos los días en pantalla, desde el primero (lunes) hasta el último (domingo),
 * en una misma línea y separados por espacios. En la siguiente línea, muéstralos en orden inverso
 * (de domingo a lunes). Finalmente, pide al usuario un número de día (por ejemplo, el 3) y muestra su
 * nombre (el 3 sería Miércoles).
 * 
 * Autor: Igor (...)
*/

using System;

class Ej69
{
    static void Main()
    {
        try
        {
            string[] diasSem = {"Lunes", "Martes", "Miércoles", "Jueves", 
                    "Viernes", "Sábado", "Domingo" };
            byte dia;
            
            // Datos en orden directo
            for (int i = 0; i <= diasSem.Length - 1; i++)
            {
                if (i == diasSem.Length - 1)
                    Console.WriteLine("{0}", diasSem[i]);
                else
                    Console.Write("{0} ", diasSem[i]);
            }
            
            // Datos en orden inverso
            for (int i = diasSem.Length -1; i >= 0; i--)
            {
                if (i == 0)
                    Console.WriteLine("{0}", diasSem[i]);
                else
                    Console.Write("{0} ", diasSem[i]);
            }
            
            // Extraer uno
            Console.Write("Introduce el número del día de la semana (del 1 al 7 inclusive): ");
            dia = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("El día {0} es {1}.", dia, diasSem[dia-1]);

        }
        catch (Exception errorEncontrado)
        {
            Console.WriteLine("\a\nERROR FATAL: {0}", errorEncontrado.Message);
        }
    }
}
