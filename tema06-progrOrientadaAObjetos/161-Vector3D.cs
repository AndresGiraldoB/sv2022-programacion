/*Crea una clase Vector3D que represente un vector en el espacio tridimensional 
(con coordenadas X, Y, Z, que serán números reales de doble precisión). Debe 
tener:

-Un constructor que permita inicializar los valores de X, Y, Z.

- En vez de emplear atributos y setters+getters convencionales, deberás 
utilizar propiedades en formato compacto.

- Un método "ToString", que devolvería algo como "<2, -3, 4.2>" (es decir, los 
valores X, Y, Z, separados por ", ", precedidos por un símbolo de "menor que" y 
terminando con un símbolo de "mayor que").

-Un método "GetLongitud", que permita obtener la longitud (módulo) del 
vector(la raíz cuadrada de x^2 + y^2 + z^2)

-Un método "Sumar", que permita sumar un vector (que se pasará como parámetro) 
al vector actual (el resultado será: < x1 + x2, y1 + y2, z1 + z2 >)

Crea un programa de prueba, que permita probar estas funcionalidades.

Fátima (...) */

using System;

class Vector3D
{
    private double x, y, z;

    public Vector3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public override string ToString()
    {
        return "<" + x + ", " + y + ", " + z + ">";
    }

    public double GetLongitud()
    {
        return Math.Sqrt(x*x + y*y + z*z);
    }

    public void Sumar(Vector3D v)
    {
        x += v.x;
        y += v.y;
        z += v.z;
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
    }
}

