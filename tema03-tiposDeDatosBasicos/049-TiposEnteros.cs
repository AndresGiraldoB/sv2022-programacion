using System;

// Adrián (...)
 
/*
49. Crea un programa en C# que pida al usuario su edad, su año de nacimiento, 
su estatura en centímetros, la población de su ciudad, la población estimada 
del mundo y el dinero que tiene ahorrado (en euros, sin decimales). Debes 
optimizar los tipos de datos usados (todos ellos serán números enteros).
*/
 
class Optimización
{
    static void Main()
    {
        Console.Write("Introduzca su edad:  ");
        byte edad = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Introduzca su año de nacimiento:  ");
        ushort nacimiento = Convert.ToUInt16(Console.ReadLine());
        
        Console.Write("Introduzca su estatura en centimetros:  ");
        byte estatura = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Introduzca la población de su ciudad:  ");
        uint poblacionCiudad = Convert.ToUInt32(Console.ReadLine());
        
        Console.Write("Introduzca la población estimada del mundo: ");
        ulong poblacionMundo= Convert.ToUInt64(Console.ReadLine());
        
        Console.Write("Introduzca el dinero que tiene ahorrado (en euros, sin decimales):  ");
        long dinero = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Edad {0} años",edad);
        Console.WriteLine("Nació en el año {0} ", nacimiento);
        Console.WriteLine("Mide {0} metros", estatura /100.0 );
        Console.WriteLine("Hay {0} habitantes en su ciudad", poblacionCiudad);
        Console.WriteLine("hay {0} habitantes en el mundo", poblacionMundo);
        Console.WriteLine("Tiene {0} euros ahorrados",dinero);
    }
}

