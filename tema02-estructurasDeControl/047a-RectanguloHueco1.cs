/*47. Muestra un rectángulo hueco, con el ancho y el alto que elija el usuario, 
 * y usando como símbolo el número que escoja el usuario, como en este ejemplo:
Ancho? 5
Alto? 3
Número? 1
11111
1   1
11111


Manuel Jesús (...) */

using System;

class Rectangulo
{
    static void Main()
    {
        int alto, ancho, simbolo;
        Console.WriteLine("Dime el alto");
        alto = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime el ancho");
        ancho = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qué símbolo quieres mostrar");
        simbolo = Convert.ToInt32(Console.ReadLine());

        for ( int fila = 1; fila <= alto; fila++)
        {
            for (int columna = 1; columna <= ancho; columna++)
            {
                if (((columna == 1) || (columna == ancho)) 
                    || ((fila == 1) || (fila == alto)))
                {
                    Console.Write(simbolo);
                }
                else 
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
