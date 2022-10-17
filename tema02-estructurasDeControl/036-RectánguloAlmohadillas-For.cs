// Francisco (...) - 1ºDAM Semipresencial

/* 
 * 36. Haz un programa que pida al usuario una altura y una anchura y que 
 * muestre, empleando la orden "for", un rectángulo formado por "almohadillas"
 * (el símbolo "hash") con esa altura y anchura, como en este ejemplo:
 * 
 *  Ancho? 3
 *  Alto? 5
 *  ###
 *  ###
 *  ###
 *  ###
 *  ###
 */

using System;

class RectanguloAlmohadillaFor
{
    static void Main()
    {
        int ancho, alto;

        Console.Write( "Ancho? " );
        ancho = Convert.ToInt32( Console.ReadLine() );

        Console.Write( "Alto? " );
        alto = Convert.ToInt32( Console.ReadLine() );

        for ( int fila = 0; fila < alto; fila++ )
        {
            for ( int columna = 0; columna < ancho; columna++ )
            {
                Console.Write( "#" );
            }

            Console.WriteLine();
        }
    }
}
