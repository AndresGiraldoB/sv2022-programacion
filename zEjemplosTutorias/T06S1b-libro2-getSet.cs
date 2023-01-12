using System;

class Libro
{
    private string autor;
    private string titulo;
    private string ubicacion;

    public string GetAutor() { return autor; }
    public string GetTitulo() { return titulo; }
    public string GetUbicacion() { return ubicacion; }

    public void SetAutor(string nuevoAutor) { autor = nuevoAutor; }
    public void SetTitulo(string nuevoTitulo) { titulo = nuevoTitulo; }
    public void SetUbicacion(string nuevaUbicacion) { ubicacion = nuevaUbicacion; }

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

        Console.WriteLine( l.GetAutor() );
        l.SetTitulo("La larga marcha");

        l.MostrarDetalles();
    }
}

