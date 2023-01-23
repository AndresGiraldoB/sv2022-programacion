// Juan Manuel (...) 1º DAM Semipresencial

/*
133. Crea una versión mejorada del ejercicio anterior, con un método 
"Inicializar(x, y, texto)" para la clase "Título", que permita fijar 
a la vez los valores iniciales para x, y, texto. Pruébalo desde "Main"
escribiendo un título subrayado con los valores: 
texto = "Hola", x = 35, y = 11
*/

using System;

class Titulo
{
    protected int x, y;
    protected string texto;
    
    public void Inicializar(int nuevoX, int nuevoY, string nuevoTexto)
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
        TituloSubrayado titulo2 = new TituloSubrayado();
        titulo2.Inicializar(35, 11, "Hola");
        titulo2.Mostrar();
    }
}
