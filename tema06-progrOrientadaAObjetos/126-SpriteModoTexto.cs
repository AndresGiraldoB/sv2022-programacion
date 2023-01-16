using System;

/*126. Crea una clase llamada "SpriteModoTexto", que representará una supuesta 
imagen de un juego en modo de consola. Sus atributos (públicos) serán las 
coordenadas x e y (de tipo byte) y el carácter que represente esa supuesta 
imagen. Tendrá un método (void) llamado "Dibujar", que mostrará ese carácter en 
la pantalla, en las coordenadas indicadas por sus atributos (puedes ayudarte de 
Console.SetCursorPosition para conseguir que el texto aparezca realmente en 
esas coordenadas). Crea una clase "PruebaDeSprite" (en el mismo fichero 
fuente), que tendrá un "Main" para probar la clase "SpriteModoTexto", creando 
una supuesta nave espacial formada por el carácter "M", en las coordenadas (40, 
20) y que habrá de mostrarse. Deberás entregar sólo el fichero .cs.*/

// Noelia (...)

class SpriteModoTexto
{
    public byte x, y;
    public char caracter;

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
    }

}
class PruebaDeSprite
{
    static void Main()
    {
        SpriteModoTexto S = new SpriteModoTexto();
        S.x = 40;
        S.y = 20;
        S.caracter='M';
        S.Dibujar();
    }
}


















