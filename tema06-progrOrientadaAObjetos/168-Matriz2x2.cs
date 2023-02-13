/* 168. Crea una clase "Matriz2x2", que representará una matriz de números 
reales, con 2 filas y 2 columnas. Debe contener los siguientes métodos:

- Un constructor que reciba los dos valores de la primera fila y los dos de la 
segunda: Matriz2x2(f1a, f1b, f2a, f2b)

- Un segundo constructor sin argumentos, que establezca todos los valores a 0

- Multiplicar( n ), que multiplicará todos los elementos por un cierto valor.

- Sumar(m2) que sume elemento a elemento una segunda matriz.

- Debes sobrecargar el operador suma, para que también se puedan sumar "de 
manera natural".

- ToString, que devolverá una cadena parecida a "  2   -7   \n  -3  4".

- Mostrar, que escribirá la matriz en pantalla.

- Deberá haber un getter con el formato Get(fila, columna) y un setter con el 
formato Set(fila, columna, valor)

El programa de prueba debe crear pedir al usuario los valores para dos matrices 
A y B, multiplicar la segunda por 3, sumar A y B en un nueva matriz C y mostrar 
las tres matrices resultantes en pantalla, separadas por sendas líneas en 
blanco.

Autor: Igor (...) 1DAW
*/


using System;

class Matriz2x2
{
    private float[,] matriz = new float[2,2];

    public float Get(int fila, int columna)
    {
        return matriz[fila, columna];
    }

    public void Set(int fila, int columna, float valor)
    {
        matriz[fila, columna] = valor;
    }

    public Matriz2x2(float f1a, float f1b, float f2a, float f2b)
    {
        matriz[0, 0] = f1a;
        matriz[0, 1] = f1b;
        matriz[1, 0] = f2a;
        matriz[1, 1] = f2b;
    }

    public Matriz2x2()
    {
        matriz[0, 0] = 0;
        matriz[0, 1] = 0;
        matriz[1, 0] = 0;
        matriz[1, 1] = 0;
    }

    public void Multiplicar(float n)
    {
        matriz[0, 0] *= n;
        matriz[0, 1] *= n;
        matriz[1, 0] *= n;
        matriz[1, 1] *= n;
    }

    public void Sumar(Matriz2x2 m2)
    {
        matriz[0, 0] += m2.matriz[0, 0];
        matriz[0, 1] += m2.matriz[0, 1];
        matriz[1, 0] += m2.matriz[1, 0];
        matriz[1, 1] += m2.matriz[1, 1];
    }

    public static Matriz2x2 operator +(Matriz2x2 m1, Matriz2x2 m2)
    {
        return new Matriz2x2(
            m1.matriz[0, 0] + m2.matriz[0, 0],
            m1.matriz[0, 1] + m2.matriz[0, 1],
            m1.matriz[1, 0] + m2.matriz[1, 0],
            m1.matriz[1, 1] + m2.matriz[1, 1]);
    }

    //"  2 ? -7   \n  -3  4"
    public override string ToString()
    {
        return "  " + matriz[0, 0] + "  " + matriz[0, 1] + Environment.NewLine +
               "  " + matriz[1, 0] + "  " + matriz[1, 1] + Environment.NewLine;
    }

    public void Mostrar()
    {
        Console.WriteLine(this);
    }
}

// --

class PruebaDeMatriz2x2
{
    static float PedirDato(string q)
    {
        Console.Write(q);
        return Convert.ToSingle(Console.ReadLine());
    }

    static void Main()
    {
        Matriz2x2[] matrices = new Matriz2x2[3];

        for (int i = 0; i < matrices.Length - 1; i++)
        {
            Console.WriteLine("Introduce los datos de la matriz:");
            matrices[i] = new Matriz2x2(PedirDato("Fila 0, dato 0: "),
                                        PedirDato("Fila 0, dato 1: "),
                                        PedirDato("Fila 1, dato 0: "),
                                        PedirDato("Fila 1, dato 1: "));
        }

        Console.WriteLine("Datos de la matriz A:");
        matrices[0].Mostrar();

        Console.WriteLine("Datos de la matriz B:");
        matrices[1].Mostrar();

        Console.WriteLine("Matriz B tras multiplicar por 3:");
        matrices[1].Multiplicar(3);
        matrices[1].Mostrar();

        matrices[2] = matrices[0] + matrices[1];
        Console.WriteLine("Sumar datos de matriz A y B en una nueva (C):");
        matrices[2].Mostrar();

        Console.WriteLine("Mostrando todas las matrices:");

        foreach (Matriz2x2 m in matrices)
            m.Mostrar();
    }
}
