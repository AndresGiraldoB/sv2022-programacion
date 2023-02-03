/* 
Una agencia de viajes nos ha pedido crear un programa en C# que les 
permita almacenar hasta 750 fichas de posibles viajes para sus clientes.
Para cada viaje, debes guardar los siguientes datos:

Ciudad (por ejemplo, Roma)
Días (p.ej. 4)
Precio (p.ej. 450)
Detalles (un texto libre, por ejemplo "Salida en Semana Santa")


El programa debe permitir al usuario las siguientes operaciones:

1 - Añadir un viaje. La ciudad no debe estar vacía. Los días no pueden 
ser más de 30. El precio no debe ser 0.

2 - Mostrar todos los viajes almacenados. Cada viaje debe aparecer en 
una línea, en formato de ciudad, días y precio, separados por un guion 
(por ejemplo, "Roma - 4 días - 450 euros"). El programa debe hacer una 
pausa después de mostrar cada bloque de 24 viajes, mostrar el mensaje 
"Pulse Intro para continuar" y esperar hasta que el usuario pulse Intro.
Se debe avisar al usuario si no hay datos.

3 - Buscar viajes que contengan un determinado texto (como parte de su 
ciudad o detalles, sin distinción de mayúsculas y minúsculas). 
Los datos se deben mostrar en líneas separadas, con una línea en blanco
adicional después de cada viaje. Se debe avisar al usuario si 
no se encuentra ninguno.

4 - Modificar un registro (el programa solicitará el número, mostrará 
el valor anterior de cada campo y el usuario podrá pulsar Intro para no
modificar alguno de los datos). Se debe advertir al usuario 
(pero no volver a preguntarle) si introduce un número de registro 
incorrecto. No es necesario validar ninguno de los campos.

5 - Eliminar un registro, en la posición indicada por el usuario. 
Se le debe avisar (pero no volver a preguntarle) si introduce 
un número de registro incorrecto. Se debe mostrar el dato que se va a 
borrar y pedir confirmación.

6 - Ordenar los datos alfabéticamente por ciudad + precio.

7 - Eliminar espacios sobrantes (espacios iniciales, finales y 
duplicados en todas las ciudades y detalles. Por ejemplo, 
un detalle como "  Datos   de prueba  " se convertirá en 
"Datos de prueba".

S - Salir (como esta versión preliminar del proyecto no almacena la 
información, se perderá).

-------------

Cada opción del menú principal debe estar extraída a una función. 
Por lo general, cada una de estas funciones deberá recibir como 
parámetros el array con los datos y el contador de cuántos datos 
hay almacenados (quizá como parámetro "ref"), de modo que no existan 
variables globales, sino variables locales y datos pasados como 
parámetros.

Además de las funciones que consideres adecuadas para descomponer el 
problema, DEBES crear las siguientes funciones:

Para simplificar el "Añadir"; será un WriteLine seguido de un ReadLine
string Pedir(string aviso) 

Para simplificar el "Añadir" en el caso de datos que no deban estar
vacíos. Se encargará de pedir tantas veces como sea necesario
string PedirNoVacio(string aviso) 

Para simplificar el "Modificar": pedirá el nuevo valor, y 
conservará el anterior si se introduce una cadena vacía
string Modificar(string nombreCampo, string valorAnterior)

Para simplificar la opción de buscar: devolverá true si un
cierto viaje contiene un cierto dato
bool Contiene(Viaje v, String texto)

Para simplificar la opción de buscar y la de borrar
void MostrarUnDato(Viaje[] datos, int pos)


También puedes crear las funciones adicionales que consideres 
convenientes, donde veas que tienes tareas repetitivas 
(por ejemplo, puede ser útil una que elimine los espacios sobrantes 
de una cadena).

*/
using System;

class EjercicioNota3
{
    struct Viaje
    {
        public string ciudad;
        public byte dia;
        public int precio;
        public string detalles;
    }

    const string SALIR = "S", ANADIR = "1", VERTODO = "2", 
        BUSCARVIAJE = "3", MODIFICAR = "4", ELIMINAR = "5", 
        ORDENAR = "6", ELIMINARESPACIOS = "7";
    const short MAXIMO = 750;
    const byte BLOQUE = 24;

