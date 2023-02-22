//Edgar (...) --- 1º DAW

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
        : this(4, 2)
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
        : this(16, 8)
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
        : this(1, 1)
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
        : this(10, 5)
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

class Nivel
{
    private char[,] laberinto;
    private int pildorasPequenas { get; set; }
    private int pildorasGrandes { get; set; }

    const int FILAS = 10;
    const int COLUMNAS = 18;

    public Nivel()
    {
        laberinto = new char[,]
        {
            {'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-' },
            {'|',' ','|','.','|',' ','o',' ',' ','|',' ','|','o',' ','|',' ',' ','|' },
            {'|','.','|',' ','o',' ',' ','|',' ','|',' ',' ',' ',' ','|',' ','.','|' },
            {'|',' ','|',' ',' ',' ',' ','|',' ','|',' ','.','|',' ','|',' ',' ','|' },
            {'|',' ',' ',' ',' ','|','.','|','o',' ',' ',' ','|',' ','|',' ',' ','|' },
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|',' ','o',' ',' ',' ','|' },
            {'|',' ','o',' ','|','.',' ',' ',' ',' ','.','|',' ',' ','.',' ',' ','|' },
            {'|',' ','|',' ','|',' ',' ',' ','|',' ',' ','|',' ','|',' ',' ',' ','|' },
            {'|',' ','|','.','|',' ',' ','o','|',' ',' ',' ','.','|',' ','|','o','|' },
            {'|','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','|' }
        };
        pildorasGrandes = 8;
        pildorasPequenas = 10;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(0,0);
        for (int y = 0; y < FILAS; y++)
        {
            for (int x = 0; x < COLUMNAS; x++)
            {
                Console.Write(laberinto[y, x]);
            }
            Console.WriteLine();
        }
    }

    public bool EsPosibleMoverA(int x, int y)
    {
        if (x <= 0 || y <= 0 || x >= COLUMNAS-1 || y >= FILAS-1)
        {
            return false;
        }
        if (laberinto[y, x] == '|')
        {
            return false;
        }
        return true;
    }

    public int ObtenerPuntosDe(int x, int y)
    {
        int puntos = 0;
        if (laberinto[y,x] == '.')
        {
            laberinto[y,x] = ' ';
            puntos += 10;
            pildorasPequenas--;
        }
        if (laberinto[y,x] == 'o')
        {
            laberinto[y,x] = ' ';
            puntos += 25;
            pildorasGrandes--;
        }
        return puntos;
    }

    public bool TodasLasPildorasRecogidas()
    {
        return (pildorasGrandes == 0 && pildorasPequenas == 0);
    }
}

// ----------

class PacMan
{
    static void Main()
    {
        bool terminado = false;
        ConsoleKeyInfo tecla;
        int puntos = 0;
        Pac pac = new Pac(5, 5);
        SpriteModoTexto[] fantasmas = new SpriteModoTexto[4];
        fantasmas[0] = new FantasmaAzul();
        fantasmas[1] = new FantasmaRojo();
        fantasmas[2] = new FantasmaRosa();
        fantasmas[3] = new FantasmaNaranja();

        Nivel nivel = new Nivel();

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            nivel.Mostrar();
            pac.Dibujar();

            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Puntos: " + puntos);

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
                if (nivel.EsPosibleMoverA(pac.GetX()-1, pac.GetY()))
                {
                    pac.MoverIzquierda();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                if (nivel.EsPosibleMoverA(pac.GetX()+1, pac.GetY()))
                {
                    pac.MoverDerecha();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }
            else if (tecla.Key == ConsoleKey.UpArrow)
            {
                if (nivel.EsPosibleMoverA(pac.GetX(), pac.GetY()-1))
                {
                    pac.MoverArriba();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }
            else if (tecla.Key == ConsoleKey.DownArrow)
            {
                if (nivel.EsPosibleMoverA(pac.GetX(), pac.GetY()+1))
                {
                    pac.MoverAbajo();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }

            // Movimiento: fantasmas

            if ((nivel.EsPosibleMoverA(fantasmas[0].GetX()+1, fantasmas[0].GetY())))
            {
                fantasmas[0].Mover();
            }
            if ((nivel.EsPosibleMoverA(fantasmas[1].GetX(), fantasmas[1].GetY()-1)))
            {
                fantasmas[1].Mover();
            }
            if ((nivel.EsPosibleMoverA(fantasmas[2].GetX(), fantasmas[2].GetY() + 1)))
            {
                fantasmas[2].Mover();
            }
            if ((nivel.EsPosibleMoverA(fantasmas[3].GetX()-1, fantasmas[3].GetY())))
            {
                fantasmas[3].Mover();
            }
            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape
            && !terminado && !nivel.TodasLasPildorasRecogidas());

        if (terminado)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Has perdido!");
        }
        else if (nivel.TodasLasPildorasRecogidas())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Enhorabuena por la victoria!");
        }

        Console.ResetColor();
    }
}

