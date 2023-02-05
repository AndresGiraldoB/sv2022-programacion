// DAN 1DAW

/*
158. Crea una clase "Encriptador", que permita encriptar y desencriptar textos.

Tendrá un método "Encriptar", que recibirá una cadena y devolverá otra cadena. 
Será un método estático, por lo que no necesitaremos crear ningún objeto de 
tipo "Encriptador".

También habrá un método "Desencriptar".

En este primer acercamiento, el método de cifrado será muy simple: para cifrar 
sumaremos 1 a cada carácter, de modo que "Hola" se convierta en "Ipmb", y para 
descifrar restaremos 1 a cada carácter.

Crea una clase PruebaDeEncriptador para probarlo. Un ejemplo de uso podría ser

string nuevoTexto = Encriptador.Encriptar ("Hola");
*/

using System;

class Encriptador
{
    public static string Encriptar(string texto)
    {
        string textoEncriptado = "";

        for (int i = 0; i < texto.Length; i++)
        {
            textoEncriptado += Convert.ToChar(texto[i] + 1);
        }

        return textoEncriptado;
    }

    public static string Desencriptar(string texto)
    {
        string textoDesencriptado = "";

        for (int i = 0; i < texto.Length; i++)
        {
            textoDesencriptado += Convert.ToChar(texto[i] - 1);
        }

        return textoDesencriptado;
    }
}

class PruebaDeEncriptador
{
    static void Main()
    {
        string nuevoTexto = Encriptador.Encriptar("Hola");
        Console.WriteLine(nuevoTexto);
        Console.WriteLine(Encriptador.Desencriptar(nuevoTexto));
    }
}
