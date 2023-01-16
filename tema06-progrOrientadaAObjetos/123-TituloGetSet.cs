// DAN 1DAW

/*
123. Crea una nueva versión de la clase "Titulo". 
Sus atributos serán privados y tendrán getters y 
setters para poder darle valor y leer su valor. Cambia 
el programa y "Main" según sea necesario. Deberás entregar 
sólo el (único) fichero .cs.
*/

using System;

namespace Ejercicios
{
    class Titulo
    {
        private int x, y;
        private string texto;

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public string GetTexto()
        {
            return texto;
        }

        public void SetX(int nuevoX)
        {
            x = nuevoX;
        }

        public void SetY(int nuevoY)
        {
            y = nuevoY;
        }

        public void SetTexto(string nuevoTexto)
        {
            texto = nuevoTexto;
        }

        public void Mostrar()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(texto);
        }
    }

    class PruebaDeTitulo
    {
        static void Main()
        {
            Titulo titulo = new Titulo();

            titulo.SetX(30);
            titulo.SetY(5);
            titulo.SetTexto("Hola");
            titulo.Mostrar();
        }
    }
}