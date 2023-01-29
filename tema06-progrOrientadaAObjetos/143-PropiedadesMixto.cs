// Juan Manuel (...= 1º DAM Semipresencial

/*
143.Crea una nueva versión del ejercicio 136 (última versión de la clase Titulo)
, partiendo de la "solución oficial", pero en la que, en vez de "getters" y 
"setters" convencionales, emplees "propiedades", usando el formato compacto
cuando sea posible, pero teniendo en cuenta que las propiedades X e Y deben ser
de tipo "int", pero ocultar datos que internamente serán de tipo "byte". 
Prueba su funcionamiento, cambiando la X y el texto antes de mostrar el título.
Puedes eliminar los destructores.
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
        Titulo t1 = new Titulo(30, 3, "Hola");
        t1.X = 1;
        t1.Texto = t1.Texto + ", hemos cambiado el texto";
        t1.Mostrar();

        TituloSubrayado t2 = new TituloSubrayado(25, 7, "Hola subrayado");
        t2.Mostrar();

        TituloSubrayado t3 = new TituloSubrayado(35, 11, "Hola");
        t3.Mostrar();

        TituloCentrado t4 = new TituloCentrado(15, "Hola centrado");
        t4.Mostrar();
    }
}

