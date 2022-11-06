// Daniel (..)

/* 60. Crea un programa que le pida al usuario dos números 
 * (reales de doble precisión) y una operación para realizar en ellos 
 * (+, -, *, /) y muestre el resultado de esa operación, como en este ejemplo:

Introduzca el primer número: 8
Introduzca la operación: +
Introduzca el segundo número: 7
8 + 7 = 15 */

using System;

class Calculadora
{
    static void Main()
    {
        double primerNumero, segundoNumero;
        char operador;

        Console.Write("Introduzca el primer número: ");
        primerNumero = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduzca la operación: ");
        operador = Convert.ToChar(Console.ReadLine());
        Console.Write("Introduzca el segundo número: ");
        segundoNumero = Convert.ToDouble(Console.ReadLine());

        switch (operador)
        {
            case '+':
                Console.WriteLine("{0} {1} {2} = {3}", primerNumero, operador,
                    segundoNumero, primerNumero + segundoNumero); 
                break;
            case '-':
                Console.WriteLine("{0} {1} {2} = {3}", primerNumero, operador,
                    segundoNumero, primerNumero - segundoNumero);
                break;
            case '/':
                Console.WriteLine("{0} {1} {2} = {3}", primerNumero, operador,
                    segundoNumero, primerNumero / segundoNumero); 
                break;
            case '*':
                Console.WriteLine("{0} {1} {2} = {3}", primerNumero, operador,
                    segundoNumero, primerNumero * segundoNumero); 
                break;
            default:
                Console.WriteLine("Operación no válida"); 
                break;
        }
    }
}
