﻿/* Crea una nueva versión de la clase Recuadro, que, en vez del método 
"Inicializar", incluya un constructor para dar valores iniciales. Piensa qué 
cambios necesitarás en RecuadroRelleno. Pruébalo desde "Main".
 */

using System;

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro(10, 2, 40, 5, '#');
        r1.Dibujar();

        RecuadroRelleno r2 = new RecuadroRelleno(20, 4, 20, 10, 'M');
        //r2.Inicializar(20, 4, 20, 10, 'M');
        r2.Dibujar();
    }
}

class Recuadro
{
    protected int x, y;
    protected int anchura, altura;
    protected char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetAnchura() { return anchura; }
    public int GetAltura() { return altura; }
    public char GetCaracter() { return caracter; }

    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }
    public void SetAltura(int nuevaAltura) { altura = nuevaAltura; }
    public void SetAnchura(int nuevaAnchura) { anchura = nuevaAnchura; }
    public void SetCaracter(char nuevoCaracter) { caracter = nuevoCaracter; }

    public Recuadro(int nuevaX, int nuevaY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        x = nuevaX;
        y = nuevaY;
        altura = nuevaAltura;
        anchura = nuevaAnchura;
        caracter = nuevoCaracter;
    }

    public Recuadro() // Para que funcione la herencia (por ahora)
    { 
    }

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
                    Console.WriteLine(caracter);
                }
            }
        }
    }

}

class RecuadroRelleno : Recuadro
{
    public RecuadroRelleno(int nuevaX, int nuevaY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        x = nuevaX;
        y = nuevaY;
        altura = nuevaAltura;
        anchura = nuevaAnchura;
        caracter = nuevoCaracter;
    }

    public new void Dibujar()
    {
        for (int fila = 1; fila <= altura; fila++)
        {
            for (int columna = 1; columna <= anchura; columna++)
            {
                Console.SetCursorPosition(x + columna, y + fila);
                Console.WriteLine(caracter);
            }
        }
    }
}
