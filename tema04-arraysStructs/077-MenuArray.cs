//Francisco de Borja (...)

/*77.Crea una nueva versión del programa del menú (ejercicio 62), 
 * en el que los textos de los menús estarán almacenados en un array.
 * La apariencia deberá ser algo como:

1.Jugar nueva partida
2. Cargar partida
3. Ver mejores puntuaciones
0. Salir
2
Ha escogido la opción "2": "Cargar partida"
(puedes optar por que la opción "Salir" sea siempre la 0 - lo que es 
ligeramente más difícil -, o bien por que las opciones sean números del 1 al 4,
siendo "Salir" la 4 - lo que es algo más fácil -, a tu criterio).*/

using System;

class Ejercicio77
{
    static void Main()
    {
        int seleccion;
        string[] opciones = { "Salir", "jugar nueva partida", "Cargar partida", 
            "Ver mejores puntuaciones"};

        Console.WriteLine("Escoja una de las opciones");
        for (int i = 0; i < opciones.Length; i++)
        {
            Console.WriteLine("{0}. {1}", i, opciones[i]);
        }

        seleccion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ha escogido la opcion \"{0}\": \"{1}\"",
                seleccion, opciones[seleccion]);
    }
}
