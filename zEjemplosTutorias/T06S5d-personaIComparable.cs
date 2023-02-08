/* A partir de las clases Persona y PersonaConEdad, implementa la interfaz 
IComparable. Detalla su método CompareTo, de modo que dos personas se ordenen 
por apellidos. Añade tres personas de ejemplo, ordénalos y muestra el 
resultado.

*/

using System;

class PruebaDePersonaIComparable
{
    static void Main()
    {
        Persona[] personas = new Persona[3];
        personas[2] = new Persona("Alberta", "Alcaraz");
        personas[1] = new PersonaConEdad("Basilio", "Bustos", 15);
        personas[0] = new Persona("Carlos", "Canales");

        Array.Sort(personas);

        foreach (Persona p in personas)
        {
            Console.WriteLine(p);
        }
    }
}

// ------------------------

class Persona : IComparable<Persona>
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public Persona(string Nombre, string Apellidos)
    {
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
    }

    public override string ToString()
    {
        return Apellidos + ", " + Nombre;
    }

    int IComparable<Persona>.CompareTo(Persona otro)
    {
        return Apellidos.CompareTo(otro.Apellidos);
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
}
