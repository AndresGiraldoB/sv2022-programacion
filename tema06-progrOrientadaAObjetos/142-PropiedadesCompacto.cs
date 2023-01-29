// Juan Manuel (...) 1º DAM Semipresencial

/*
142.Crea una nueva versión del ejercicio 136 (última versión de la clase Titulo)
, partiendo de la "solución oficial", pero en la que, en vez de "getters" y
"setters" convencionales, emplees "propiedades" en FORMATO COMPACTO. Puedes 
eliminar los destructores. Prueba su funcionamiento, cambiando la X y el texto
después de crear el título y antes de mostrarlo.
*/

using System;

class Titulo
{
    public Titulo() { }

    public Titulo(int nuevoX, int nuevoY, string nuevoTexto)
    {
        Texto = nuevoTexto;
        X = nuevoX;
        Y = nuevoY;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public string Texto { get; set; }

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

