using System;

class ParImpar
{
    static void Main()
    {
        int numero;
    
        Console.Write("Dime un número(1 a 4): ");
        numero = Convert.ToInt32( Console.ReadLine() );
        
        // Alternativa 1: exhaustivo
        
        switch(numero)
        {
            case 1:
                Console.WriteLine("Impar");
                break;
            
            case 2:
                Console.WriteLine("Par");
                break;
                
            case 3:
                Console.WriteLine("Impar");
                break;
                
            case 4:
                Console.WriteLine("Par");
                break;
                
            default:
                Console.WriteLine("No sé contar tanto");
                break;
        }
        
        // Alternativa 2: menos repetitiva, con "goto case"
        
        switch(numero)
        {
            case 1: Console.WriteLine("Impar"); break;
            case 2: Console.WriteLine("Par"); break;
            case 3: goto case 1;
            case 4: goto case 2;
            default:
                Console.WriteLine("No sé contar tanto");
                break;
        }
        
        // Alternativa 3: la más compacta
        
        switch(numero)
        {
            case 1: 
            case 3: Console.WriteLine("Impar"); break;
            
            case 2: 
            case 4: Console.WriteLine("Par"); break;
            
            default:
                Console.WriteLine("No sé contar tanto");
                break;
        }
    }
}
