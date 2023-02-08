/* Crea una clase Cadena, que internamente contenga un "string". Sobrecarga el 
operador "*", para poder "multiplicar una cadena por un número". Por ejemplo, 
el texto "Hola", si se multiplica por 3, generaría "HolaHolaHola".
*/


using System;

class PruebaDeCadena
{
    static void Main()
    {
        Cadena c = new Cadena("Hola");
        Console.WriteLine(c);

        Cadena c2 = c * 5;
        Console.WriteLine(c2);
    }
}

// ---------------

class Cadena
{
    public string Texto { get; set; }

    public Cadena(string texto)
    {
        Texto = texto;
    }

    public override string ToString()
    {
        return Texto; 
    }

    public static Cadena operator * (Cadena c, int n)
    {
        string textoRespuesta = "";
        for (int i = 0; i < n; i++)
        {
            textoRespuesta += c.Texto;
        }
        return new Cadena(textoRespuesta);
    }
}

// Hola
// HolaHolaHolaHolaHola
