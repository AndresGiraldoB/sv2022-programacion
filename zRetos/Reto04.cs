/*
Reto 04: Máximo menos mínimo

Recibirás 3 números enteros A, B y C tales que A <= B  <=C.

Debes encontrar el valor de max(A, B, C) - min(A, B, C)

Formato de entrada

La primera línea de entrada contendrá un solo entero T, que denota el 
número de casos de prueba.

Cada caso de prueba consta de 3 números enteros A, B, C.

Formato de salida

Para cada caso de prueba, muestra el valor de max(A, B, C) - min(A, B, C).

Restricciones
1 ≤ T ≤ 10
1 ≤ A < B < C ≤ 10


Ejemplo de entrada

4
1 3 10
5 6 7
3 8 9
2 5 6

Salida para esa entrada

9
2
6
4

*/

//Francis (...), retoques por Nacho

using System;
class Reto04_MaximosMenosMinimo
{
    static void Main()
    {
        byte T = Convert.ToByte(Console.ReadLine());
        byte A, B, C;

        for (byte i = 0; i < T; i++)
        {
            string[] numerosComoCadena = Console.ReadLine().Split();
            A = Convert.ToByte(numerosComoCadena[0]);
            B = Convert.ToByte(numerosComoCadena[1]);
            C = Convert.ToByte(numerosComoCadena[2]);

            Console.WriteLine(C - A);
        }
    }
}