    static void Main()
    {
        Viaje[] viajes = new Viaje[MAXIMO];
        ushort cantidad = 0;
        string opcion;

        do
        {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion)
            {
                case ANADIR:
                    Anyadir(viajes, ref cantidad);
                    break; 
                case VERTODO:
                    MostrarViajes(viajes, cantidad);
                    break;
                case BUSCARVIAJE:
                    BuscarTexto(viajes, cantidad);
                    break;
                case MODIFICAR:
                    ModificarViaje(viajes, cantidad);
                    break;
                case ELIMINAR:
                    EliminarViaje(viajes, ref cantidad);
                    break;
                case ORDENAR:
                    OrdenarDatos(viajes, cantidad);
                    break;
                case ELIMINARESPACIOS:
                    EliminarEspacios(viajes, cantidad);
                    break;
                case SALIR:
                    Console.WriteLine("¡Hasta la vista!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (opcion != SALIR);
    }


    // ------------------- FUNCIONES PRINCIPALES ---------------------

    
    static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("===============MENU===============");
        Console.WriteLine(ANADIR + "- Añadir un viaje");
        Console.WriteLine(VERTODO + "- Mostrar todos los viajes");
        Console.WriteLine(BUSCARVIAJE + "- Buscar viaje");
        Console.WriteLine(MODIFICAR + "- Modificar viaje");
        Console.WriteLine(ELIMINAR + "- Eliminar viaje");
        Console.WriteLine(ORDENAR + "- Ordenar viajes");
        Console.WriteLine(ELIMINARESPACIOS + "- Corregir espacios");
        Console.WriteLine(SALIR + "- Salir");
        Console.WriteLine();
    }

    
    static string PedirOpcion()
    {
        return Pedir("¿Opción?").ToUpper();
    }

    
    static void Anyadir(Viaje[] viajes, ref ushort cantidad) 
    {
        if (cantidad >= MAXIMO)
        {
            Console.WriteLine("No caben más viajes");
        }
        else
        {
            string datoTemp;
           
            viajes[cantidad].ciudad = PedirNoVacio("¿Ciudad?");
            
            do
            {
                datoTemp = Pedir("¿Días?");
            }
            while (Convert.ToInt16(datoTemp) > 30);            
            viajes[cantidad].dia = Convert.ToByte(datoTemp);
 
            do
            {
                datoTemp = Pedir("¿Precio?");
            }
            while (datoTemp == "0");
            viajes[cantidad].precio = Convert.ToInt32(datoTemp);

            viajes[cantidad].detalles = Pedir("¿Detalles?");

            cantidad++;
        }
    }


    static void MostrarViajes(Viaje[] viajes, ushort cantidad)
    {
        if(cantidad == 0)
        {
            Console.WriteLine("No hay datos para mostrar");
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write((i+1) + ". "); // Contador, para poder modificar
                MostrarUnaLinea(viajes, i);

                if((i + 1) % BLOQUE  == 0)
                {
                    Pedir("Pulse Intro para continuar");
                }
            }
        }
    }


