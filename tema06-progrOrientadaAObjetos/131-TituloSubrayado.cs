/* 131. Crea una clase "TituloSubrayado", que herede de "Titulo" (ej.123)
 * y que mostrará guiones debajo del título. Tu fuente contendrá 
 * las tres clases: Titulo (sin modificar), TituloSubrayado y PruebaDeTitulo. 
 * Pruébalo en "Main", mostrando un título subrayado. 
 * Quizá obtengas algún error de compilación si intentas acceder a 
 * los atributos, y debas emplear los "getters".
 * 
 * 
 * Radha
 * 
 * */


using System;

class Titulo
{
    private int x, y;
    private string texto;

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
        Console.SetCursorPosition(GetX(), GetY());
        Console.WriteLine(GetTexto());
        
        Console.SetCursorPosition(GetX(), GetY()+1);
        for(int i = 0;i < GetTexto().Length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}

// --------------------

class PruebaDeTitulo
{
    static void Main()
    {
        TituloSubrayado titulo = new TituloSubrayado();

        titulo.SetX(30);
        titulo.SetY(5);
        titulo.SetTexto("Hola");
        titulo.Mostrar();
    }
}

