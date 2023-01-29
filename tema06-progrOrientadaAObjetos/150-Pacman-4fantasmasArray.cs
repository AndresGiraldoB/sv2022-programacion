/*150. Crea una nueva versión del fuente de Pac y los 4 fantasmas 
 * (ejercicio 149), en el que los 4 fantasmas sean parte de un único 
 * array. Comprueba que se mueven correctamente.
 
 Radha */

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

    public virtual void Mover()
    {
    }

    public SpriteModoTexto() { }

    public SpriteModoTexto(byte nuevaX, byte nuevaY, char nuevoCaracter)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = nuevoCaracter;
    }
}

// ----------

class Fantasma : SpriteModoTexto
{
    public Fantasma(byte nuevaX, byte nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'A';
    }
    
    public Fantasma()
    {
    }
}

// ----------

class FantasmaAzul : Fantasma
{
    public FantasmaAzul(byte nuevaX, byte nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'A';
    }

    public override void Mover()
    {
        x++;
    }
}

// ----------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(byte nuevaX, byte nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'A';
    }

    public override void Mover()
    {
        y--;
    }
}

// ----------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(byte nuevaX, byte nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'A';
    }

    public override void Mover()
    {
        y++;
    }
}

// ----------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(byte nuevaX, byte nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'A';
    }

    public override void Mover()
    {
        x--;
    }
}

// ----------

class Pac : SpriteModoTexto
{
    public Pac(byte x, byte y)
    {
        this.x = x;
        this.y = y;
        caracter = 'C';
    }
}

// ----------

class PacMan
{
    static void Main()
    {
        ConsoleKeyInfo tecla;
        Pac pac = new Pac(40, 8);
        SpriteModoTexto[] fantasmas = new SpriteModoTexto[4];
        fantasmas[0] = new FantasmaAzul(36, 8);
        fantasmas[1] = new FantasmaRojo(44, 8);
        fantasmas[2] = new FantasmaRosa(40, 6);
        fantasmas[3] = new FantasmaNaranja(40, 10);

        do
        {
            pac.Dibujar();
            // Dibujado: recorriendo el array con "for", por ejemplo
            for (int i = 0; i < 4; i++)
            {
                fantasmas[i].Dibujar();
            }

            tecla = Console.ReadKey();

            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                pac.MoverIzquierda();
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                pac.MoverDerecha();
            }
            else if (tecla.Key == ConsoleKey.UpArrow)
            {
                pac.MoverArriba();
            }
            else if (tecla.Key == ConsoleKey.DownArrow)
            {
                pac.MoverAbajo();
            }
            
            // Movimiento: recorriendo el array con "foreach", por ejemplo
            foreach (SpriteModoTexto f in fantasmas)
            {
                f.Mover();
            }
            
            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape);
    }
}
