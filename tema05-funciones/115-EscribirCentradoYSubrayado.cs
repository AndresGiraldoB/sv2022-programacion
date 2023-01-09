/* 
 * 115. Crea una función EscribirCentradoYSubrayado, que escriba centrado horizontalmente en pantalla
 * (suponiendo una anchura de 80 columnas) y subrayado (con guiones) el texto que se indique como parámetro.
 * 
 * Autor: Igor (...)
*/

using System;

class Ej115
{
    static void EscribirCentradoYSubrayado(string texto)
    {
        int n = (80 - texto.Length) / 2;
        string espacios = new string(' ', n);
        string subrayado = new string('-', texto.Length);
        Console.WriteLine(espacios + texto);
        Console.WriteLine(espacios + subrayado);
    }

    static void Main()
    {
        EscribirCentradoYSubrayado(Console.ReadLine());
    }
}

