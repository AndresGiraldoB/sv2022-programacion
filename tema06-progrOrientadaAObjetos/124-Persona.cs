/*Crea un clase "Persona", que permita almacenar ciertos datos de personas, de 
momento sólo: nombre (cadena de texto), edad (byte) y eMail (cadena de texto). 
Estos atributos deben ser accesibles a través de getter y setters. Crea, en el 
mismo fichero fuente, una clase "PruebaDePersona", que contendrá Main, y que 
pedirá al usuario los datos de 2 personas (sin usar todavía un array) y luego 
los mostrará. Deberás entregar sólo el (único) fichero .cs.

Fátima (...)*/

using System;
class Persona
{
    private string nombre, email;
    private byte edad;

    public string GetNombre() { return nombre; }
    public string GetEmail() { return email; }
    public byte GetEdad() { return edad; }

    public void SetNombre(string nuevoNombre) { nombre = nuevoNombre; }
    public void SetEmail(string nuevoEmail) { email = nuevoEmail; }
    public void SetEdad(byte nuevaEdad) { edad = nuevaEdad; }  

    public void Mostrar()
    {
        Console.WriteLine("Nombre: {0}, Email: {1}, Edad: {2}", nombre, email, edad);
    }
}

class PruebaDePersona
{
    static void Main()
    {
        Persona p1 = new Persona();

        Console.Write("Dime el nombre de la primera persona: ");
        p1.SetNombre(Console.ReadLine());

        Console.Write("Dime el email de la primera persona: ");
        p1.SetEmail(Console.ReadLine());

        Console.Write("Dime la edad de la primera persona: ");
        p1.SetEdad(Convert.ToByte(Console.ReadLine()));

        Persona p2 = new Persona();

        Console.Write("Dime el nombre de la segunda persona: ");
        string nombre2 = Console.ReadLine();
        p2.SetNombre(nombre2);

        Console.Write("Dime el email de la segunda persona: ");
        string email2 = Console.ReadLine();
        p2.SetEmail(email2);

        Console.Write("Dime la edad de la segunda persona: ");
        byte edad2 = Convert.ToByte(Console.ReadLine());
        p2.SetEdad(edad2);

        p1.Mostrar();
        p2.Mostrar();
    }
}
