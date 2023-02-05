/* 152. A partir del ejercicio anterior (o del 147, si no has conseguido hacer 
el anterior), emplea "this" para que los constructores puedan tener parámetros 
con nombres como "x" en vez de "nuevaX". */

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

    public Titulo(int X, int Y, string Texto)
    {
        this.Texto = Texto;
        this.X = X;
        this.Y = Y;
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
    public TituloSubrayado(int X, int Y, string Texto)
        : base(X, Y, Texto)
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
    public TituloCentrado(int Y, string Texto)
        : base(40 - (Texto.Length / 2), Y, Texto)
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

