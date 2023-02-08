/* Crea una clase abstracta FiguraGeometrica, con atributos "x" e "y" y con un 
método abstracto "Dibujar". 
  
Comprueba que no te deja instanciar objetos de esa clase.

Crea una clase Cuadrado, que herede de ella, que añada un atributo "lado". 
Implementa en ella el método "Dibujar", de modo que dibuje un cuadrado de ese 
lado, en esas coordenadas de pantalla (ayúdate de Console.SetCursorPosition).
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

class Cuadrado : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Cuadrado dibujado");
    }
}

