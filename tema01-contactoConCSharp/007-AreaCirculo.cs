/* Jorge (...)
 * Programa para calculár el área de una circunferencia

Crea un programa que permita calcular áreas de círculos. El usuario 
introducirá el radio y se le responderá algo como "El área de un 
círculo de radio 2 m es de 12,56 m2". Recuerda que la fórmula es "Área 
= PI * radio al cuadrado". Para elevar el radio al cuadrado, puedes 
emplear r*r y PI vale 3.141592. Debes usar {0} en vez de "Write". No 
puedes utilizar "using System;". El programa debe contener un único 
comentario de múltiples líneas, que detalle tu nombre y el cometido del 
programa.

*/

class Calculoarea
{
        static void Main()
        {
            int radio;
        
            System.Console.Write("Introduzca el radio del círculo ");
            radio = System.Convert.ToInt32( System.Console.ReadLine() );
            
            System.Console.WriteLine("El área de un circulo de radio {0}m es de {1}m2", 
                radio, 3.141592*radio*radio);
        }
}
