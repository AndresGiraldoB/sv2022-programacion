/*
 * José Manuel (...)
 * 
 * 69. Crea un array que contenga los nombres de los días de la semana,
 * indicando los datos iniciales del array entre llaves. Muestra todos los
 * días en pantalla, desde el primero (lunes) hasta el último (domingo), en
 * una misma línea y separados por espacios. En la siguiente línea, muéstralos
 * en orden inverso (de domingo a lunes). Finalmente, pide al usuario un número
 * de día (por ejemplo, el 3) y muestra su nombre (el 3 sería Miércoles).
 */


using System;
class Ejercicio_69

{
    static void Main()
    {
        byte numeroDia;
        string[] diasDeLaSemana =
        {
            "Lunes", "Martes", "Miercoles", "Jueves", "Viernes",
            "Sábado", "Domingo"
        };

        // Datos en orden directo
        for (int i = 0; i < 7; i++)
        {
            Console.Write("{0} ", diasDeLaSemana[i]);
        }
        Console.WriteLine();
        
        // Datos en orden inverso
        for (int j = 6; j >= 0; j--)
        {
            Console.Write("{0} ", diasDeLaSemana[j]);
        }
        Console.WriteLine();
        
        // Extraer uno
        Console.WriteLine("Dime un número de día:");
        numeroDia = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Día de la semana es: {0}", 
            diasDeLaSemana[numeroDia - 1]);
    }
}
