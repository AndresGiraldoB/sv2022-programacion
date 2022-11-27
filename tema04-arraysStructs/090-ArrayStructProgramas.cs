// Daniel (...)

/* 
90 - Juegos de ordenador (examen de 2014-2015)

Crea un programa de C# que pueda almacenar hasta 10000 juegos de ordenador. 
Para cada juego, debe permitir al usuario almacenar la siguiente información:

 • Título (por ejemplo, GranTurismo 6)

 • Categoría (por ejemplo, carreras)

 • Plataforma (por ejemplo, PS3)

 • Año (por ejemplo, 2013)

 • Clasificación (por ejemplo, 8.7)

 • Comentarios

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un nuevo juego (al final de los datos existentes). El título y la 
descripción no deben estar vacíos. El año, si se introduce, debe ser de 1940 a 2100. 
La calificación, si se introduce, debe ser de 0 a 10. No se debe realizar ninguna otra 
validación.

2 - Mostrar todos los datos de un juego determinado (a partir de su número de registro o 
bien de su título exacto -sin distinción de mayúsculas y minúsculas-, según elija el usuario).

3 - Mostrar todos los juegos de una determinada plataforma y categoría. Debe mostrar el 
número de registro, el título, el año y la clasificación, haciendo una pausa después de 
cada 22 filas.

4 - Buscar juegos que contengan un determinado texto (búsqueda parcial, en cualquier 
campo de texto, sin distinción de mayúsculas y minúsculas). Debe mostrar el número de 
registro, el título, el año y la clasificación, haciendo una pausa después de cada 22 filas.

5 - Modificar un registro: pedirá al usuario su número, mostrará el valor anterior de 
cada campo y permitirá pulsar Intro para no modificar alguno de los datos. Se debe avisar 
al usuario (pero no volver a pedir) si introduce un número de registro incorrecto. 
El año y la calificación, si se modifican, deben ser válidos.

6 - Eliminar un registro, en la posición indicada por el usuario. Se le debe avisar 
(pero no volver a preguntar) si introduce un número de registro incorrecto. 
Debe mostrar el registro que se va a eliminar y solicitar confirmación antes de la 
eliminación.

7 - Ordenar los datos alfabéticamente, por título y (si es necesario) por plataforma.

8 - Eliminar espacios redundantes: eliminar espacios finales, espacios iniciales y 
espacios duplicados en la descripción, categoría y plataforma.

S - Salir de la aplicación (como no sabemos almacenar la información en archivo, 
los datos se perderán).
*/

using System;
using System.Text;

class Ejercicios
{
    struct TipoJuegos
    {
        public string titulo;
        public string descripcion;
        public string categoria;
        public string plataforma;
        public short anyo;
        public float calificacion;
        public string comentarios;
    }
    
