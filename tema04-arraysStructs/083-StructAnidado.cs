/* Juan Manuel (...) */

/*
83. Crea una variante del ejercicio 82, en la que no guardes la edad de cada persona,
sino la fecha de nacimiento (día, mes, año, en forma de struct anidado). Al igual que
antes, pide al usuario datos de 3 personas (que serán parte de un array)
y luego muéstralos.
*/


using System;

class Ejercicio83
{
    struct TipoFecha
    {
        public byte dia;
        public byte mes; 
        public ushort anyo;
    }

    struct TipoPersona
    {
        public string nombre;
        public byte edad;
        public TipoFecha fecha;
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
            Console.WriteLine(" Ahora la fecha de nacimiento.");
            Console.Write(" Dime el día: ");
            personas[i].fecha.dia = Convert.ToByte(Console.ReadLine());
            Console.Write(" Dime el mes: ");
            personas[i].fecha.mes = Convert.ToByte(Console.ReadLine());
            Console.Write(" Dime el año: ");
            personas[i].fecha.anyo = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine(" Estos son los datos guardados de las tres personas.");
        for (int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine(" *** " + ordinales[i] + " persona ***");
            Console.WriteLine(" Nombre: " + personas[i].nombre);
            Console.WriteLine(" Edad: " + personas[i].edad);
            Console.WriteLine(" Fecha de nacimiento: " + personas[i].fecha.dia + "/" +
                personas[i].fecha.mes + "/" + personas[i].fecha.anyo);
            Console.WriteLine();
        }
    }
}

