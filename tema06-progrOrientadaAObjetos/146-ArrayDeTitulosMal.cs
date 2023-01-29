// Juan Manuel (...) 1º DAM Semipresencial

/*
146. A partir del ejercicio anterior (145), crea un programa cuyo Main prepare
un array de títulos. Este array contendrá un título convencional, un título
centrado y dos títulos subrayados, en distintas coordenadas de pantalla, y el
programa de prueba primero creará todos ellos y luego mostrará todos ellos.
Comprueba si los subrayados se ven correctamente.
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
        Titulo[] titulos = new Titulo[4];
        titulos[0] = new Titulo(5, 3, "Hola, título convencional");
        titulos[1] = new TituloCentrado(7, "Hola, título centrado");
        titulos[2] = new TituloSubrayado(50, 10, "Hola, título subrayado1");
        titulos[3] = new TituloSubrayado(40, 16, "Hola, título subrayado2");
       
        foreach (var t in titulos)
        {
            t.Mostrar();
        }

        // Se ejecuta Mostrar() de la clase Titulo y no la de TituloSubrayado

    }
}
