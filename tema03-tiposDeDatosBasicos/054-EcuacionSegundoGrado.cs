// Francisco (...) - 1ºDAM Semipresencial

/* 
 * 54. Crea un programa que calcule las soluciones ("raíces") de una ecuación 
 * de segundo grado Ax2 + Bx + C = 0 (si no recuerdas la fórmula, puedes verla 
 * en la Wikipedia)
 * Nota: para calcular la raíz cuadrada, puedes usar Math.Sqrt( x ), 
 * que veremos con más detalle la próxima semana.
 */

using System;

class ecuacionSegundoGrado
{
    static void Main()
    {
        sbyte a, b, c;
        double interiorRaiz;
        double x1, x2;

        Console.Write("Introduce el valor de a: ");
        a = Convert.ToSByte(Console.ReadLine());

        Console.Write("Introduce el valor de b: ");
        b = Convert.ToSByte(Console.ReadLine());

        Console.Write("Introduce el valor de c: ");
        c = Convert.ToSByte(Console.ReadLine());

        interiorRaiz = b * b - 4 * a * c;

        if (interiorRaiz < 0)
        {
            Console.WriteLine("No tiene solución");
        }

        else
        {
            x1 = ((-b) + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            x2 = ((-b) - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);

            if (interiorRaiz == 0)
            {
                Console.WriteLine("{0} como única solución",
                    x1.ToString("0.00"));
            }

            else
            {
                Console.WriteLine("{0} y {1} como soluciones",
                    x1.ToString("0.00"), x2.ToString("0.00"));
            }
        }
    }
}
