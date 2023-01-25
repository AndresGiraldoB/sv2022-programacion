/* Crea una clase llamada "PseudoRandom" para generar "falsos números 
aleatorios". En ella, crea un método estático "Get" que devolverá los 
milisegundos del reloj del sistema actual (deberás usar 
"DateTime.Now.Millisecond"). Crea un "Main" para probarla, en una clase 
auxiliar.
*/

using System;

class PruebaPseudoRandom
{
    static void Main()
    {
        Console.WriteLine(   PseudoRandom.Get()  );
    }
}

class PseudoRandom
{
    public static int Get()
    {
        return DateTime.Now.Millisecond;
    }
}
