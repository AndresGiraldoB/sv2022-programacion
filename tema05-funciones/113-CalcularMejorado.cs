//Francis (...) - 1ºDAM Semipresencial

/*
 * 113. Crea una versión mejorada del programa "calcular", que también permita 
 * calcular potencias (con la letra E, de "elevado a"), que devuelva al sistema 
 * operativo el código de error 0 si todo ha sido correcto, el código 1 si se ha 
 * indicado un operador no válido o el código 2 si alguno de los números no 
 * era válido, además de mostrar en consola un mensaje de aviso adecuado:
 * 
 * calcular 2 E 3
 * 8
 * calcular 2 ** 3
 * Operador desconocido
 * calcular 3 + Hola
 * Número no válido
 * Nota: el enunciado original de este ejercicio pedía usar el símbolo ^ para la 
 * potencia, pero se trata de un carácter de escape en el intérprete de 
 * comandos de Windows, por lo que para usarlo habría que hacer:
 * 
 * calcular 2 "^" 3
 */

using System;
class CalcularMejorado
{
    static int Main(string[] args)
    {
        if (args.Length == 3)
        {
            try
            {
                int num1 = Convert.ToInt32(args[0]);
                string op = Convert.ToString(args[1]);
                int num2 = Convert.ToInt32(args[2]);

                switch (args[1])
                {
                    case "+": Console.WriteLine(num1 + num2); break;
                    case "-": Console.WriteLine(num1 - num2); break;
                    case "*": Console.WriteLine(num1 * num2); break;
                    case "/": Console.WriteLine((double) num1 / num2); break;
                    case "^":
                    case "E":
                        int aux = 1;
                        for (int i = 0; i < num2; i++)
                        {
                            aux *= num1;
                        }
                        Console.WriteLine(aux); break;
                    default:
                        Console.WriteLine("Operador deconocido");
                        return 1;
                }

                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Número no válido");
                return 2;
            }
        }
        else
        {
            Console.WriteLine("Indica una operación como: 15 / 2 ");
            return 3;
        }
    }
}
