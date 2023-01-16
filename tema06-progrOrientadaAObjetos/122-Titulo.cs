// Alejandro (...)

// 122. Crea una clase llamada "Titulo". Sus atributos (públicos)
// serán el texto y las coordenadas x e y. Tendrá un método void llamado "Mostrar",
// que mostrará su texto en la pantalla, en las coordenadas indicadas
// por sus atributos. Crea una clase "PruebaDeTitulo" (en el mismo fichero fuente),
// que tendrá un "Main" para probarlo. Puedes ayudarte de
// Console.SetCursorPosition(columna,fila) para conseguir que el texto aparezca
// realmente en esas coordenadas. Deberás entregar sólo el (único) fichero .cs.


using System;

class Titulo
{
    public int x, y;
    public string texto;

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
        Titulo t= new Titulo();
        t.x = 30;
        t.y = 10;
        t.texto = "Hola";
        t.Mostrar();
    }
}
