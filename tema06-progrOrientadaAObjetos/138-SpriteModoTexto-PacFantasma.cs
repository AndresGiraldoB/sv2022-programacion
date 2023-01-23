/*

138. Para un esqueleto de juego de PacMan en modo consola, crea una clase 
Fantasma, que herede de SpriteModoTexto y cuyo constructor sólo recibirá los 
valores de X e Y, y prefijará el carácter a "A". Crea una clase Pac, que 
también herede de SpriteModoTexto y cuyo constructor sólo recibirá los valores 
de X e Y, y prefijará el carácter a "C". El primer Main de prueba creará un Pac 
y 4 Fantasmas, con coordenadas adecuadas, y los mostrará en pantalla. 
Probablemente, necesitarás crear un constructor vacío en SpriteModoTexto; 
mejoraremos ese detalle más adelante.

 * Autor: Igor (...) 1 DAW (usando como ejercicio base
 * https://github.com/ncabanes/sv2022-programacion/blob/main/tema06-progrOrientadaAObjetos/127-SpriteModoTexto-GetSet.cs).
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
        Pac pacMan = new Pac(40, 8);
        Fantasma fantasma0 = new Fantasma(36, 8);
        Fantasma fantasma1 = new Fantasma(44, 8);
        Fantasma fantasma2 = new Fantasma(40, 6);
        Fantasma fantasma3 = new Fantasma(40, 10);

        pacMan.Dibujar();
        fantasma0.Dibujar();
        fantasma1.Dibujar();
        fantasma2.Dibujar();
        fantasma3.Dibujar();
    }
}
