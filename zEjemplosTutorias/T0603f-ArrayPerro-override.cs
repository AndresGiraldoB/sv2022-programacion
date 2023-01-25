/* Crea una nueva versión de las clases Perro y Dalmata, 
 * usando "virtual" y "override".
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
    public virtual void Ladrar()
    {
        Console.WriteLine("Guau");
    }
}

class Dalmata : Perro
{
    public override void Ladrar()
    {
        Console.WriteLine("Auuuu");
    }
}
