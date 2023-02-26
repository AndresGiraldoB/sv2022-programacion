/* Cuarto ejercicio con nota (tema 6)

Nos han pedido crear un esqueleto para un sistema informático de un 
fotógrafo.

Por una parte, existirá una clase genérica Foto, para representar las 
fotografías que el estudio fotográfico tiene realizadas. En concreto, 
en esta primera versión distinguiremos entre fotos de particulares y 
fotos de colecciones (las primeras no se pueden enseñar a nadie y las 
segundas se utilizan para realizar exposiciones). En ambos casos 
querremos saber el nombre del fichero y la fecha de realización (ambos 
datos serán textos). En la clase Foto existirá un constructor que 
permita dar valores a los dos atributos. Las fotos deben implementar la 
interfaz IComparable, para que (en una versión posterior de la 
aplicación) se puedan ordenar por nombre de fichero. También se ha 
decidido no incluir todavía otros atributos que pueden resultar útiles, 
como el lugar de realización de la foto e información técnica (cámara 
empleada, resolución, ISO, etc.)

- Para las fotos de clientes particulares (clase FotoParticular), 
detallaremos también el nombre y el teléfono del cliente. El 
constructor recibirá nombre, fecha, nombre y teléfono, en ese orden.

- Para la segunda clase (FotoColeccion), se anotará una temática, de 
modo que el constructor recibirá nombre, fecha y temática, en ese 
orden. Un segundo constructor no recibirá la temática, sino que la 
prefijará a "Abstracto".

Para cada uno de los atributos, crearemos getters y setters 
"convencionales". Además, habrá un ToString en cada clase, que 
devolverá los campos en el mismo orden en que aparecen en el 
constructor, separados por " – ". También habrá un método 
"MostrarDatos", que mostrará en pantalla esa misma información (campos 
separados por guiones), seguida de " (Particular)" o " (Colección)", 
según el caso. Como es deseable que todas las clases implementen el 
método MostrarDatos, vamos a crear una interfaz "IMostrable" que 
obligue a la clase Foto y derivadas a implementar este método.

También nos han pedido llevar cuenta las exposiciones (clase 
Exposicion) que se han realizado o se van a realizar. La información 
que se desea guardar será el nombre de la exposición, el lugar, la 
fecha (como texto) y un campo que indique si está pendiente de realizar 
o ya se ha realizado.

Cada exposición deberá guardar también un registro de las fotografías 
que se van a exponer (máximo 100), por lo que deberá tener un método 
IncluirFoto(f), que permita añadir una foto a la exposición.

Para la clase Exposicion habrá un constructor que reciba todos esos 
datos en ese orden (nombre, lugar, fecha, pendiente). Los datos se 
representarán como propiedades en formato compacto, con la peculiaridad 
de que no queremos que se pueda modificar posteriormente el nombre de 
la exposición. El método ToString devolverá el nombre de la exposición, 
el lugar y la fecha, separados por " | ". Esta clase también 
implementará la interfaz IMostrable, y su método MostrarDatos escribirá 
su "ToString", seguido de los ToString de las fotos que contiene, cada 
uno en una línea.

La clase principal se llamará "EstudioFotografia" y contendrá como 
atributos un array de fotos y un array de exposiciones.

El cuerpo del programa estará en el método Ejecutar de la clase 
EstudioFotografia. Este cuerpo creará dos fotografías prefijadas y una 
exposición con ambas fotos asignadas. Mostrará, además, un menú con las 
siguientes opciones:

1. Añadir una fotografía (particular o de colección).

2. Añadir una exposición.

3. Añadir fotos a una exposición.

4. Ver todas las fotos existentes (incluyendo su número de registro).

5. Modificar una foto (a partir de su número).

6. Buscar fotos, a partir de un fragmento de su descripción (su "ToString").

7. Listar las exposiciones con sus correspondientes fotografías.

S. Salir

Esta misma clase EstudioFotografia será la que también contenga Main. 
Dicho Main se limitará a crear un objeto de la clase EstudioFotografia 
y llamar a su método Ejecutar.

Como no sabemos manejar ficheros, esta primera versión provisional 
perderá la información cada vez que termine una sesión.

Deberás entregar un proyecto de Visual Studio, en el que cada clase 
estará en su propio fichero. Recuerda evitar código repetitivo tanto 
como sea posible, reutilizando constructores o métodos cuando 
corresponda.
*/

