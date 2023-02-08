/* Etiqueta la clase Cuadrado como "sellada". Comprueba que no se te permite de 
heredar de ella.
*/

using System;

class PruebaDeFiguraGeometrica
{
    static void Main()
    {
        Cuadrado f = new Cuadrado();
        f.Dibujar();
    }
}

// ---------------

abstract class FiguraGeometrica
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Dibujar();
}

sealed class Cuadrado : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Cuadrado dibujado");
    }
}

/*
class Rectangulo : Cuadrado
{
    public override void Dibujar()
    {
        Console.WriteLine("Rectangulo dibujado");
    }
}
*/
