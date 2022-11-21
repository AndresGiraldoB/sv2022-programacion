/*80. Crea una variante del programa anterior, que pregunte al usuario cuántos 
datos guardará en un primer bloque de números reales de doble precisión, 
luego cuántos datos guardará en un segundo bloque, y finalmente pida todos esos datos. 
Los debe guardar en un array de arrays. Después mostrará el promedio de los valores que 
hay guardados en el primer subarray, luego el promedio de los valores en el segundo subarray 
y finalmente el promedio global.

Miguel Angel (...)
*/

using System;

class Ejercicio80
{
    static void Main()
    {
        double[][] datos = new double[2][];
        
        Console.Write("¿Cuántos datos guardarás en el primer bloque de números? ");
        int primerBloque = Convert.ToInt32(Console.ReadLine());
        datos[0] = new double[primerBloque];
        
        Console.Write("¿Cuántos datos guardarás en el segundo bloque de números? ");
        int segundoBloque = Convert.ToInt32(Console.ReadLine());
        datos[1] = new double[segundoBloque];
        
        // Petición de datos
        for (int i=0; i<datos.Length; i++)
        {
            for (int j=0; j < datos[i].Length; j++)
            {
                Console.Write("Dime un número ({0}, {1}): ", i+1, j+1);
                datos[i][j]= Convert.ToInt32(Console.ReadLine());
            }
        }
        
        // Promedio de los valores que hay guardados en el cada subarray
        for (int i=0; i<datos.Length; i++)
        {
            double sumaSubArray=0;
            for (int j=0; j < datos[i].Length; j++)
            {
                sumaSubArray += datos[i][j];
            }
            Console.WriteLine( "Promedio del bloque {0}: {1}",
                i+1, sumaSubArray / datos[i].Length );
        }
        
        // Promedio global
        double sumaGlobal=0;
        int cantidadDatos = 0;
        for (int i=0; i<datos.Length; i++)
        {
            for (int j=0; j < datos[i].Length; j++)
            {
                sumaGlobal+=datos[i][j];
                cantidadDatos++;
            }
        }
        Console.WriteLine("Promedio global: " + sumaGlobal / cantidadDatos);
    }
}
    
