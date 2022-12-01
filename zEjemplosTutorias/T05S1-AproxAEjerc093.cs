using System;

class EjemploEjercicio93
{
    static void Main()
    {
        ComprobarHechos();
        ComprobarAsignatura("Bases de datos");
    }

    static void ComprobarHechos()
    {
        Console.WriteLine("Se me va dando mejor la programación");
    }

    static void ComprobarAsignatura( string asignatura )
    {
        Console.WriteLine("Se me va dando mejor " + asignatura);
    }

    
}

