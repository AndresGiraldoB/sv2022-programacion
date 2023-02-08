/* Mejora el ejercicio anterior: A partir de las clases Persona y 
PersonaConEdad, implementa la interfaz IComparable. Detalla su método 
CompareTo, de modo que dos personas se ordenen por apellidos, y, en caso de 
coincidir los apellidos, por nombre. Añade tres personas de ejemplo, ordénalos 
y muestra el resultado.
*/

using System;

class PruebaDePersonaIComparable2
{
    static void Main()
    {
        Persona[] personas = new Persona[4];
        personas[2] = new Persona("Alberta", "Alcaraz");
        personas[1] = new PersonaConEdad("Basilio", "Bustos", 15);
        personas[0] = new Persona("Manuel", "Canales");
        personas[3] = new Persona("Carlos", "Canales");

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
        if (Apellidos != otro.Apellidos)
            return Apellidos.CompareTo(otro.Apellidos);
        else
            return Nombre.CompareTo(otro.Nombre);
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

// Alcaraz, Alberta
// Bustos, Basilio - 15
// Canales, Carlos
// Canales, Manuel
