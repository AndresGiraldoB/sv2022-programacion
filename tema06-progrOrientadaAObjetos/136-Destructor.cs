//Francis (...) - 1ºDAM Semipresencial

/*
 * 136. A partir del ejercicio 135, añade un destructor a la clase "Titulo", 
 * que escriba en pantalla "Destruyendo el título". Comprueba el funcionamiento 
 * de esta versión del programa.
 */

using System;

class Titulo
{
    protected int x, y;
    protected string texto;

    public Titulo() { }

    public Titulo(int nuevoX, int nuevoY, string nuevoTexto)
    {
        texto = nuevoTexto;
        x = nuevoX;
        y = nuevoY;
    }
    
    ~Titulo() { Console.WriteLine("Destruyendo el título"); }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public string GetTexto()
    {
        return texto;
    }

    public void SetX(int nuevoX)
    {
        x = nuevoX;
    }

    public void SetY(int nuevoY)
    {
        y = nuevoY;
    }

    public void SetTexto(string nuevoTexto)
    {
        texto = nuevoTexto;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}

// --------------------

class TituloSubrayado : Titulo
{
    public TituloSubrayado(int nuevoX, int nuevoY, string nuevoTexto)
    {
        texto = nuevoTexto;
        x = nuevoX;
        y = nuevoY;
    }

    public new void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);

        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine(new string('-', texto.Length));
    }
}

// --------------------

class TituloCentrado : Titulo
{
    public TituloCentrado(int nuevoY, string nuevoTexto)
    {
        texto = nuevoTexto;
        x = 40 - (nuevoTexto.Length / 2);
        y = nuevoY;
    }
}

// --------------------

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo t1 = new Titulo(30, 3, "Hola");
        t1.Mostrar();

        TituloSubrayado t2 = new TituloSubrayado(25, 7, "Hola subrayado");
        t2.Mostrar();

        TituloSubrayado t3 = new TituloSubrayado(35, 11, "Hola");
        t3.Mostrar();

        TituloCentrado t4 = new TituloCentrado(15, "Hola centrado");
        t4.Mostrar();
    }
}
