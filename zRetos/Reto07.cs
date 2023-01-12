/*
Estadísticas sencillas

Sergey ha hecho N mediciones. Ahora, quiere saber el valor medio de las medidas realizadas.

Para que el promedio represente mejor las medidas, antes de calcularlo quiere eliminar las 
K medidas más altas y las K más bajas. Después de eso, calculará el valor promedio entre las 
mediciones restantes de N - 2K.

¿Podrías ayudar a Sergey a encontrar el valor promedio que obtendrá después de estas manipulaciones?

Entrada

La primera línea de la entrada contiene un número entero T que indica el número de casos de prueba. 
La descripción de los casos de prueba T sigue.

La primera línea de cada caso de prueba contiene dos números enteros N y K separados por espacios que 
indican el número de mediciones y cantidad de valores mayor y menor que se eliminarán.

La segunda línea contiene N enteros separados por espacios A1, A2, ..., AN que denotan las medidas.

Salida

Para cada caso de prueba, deberás responder con una sola línea que contenga el valor promedio después de 
eliminar las K mediciones más bajas y las K más grandes.

Tu respuesta se considerará correcta, en caso de que tenga un error absoluto o relativo, 
que no exceda de 10-6.

Restricciones

1 ≤ T ≤ 100

1 ≤ N ≤ 104

0 ≤ 2K < N

-106 ≤ Ai ≤ 106

Ejemplo de entrada

3
5 1
2 9 -10 25 1
5 0
2 9 -10 25 1
3 1
1 1 1

Salida para esa entrada

4.000000
5.400000
1.000000

Explicación

Ejemplo 1. Después de eliminar 1 medida mayor y 1 medida menor, obtenemos el conjunto {2, 9, 1}. 
El valor promedio en este conjunto es (2+9+1)/3=4.

Ejemplo 2. El valor promedio en el conjunto {2, 9, -10, 25, 1} es (2+9-10+25+1)/5=5.4.

Ejemplo 3. Después de eliminar las 1 medida más grande y la más pequeña, Sergey se quedará con 
una sola medida, es decir, 1. El promedio de esto es 1.
*/

// Solución por Nacho

using System;

public class Simpstat
{
    public static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < casos; i++) 
        {
            // Leo la cantidad de datos y cuántos a eliminar
            string[] detalles = Console.ReadLine().Split();
            int cantidad = Convert.ToInt32(detalles[0]);
            int eliminar = Convert.ToInt32(detalles[1]);

            // Leo los datos individuales y vuelco a array de enteros
            string[] numerosStr = Console.ReadLine().Split();
            int[] datos = new int[cantidad];
            for (int j = 0; j < cantidad; j++)
            {
                datos[j] = Convert.ToInt32(numerosStr[j]);
            }
            
            // Ordeno y sumo los datos centrales
            Array.Sort (datos);
            double suma = 0;
            for (int j = eliminar; j < cantidad-eliminar; j++)
            {
                suma += datos[j];
            }
            
            // Finalmente, muestro la media
            Console.WriteLine (suma / (cantidad - eliminar*2));
        }
    }
}
