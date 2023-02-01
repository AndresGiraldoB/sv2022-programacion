/* Amplía la clase  PersonaConEdad, para añadir un método 
CalcularAnyoNacimiento, que deduzca el año en que nació, restando su 
edad del año actual.

Crea un array que contenga clases Persona y PersonaConEdad, añade 3 
datos de ejemplo, recorre el array con un foreach, mostrando los datos 
de cada una (usando ToString() y muestra el año de nacimiento de las 
que sean de tipo PersonaConEdad.
*/

using System;

class PruebaDePersona5
{
    static void Main()
    {
        Persona[] personas = new Persona[3];
        personas[0] = new Persona("Alberto", "Alcaraz");
        personas[1] = new PersonaConEdad("Basilio", "Bustos", 15);
        personas[2] = new Persona("Carlos", "Canales");

        foreach (Persona p in personas)
        {
            Console.WriteLine(p);
            if (p is PersonaConEdad)
            {
                Console.Write("  Nacido en: ");
                Console.WriteLine( ((PersonaConEdad) p).CalcularAnyoNacimiento() );
            }
        }


    }
}

// ------------------------

class Persona
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

// Alcaraz, Alberto
// Bustos, Basilio - 15
//   Nacido en: 2008
// Canales, Carlos
