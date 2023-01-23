/* 132. Crea una nueva versión de clase "Titulo" y "TituloSubrayado" (ej.131), 
 * en la que los atributos sean "protected", y emplees los atributos 
 * en vez de "getters". Pruébalo en "Main".
 * 
 * 
 * Radha
 * 
 * */


using System;

class Titulo
{
    protected int x, y;
    protected string texto;

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
        
        Console.SetCursorPosition(x, y+1);
        for(int i = 0;i < texto.Length; i++)
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
