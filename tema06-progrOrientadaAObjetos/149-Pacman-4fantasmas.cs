/* 149. A partir de la "solución oficial" del esqueleto de PacMan 
 * (ejercicio 139), ya sea en su versión como proyecto o en un único 
 * fichero, añade un método Mover a la clase Sprite, que inicialmente 
 * estará vacío. Crea cuatro subtipos de fantasmas, cada uno con un 
 * movimiento distinto. Por ejemplo, la clase FantasmaAzul puede moverse
 * hacia la derecha, la clase FantasmaNaranja hacia la izquierda,
 * el FantasmaRojo hacia arriba y el FantasmaRosa hacia abajo. 
 * Cada vez que el jugador pulse una tecla, no sólo se moverá Pac, 
 * sino también los cuatro fantasmas (que aún no serán parte de un array).
 
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
        FantasmaAzul fantasma0 = new FantasmaAzul(36, 8);
        FantasmaRojo fantasma1 = new FantasmaRojo(44, 8);
        FantasmaRosa fantasma2 = new FantasmaRosa(40, 6);
        FantasmaNaranja fantasma3 = new FantasmaNaranja(40, 10);

        do
        {
            pac.Dibujar();
            fantasma0.Dibujar();
            fantasma1.Dibujar();
            fantasma2.Dibujar();
            fantasma3.Dibujar();

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
            
            fantasma0.Mover();
            fantasma1.Mover();
            fantasma2.Mover();
            fantasma3.Mover();

            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape);
    }
}
