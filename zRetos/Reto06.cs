/* 
Estudiando el alfabeto
Chef tiene un hermano menor, Jeff, que está aprendiendo a leer.

Sólo conoce algunas letras del alfabeto. Para ayudar a Jeff a estudiar, 
Chef le dio un libro con el texto compuesto por N palabras. Jeff puede leer 
una palabra si sólo está formada por las letras que conoce.

Ahora Chef siente curiosidad por saber qué palabras podrá leer su hermano y 
cuáles no. ¿Puedes ayudarle?

Entrada

La primera línea de la entrada contiene una cadena de letras minúsculas S, 
que consta de las letras que Jeff puede leer. Cada letra aparecerá en S no más 
de una vez.

La segunda línea de la entrada contiene un número entero N que indica el número 
de palabras del libro.

Cada una de las siguientes N líneas contiene una sola cadena de letras latinas 
minúsculas Wi, que denota la i-ésima palabra del libro.

Salida

Para cada una de las palabras, debes escribir "Yes" (sin comillas) en caso de que 
Jeff pueda leerlo y "No" (sin comillas) en caso contrario.

Restricciones

1 ≤ |S| ≤ 26

1 ≤ N ≤ 1000

1 ≤ |Wi| ≤ 12

Cada letra aparecerá en S no más de una vez.

S, Wi están formadas sólo por letras latinas minúsculas.

Ejemplo de entrada

act
3
cat
dog
tactac


Salida para esa entrada

Yes
No
Yes

Explicación

La primera palabra se puede leer.
La segunda palabra contiene las letras d, o y g que Jeff no conoce.

Autor: Igor (...)
*/

using System;

class Reto06
{
    static void Main()
    {
        string letras = Console.ReadLine();
        ushort casos = Convert.ToUInt16(Console.ReadLine());
        for (ushort i = 0; i < casos; i++)
        {
            byte letrasEncontradas = 0;
            string palabra = Console.ReadLine();
            for (byte j = 0; j < palabra.Length; j++)
                if (letras.Contains("" + palabra[j]))
                    letrasEncontradas++;
            Console.WriteLine(letrasEncontradas == palabra.Length ? "Yes" : "No");
        }
    }
}
