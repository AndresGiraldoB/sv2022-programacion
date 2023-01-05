/*Reto 02: Comida de equipo
¡Hoy es nuestra comida de equipo quincenal! Esta vez, vamos a nuestro restaurante indio favorito 
y queremos saber de antemano el número mínimo de mesas necesarias para acomodar a todos los miembros del equipo.

Todas las mesas tienen forma cuadrada, siempre deben estar unidas en una fila
y no puede haber más de un comensal sentado a cada lado de la mesa.

Ejemplo para 4 comensales:

     O
   +---+
 O | 1 | O
   +---+
     O


4 comensales -> 1 mesa

Ejemplo para 5 comensales:

     O   O
   +---+---+
 O | 1 | 2 |
   +---+---+
     O   O
5 comensales -> 2 mesas

Entrada
En la primera línea, un entero T indica el número de casos. 
Cada caso se describe en una línea con un entero N que indica el número de comensales.

Salida
Para cada caso t, la salida es la cadena Case #t: r donde t es el número de caso y r es el resultado.

Límites

1 <= T <= 50

0 <= N <= 2^16


Entrada de ejemplo
8
2
4
6
5
7
3
26073
59794

Salida de ejemplo
Case #1: 1
Case #2: 1
Case #3: 2
Case #4: 2
Case #5: 3
Case #6: 1
Case #7: 13036
Case #8: 29896
*/


using System;

class Reto02
{
    static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        int mesas;

        for (int i = 0; i < casos; i++)
        {
            int comensales = Convert.ToInt32(Console.ReadLine());
            if (comensales < 4)
                mesas = 1;
            else
                mesas = (comensales - 1)/ 2;
            Console.WriteLine("Case #{0}: {1}",casos + 1, mesas);
        }
    }
}
