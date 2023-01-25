/* Crea una nueva versión del array formado por 4 recuadros, de los cuales 2 
serán de la clase Recuadro y 3 serán RecuadroRelleno. Emplea "virtual" y 
"override".
*/

using System;

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro[] recuadros = new Recuadro[5];
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 1)
                recuadros[i] = new Recuadro(i*2, i*2, (5+i)*2, (3+i)*2, 'M');
            else
                recuadros[i] = new RecuadroRelleno(i * 2, i * 2, (5 + i) * 2, (3 + i) * 2, 'M');
        }

        for (int i = 0; i < 5; i++)
        {
            recuadros[i].Dibujar();
        }
    }
}

class Recuadro
{
    public int X { get; set; }
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
