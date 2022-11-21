/* Juan Manuel (...)

/*
82. Crea una versión mejorada del ejercicio anterior, que pida al usuario los
datos de 3 personas, los guarde en un array y luego los muestre.
*/


using System;

class Ejercicio82
{

    struct TipoPersona
    {
        public string nombre;
        public byte edad;
        public float estatura;
    }

    static void Main()
    {
        const int MAXIMO = 3;
        TipoPersona[] personas = new TipoPersona[MAXIMO];
        string[] ordinales = { "Primera", "Segunda", "Tercera" };

        Console.WriteLine(" Vamos a guardar datos de tres personas.");
        for (int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine(" *** " + ordinales[i] + " persona ***");
            Console.Write(" Dime el nombre: ");
            personas[i].nombre = Console.ReadLine();
            Console.Write(" Dime la edad: ");
            personas[i].edad = Convert.ToByte(Console.ReadLine());
            Console.Write(" Dime la estatura: ");
            personas[i].estatura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine(" Estos son los datos guardados de las tres personas.");
        for (int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine(" *** " + ordinales[i] + " persona ***");
            Console.WriteLine(" Nombre: " + personas[i].nombre);
            Console.WriteLine(" Edad: " + personas[i].edad);
            Console.WriteLine(" Estatura: " + personas[i].estatura);
            Console.WriteLine();
        }
    }
}

