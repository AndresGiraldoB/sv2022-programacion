// Juan Manuel (...) 1º DAM Semipresencial

/*
141. Crea una nueva versión del ejercicio 136 (última versión de la clase
Titulo), partiendo de la "solución oficial", pero en la que, en vez de
"getters" y "setters" convencionales, emplees "propiedades" en FORMATO LARGO.
Puedes eliminar los destructores. Prueba su funcionamiento, cambiando la X y 
el texto después de crear el título y antes de mostrarlo.
Fuente:
https://github.com/ncabanes/sv2022-programacion/blob/main/
tema06-progrOrientadaAObjetos/136-Destructor.cs

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

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public string Texto
    {
        get { return texto; }
        set { texto = value; }
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

