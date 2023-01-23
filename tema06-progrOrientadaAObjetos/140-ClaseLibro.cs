/* 140. De cara a irnos acercando a una versión orientada a objetos del 
proyecto de la Biblioteca (ejercicio 111), crea una clase Libro, con atributos: 
titulo (string), autor (string), anyoPubli (entero corto). Debes preparar 
setters y getters para todos ellos, pero los getters numéricos devolverán datos 
"int", y lo setters numéricos recibirán datos "int". Crea también un 
constructor adecuado, un método Mostrar (void) que muestre los datos de un 
Libro en pantalla, y un método Contiene (booleano) que devuelva "true" si el 
título o el autor contienen el texto que se indique como parámetro. */

using System;

class Libro
{
    protected string titulo;
    protected string autor;
    protected short anyoPubli;
    
    public Libro(string nuevoTitulo, string nuevoAutor, int nuevoAnyoPublicacion)
    {
        titulo = nuevoTitulo;
        autor = nuevoAutor;
        anyoPubli = (short) nuevoAnyoPublicacion;
    }
    
    public string GetTitulo() { return titulo; }
    public string GetAutor() { return autor; }
    public int GetAnyoPublicacion() { return anyoPubli; }

    public void SetTitulo(string nuevoTitulo) { titulo = nuevoTitulo; }
    public void SetAutor(string nuevoAutor) { autor = nuevoAutor; }
    public void SetAnyoPublicacion(int nuevoAnyoPublicacion) 
    { 
        anyoPubli = (short) nuevoAnyoPublicacion; 
    }
    
    public void Mostrar()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anyoPubli);
    }
    
    public bool Contiene(string texto)
    {
        return titulo.ToUpper().Contains(texto.ToUpper())
            ||  autor.ToUpper().Contains(texto.ToUpper());
    }
}

class PruebaClaseLibro
{
    static void Main()
    {
        Libro l = new Libro("It","Stephen King",2022);
        l.SetAnyoPublicacion(1986);
        l.Mostrar();
        
        if (l.Contiene("st"))
        {
            Console.WriteLine("Contiene  \"st\"");
        }
    }
}
