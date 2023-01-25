/* Implementa las clases Perro y Dalmata (que hereda de Perro), con métodos 
Ladrar distintos. Comprueba que el Ladrar de Dalmata se comporta bien si creas 
un objeto independiente, pero no si es parte de un array.
*/

using System;

class PruebaPerro
{
    static void Main()
    {
        Perro[] perros = new Perro[5];
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 1)
                perros[i] = new Perro();
            else
                perros[i] = new Dalmata();
        }

        for (int i = 0; i < 5; i++)
        {
            perros[i].Ladrar();
        }
    }
}

class Perro
{
    public void Ladrar()
    {
        Console.WriteLine("Guau");
    }
}

class Dalmata : Perro
{
    public new void Ladrar()
    {
        Console.WriteLine("Auuuu");
    }
}
