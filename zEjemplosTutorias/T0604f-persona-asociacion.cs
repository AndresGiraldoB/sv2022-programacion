/* Crea una versión ampliada de las clases Persona y PersonaConEdad, en 
la que cada persona pueda tener una madre (omitiremos el padre y los 
hijos. Crea un método IndicarMadre(Persona p) para dar valor a ese 
nuevo atributo. Añade también un método MostrarFamilia, que muestre el 
nombre de la madre (si existe).
*/

using System;

class PruebaDePersona6
{
    static void Main()
    {
        Persona[] personas = new Persona[3];
        personas[0] = new Persona("Alberta", "Alcaraz");
        personas[1] = new PersonaConEdad("Basilio", "Bustos", 15);
            personas[1].IndicarMadre(personas[0]);
        personas[2] = new Persona("Carlos", "Canales");

        foreach (Persona p in personas)
        {
            Console.WriteLine(p);
            if (p is PersonaConEdad)
            {
                Console.Write("  Nacido en: ");
                Console.WriteLine( ((PersonaConEdad) p).CalcularAnyoNacimiento() );
            }
            p.MostrarFamilia();
        }


    }
}

// ------------------------

class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    protected Persona madre;

    public Persona(string Nombre, string Apellidos)
    {
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
    }

    public override string ToString()
    {
        return Apellidos + ", " + Nombre;
    }

    public void IndicarMadre(Persona m)
    {
        madre = m;
    }

    public void MostrarFamilia()
    {
        if (madre != null)
            Console.WriteLine("  Madre: " + madre);
    }
}

// ------------------

class PersonaConEdad : Persona
{
    public int Edad { get; set; }

    public PersonaConEdad(string Nombre, string Apellidos, int Edad)
        : base(Nombre, Apellidos)
    {
        this.Edad = Edad;
    }

    public PersonaConEdad(string Nombre, string Apellidos)
        : this(Nombre, Apellidos, 18)
    {
    }

    public override string ToString()
    {
        return base.ToString() + " - " + Edad;
    }

    public int CalcularAnyoNacimiento()
    {
        return 2023 - Edad;
    }
}

// Alcaraz, Alberta
// Bustos, Basilio - 15
//   Nacido en: 2008
//   Madre: Alcaraz, Alberta
// Canales, Carlos