    static void Main()
    {
        const int TAMANYO = 10000;
        const char ANYADIR = '1', MOSTRARDATOS = '2', MOSTRARJUEGOS = '3',
            BUSCAR = '4', MODIFICAR = '5', ELIMINARDATOS = '6', ORDENAR = '7',
            ELIMINARESPACIOS = '8', SALIR = 'S';
        string tituloTemp, descripcionTemp, categoriaTemp,
            plataformaTemp, comentariosTemp, anyoTempString,
            calificacionTempString;
        TipoJuegos auxiliar;
        string textoBuscar;
        short anyoTemp;
        float calificacionTemp;
        int cantidad = 0;
        int posicion;
        bool encontrado;
        bool confirmacion;
        char opcion;

        TipoJuegos[] juegos = new TipoJuegos[TAMANYO];

        do
        {
            Console.Clear();
            Console.WriteLine("--- Menú ---");
            Console.WriteLine("{0}. Añadir un nuevo juego.", ANYADIR);
            Console.WriteLine("{0}. Mostrar todos los datos de un juego.", MOSTRARDATOS);
            Console.WriteLine("{0}. Mostrar todos los juegos por plataforma y categoría.", MOSTRARJUEGOS);
            Console.WriteLine("{0}. Buscar juegos que contengan un texto.", BUSCAR);
            Console.WriteLine("{0}. Modificar un registro.", MODIFICAR);
            Console.WriteLine("{0}. Eliminar un registro.", ELIMINARDATOS);
            Console.WriteLine("{0}. Ordenar datos alfabéticamente.", ORDENAR);
            Console.WriteLine("{0}. Eliminar espacios redundantes.", ELIMINARESPACIOS);
            Console.WriteLine("{0}. Salir del programa.", SALIR);
            Console.WriteLine("---      ---");

            opcion = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (opcion)
            {
                case SALIR:

                    Console.WriteLine("Saliendo del programa. Adiós.");

                    break;

                // Añadir un juego nuevo
                case ANYADIR:
                    Console.WriteLine("Opción \"Añadir un nuevo juego\" seleccionada.");
                    if (cantidad > TAMANYO)
                    {
                        Console.WriteLine("Error. No hay más espacio libre.");
                    }
                    else
                    {
                        // Añadir título
                        do
                        {
                            Console.Write("Escribe el título del juego (No puede estar vacío): ");
                            tituloTemp = Console.ReadLine();

                            if (tituloTemp == "")
                            {
                                Console.WriteLine("Error. El título no puede estar vacío. " +
                                    "Prueba de nuevo.");
                            }
                            else
                            {
                                juegos[cantidad].titulo = tituloTemp;
                            }
                        }
                        while (tituloTemp == "");

                        // Añadir descripción
                        do
                        {
                            Console.Write("Escribe la descripción del juego (No puede estar vacía): ");
                            descripcionTemp = Console.ReadLine();

                            if (descripcionTemp == "")
                            {
                                Console.WriteLine("Error. La descripción no puede estar vacía. " +
                                    "Prueba de nuevo.");
                            }
                            else
                            {
                                juegos[cantidad].descripcion = descripcionTemp;
                            }
                        }
                        while (descripcionTemp == "");

                        // Añadir categoría
                        do
                        {
                            Console.Write("Escribe la categoría del juego (No puede estar vacía): ");
                            categoriaTemp = Console.ReadLine();

                            if (categoriaTemp == "")
                            {
                                Console.WriteLine("Error. La categoría no puede estar vacía. " +
                                    "Prueba de nuevo.");
                            }
                            else
                            {
                                juegos[cantidad].categoria = categoriaTemp;
                            }
                        }
                        while (categoriaTemp == "");

                        // Añadir plataforma
                        Console.Write("Escribe la plataforma del juego: ");
                        juegos[cantidad].plataforma = Console.ReadLine();

                        // Añadir año
                        do
                        {
                            Console.Write("Escribe el año del juego " +
                                "(Debe estar entre 1940 y 2100): ");
                            anyoTemp = Convert.ToInt16(Console.ReadLine());

                            if ((anyoTemp < 1940) || (anyoTemp > 2100))
                            {
                                Console.WriteLine("Error. El año debe estar entre " +
                                    "1940 y 2100, ambos inclusive.");
                            }
                            else
                            {
                                juegos[cantidad].anyo = anyoTemp;
                            }
                        }
                        while ((anyoTemp < 1940) || (anyoTemp > 2100));

                        // Añadir calificación
                        do
                        {
                            Console.Write("Escribe la calificación del juego " +
                                "(Debe estar entre 0 y 10, ambos inclusive.): ");
                            calificacionTemp = Convert.ToSingle(Console.ReadLine());

                            if ((calificacionTemp < 0) || (calificacionTemp > 10))
                            {
                                Console.WriteLine("Error. La calificación debe ser entre " +
                                    "0 y 10, ambos inclusive.");
                            }
                            else
                            {
                                juegos[cantidad].calificacion = calificacionTemp;
                            }
                        }
                        while ((calificacionTemp < 0) || (calificacionTemp > 10));

                        // Añadir comentarios
                        Console.Write("Escribe un comentario sobre el juego: ");
                        juegos[cantidad].comentarios = Console.ReadLine();
                    }

                    Console.WriteLine("Datos del juego guardados con éxito.");
                    cantidad++;
                    Console.WriteLine("Pulsa cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;

                // Mostrar datos de un juego
                case MOSTRARDATOS:

                    Console.WriteLine("Opción \"Mostrar todos los datos de un juego\" seleccionada.");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Error. No hay ningún juego guardado. " +
                            "Prueba a guardar algún juego primero.");
                    }
                    else
                    {
                        Console.WriteLine("Puedes buscar un juego de dos maneras distintas:");
                        Console.WriteLine("1. A partir de su número de registro.");
                        Console.WriteLine("2. A partir de su título exacto.");
                        Console.Write("Elige tu opción: ");

                        byte opcionMostrar = Convert.ToByte(Console.ReadLine());

                        switch (opcionMostrar)
                        {
                            // Mostrar datos por registro
                            case 1:

                                Console.WriteLine("Has elegido la opción \"A partir de " +
                                    "su número de registro\".");
                                Console.Write("Escribe el número de registro: ");
                                posicion = Convert.ToInt32(Console.ReadLine());

                                if (posicion <= 0 || posicion > cantidad)
                                {
                                    Console.WriteLine("Error. Número de registro incorrecto.");
                                }
                                else
                                {
                                    Console.WriteLine("Juego número {0}.", posicion);
                                    Console.WriteLine("Título: {0}.", juegos[posicion - 1].titulo);
                                    Console.WriteLine("Descripción: {0}.", juegos[posicion - 1].descripcion);
                                    Console.WriteLine("Categoría: {0}.", juegos[posicion - 1].categoria);
                                    Console.WriteLine("Plataforma: {0}.", juegos[posicion - 1].plataforma);
                                    Console.WriteLine("Año: {0}.", juegos[posicion - 1].anyo);
                                    Console.WriteLine("Calificación: {0}.", juegos[posicion - 1].calificacion);
                                    Console.WriteLine("Comentarios: {0}.", juegos[posicion - 1].comentarios);
                                    Console.WriteLine();
                                }

                                break;

                            // Mostrar datos por título exacto
                            case 2:

                                Console.WriteLine("Has elegido la opción \"A partir de " +
                                    "su título exacto\".");
                                Console.Write("Escribe su título exacto: ");
                                tituloTemp = Console.ReadLine().ToLower();

                                posicion = -1;
                                encontrado = false;
                                for (int i = 0; i < cantidad && encontrado == false; i++)
                                {
                                    if (juegos[i].titulo.ToLower() == tituloTemp)
                                    {
                                        encontrado = true;
                                        posicion = i;
                                    }
                                }

                                if (encontrado)
                                {
                                    Console.WriteLine("Juego número: {0}.", posicion + 1);
                                    Console.WriteLine("Título: {0}.", juegos[posicion].titulo);
                                    Console.WriteLine("Descripción: {0}.", juegos[posicion].descripcion);
                                    Console.WriteLine("Categoría: {0}.", juegos[posicion].categoria);
                                    Console.WriteLine("Plataforma: {0}.", juegos[posicion].plataforma);
                                    Console.WriteLine("Año: {0}.", juegos[posicion].anyo);
                                    Console.WriteLine("Calificación: {0}.", juegos[posicion].calificacion);
                                    Console.WriteLine("Comentarios: {0}.", juegos[posicion].comentarios);
                                }
                                else
                                {
                                    Console.WriteLine("No se ha encontrado ninguna coincidencia.");
                                }

                                break;
                        }
                    }

                    Console.WriteLine("Pulsa cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;

                // Mostrar todos los juegos de una categoría o plataforma
                case MOSTRARJUEGOS:

                    Console.WriteLine("Has elegido la opción \"Mostrar todos los juegos " +
                        "por plataforma y categoría\".");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Error. No hay ningún juego guardado. " +
                            "Prueba a guardar algún juego primero.");
                    }
                    else
                    {
                        Console.Write("Plataforma de los juegos para mostrar: ");
                        plataformaTemp = Console.ReadLine().ToLower();
                        Console.Write("Categoría de los juegos para mostrar: ");
                        categoriaTemp = Console.ReadLine().ToLower();

                        encontrado = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (i % 22 == 0 && i != 0)
                            {
                                Console.WriteLine("Pausa cada 22 juegos. Presiona " +
                                    "cualquier tecla para continuar.");
                                Console.ReadKey();
                            }

                            if ((juegos[i].plataforma.ToLower() == plataformaTemp) &&
                                (juegos[i].categoria.ToLower() == categoriaTemp))
                            {
                                Console.WriteLine("Juego número: {0}.", i + 1);
                                Console.WriteLine("Título: {0}.", juegos[i].titulo);
                                Console.WriteLine("Año: {0}.", juegos[i].anyo);
                                Console.WriteLine("Calificación: {0}.", juegos[i].calificacion);

                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se han encontrado juegos que pertenezcan" +
                                " a la plataforma \"{0}\" y a la categoría \"{1}\"",
                                plataformaTemp, categoriaTemp);
                        }
                    }
                    Console.WriteLine();
                    break;

