/*
Crea una clase RecuadroRelleno, que herede de Recuadro, y cuyo método "Dibujar" 
muestre un rectángulo relleno, en vez de uno formado sólo por bordes. Los 
atributos deberán pasar a ser "protected".
*/

using System;

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro();
        r1.SetX(10);
        r1.SetY(2);
        r1.SetAnchura(40);
        r1.SetAltura(5);
        r1.Dibujar();

        RecuadroRelleno r2 = new RecuadroRelleno();
        r2.SetX(20);
        r2.SetY(4);
        r2.SetAnchura(20);
        r2.SetAltura(10);
        r2.Dibujar();
    }
}

class Recuadro
{
    protected int x, y;
    protected int anchura, altura;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetAnchura() { return anchura; }
    public int GetAltura() { return altura; }

    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }
    public void SetAltura(int nuevaAltura) { altura = nuevaAltura; }
    public void SetAnchura(int nuevaAnchura) { anchura = nuevaAnchura; }

    public void Dibujar()
    {
        for (int fila = 1; fila <= altura; fila++)
        {
            for (int columna = 1; columna <= anchura; columna++)
            {
                if ((fila == 1) || (fila == altura)
                    || (columna == 1) || (columna == anchura))
                {
                    Console.SetCursorPosition(x + columna, y + fila);
                    Console.WriteLine("#");
                }
            }
        }
    }

}

class RecuadroRelleno : Recuadro
{
    public new void Dibujar()
    {
        for (int fila = 1; fila <= altura; fila++)
        {
            for (int columna = 1; columna <= anchura; columna++)
            {
                Console.SetCursorPosition(x + columna, y + fila);
                Console.WriteLine("#");
            }
        }
    }
}
