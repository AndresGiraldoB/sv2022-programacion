/*

139. Crea un esqueleto mejorado para el juego de PacMan: el nuevo Main 
permitirá mover a Pac se pulsen las flechas del teclado, para lo que puedes 
tomar ideas del siguiente fragmento de código:

ConsoleKeyInfo tecla = Console.ReadKey();

if (tecla.Key == ConsoleKey.LeftArrow)
    pac.MoverIzquierda();
else if (tecla.Key == ConsoleKey.RightArrow)
    pac.MoverDerecha();

Este esqueleto deberá repetirse hasta que se pulse la tecla Escape. Te 
interesará borrar la pantalla con Console.Clear();

Autor: Igor Loza Ramos 1 DAW (usando como ejercicio base
https://github.com/ncabanes/sv2022-programacion/blob/main/tema06-progrOrientadaAObjetos/127-SpriteModoTexto-GetSet.cs).
*/

using System;

class SpriteModoTexto
{
    protected byte x, y;
    protected char caracter;

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
    
    public void MoverArriba()
    {
        y--;
    }

    public void MoverAbajo()
    {
        y++;
    }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
    }

    public SpriteModoTexto() { }

    public SpriteModoTexto(byte x, byte y, char caracter)
    {
        this.x = x;
        this.y = y;
        this.caracter = caracter;
    }


} // fin clase SpriteModoTexto

class Fantasma : SpriteModoTexto
{
    public Fantasma(byte x, byte y)
    {
        this.x = x;
        this.y = y;
        caracter = 'A';
    }
}

class Pac : SpriteModoTexto
{
    public Pac(byte x, byte y)
    {
        this.x = x;
        this.y = y;
        caracter = 'C';
    }
}

class PruebaDeSprite
{
    static void Main()
    {
        ConsoleKeyInfo tecla;
        Pac pac = new Pac(40, 8);
        Fantasma fantasma0 = new Fantasma(36, 8);
        Fantasma fantasma1 = new Fantasma(44, 8);
        Fantasma fantasma2 = new Fantasma(40, 6);
        Fantasma fantasma3 = new Fantasma(40, 10);

        do
        {
            pac.Dibujar();
            fantasma0.Dibujar();
            fantasma1.Dibujar();
            fantasma2.Dibujar();
            fantasma3.Dibujar();
            
            tecla = Console.ReadKey();
            
            if (tecla.Key == ConsoleKey.LeftArrow)
                pac.MoverIzquierda();
            else if (tecla.Key == ConsoleKey.RightArrow)
                pac.MoverDerecha();
            else if (tecla.Key == ConsoleKey.UpArrow)
                pac.MoverArriba();
            else if (tecla.Key == ConsoleKey.DownArrow)
                pac.MoverAbajo();
                
            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape);
    }
}
