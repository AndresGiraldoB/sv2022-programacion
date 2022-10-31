/*
Calcula el volumen de un cilindro, a partir de su radio y su altura, que 
introducirá el usuario. El volumen será "pi por el radio al cuadrado, 
multiplicado por la altura". Debes utilizar variables de tipo "float" y mostrar 
los resultados con tres decimales.
*/

//Edgar (...)

using System;

class Volumen
{
    static void Main()
    {
        float radio, altura, volumen, pi;
        
        pi = 3.141592f;
        
        Console.Write("Introduce el radio del cilindro: ");
        radio = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce la altura: ");
        altura = Convert.ToSingle(Console.ReadLine());
        
        volumen = pi * radio*radio * altura;
        Console.WriteLine("El volumen del cilindro es de {0}.", 
            volumen.ToString("N3"));
    }
}