                // Buscar juegos que contengan un texto en cualquier campo de texto
                case BUSCAR:

                    Console.WriteLine("Has elegido la opción \"Buscar juegos " +
                        "que contengan un texto\".");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Error. No hay ningún juego guardado. " +
                            "Prueba a guardar algún juego primero.");
                    }
                    else
                    {
                        Console.Write("Escribe el texto a buscar: ");
                        textoBuscar = Console.ReadLine().ToLower();

                        encontrado = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (i % 22 == 0 && i != 0)
                            {
                                Console.WriteLine("Pausa cada 22 juegos. Presiona " +
                                    "cualquier tecla para continuar.");
                                Console.ReadKey();
                            }

                            if (((juegos[i].titulo.ToLower()).Contains(textoBuscar)) ||
                                ((juegos[i].categoria.ToLower()).Contains(textoBuscar)) ||
                                ((juegos[i].plataforma.ToLower()).Contains(textoBuscar)) ||
                                ((juegos[i].comentarios.ToLower()).Contains(textoBuscar)))
                            {
                                Console.WriteLine("Juego número: {0}.", i + 1);
                                Console.WriteLine("Título: {0}.", juegos[i].titulo);
                                Console.WriteLine("Año: {0}.", juegos[i].anyo);
                                Console.WriteLine("Calificación: {0}.", juegos[i].calificacion);

                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se ha encontrado ninguna coincidencia.");
                        }
                    }

                    Console.WriteLine();
                    break;

                // Modificar un registro
                case MODIFICAR:

                    Console.WriteLine("Has elegido la opción \"Modificar un registro\".");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Error. No hay ningún juego guardado. " +
                            "Prueba a guardar algún juego primero.");
                    }
                    else
                    {
                        Console.Write("Escribe el número del registro " +
                            "que quieres modificar: ");
                        posicion = Convert.ToInt32(Console.ReadLine());

                        if (posicion <= 0 || posicion > cantidad)
                        {
                            Console.WriteLine("Número de registro no válido.");
                        }
                        else
                        {
                            Console.WriteLine("Mostrando datos anteriores de cada campo " +
                                "en el registro número: {0}", posicion);
                            Console.WriteLine("Presiona Intro para no modificar el campo.");
                            Console.WriteLine("Escribe para modificar el campo.");

                            // Modificar título
                            Console.WriteLine("Título actual: {0}", juegos[posicion - 1].titulo);
                            Console.Write("Título nuevo: ");
                            tituloTemp = Console.ReadLine();

                            if (tituloTemp != "")
                            {
                                juegos[posicion - 1].titulo = tituloTemp;
                            }

                            // Modificar descripción
                            Console.WriteLine("Descripción actual: {0}", juegos[posicion - 1].descripcion);
                            Console.Write("Descripción nueva: ");
                            descripcionTemp = Console.ReadLine();

                            if (descripcionTemp != "")
                            {
                                juegos[posicion - 1].descripcion = descripcionTemp;
                            }

                            // Modificar categoría
                            Console.WriteLine("Categoría actual: {0}", juegos[posicion - 1].categoria);
                            Console.Write("Categoría nueva: ");
                            categoriaTemp = Console.ReadLine();

                            if (categoriaTemp != "")
                            {
                                juegos[posicion - 1].categoria = categoriaTemp;
                            }

                            // Modificar plataforma
                            Console.WriteLine("Plataforma actual: {0}", juegos[posicion - 1].plataforma);
                            Console.Write("Plataforma nueva: ");
                            plataformaTemp = Console.ReadLine();

                            if (plataformaTemp != "")
                            {
                                juegos[posicion - 1].plataforma = plataformaTemp;
                            }

                            // Modificar año
                            Console.WriteLine("Año actual: {0}", juegos[posicion - 1].anyo);
                            Console.Write("Año nuevo: ");
                            anyoTempString = Console.ReadLine();

                            if (anyoTempString != "")
                            {
                                anyoTemp = Convert.ToInt16(anyoTempString);

                                if (anyoTemp < 1940 || anyoTemp > 2100)
                                {
                                    Console.WriteLine("Error. Año no válido.");
                                    Console.WriteLine("Debe estar entre 1940 y 2100. Ambos inclusive.");
                                }
                                else
                                {
                                    juegos[posicion - 1].anyo = anyoTemp;
                                }
                            }

                            // Modificar calificación
                            Console.WriteLine("Calificación actual: {0}",
                                juegos[posicion - 1].calificacion.ToString("N1"));
                            Console.Write("Calificación nueva: ");
                            calificacionTempString = Console.ReadLine();

                            if (calificacionTempString != "")
                            {
                                calificacionTemp = Convert.ToSingle(calificacionTempString);

                                if (calificacionTemp < 0 || calificacionTemp > 10)
                                {
                                    Console.WriteLine("Error. Calificación no válida.");
                                    Console.WriteLine("Debe estar entre 0 y 10. Ambos inclusive.");
                                }
                                else
                                {
                                    juegos[posicion - 1].calificacion = calificacionTemp;
                                }
                            }

                            // Modificar comentarios
                            Console.WriteLine("Comentario actual: {0}", juegos[posicion - 1].comentarios);
                            Console.Write("Comentario nuevo: ");
                            comentariosTemp = Console.ReadLine();

                            if (comentariosTemp != "")
                            {
                                juegos[posicion - 1].comentarios = comentariosTemp;
                            }
                        }
                    }

                    Console.WriteLine();
                    break;

                // Eliminar un registro
                case ELIMINARDATOS:

                    Console.WriteLine("Has elegido la opción \"Eliminar un registro\".");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Error. No hay ningún juego guardado. " +
                            "Prueba a guardar algún juego primero.");
                    }
                    else
                    {
                        Console.Write("Escribe el número del registro a eliminar: ");
                        posicion = Convert.ToInt32(Console.ReadLine());

                        if (posicion <= 0 || posicion > cantidad)
                        {
                            Console.WriteLine("Error. Número de registro incorrecto.");
                        }
                        else
                        {
                            Console.WriteLine("Mostranto datos del registro número: {0}", posicion);
                            Console.WriteLine("Título: {0}.", juegos[posicion - 1].titulo);
                            Console.WriteLine("Descripción: {0}.", juegos[posicion - 1].descripcion);
                            Console.WriteLine("Categoría: {0}.", juegos[posicion - 1].categoria);
                            Console.WriteLine("Plataforma: {0}.", juegos[posicion - 1].plataforma);
                            Console.WriteLine("Año: {0}.", juegos[posicion - 1].anyo);
                            Console.WriteLine("Calificación: {0}.", juegos[posicion - 1].calificacion);
                            Console.WriteLine("Comentarios: {0}.", juegos[posicion - 1].comentarios);
                            Console.WriteLine();

                            confirmacion = false;

                            Console.WriteLine("¿Deseas eliminar este registro?");
                            Console.WriteLine("Para confirmar, escribe \"s\".");
                            Console.WriteLine("Para cancelar, presiona cualquier otra tecla.");
                            Console.Write("Elección: ");

                            if (Console.ReadLine().ToLower() != "s")
                            {
                                Console.WriteLine("Cancelar seleccionado. No se borrará el registro" +
                                    " número: {0}", posicion);
                            }
                            else
                            {
                                confirmacion = true;
                            }

                            if (confirmacion)
                            {
                                for (int i = posicion - 1; i < cantidad; i++)
                                {
                                    juegos[i] = juegos[i + 1];
                                }

                                cantidad--;

                                Console.WriteLine("El registro número: {0} " +
                                    "se ha eliminado con éxito.", posicion);
                            }
                        }
                    }

                    Console.WriteLine();
                    break;

                // Ordenar un registro
                case ORDENAR:

                    Console.WriteLine("Has elegido la opción \"Ordenar datos alfabéticamente\".");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Error. No hay ningún juego guardado. " +
                            "Prueba a guardar algún juego primero.");
                    }
                    else
                    {
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = i + 1; j < cantidad; j++)
                            {
                                if ((juegos[i].titulo.CompareTo(juegos[j].titulo) > 0) ||
                                    ((juegos[i].titulo == juegos[j].titulo) &&
                                    (juegos[i].plataforma.CompareTo(juegos[j].plataforma) > 0)))
                                {
                                    auxiliar = juegos[i];
                                    juegos[i] = juegos[j];
                                    juegos[j] = auxiliar;
                                }
                            }
                        }

                        Console.WriteLine("Se han ordenado con éxito.");
                    }

                    Console.WriteLine();
                    break;

                // Eliminar espacios redundantes
                case ELIMINARESPACIOS:

                    Console.WriteLine("Has elegido la opción \"Eliminar espacios redundantes\".");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Error. No hay ningún juego guardado. " +
                            "Prueba a guardar algún juego primero.");
                    }
                    else
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            juegos[i].descripcion = juegos[i].descripcion.Trim();
                            juegos[i].categoria = juegos[i].categoria.Trim();
                            juegos[i].plataforma = juegos[i].plataforma.Trim();

                            for (int j = 0; j < juegos[i].descripcion.Length; j++)
                            {
                                if (juegos[i].descripcion[j] == ' ' && juegos[i].descripcion[j + 1] == ' ')
                                {
                                    juegos[i].descripcion = juegos[i].descripcion.Remove(j, 1);

                                    j--;
                                }
                            }

                            for (int j = 0; j < juegos[i].categoria.Length; j++)
                            {
                                if (juegos[i].categoria[j] == ' ' && juegos[i].categoria[j + 1] == ' ')
                                {
                                    juegos[i].categoria = juegos[i].categoria.Remove(j, 1);

                                    j--;
                                }
                            }

                            for (int j = 0; j < juegos[i].plataforma.Length; j++)
                            {
                                if (juegos[i].plataforma[j] == ' ' && juegos[i].plataforma[j + 1] == ' ')
                                {
                                    juegos[i].plataforma = juegos[i].plataforma.Remove(j, 1);

                                    j--;
                                }
                            }
                        }

                        Console.WriteLine("Espacios redundantes eliminados con éxito.");
                    }

                    Console.WriteLine();
                    break;
            }
        }
        while (opcion != SALIR);
    }
}
