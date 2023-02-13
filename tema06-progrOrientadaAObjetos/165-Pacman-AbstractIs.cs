// DAN 1DAW

/*
165. Crea una nueva versión de PacMan (ejercicio 154), 
partiendo de la solución oficial, con los siguientes cambios:

- La clase Sprite debe ser abstracta.

- Cada subtipo de fantasma debe tener un constructor vacío, 
que prefije unas ciertas coordenadas, además del constructor que recibe X e Y, 
para simplificar Main.

- Para practicar el uso de "is", cambia el color desde Main antes de 
dibujar cada tipo de fantasma, según el tipo al que pertenezca. 
Podrás emplear construcciones como "Console.ForegroundColor = ConsoleColor.Red;".
*/

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

    public FantasmaAzul()
        : this(36, 8)
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

    public FantasmaRojo()
        : this(44, 8)
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

    public FantasmaRosa()
        : this(40, 6)
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

    public FantasmaNaranja()
        : this(40, 10)
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
        fantasmas[0] = new FantasmaAzul();
        fantasmas[1] = new FantasmaRojo();
        fantasmas[2] = new FantasmaRosa();
        fantasmas[3] = new FantasmaNaranja();

        do
        {
            pac.Dibujar();
            // Dibujado: recorriendo el array con "for", por ejemplo
            for (int i = 0; i < fantasmas.Length; i++)
            {
                if (fantasmas[i] is FantasmaAzul)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (fantasmas[i] is FantasmaRojo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (fantasmas[i] is FantasmaRosa)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (fantasmas[i] is FantasmaNaranja)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }

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