/* 
    Luis (...)
    
    58. Crea un programa que pida al usuario que introduzca un símbolo y 
    responda si se trata de un dígito (0 al 9), un operador (+ - * / %) o algún 
    otro símbolo. Debes emplear el tipo de datos "char" y hacerlo de dos formas 
    distintas (en un mismo programa, que pedirá datos sólo una vez y mostrará 
    dos resultados): primero usando "if" y después empleando "switch".
*/

using System;


class Ejercicio58
{
    static void Main()
    {
        char simbolo;
        
        Console.Write("Introduce un símbolo: ");
        simbolo = Convert.ToChar(Console.ReadLine());
       
        Console.WriteLine();
        Console.WriteLine("Con IF...");
        
        if (simbolo == '+' || simbolo == '-' || simbolo == '*' 
                || simbolo == '/' || simbolo == '%')
            Console.WriteLine("Es un operador.");
        else if ((simbolo >= '0') && (simbolo <= '9'))           
            Console.WriteLine("Es un dígito.");
        else
            Console.WriteLine("Es otro símbolo.");
                
        Console.WriteLine();        
        Console.WriteLine("Con SWITCH...");
        
        switch (simbolo)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Es un dígito.");
                break;
            case '+':
            case '-':
            case '*':
            case '/':
            case '%':   
                Console.WriteLine("Es un operador.");
                break;
            default:
                Console.WriteLine("Es otro símbolo.");
                break;  
        }
    }
}

