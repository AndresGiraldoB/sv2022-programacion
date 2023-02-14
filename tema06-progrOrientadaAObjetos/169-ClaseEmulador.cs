// Víctor Rául (...) 1ºDAW, retoques menores por Nacho
/*
169. Emuladores (examen del tema 6, grupo presencial, 2016-2017)

Se desea crear un emulador de múltiples ordenadores clásicos usando un diseño 
orientado a objetos.

Para ello, en primer lugar se considerará, de forma simplificada, que un 
Ordenador está formado únicamente por un Procesador y una Memoria. También nos 
interesará almacenar un nombre para cada ordenador. Los tres valores, en ese 
orden, se deberán indicar en el (único) constructor de la clase Ordenador. Sólo 
se creará un método Get para poder acceder a su nombre, pero también se 
incluirá un método ToString, que devolverá algo como "ZxSpectrum, procesador 
Z80, 8 bits, 3.5 MHz, 16384 bytes de memoria".

Un Procesador contendrá una serie de posiciones internas de memoria, llamadas 
registros (por ejemplo A o AX). Por ello, queremos que esta clase contenga un 
único constructor, que recibirá tres parámetros: el primero será el número de 
bits del procesador (por ejemplo, 8); el segundo será la velocidad de proceso, 
medida en Megahertzios (por ejemplo, 3.58) y el tercero será una cadena de 
texto que indicará los nombres de los registros separados por espacios (por 
ejemplo "A B C D"). Además, existirá un método AnadirOrden, que servirá para 
anotar órdenes que acepta este procesador. Estas órdenes se indicarán como dos 
parámetros de AnadirOrden. El primer parámetro indicará el código de esa orden 
(por ejemplo 121 en base decimal o 0x79 en base hexadecimal) y el segundo 
parámetro será el equivalente en ensamblador de esa orden (por ejemplo, "LD A, 
C"). Más adelante, todas las órdenes se almacenarán en una estructura de datos, 
como un array, pero esta primera versión no debe preocuparse aún de eso, sino 
que en ella, el método AnadirOrden estará vacío. También existirá un método 
MostrarOrdenes, que, en una versión posterior, mostraría toda la lista de 
órdenes que soporta el procesador, pero que por ahora sólo mostrará "Lista de 
órdenes aún no disponible". Igualmente, la clase Procesador tendrá métodos Get 
para su número de bits y para su velocidad de proceso. También tendrá un método 
"ToString", que devolverá algo como "8 bits, 3.5 MHz".

La clase Memoria contendrá un dos atributos: el tamaño y un array de bytes que 
contendrá la información real. Existirá un constructor que recibirá como 
parámetro el tamaño de la memoria, en bytes (por ejemplo, 65536) y creará un 
array de bytes de ese tamaño. También se creará un segundo constructor, que 
recibirá el tamaño de la memoria (por ejemplo, 65536) y el tamaño del bus de 
datos, medido en bits (por ejemplo, 8). Aun así, este constructor todavía no se 
va a implementar, así que delegará en el primer constructor e ignorará el dato 
del tamaño del bus de datos (pero contendrá un comentario TO DO en su interior, 
para recordar que se pretende implementar más adelante). La clase también 
tendrá métodos Get(dirección) para obtener el valor almacenado en una cierta 
posición de memoria y Set(dirección, valor) para guardar un cierto valor en una 
posición de memoria. También tendrá un método GetTamano, que devuelva su 
tamaño, medido en bytes.

Crea una clase ProcesadorZ80, que permita crear un procesador Zilog Z80 o 
derivado. Esta clase contendrá un único constructor para indicar la velocidad 
en MHz (porque el número de bits quedará prefijado a 8 y los registros estarán 
prefijados a "A B C D E F H L"). Su MostrarOrdenes escribirá en pantalla el 
texto "Z80: " seguido del aviso que se ha indicado en la clase procesador. Su 
método ToString devolverá "Z80, " seguido del ToString de un procesador 
genérico.

Crea una clase Procesador6502, que permita crear un procesador MOS 6502 o 
derivado. Esta clase contendrá un único constructor para indicar la velocidad 
en MHz (porque el número de bits quedará prefijado a 8 y los registros a "A X 
Y"). Su MostrarOrdenes escribirá en pantalla el texto "6502: " seguido del 
aviso previsto en la clase procesador. Su método ToString devolverá "6502, " 
seguido del ToString de un procesador genérico.

Crea un programa de prueba (clase Emuladores) que tenga un array de 
ordenadores. Los dos primeros ordenadores estarán prefijados: un ZxSpectrum, 
con procesador Z80 a 3.5 MHz y 16384 bytes de memoria, y un Commodore VIC-20, 
con procesador 6502 a 1.1 MHz y 5120 bytes de memoria. A continuación, el 
usuario podrá elegir qué ordenadores adicionales desea introducir en el array, 
mediante un menú que le pregunte si quiere añadir un equipo basado en el Z80 
(opción 1) o en el 6502 (opción 2), o bien si quiere ver todos los datos que se 
han introducido hasta el momento (opción 3) o terminar (opción 0). Cada vez que 
elija añadir un equipo, se le preguntará el nombre de éste, la velocidad en MHz 
y el tamaño de su memoria.

*/

