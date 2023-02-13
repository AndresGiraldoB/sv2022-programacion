// DAN 1DAW

/*
166. Mejora el esqueleto de PacMan (ejercicio 165), con estos tres detalles:

- En vez de emplear "is" para comprobar el tipo de cada fantasma, haz que el 
color cambie en el método dibujar de la propia clase Fantasma (y derivadas).

- Mejora las lógicas de movimiento para que no se salgan de ciertos límites 
(por ejemplo, una Y negativa actualmente provocará que el programa falle).

- Añade a la clase SpriteModoTexto un método booleano 
"ColisionaCon(otroSprite)", que te permita saber si dos elementos del juego 
chocan (basta con que mires si coinciden su X y su Y). 

Úsalo en el cuerpo del programa para que el juego termine si un fantasma toca 
al jugador. */

using System;

abstract class SpriteModoTexto
{
    protected byte x, y;
    protected char caracter;

    // Get
    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetCaracter() { return caracter; }

    //Set
    public void SetX(int x) { this.x = (byte)x; }
    public void SetY(int y) { this.y = (byte)y; }
    public void SetCaracter(char caracter) { this.caracter = caracter; }

    public void MoverDerecha()
    {
        if (x < Console.WindowWidth - 1)
            x++;
    }

    public void MoverIzquierda()
    {
        if (x > 0)
            x--;
    }

    public void MoverArriba()
    {
        if (y > 0)
            y--;
    }

    public void MoverAbajo()
    {
        if (y < Console.WindowHeight - 1)
            y++;
    }

    public virtual void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
    }

    public virtual void Mover()
    {
    }

    public bool ColisionaCon(SpriteModoTexto otroSprite)
    {
        return this.x == otroSprite.x && this.y == otroSprite.y;
    }

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
    public Fantasma(byte x, byte y)
        : base(x, y, 'A')
    {
    }
}

// ----------

class FantasmaAzul : Fantasma
{
    public FantasmaAzul(byte x, byte y)
        : base(x, y)
    {
    }

    public FantasmaAzul()
        : this(36, 8)
    {
    }

    public override void Mover()
    {
        if (x < Console.WindowWidth - 1)
            x++;
    }

    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Dibujar();
    }
}

// ----------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(byte x, byte y)
        : base(x, y)
    {
    }

    public FantasmaRojo()
        : this(44, 8)
    {
    }

    public override void Mover()
    {
        if (y > 0)
            y--;
    }

    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Dibujar();
    }
}

// ----------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(byte x, byte y)
        : base(x, y)
    {
    }

    public FantasmaRosa()
        : this(40, 6)
    {
    }

    public override void Mover()
    {
        if (y < Console.WindowHeight - 1)
            y++;
    }

    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        base.Dibujar();
    }
}

// ----------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(byte x, byte y)
        : base(x, y)
    {
    }

    public FantasmaNaranja()
        : this(40, 10)
    {
    }

    public override void Mover()
    {
        if (x > 0)
            x--;
    }

    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        base.Dibujar();
    }
}

// ----------

class Pac : SpriteModoTexto
{
    public Pac(byte x, byte y)
        : base(x, y, 'C')
    {
    }

    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.White;
        base.Dibujar();
    }
}

// ----------

class PacMan
{
    static void Main()
    {
        bool terminado = false;
        ConsoleKeyInfo tecla;
        Pac pac = new Pac(40, 8);
        SpriteModoTexto[] fantasmas = new SpriteModoTexto[4];
        fantasmas[0] = new FantasmaAzul();
        fantasmas[1] = new FantasmaRojo();
        fantasmas[2] = new FantasmaRosa();
        fantasmas[3] = new FantasmaNaranja();

        do
        {
            pac.Dibujar();

            for (int i = 0; i < 4; i++)
            {
                fantasmas[i].Dibujar();

                if (pac.ColisionaCon(fantasmas[i]))
                {
                    terminado = true;
                }
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
        while (tecla.Key != ConsoleKey.Escape && !terminado);

        if (terminado)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Has perdido!");
        }

        Console.ResetColor();
    }
}
