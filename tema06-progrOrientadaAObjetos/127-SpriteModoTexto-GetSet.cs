/*127. Crea una nueva versión de la clase "SpriteModoTexto". Sus atributos no
 * serán públicos, sino que tendrá "getters" y "setters" que permitan cambiar
 * el valor de éstos. Además, tendrá un método "MoverDerecha" que incrementará
 * la X en una unidad y otro "MoverIzquierda", que la disminuirá en una unidad.
 * Modifica el programa y "Main" según sea necesario. Deberás entregar sólo el
 * fichero .cs.
 **/

// Andrés (...) - 1DAW-Semipresencial.

using System;

class SpriteModoTexto
{
    private byte x, y;
    private char caracter;

    // Get
    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetCaracter() { return caracter; }

    //Set
    public void SetX(int nuevaX) { x = (byte) nuevaX; }
    public void SetY(int nuevaY) { y = (byte) nuevaY; }
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
        SpriteModoTexto nave = new SpriteModoTexto();

        nave.SetX(40);
        nave.SetY(20);
        nave.SetCaracter('M');
        nave.Dibujar();

        nave.MoverDerecha();
        nave.Dibujar();

        nave.MoverIzquierda();
        nave.Dibujar();
    }
}