using System;

class EstudioFotografia
{
    const string ANYADIRFOTO = "1", ANYADIREXPO = "2", ANYADIRFOTOEXPO = "3",
        VERTODASFOTOS = "4", MODIFICARFOTO = "5", BUSCARFOTOS = "6",
        LISTAREXPOS = "7", SALIR = "S";
    const byte CAPACIDAD_FOTOS = 100;
    const byte CAPACIDAD_EXPOSICIONES = 100;
    byte posicionFotos = 0;
    byte posicionExpos = 0;

    Foto[] fotos;
    Exposicion[] exposiciones;

    public EstudioFotografia()
    {
        fotos = new Foto[CAPACIDAD_FOTOS];
        exposiciones = new Exposicion[CAPACIDAD_EXPOSICIONES];

        AgregarFoto(new FotoParticular(
            "Paseo.jpg", "10-01-2023", "Armando Guerra", "633988766"));
        AgregarFoto(new FotoColeccion(
            "Playa.jpg", "13-01-2023"));
        AgregarExpo(new Exposicion(
            "Fotos de Paisajes", "Alicante", "12-02-2023", false));

        exposiciones[0].IncluirFoto(fotos[0]);
        exposiciones[0].IncluirFoto(fotos[1]);
    }

    public void Ejecutar()
    {
        bool salir = false;
        do
        {
            MostrarMenu();
            string opcion = Pedir("¿Opción?").ToUpper();

            switch (opcion)
            {
                case ANYADIRFOTO:
                    AnyadirFoto();
                    break;
                case ANYADIREXPO:
                    AnyadirExpo();
                    break;
                case ANYADIRFOTOEXPO:
                    AnyadirFotosExpo();
                    break;
                case VERTODASFOTOS:
                    VerTodasFotos();
                    break;
                case MODIFICARFOTO:
                    ModificarFoto();
                    break;
                case BUSCARFOTOS:
                    BuscarFoto();
                    break;
                case LISTAREXPOS:
                    ListarExpos();
                    break;
                case SALIR:
                    Console.WriteLine("Hasta la próxima!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (!salir);
    }

    private void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("---------------MENU----------------");
        Console.WriteLine(ANYADIRFOTO +
            ". Añadir una fotografía (particular o de colección).");
        Console.WriteLine(ANYADIREXPO +
            ". Añadir una exposición.");
        Console.WriteLine(ANYADIRFOTOEXPO +
            ". Añadir fotos a una exposición.");
        Console.WriteLine(
            VERTODASFOTOS +
            ". Ver todas las fotos existentes (incluyendo su número de registro).");
        Console.WriteLine(MODIFICARFOTO +
            ". Modificar una foto (a partir de su número).");
        Console.WriteLine(
            BUSCARFOTOS +
            ". Buscar fotos, a partir de un fragmento de su descripción.");
        Console.WriteLine(
            LISTAREXPOS +
            ". Listar las exposiciones con sus correspondientes fotografías.");
        Console.WriteLine(SALIR + ". Salir");
    }

    private void AnyadirFoto()
    {

        if (posicionFotos >= CAPACIDAD_FOTOS)
        {
            Console.WriteLine("No puedes añadir más fotos");
        }
        else
        {
            Foto foto;

            string tipoFoto = Pedir(
                "¿Vas a añadir una foto de colección o particular? (C/P)").ToLower();

            bool esColeccion = tipoFoto == "c";
            bool esParticular = tipoFoto == "p";

            if (esColeccion || esParticular)
            {
                Console.WriteLine("Vas a añadir una foto " +
                    (esColeccion ? "de colección" : "particular"));

                string nombreFichero = Pedir("¿Nombre del fichero?");
                string fecha = Pedir("¿Fecha de realización?");

                if (esColeccion)
                {
                    string tematica = Pedir(
                        "¿Temática? Si lo dejas en blanco se dará"
                        + " por sentado que la temática es \"Abstracta\"");

                    if (tematica == "")
                    {
                        foto = new FotoColeccion(nombreFichero, fecha);
                    }
                    else
                    {
                        foto = new FotoColeccion(nombreFichero, fecha, tematica);
                    }
                }
                else
                {
                    string nombreCliente = Pedir("¿Nombre del cliente?");
                    string telefonoCliente = Pedir("¿Teléfono del cliente?");

                    foto = new FotoParticular(nombreFichero, fecha,
                        nombreCliente, telefonoCliente);
                }
                AgregarFoto(foto);
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }
        }
    }

    private void AnyadirExpo()
    {
        if (posicionExpos >= CAPACIDAD_EXPOSICIONES)
        {
            Console.WriteLine("No caben más exposiciones");
        }
        else
        {
            bool pendiente;
            string nombre = Pedir("¿Nombre de la exposición?");
            string lugar = Pedir("¿Lugar de la exposición?");
            string fecha = Pedir("¿Fecha de la exposición?");
            string preguntarPendiente = Pedir(
                "¿La exposición está pendiente? (S/N)").ToLower();
            pendiente = preguntarPendiente == "s";

            AgregarExpo(new Exposicion(nombre, lugar,
                fecha, pendiente));
        }
    }

    private void AnyadirFotosExpo()
    {
        int elegirExpo = Convert.ToInt32(
            Pedir("¿A qué exposición quieres añadir una foto?" +
                "(Indica su número de registro)")) - 1;

        if (elegirExpo >= 0 && elegirExpo < posicionExpos)
        {
            int elegirFoto = Convert.ToInt32(Pedir(
                "Indica el número de la foto")) - 1;

            if (elegirFoto >= 0 && elegirFoto < posicionFotos)
            {
                exposiciones[elegirExpo].IncluirFoto(fotos[elegirFoto]);
            }
            else
            {
                Console.WriteLine("No hay tal foto registrada");
            }
        }
        else
        {
            Console.WriteLine("Registro incorrecto, no hay tal exposición");
        }
    }

    private void ModificarFoto()
    {
        Console.WriteLine("Si decides no modificar un campo simplemente pulsa intro");
        int numRegistro = Convert.ToInt32(Pedir(
            "¿Qué foto quieres modificar? (introduce su posición)")) - 1;

        if (numRegistro >= 0 && numRegistro < posicionFotos)
        {
            fotos[numRegistro].SetNombreFichero(Modificar("Nombre del fichero",
                fotos[numRegistro].GetNombreFichero()));

            fotos[numRegistro].SetFechaRealizacion(Modificar("Fecha",
                fotos[numRegistro].GetFechaRealizacion()));

            if (fotos[numRegistro] is FotoColeccion)
            {
                ((FotoColeccion)fotos[numRegistro]).SetTematica(
                    Modificar("Temática", 
                    ((FotoColeccion)fotos[numRegistro]).GetTematica()));
            }
            else
            {
                ((FotoParticular)fotos[numRegistro]).SetNombreCliente(
                    Modificar("Nombre del cliente", 
                    ((FotoParticular)fotos[numRegistro]).GetNombreCliente()));

                ((FotoParticular)fotos[numRegistro]).SetTelefonoCliente(
                    Modificar("Teléfono del cliente", 
                    ((FotoParticular)fotos[numRegistro]).GetTelefonoCliente()));
            }
        }
        else
        {
            Console.WriteLine("Número de registro incorrecto");
        }
    }

    private void VerTodasFotos()
    {
        for (int i = 0; i < posicionFotos; i++)
        {
            Console.Write((i + 1) + ". ");
            fotos[i].MostrarDatos();
        }
    }

    private void BuscarFoto()
    {
        bool encontrado = false;
        string fraseBuscar = Pedir("Introduce lo que quieras buscar").ToLower();

        for (int i = 0; i < posicionFotos; i++)
        {
            if (fotos[i].ToString().ToLower().Contains(fraseBuscar))
            {
                Console.WriteLine(fotos[i]);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("No hay resultados para la búsqueda");
        }
    }

    private void ListarExpos()
    {
        for (int i = 0; i < posicionExpos; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Exposición " + (i + 1));
            exposiciones[i].MostrarDatos();
        }
    }

    private void AgregarFoto(Foto f)
    {
        fotos[posicionFotos] = f;
        posicionFotos++;
    }

    private void AgregarExpo(Exposicion expo)
    {
        exposiciones[posicionExpos] = expo;
        posicionExpos++;
    }

    private static string Modificar(string nombreCampo, string valorAnterior)
    {
        string respuesta = Pedir("Dime el nuevo valor para: " +
            nombreCampo + " (antes era: " + valorAnterior + ")");

        return respuesta != "" ? respuesta : valorAnterior;
    }

    private static string Pedir(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }

    static void Main()
    {
        EstudioFotografia e = new EstudioFotografia();
        e.Ejecutar();
    }
}

// -------------------------

class Exposicion : IMostrable
{
    public string Nombre { get; } // Nota: no funcionará en C# 5 (desde Geany)
        // En C# 5, la propiedad "Nombre" habría que escribirla en formato largo
    public string Lugar { get; set; }
    public string Fecha { get; set; }
    public bool Pendiente { get; set; }

    private Foto[] fotos = new Foto[100];
    private byte pos = 0;

    public Exposicion(string nombre, string lugar, string fecha, bool pendiente)
    {
        Nombre = nombre;
        Lugar = lugar;
        Fecha = fecha;
        Pendiente = pendiente;
    }

    public override string ToString()
    {
        return Nombre + " | " + Lugar + " | " + Fecha
            + " | " + (Pendiente ? "Pendiente" : "Concluida");
    }

    public void IncluirFoto(Foto f)
    {
        if (pos >= 100)
        {
            Console.WriteLine("Cupo de fotos completado");
        }
        else
        {
            fotos[pos] = f;
            pos++;
        }
    }

    public void MostrarDatos()
    {
        Console.WriteLine(ToString());
        for (int i = 0; i < pos; i++)
        {
            Console.WriteLine("Foto nº" + (i + 1) + " " + fotos[i]);
        }
    }
}


// -------------------------

interface IMostrable
{
    void MostrarDatos();
}

// -------------------------

abstract class Foto : IComparable<Foto>, IMostrable
{
    protected string nombreFichero;
    protected string fechaRealizacion;

    public Foto(string nombreFichero, string fechaRealizacion)
    {
        this.nombreFichero = nombreFichero;
        this.fechaRealizacion = fechaRealizacion;
    }

    public string GetNombreFichero()
    {
        return nombreFichero;
    }

    public string GetFechaRealizacion()
    {
        return fechaRealizacion;
    }

    public void SetNombreFichero(string nombreFichero)
    {
        this.nombreFichero = nombreFichero;
    }

    public void SetFechaRealizacion(string fechaRealizacion)
    {
        this.fechaRealizacion = fechaRealizacion;
    }

    public int CompareTo(Foto otro)
    {
        return this.nombreFichero.CompareTo(otro.nombreFichero);
    }

    public override string ToString()
    {
        return nombreFichero + " - " + fechaRealizacion;
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine(ToString());
    }
}

// -------------------------

class FotoColeccion : Foto
{
    private string tematica;

    public FotoColeccion(string nombreFichero, string fechaRealizacion, string tematica)
        : base(nombreFichero, fechaRealizacion)
    {
        this.tematica = tematica;
    }

    public FotoColeccion(string nombreFichero, string fechaRealizacion)
        : this(nombreFichero, fechaRealizacion, "Abstracto")
    {
    }

    public string GetTematica()
    {
        return tematica;
    }

    public void SetTematica(string tematica)
    {
        this.tematica = tematica;
    }

    public override string ToString()
    {
        return base.ToString() + " - " + tematica;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine(ToString() + " (Colección)");
    }
}

// -------------------------

class FotoParticular : Foto
{
    private string nombreCliente;
    private string telefonoCliente;

    public FotoParticular(string nombreFichero, string fechaRealizacion,
            string nombreCliente, string telefonoCliente)
        : base(nombreFichero, fechaRealizacion)
    {
        this.nombreCliente = nombreCliente;
        this.telefonoCliente = telefonoCliente;
    }

    public string GetNombreCliente()
    {
        return nombreCliente;
    }

    public string GetTelefonoCliente()
    {
        return telefonoCliente;
    }

    public void SetNombreCliente(string nombreCliente)
    {
        this.nombreCliente = nombreCliente;
    }

    public void SetTelefonoCliente(string telefonoCliente)
    {
        this.telefonoCliente = telefonoCliente;
    }

    public override string ToString()
    {
        return base.ToString() + " - " + nombreCliente + " - " +
            telefonoCliente;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine(ToString() + " (Particular)");
    }
}
