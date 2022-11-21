/* Juan Manuel (...) */

/*
81. Crea un "struct" para almacenar algunos datos de personas, de momento sólo:
nombre (cadena de texto), edad (byte) y estatura en metros (real de simple
precisión). Pide al usuario datos de 2 personas (sin usar todavía ningún array)
y luego muéstralos.
*/


using System;

class Ejercicio81
{
    struct TipoPersona
    {
        public string nombre;
        public byte edad;
        public float estatura;
    }


    static void Main()
    {
        TipoPersona persona1, persona2;

        Console.WriteLine(" Vamos a guardar datos de dos personas.");
        Console.WriteLine(" *** Primera persona ***");
        Console.Write(" Dime el nombre: ");
        persona1.nombre = Console.ReadLine();
        Console.Write(" Dime la edad: ");
        persona1.edad = Convert.ToByte(Console.ReadLine());
        Console.Write(" Dime la estatura: ");
        persona1.estatura = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine(" *** Segunda persona ***");
        Console.Write(" Dime el nombre: ");
        persona2.nombre = Console.ReadLine();
        Console.Write(" Dime la edad: ");
        persona2.edad = Convert.ToByte(Console.ReadLine());
        Console.Write(" Dime la estatura: ");
        persona2.estatura = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine(" *** Primera persona datos guardados ***");
        Console.WriteLine(" Nombre: " + persona1.nombre);
        Console.WriteLine(" Edad: " + persona1.edad);
        Console.WriteLine(" Estatura: " + persona1.estatura);

        Console.WriteLine();

        Console.WriteLine(" *** Segunda persona datos guardados ***");
        Console.WriteLine(" Nombre: " + persona2.nombre);
        Console.WriteLine(" Edad: " + persona2.edad);
        Console.WriteLine(" Estatura: " + persona2.estatura);

    }
}

