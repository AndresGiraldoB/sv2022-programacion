/* 
    Luis (...)
    
    61.Escribe un programa que pida un ancho mínimo y un alto (ambos serán 
    "byte"), así como un carácter, y muestre un trapecio descendente como este:

    Introduzca el ancho mínimo deseado: 5
    Introduzca el alto deseado: 3
    Introduzca el carácter: *

    *********
     *******
      *****
*/

using System;


class ejercicio61
{
    static void Main()
    {
        byte anchoMinimo, alto;
        short anchoActual;
        char caracter;
        
        Console.Write("Introduzca el ancho mínimo deseado: ");
        anchoMinimo = Convert.ToByte(Console.ReadLine());
        Console.WriteLine();
        
        Console.Write("Introduzca el alto deseado: ");
        alto = Convert.ToByte(Console.ReadLine());
        Console.WriteLine();
        
        Console.Write("Introduzca el carácter: ");
        caracter = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();
        
        anchoActual = Convert.ToInt16(anchoMinimo + (alto -1) * 2);
        
        for (byte fila = 1;fila <= alto; fila++)
        {
            for(byte espacios = 1; espacios < fila; espacios++)
            {
                Console.Write(" ");
            }
            
            for(byte simbolos = 1; simbolos <= anchoActual; simbolos++)
            {           
                Console.Write(caracter);        
            }
            Console.WriteLine();
            
            anchoActual -= 2; 
        }
    }
}

