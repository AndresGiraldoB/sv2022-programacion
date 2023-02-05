/*154. Crea una nueva versión del ejercicio 150 (PacMan 4), a partir de la 
"solución oficial", en la que emplees "this" en los constructores para no 
necesitar parámetros como "nuevaX", no haya ningún constructor sin parámetros, 
y los constructores se apoyen unos en otros usando "base". Main no debe 
cambiar. */

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
    public void SetX(int x) { this.x = (byte) x; }
    public void SetY(int y) { this.y = (byte) y; }
    public void SetCaracter(char caracter) { this.caracter = caracter; }

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

    public override void Mover()
    {
        x++;
    }
}

// ----------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(byte x, byte y)
        : base(x, y)
    {
    }

    public override void Mover()
    {
        y--;
    }
}

// ----------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(byte x, byte y)
        : base(x, y)
    {
    }

    public override void Mover()
    {
        y++;
    }
}

// ----------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(byte x, byte y)
        : base(x, y)
    {
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
        : base(x, y, 'C')
    {
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
