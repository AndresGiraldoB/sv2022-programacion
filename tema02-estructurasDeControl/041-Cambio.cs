/*Crea un programa devuelva el cambio de una compra, utilizando siempre en 
primer lugar monedas (o billetes) del valor más grande posible. Supondremos que 
tenemos una cantidad ilimitada de monedas (o billetes) de 50, 10, 5, 2 y 1, y 
que no hay decimales. La ejecución podría ser algo como : 

Precio? 212
Pagado? 300
Tu cambio es 88: 50 10 10 10 5 2 1 

Fátima (...)*/

using System;

class Ejercicio41
{
    static void Main()
    {
        int precio, pagado, cambio;
        
        Console.WriteLine("¿Precio? ");
        precio=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿Pagado? ");
        pagado=Convert.ToInt32(Console.ReadLine());
        
        cambio = pagado-precio;
        Console.Write("Tu cambio es: ");
        
        while(cambio>= 50)
        {
            Console.Write("50 ");
            cambio = cambio-50;
        }
        
        while(cambio>= 10)
        {
            Console.Write("10 ");
            cambio = cambio-10;
        }
        
        while(cambio>= 5)
        {
            Console.Write("5 ");
            cambio = cambio-5;
        }
        
        while(cambio>= 2)
        {
            Console.Write("2 ");
            cambio = cambio-2;
        }
        
        while(cambio>= 1)
        {
            Console.Write("1 ");
            cambio = cambio-1;
        }
            
    }
}

