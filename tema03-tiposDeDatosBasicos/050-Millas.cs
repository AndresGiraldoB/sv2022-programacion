// Aitor (...)
// Ejercicios de programación
// Tema 3, semana 1
// Ejercicio 50

/*
50. Crea un programa que pida al usuario una cantidad de kilómetros y calcule 
(y escriba) su equivalencia en millas terrestres (1 milla terrestre = 1,609 Km) 
y en millas náutica (1 milla náutica = 1,852 Km). Por ejemplo, si el usuario 
introduce 20,5 km, la respuesta debería ser cercana a 12,74 millas terrestres y 
a 11,07 millas náuticas. Debes usar datos reales de simple precisión (float).
*/


using System;

class Ejercicio50
{
    static void Main ()
    {

        float km;
        
        Console.Write("Escribe una cantidad de kilómetros: ");
        km = Convert.ToSingle(Console.ReadLine());
        
        // 1 milla terrestre = 1,609 km
        float MillaTerr = km / 1.609f;
        
        // 1 milla náutica = 1,852 km
        float MillaNau = km / 1.852f; 
        
        Console.WriteLine("{0} km corresponde a {1} millas terrestres y a {2} millas náuticas",
            km, MillaTerr, MillaNau);
    }    
}
