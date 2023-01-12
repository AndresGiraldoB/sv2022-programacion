/* José Manuel (...) 1º DAW semipresencial

Reto 05: Máximo menos mínimo V2
Recibirás 3 números enteros A, B y C.

Debes encontrar el valor de max(A, B, C) - min(A, B, C)

Formato de entrada

La primera línea de entrada contendrá un solo entero T, que denota el número de
casos de prueba.

Cada caso de prueba consta de 3 números enteros A, B, C.

Formato de salida

Para cada caso de prueba, muestra el valor de max(A, B, C) - min(A, B, C).

Restricciones

1 ≤ T ≤ 1.000.000.000
1 ≤ A ≤ 1 · 1012
1 ≤ B ≤ 1 · 1012
1 ≤ C ≤ 1 · 1012

Ejemplo de entrada

4
1 35 10
7 6 5
12345678912 12345678913 12345678914
6 6 6

Salida para esa entrada

34
2
2
0

*/

using System;

class Reto5
{
    static void Main()
    {
        string bloqueNumero;
        long mayor, menor;

        long casos = Convert.ToInt64(Console.ReadLine());

        for (long i = 0; i < casos; i++)
        {
            bloqueNumero = Console.ReadLine();
            string[] fragmentosNumeros = bloqueNumero.Split();

            mayor = Convert.ToInt64(fragmentosNumeros[0]);
            menor = Convert.ToInt64(fragmentosNumeros[0]);

            for (int j = 1; j < fragmentosNumeros.Length; j++)
            {
                if (Convert.ToInt64(fragmentosNumeros[j]) > mayor)
                {
                    mayor = Convert.ToInt64(fragmentosNumeros[j]);
                }
                else if (Convert.ToInt64(fragmentosNumeros[j]) < menor)
                {
                    menor = Convert.ToInt64(fragmentosNumeros[j]);
                }
            }
            Console.WriteLine(mayor - menor);
        }
    }
}