using System;

abstract class Procesador
{
    // --- Atributos ----------
    protected int numBits;
    protected double velocidad;
    protected string[] registros; // (por ejemplo "A B C D")

    // --- Constructor ----------
    public Procesador(int numBits, double velocidad, string registros)
    {
        this.numBits = numBits;
        this.velocidad = velocidad;
        this.registros = registros.Split(' ');
    }

    //--- Setters y getters ------
    public int NumBits
    {
        get
        {
            return numBits;
        }
    }

    public double Velocidad
    {
        get
        {
            return velocidad;
        }
    }
    // ---- Métodos -----------

    public void AnadirOrden(int codigo, string orden)
    {
        //TODO: Almacenar órdenes en un estructura de datos
    }

    public virtual void MostrarOrdenes()
    {
        Console.WriteLine("Lista de ordenes aun no disponible");
    }

    public override string ToString()
    {
        return numBits + " bits, " + " " + velocidad + " MHz";
    }
}

//-----------------------------

class ProcesadorZ80 : Procesador
{
    public ProcesadorZ80(double velocidad)
        : base(8, velocidad, "A B C D E F H L") { }


    public override void MostrarOrdenes()
    {
        Console.Write("Z80:");
        base.MostrarOrdenes();
    }

    public override string ToString()
    {
        return "Z80, " + base.ToString();
    }
}

//-----------------------------

class Procesador6502 : Procesador
{
    public Procesador6502(double velocidad)
        : base(8, velocidad, "A X Y") { }


    public override void MostrarOrdenes()
    {
        Console.Write("6502:");
        base.MostrarOrdenes();
    }

    public override string ToString()
    {
        return "6502, " + base.ToString();
    }
}

//-----------------------------

class Memoria
{
    //------Atributos-------
    protected int tamanyo;
    protected byte[] info;

    //-------Constructor-----
    public Memoria(int tamanyo)
    {
        this.tamanyo = tamanyo;
        this.info = new byte[tamanyo];
    }

    public Memoria(int tamanyo, int tamanyoBus) : this(tamanyo)
    {
        //TODO: Se implementará mas adelante
    }

    //---- Setters y getters ---------

    public byte GetInfo(int direccion)
    {
        return info[direccion];
    }

    public void SetInfo(int direccion, byte valor)
    {
        info[direccion] = valor;
    }

    public int GetTamano()
    {
        return tamanyo;
    }

    public override string ToString()
    {
        return ", " + tamanyo + " bytes de memoria";
    }
}

//---------------------

