// Juan Manuel (...) 1º DAM semipresencial

/*
145.Si tus dos variantes del método "Mostrar" en la clase "TituloSubrayado"
son repetitivas, crea una nueva versión en la que una se apoye en la otra para
que tu programa no resulte repetitivo.
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
        Mostrar('-');
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

        TituloSubrayado t3 = new TituloSubrayado(50, 10, "Hola subrayado3");
        t3.Mostrar();
    }
}



