using System;

class Libro
{
    public string autor;
    public string titulo;
    public string ubicacion;

    public void MostrarDetalles()
    {
        Console.WriteLine(autor);
        Console.WriteLine(titulo);
        Console.WriteLine(ubicacion);
    }

    static void Main()
    {
        Libro l = new Libro();
        l.autor = "Stephen King";
        l.titulo = "It";
        l.ubicacion = "Est.1, Balda 2";
        l.MostrarDetalles();
    }
}

