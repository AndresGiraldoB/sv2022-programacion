/* 151. A partir de la "solución oficial" del ejercicio 147 (TituloCentrado y 
TituloSubrayado), crea una versión en la que no haya constructor vacío en la 
clase Titulo, sino que se utilice la palabra "base" donde sea necesario. */

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

    public Titulo(int nuevoX, int nuevoY, string nuevoTexto)
    {
        Texto = nuevoTexto;
        X = nuevoX;
        Y = nuevoY;
    }

    public virtual void Mostrar()
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Texto);
    }
}

// --------------------

class TituloSubrayado : Titulo
{
    public TituloSubrayado(int nuevoX, int nuevoY, string nuevoTexto)
        : base(nuevoX, nuevoY, nuevoTexto)
    {
    }

    public void Mostrar(char caracter)
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Texto);

        Console.SetCursorPosition(X, Y + 1);
        Console.WriteLine(new string(caracter, Texto.Length));
    }

    public override void Mostrar()
    {
        Mostrar('-');
    }
}

// --------------------

class TituloCentrado : Titulo
{
    public TituloCentrado(int nuevoY, string nuevoTexto)
        : base(40 - (nuevoTexto.Length / 2), nuevoY, nuevoTexto)
    {
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
    }
}

