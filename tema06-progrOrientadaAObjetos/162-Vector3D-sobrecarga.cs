/*Crea una nueva versión de la clase Vector3D, sobrecargando el operador "+", 
de modo que permita sumar dos vectores pasados como parámetros, de modo que se 
pueda hacer "vector1 = vector2+vector3;".

Sobrecarga también el operador "*", para que permita multiplicar el vector por 
un cierto número: "vector1 = vector2 * 7.4;".

Fátima (...) */

using System;

class Vector3D
{
    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public override string ToString()
    {
        return "<" + X + ", " + Y + ", " + X + ">";
    }

    public double GetLongitud()
    {
        return Math.Sqrt(X*X + Y*Y + Z*Z);
    }

    public void Sumar(Vector3D v)
    {
        X += v.X;
        Y += v.Y;
        Z += v.Z;
    }

    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3D operator *(Vector3D v1, double n)
    {
        return new Vector3D(v1.X * n, v1.Y * n, v1.Z * n);
    }
}

class Prueba
{
    static void Main()
    {
        Vector3D v = new Vector3D(10, 15, 20);
        Vector3D v2 = new Vector3D(11, 17, 23);
        v.Sumar(v2);
        Console.WriteLine(v);

        Vector3D v3 = v + v2;
        Console.WriteLine(v3);

        Vector3D v4= v * 4.7;
        Console.WriteLine(v4);
    }
}
