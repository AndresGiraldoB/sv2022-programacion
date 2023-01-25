/*
Crea una variante de la clase Recuadro, empleando propiedades (en formato 
largo) en vez de "getters" y "setters" convencionales. Haz que los atributos 
sean privados, en vez de protegidos, de modo que la clase RecuadroRelleno use 
las propiedades, en vez de los atributos. Además, desde Main, cambia la X y el 
Caracter del primer rectángulo usando propiedades.
*/

using System;

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
    private int x, y;
    private int anchura, altura;
    private char caracter;

    public int X  { get { return x; } set { x = value; } }
    public int Y { get { return y; } set { y = value; } }

    public int Anchura
    {
        get { return anchura; }
        set { anchura = value; }
    }

    public int Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public char Caracter
    {
        get { return caracter; }
        set {caracter = value; }
    }


    public Recuadro(int nuevaX, int nuevaY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        x = nuevaX;
        y = nuevaY;
        altura = nuevaAltura;
        anchura = nuevaAnchura;
        caracter = nuevoCaracter;
    }

    public Recuadro(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        altura = 10;
        anchura = 40;
        caracter = '*';
    }

    public Recuadro() // Para que funcione la herencia (por ahora)
    {
    }

    public void Dibujar()
    {
        for (int fila = 1; fila <= altura; fila++)
        {
            for (int columna = 1; columna <= anchura; columna++)
            {
                if ((fila == 1) || (fila == altura)
                    || (columna == 1) || (columna == anchura))
                {
                    Console.SetCursorPosition(x + columna, y + fila);
                    Console.WriteLine(caracter);
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
