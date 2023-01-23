// Juan Manuel (...) 1º DAM Semipresencial

/*
134. Prepara una nueva versión del ejercicio anterior, en la que la clase
"Titulo" tenga un constructor con los parámetros (x, y, texto) en vez del
método Inicializar, y también haya otro consutructor similar en
"TituloSubrayado". Pruébalo desde "Main", con los mismos valores que antes.
Quizá necesites crear un constructor vacío en "Título" para evitar errores de
compilación; lo mejoraremos más adelante.
*/

using System;

class Titulo
{
    protected int x, y;
    protected string texto;

    public Titulo() { }

    public Titulo(int nuevoX, int nuevoY, string nuevoTexto)
    {
        x = nuevoX;
        y = nuevoY;
        texto = nuevoTexto;
    }

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
        x = nuevoX;
        y = nuevoY;
        texto = nuevoTexto;
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

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo titulo = new Titulo(30, 5, "Hola");
        titulo.Mostrar();
                
        TituloSubrayado titulo1 = new TituloSubrayado(35, 11, "Hola");
        titulo1.Mostrar();
    }
}