class Ordenador
{
    protected Procesador procesador;
    protected Memoria memoria;
    protected string nombre;

    public Ordenador(Procesador procesador, Memoria memoria, string nombre)
    {
        this.procesador = procesador;
        this.memoria = memoria;
        this.nombre = nombre;
    }

    public string Nombre
    {
        get
        {
            return nombre;
        }
    }

    public override string ToString()
    {
        return nombre + 
            ", procesador " + procesador.ToString() + 
            " " + memoria.ToString();
    }
}

//----------------------

class Emuladores
{
    static void Main()
    {
        const int MAX = 10;
        Ordenador[] ordenadores = new Ordenador[MAX];
        int numOrdenadores = 2;

        ProcesadorZ80 proZ80 = new ProcesadorZ80(3.5f);
        Memoria memoriaZ80 = new Memoria(16384);
        Ordenador ordenadorZ80 = new Ordenador(proZ80, memoriaZ80, "ZxSpectrum");

        Procesador6502 pro6502 = new Procesador6502(1.1f);
        Memoria memoria6502 = new Memoria(5120);
        Ordenador ordenador6502 = new Ordenador(pro6502, memoria6502, "Commodore VIC-20");

        ordenadores[0] = ordenadorZ80;
        ordenadores[1] = ordenador6502;

        string opc;

        do
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("          MENÚ          ");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Añadir ordenador basado en Z80");
            Console.WriteLine("2. Añadir ordenador basado en 6502");
            Console.WriteLine("3. Ver todos los ordenador");
            Console.WriteLine("0. Terminar");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.Write("Escoja una opción del menú: ");
            opc = Console.ReadLine();

            switch (opc)
            {
                case "0":
                    Console.WriteLine("¡Hasta la proxima!");
                    break;

                case "1":
                    string nombre = PedirNoVacio("Nombre del ordenador: ");
                    double velocidad = Convert.ToDouble(PedirNoVacio("Velocidad en Mhz: "));
                    int tamanoMemoria = Convert.ToInt32(PedirNoVacio("Tamaño memoria en byte: "));

                    ProcesadorZ80 pro = new ProcesadorZ80(velocidad);
                    Memoria mem = new Memoria(tamanoMemoria);
                    Ordenador ord = new Ordenador(pro, mem, nombre);

                    Anadir(ordenadores, ref numOrdenadores, MAX, ord);

                    break;
                case "2":
                    nombre = PedirNoVacio("Nombre del ordenador: ");
                    velocidad = Convert.ToDouble(PedirNoVacio("Velocidad en Mhz: "));
                    tamanoMemoria = Convert.ToInt32(PedirNoVacio("Tamaño memoria en byte: "));

                    Procesador6502 proOtro = new Procesador6502(velocidad);
                    Memoria mem6502 = new Memoria(tamanoMemoria);
                    Ordenador ord6502 = new Ordenador(proOtro, mem6502, nombre);

                    Anadir(ordenadores, ref numOrdenadores, MAX, ord6502);
                    break;

                case "3":

                    for (int i = 0; i < numOrdenadores; i++)
                    {
                        Console.WriteLine( ordenadores[i].ToString());
                    }
                    break;

                default:
                    Console.Write("Opción desconocida.\n");
                    break;
            }
        } while (opc != "0");
    }


    static string PedirNoVacio(string aviso)
    {
        string texto;
        Console.Write(aviso);
        do
        {
            texto = Console.ReadLine();
            if (texto == "") 
                Console.Write("No puede ser vacío. Introduzca un dato nuevamente: ");
        } while (texto == "");
        return texto;
    }


    static void Anadir(Ordenador[] ordenadores,ref int numOrdenadores,int max, 
        Ordenador ordenador)
    {
        if (numOrdenadores > max) Console.WriteLine("Lleno");
        else 
        {
            ordenadores[numOrdenadores] = ordenador;
            numOrdenadores++;
        }
    }
}
