//Noelia (...)


/*Se denomina número reversible a aquél que al ser sumado a sí mismo tras
invertir sus dígitos da como resultado un número en el que todos los
dígitos son impares.

Por ejemplo, el número 36 es reversible pues 36 + 63 = 99, y los dos dígitos de 
99 son impares. Fíjate que esto significa que también el número 63 es reversible.
También lo son el 409 y el 904.

Para ser considerado número reversible, la cantidad de dígitos del número y de
su versión invertida debe ser el mismo. Por tanto, el número 1000 no es 
reversible, incluso aunque 1000 + 0001 = 1001. 
No se considera válido porque 0001 es en realidad el número 1, 
que tiene menos dígitos que 1000.

Hay más números reversibles de lo que podría parecer. 
Por ejemplo, hay 20 de 2 dígitos, y 100 de 3.

Entrada

La entrada está compuesta de una serie de casos de prueba. 
Cada uno contendrá una línea, con un número positivo menor que 109.

Un caso de prueba con un 0 indica el final, y no deberá procesarse.

Salida

Para cada caso de prueba el programa deberá escribir SI si el número
es reversible, y NO si no lo es.


Entrada de ejemplo

36
904
1000
37
209
0

Salida de ejemplo

SI
SI
NO
NO
SI

Origen: Acepta el reto, 193 - https://www.aceptaelreto.com/problem/statement.php?id=193
 */


using System;
using System.Text;

class Reto03
{
    static void Main()
    {
        string entrada = Console.ReadLine();

        while (entrada != "0" )
        {
            string cadenaInvertida = "";
            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                cadenaInvertida = cadenaInvertida + entrada[i];
            }

            int numeroReves = Convert.ToInt32(cadenaInvertida);
            int numero = Convert.ToInt32(entrada);
            long suma = numero + numeroReves;

            bool reversible = true;

            if (( entrada[0] == '0') || ( cadenaInvertida[0] == '0'))
                reversible = false;

            while (suma != 0 && reversible == true)
            {
                if (suma % 2 == 0)
                {
                    reversible = false;
                }
                else
                {
                    suma /= 10;
                }
            }

            if (reversible)
            {
                Console.WriteLine( "SI" );
            }
            else
            {
                Console.WriteLine( "NO" );
            }

            entrada = Console.ReadLine ();
        }
    }
}
