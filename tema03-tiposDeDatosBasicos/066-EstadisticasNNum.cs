/* Juan Manuel (...) 1º DAM Semipresencial */

/*
66. Escribe un programa que pida al usuario números reales de doble
precisión, tras cada introducir cada número, muestre cuál es hasta
ese momento el máximo, mínimo, suma y media. Terminará cuando
introduzca la palabra "fin":

Dato: 5
Max = 5, Min = 5, Suma = 5, Media = 5
Dato: 2.2
Max = 5, Min = 2.2, Suma = 7.2, Media = 3.6
Dato: fin
¡Hasta otra!
Pista: deberás leer lo que introduzca el usuario como string, 
y convertir a dato numérico sólo en caso de que no sea la palabra "fin".
*/

using System;

class Ejercicio66
{
    static void Main()
    {
        string dato;
        double datoNumerico, minimo = 0, maximo = 0, suma=0, media;
        int contadorLecturas = 1;

        do
        {
            Console.Write("Dato "+contadorLecturas+" (\"fin\" para terminar): ");
            dato = Console.ReadLine();

            if (dato != "fin")
            {
                datoNumerico = Convert.ToDouble(dato);

                if (contadorLecturas == 1)// Inicializamos 
                {
                    minimo = maximo = suma = media = datoNumerico;
                }
                else
                {
                    if (datoNumerico > maximo)
                    {
                        maximo = datoNumerico;
                    }
                    if (datoNumerico < minimo)
                    {
                        minimo = datoNumerico;
                    }
                    suma += datoNumerico;
                    media = suma / contadorLecturas;
                }
                Console.WriteLine("Max = {0}, Min = {1}, Suma = {2}, Media = {3}",
                maximo, minimo, suma, media);
                contadorLecturas++;
            }
            else
            {
                Console.WriteLine("¡Hasta otra!");
            }

        } while (dato != "fin");
    }
}

