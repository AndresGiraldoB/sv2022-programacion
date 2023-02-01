/* Crea una versión de las clases Persona y PersonaConEdad, en la que 
los constructores reciban parámetros que se llamen igual que los 
atributos. Además, existirá un constructor alternativo para 
PersonaConEdad, que no recibirá edad, y la prefijará a 18 años, 
apoyándose en el constructor que sí la recibe.
*/

using System;

class PruebaDePersona3
{
    static void Main()
    {
        Persona p = new Persona("Alberto", "Alcaraz");
        Console.WriteLine(p);
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
}