    static void BuscarTexto(Viaje[] viajes, ushort cantidad)
    {
        bool encontrado = false;
        string textoBuscar = Pedir("¿Texto a buscar?").ToLower();

        for(int i = 0; i < cantidad; i++)
        {
            if (Contiene(viajes[i], textoBuscar))
            {
                MostrarUnDato(viajes, i);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se ha encontrado en ningún viaje");
        }
    }


    static void ModificarViaje(Viaje[] viajes, ushort cantidad)
    {
        int posModificar = Convert.ToInt32(Pedir("¿Posición a modificar?"));

        if (posModificar >= 1 && posModificar <= cantidad)
        {
            posModificar--;

            viajes[posModificar].ciudad = Modificar("Ciudad",
                viajes[posModificar].ciudad);
            
            viajes[posModificar].dia = Convert.ToByte(Modificar("¿Días?",
                Convert.ToString(viajes[posModificar].dia)));
            
            viajes[posModificar].precio = Convert.ToInt32(Modificar("¿Precio?",
                Convert.ToString(viajes[posModificar].precio)));

            viajes[posModificar].detalles = Modificar("¿Detalles?", 
                viajes[posModificar].detalles);
        }
        else
        {
            Console.WriteLine("Número de registro incorrecto");
        }
    }


    static void EliminarViaje(Viaje[] viajes, ref ushort cantidad)
    {
        int posBorrar = Convert.ToInt32(Pedir("¿Posición a borrar?"));

        if(cantidad == 0)
        {
            Console.WriteLine("No hay datos para borrar");
        }
        else if (posBorrar >= 1 && posBorrar <= cantidad)
        {
            posBorrar--;
            MostrarUnDato(viajes, posBorrar);
            string siNo = Pedir("¿Seguro que deseas borrarlo? (Si/No)").ToLower();

            if (siNo == "si" || siNo == "s")
            {
                for (int i = posBorrar; i < cantidad; i++)
                {
                    viajes[i] = viajes[i + 1];
                }
                cantidad--;

                Console.WriteLine("Registro borrado");
            }
            else
            {
                Console.WriteLine("Registro no borrado");
            }
        }
        else
        {
            Console.WriteLine("Número de registro incorrecto");
        }
    }


    static void OrdenarDatos(Viaje[] viajes, ushort cantidad)
    {
        for (int i = 0; i < cantidad - 1; i++)
        {
            for (int j = i + 1; j < cantidad; j++)
            {
                if (viajes[i].ciudad.CompareTo(viajes[j].ciudad) > 0 
                    ||
                    (viajes[i].ciudad == viajes[j].ciudad
                        && viajes[i].precio > viajes[j].precio))
                {
                    Viaje aux = viajes[i];
                    viajes[i] = viajes[j];
                    viajes[j] = aux;
                }
            }
        }

        Console.WriteLine("Datos ordenados correctamente");
    }


    static void EliminarEspacios(Viaje[] viajes, ushort cantidad)
    {
        for(int i = 0; i < cantidad; i++)
        {
            viajes[i].ciudad = CorregirEspacios(viajes[i].ciudad);
            viajes[i].detalles = CorregirEspacios(viajes[i].detalles);
        }
        Console.WriteLine("Espacios corregidos");
    }


    //------------------- FUNCIONES AUXILIARES ----------------------


    static string Pedir(string aviso)
    {
        Console.WriteLine(aviso);
        return Console.ReadLine();
    }

    static string PedirNoVacio(string aviso)
    {
        string palabra;
        do
        {
            palabra = Pedir(aviso);
            if (palabra == "")
                Console.WriteLine("No debe estar vacío");
        }
        while (palabra == "");
        return palabra;
    }

    static void MostrarUnaLinea(Viaje[] viajes, int pos)
    {
        Console.WriteLine("{0} - {1} días - {2} euros", 
            viajes[pos].ciudad, viajes[pos].dia,
            viajes[pos].precio);
    }

    static void MostrarUnDato(Viaje[] datos, int pos)
    {
        Console.WriteLine("Registro: {0} ", pos + 1);
        Console.WriteLine("Ciudad: {0} ", datos[pos].ciudad);
        Console.WriteLine("Días: {0}", datos[pos].dia);
        Console.WriteLine("Precio: {0}", datos[pos].precio);
        Console.WriteLine("Detalles: {0}", datos[pos].detalles);
        Console.WriteLine();
    }

    static bool Contiene(Viaje v, string texto)
    {
        return v.ciudad.ToLower().Contains(texto.ToLower()) ||
            v.detalles.ToLower().Contains(texto.ToLower());
    }

    static string Modificar(string nombreCampo, string valorAnterior)
    {
        string respuesta = Pedir("Dime el nuevo valor para: " +
            nombreCampo + " (antes era: " + valorAnterior+")");
        return respuesta != "" ? respuesta : valorAnterior;
    }

    static string CorregirEspacios(string dato)
    {
        dato = dato.Trim();
        while(dato.Contains("  "))
        {
            dato = dato.Replace("  "," ");
        }
        return dato;
    }
}
