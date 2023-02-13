/*
 * 164. Crea una interfaz "Dibujable", con un método (void) Dibujar, y una 
 * interfaz "Medible", con un método (int) GetArea. Crea una clase 
 * RectanguloEnPantalla, con atributos x1, y1 (esquina superior izquierda), x2, y2 
 * (esquina inferior derecha) y que debe implementar ambas interfaces. No es 
 * necesario que el método Dibujar realmente haga "nada útil", basta con que 
 * escriba "Dibujando"; de igual modo, no es necesario que el método GetArea 
 * devuelva el área real del rectángulo, puede devolver un 0. Si lo prefieres, 
 * puedes hacer que realmente se dibuje en pantalla y que realmente se calcule su 
 * área. En cualquier caso, comprueba el comportamiento de tu clase.
 * 
 * Alumno: Omar (...)
*/

using System;

interface Dibujable
{
    void Dibujar();
}

interface Medible
{
    int GetArea();
}

class RectanguloEnPantalla : Dibujable, Medible
{
    int x1, y1, x2, y2;
    
    public RectanguloEnPantalla(int x1, int x2, int y1, int y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
    
    public void Dibujar()
    {
        Console.WriteLine("Dibujando");
    }
    
    public int GetArea()
    {
        return 0;
    }
}

class PruebaDeRectangulo
{
    static void Main()
    {
        RectanguloEnPantalla rectangulo = new RectanguloEnPantalla(1, 2, 3, 4);
        
        rectangulo.Dibujar();
        Console.WriteLine("Area: " + rectangulo.GetArea() );
    }
}
