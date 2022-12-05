using System;

/*99. Crea una función llamada "EscribirEspaciado", que mostrará el parámetro 
 de texto con un espacio adicional entre cada par de letras.
 Por ejemplo, el texto "DAM/DAW" se mostraría como "D A M / D A W". Pruébala en 
 Main, a partir de un texto introducido por el usuario.*/

// Noelia (...)

class Ejercicio99
{
    static void Main()
    {
        Console.WriteLine("Escribe el texto: ");
        string t = Console.ReadLine();
        EscribirEspaciado(t); 
    }
    
    static void EscribirEspaciado (string a)
    {
        string nuevoTexto = "";
        for (int i = 0; i < a.Length; i++)
        {
            nuevoTexto += a[i] + " ";
        }
        Console.WriteLine(nuevoTexto.Trim());
    }
    
   
}

