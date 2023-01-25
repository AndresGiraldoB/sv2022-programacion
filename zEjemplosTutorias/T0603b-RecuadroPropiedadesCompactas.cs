/* Crea una variante de la clase Recuadro, empleando propiedades (en formato 
corto) en vez de "getters" y "setters" convencionales.
*/

using System;
using System.Net.WebSockets;

class PruebaDeRecuadro
{
    static void Main()
    {
        // Recuadro r1 = new Recuadro(10, 2, 40, 5, '#');
        Recuadro r1 = new Recuadro(10, 2);
        r1.X = 15;
        r1.Caracter = 'H';
        r1.Dibujar();

        RecuadroRelleno r2 = new RecuadroRelleno(20, 4, 20, 10, 'M');
        r2.Dibujar();
    }
}

class Recuadro
{
    public int X  { get; set; }
    public int Y { get; set; }
    public int Anchura { get; set; }
    public int Altura { get; set; }
    public char Caracter { get; set; }

    public Recuadro(int nuevaX, int nuevaY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        X = nuevaX;
        Y = nuevaY;
        Altura = nuevaAltura;
        Anchura = nuevaAnchura;
        Caracter = nuevoCaracter;
    }

    public Recuadro(int nuevaX, int nuevaY)
    {
        X = nuevaX;
        Y = nuevaY;
        Altura = 10;
        Anchura = 40;
        Caracter = '*';
    }

    public Recuadro() // Para que funcione la herencia (por ahora)
    {
    }

    public void Dibujar()
    {
        for (int fila = 1; fila <= Altura; fila++)
        {
            for (int columna = 1; columna <= Anchura; columna++)
            {
                if ((fila == 1) || (fila == Altura)
                    || (columna == 1) || (columna == Anchura))
                {
                    Console.SetCursorPosition(X + columna, Y + fila);
                    Console.WriteLine(Caracter);
                }
            }
        }
    }

}

class RecuadroRelleno : Recuadro
{
    public RecuadroRelleno(int nuevaX, int nuevaY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        X = nuevaX;
        Y = nuevaY;
        Altura = nuevaAltura;
        Anchura = nuevaAnchura;
        Caracter = nuevoCaracter;
    }

    public new void Dibujar()
    {
        for (int fila = 1; fila <= Altura; fila++)
        {
            for (int columna = 1; columna <= Anchura; columna++)
            {
                Console.SetCursorPosition(X + columna, Y + fila);
                Console.WriteLine(Caracter);
            }
        }
    }
}
