/*155. Crea una clase "AlbumDeFotosFisico" con un atributo privado "numeroDePaginas".

También debe tener un método público "GetNumeroDePaginas", que devolverá el número de páginas.

El constructor predeterminado creará un álbum con 16 páginas. Habrá un constructor adicional,
con el que podemos especificar el número de páginas que queremos en el álbum. Un constructor 
se apoyará en otro empleando "this".

Crea una clase "AlbumDeFotosGrande", que herede de ella, y cuyo constructor creará un álbum 
con 64 páginas, empleando "base".

Prepara una clase de prueba "PruebaDeAlbum", que cree un array que contenga un álbum con su
constructor predeterminado, uno con 24 páginas, un "AlbumDeFotosGrande" y finalmente recorra 
el array para mostrar la cantidad de páginas que tienen los tres álbumes.

 1º DAW MJBS*/

using System;

class AlbumDeFotosFisico
{
    private int numeroDePaginas;

    public int GetNumeroDePaginas()
    {
        return numeroDePaginas;
    }

    public AlbumDeFotosFisico(int numeroDePaginas)
    {
        this.numeroDePaginas = numeroDePaginas;
    }

    public AlbumDeFotosFisico():this(16)
    {
    }
   
}

//--------------------------------------

class AlbumDeFotosGrande : AlbumDeFotosFisico
{
    public AlbumDeFotosGrande()
        :base(64)
    {
    }
}

//---------------------------------------

class PruebaDeAlbum
{
    static void Main()
    {
        AlbumDeFotosFisico[] album = new AlbumDeFotosFisico[3];
        album[0] = new AlbumDeFotosFisico();
        album[1] = new AlbumDeFotosFisico(24);
        album[2] = new AlbumDeFotosGrande();
        for(int i = 0; i < album.Length; i++)
        {
            Console.WriteLine("Album: " + i + ". Páginas: " + 
                album[i].GetNumeroDePaginas());
        }
    }
}
