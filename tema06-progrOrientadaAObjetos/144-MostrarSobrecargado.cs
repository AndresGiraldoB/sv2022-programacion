// Juan Manuel (...) 1º DAM Semipresencial

/*
144. A partir del ejercicio anterior (o, si no te ha salido, partiendo del
ejercicio 132), crea una nueva versión, que incluya una variante sobrecargada
del método "Mostrar" de la clase "TituloSubrayado", que recibirá como parámetro
el carácter con el que se desea que el texto aparezca subrayado.
Pruébalo en Main, mostrando dos títulos subrayados, uno de los cuales usará
guiones y otro usará "=".
*/

using System;

class Titulo
{
    protected byte x, y;

    public string Texto { get; set; }

    public int X
    {
        get { return x; }
        set { x = (byte)value; }
    }

    public int Y
    {
        get { return y; }
        set { y = (byte)value; }
    }

    public Titulo() { }

    public Titulo(int nuevoX, int nuevoY, string nuevoTexto)
    {
        Texto = nuevoTexto;
        X = nuevoX;
        Y = nuevoY;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Texto);
    }
}

// --------------------

class TituloSubrayado : Titulo
{
    public TituloSubrayado(int nuevoX, int nuevoY, string nuevoTexto)
    {
        Texto = nuevoTexto;
        X = nuevoX;
        Y = nuevoY;
    }

    public void Mostrar(char caracter)
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Texto);

        Console.SetCursorPosition(X, Y + 1);
        Console.WriteLine(new string(caracter, Texto.Length));
    }

    public new void Mostrar()
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Texto);

        Console.SetCursorPosition(X, Y + 1);
        Console.WriteLine(new string('-', Texto.Length));
    }
}

// --------------------

class TituloCentrado : Titulo
{
    public TituloCentrado(int nuevoY, string nuevoTexto)
    {
        Texto = nuevoTexto;
        X = 40 - (nuevoTexto.Length / 2);
        Y = nuevoY;
    }
}

// --------------------

class PruebaDeTitulo
{
    static void Main()
    {
        TituloSubrayado t1 = new TituloSubrayado(30, 3, "Hola subrayado1");
        t1.Mostrar('-');

        TituloSubrayado t2 = new TituloSubrayado(25, 7, "Hola subrayado2");
        t2.Mostrar('=');
    }
}
