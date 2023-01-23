// DAN 1DAW

/*
137. Crea una nueva versión de la clase SpriteModoTexto (ejercicio 127), 
con un constructor que permita dar valores inciiales para x, y, carácter. 
Los atributos deben pasar a ser "protected". Usa este constructor desde Main, 
en vez de los setters.
*/

using System;

class SpriteModoTexto
{
    protected byte x, y;
    protected char caracter;

    public SpriteModoTexto(byte nuevoX, byte nuevoY, char nuevoCaracter)
    {
        x = nuevoX;
        y = nuevoY;
        caracter = nuevoCaracter;
    }

    // Get
    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetCaracter() { return caracter; }

    //Set
    public void SetX(int nuevaX) { x = (byte)nuevaX; }
    public void SetY(int nuevaY) { y = (byte)nuevaY; }
    public void SetCaracter(char nuevoCaracter) { caracter = nuevoCaracter; }

    public void MoverDerecha()
    {
        x++;
    }

    public void MoverIzquierda()
    {
        x--;
    }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
    }
} // fin clase SpriteModoTexto


class PruebaDeSprite
{
    static void Main()
    {
        SpriteModoTexto nave = new SpriteModoTexto(40, 20, 'M');
       
        nave.Dibujar();

        nave.MoverDerecha();
        nave.Dibujar();

        nave.MoverIzquierda();
        nave.Dibujar();
    }
}
