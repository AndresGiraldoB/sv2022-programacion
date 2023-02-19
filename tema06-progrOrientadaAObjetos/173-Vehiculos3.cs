/*173. A partir del ejercicio anterior (Vehículo y derivadas), crea un 
 * programa en el que se muestre un menú al usuario y se le permita 
 * introducir datos (en un array de 1000 vehículos) de coches o motos, 
 * mostrar todos los datos almacenados hasta el momento, buscar en ellos
 * (a partir de su ToString), o modificar uno concreto.
 
 Radha */

using System;

class PruebaDeVehiculo
{
    const string INTRODUCIR = "1", MOSTRAR = "2", BUSCAR = "3", 
        MODIFICAR = "4", SALIR = "S";
    const short MAXIMO = 1000;
    static void Main()
    {
        Vehiculo[] vehiculos = new Vehiculo[MAXIMO];
        short cantidad = 0;
        string opcion;

        do
        {
            Console.WriteLine();
            MostrarMenu();
            opcion = PedirString("¿Opción?").ToUpper();

            switch(opcion)
            {
                case INTRODUCIR:
                    Introducir(vehiculos,ref cantidad);
                    break;
                case MOSTRAR:
                    Mostrar(vehiculos, cantidad);
                    break;
                case BUSCAR:
                    Buscar(vehiculos, cantidad);
                    break; 
                case MODIFICAR:
                    Modificar(vehiculos, cantidad);
                    break;
                case SALIR:
                    Console.WriteLine("Adiós!");
                    break;
                default: 
                    Console.WriteLine("Opción inválida");
                    break;
            }

        }
        while (opcion != SALIR);

    }

    static void MostrarMenu()
    {
        Console.WriteLine(INTRODUCIR + ". Introducir datos de coche o moto");
        Console.WriteLine(MOSTRAR + ". Mostrar todos los datos");
        Console.WriteLine(BUSCAR + ". Buscar un dato");
        Console.WriteLine(MODIFICAR + ". Modificar un dato");
        Console.WriteLine(SALIR + ". Salir");
    }

    static void Introducir(Vehiculo[] vehiculos, ref short cantidad)
    {
        if(cantidad >= MAXIMO)
        {
            Console.WriteLine("No caben más vehículos");
        }
        else
        {
            string cocheMoto = PedirString
                ("¿Quieres añadir un coche o una moto? (C/M)").ToUpper();
            string marca = PedirString("¿Marca?");
            string modelo = PedirString("¿Modelo?");

            if(cocheMoto == "C" || cocheMoto == "COCHE")
            {
                vehiculos[cantidad] = new Coche(marca, modelo);
                cantidad++;
            }
            else if(cocheMoto == "M" || cocheMoto == "MOTO")
            {
                vehiculos[cantidad] = new Moto(marca, modelo);
                cantidad++;
            }
            else
            {
                Console.WriteLine("Debes elegir entre moto (M) o coche (C)");
            }

            Console.WriteLine();
        }
    }

    static void Mostrar(Vehiculo[] vehiculos, short cantidad)
    {
        if(cantidad == 0)
        {
            Console.WriteLine("No hay datos para buscar");
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(vehiculos[i]);
            }
        }

    }
    
    static void Buscar(Vehiculo[] vehiculos, short cantidad)
    {
        bool encontrado = false;
        string datoBuscar = PedirString("Introduce dato para buscar: ");

        for(int i = 0; i < cantidad; i++)
        {
            if (vehiculos[i].ToString().Contains(datoBuscar))
            {
                Console.WriteLine(vehiculos[i]);
                encontrado = true;
            }
        }
        
        if (! encontrado)
        {
            Console.WriteLine("Ningún registro contenía el dato");
        }
    }

    static void Modificar(Vehiculo[] vehiculos, short cantidad)
    {
        int registroModificar = Convert.ToInt32(PedirString(
            "¿Qué posición deseas modificar?"));

        if(registroModificar >= 1 && registroModificar <= cantidad) 
        {
            registroModificar--;

            vehiculos[registroModificar].Marca = ModificarAuxiliar(
                "Marca", vehiculos[registroModificar].Marca);
            
            vehiculos[registroModificar].Modelo = ModificarAuxiliar(
                "Modelo",vehiculos[registroModificar].Modelo);              
            
            vehiculos[registroModificar].CantidadDeRuedas = 
                Convert.ToByte(ModificarAuxiliar("Cantidad de ruedas", 
                Convert.ToString(vehiculos[registroModificar].CantidadDeRuedas)));

            if (vehiculos[registroModificar] is Moto)
            {
                ((Moto)vehiculos[registroModificar]).TipoDeLicencia = ModificarAuxiliar(
                "Tipo de Licencia", ((Moto) vehiculos[registroModificar]).TipoDeLicencia);
            }
        }
        else
        {
            Console.WriteLine("Registro incorrecto");
        }
    }

    static string PedirString(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }    
   
    static string ModificarAuxiliar(string nombreCampo, string valorAnterior)
    {
        string respuesta = PedirString("Dime el nuevo valor para: " +
            nombreCampo + " (antes era: " + valorAnterior + ")");
        return respuesta != "" ? respuesta : valorAnterior;
    }
}

// ------------------------------

abstract class Vehiculo
{

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public byte CantidadDeRuedas { get; set; }

    public Vehiculo(string marca, string modelo, byte cantidadDeRuedas)
    {
        Marca = marca;
        Modelo = modelo;
        CantidadDeRuedas = cantidadDeRuedas;
    }



    public override string ToString()
    {
        return "Marca: " + Marca + " - " + "Modelo: " + Modelo + " - " + 
            "Cantidad de ruedas: " + CantidadDeRuedas;
    }

}

// ------------------------------

class Coche : Vehiculo
{
    public Coche(string marca, string modelo) : 
        base(marca, modelo, 4)
    {
    }

    public override string ToString()
    {
        return base.ToString() + " (Coche)";
    }
}

// ------------------------------

sealed class Moto : Vehiculo
{
    public string TipoDeLicencia { get; set; }
    
    public Moto(string marca, string modelo, string tipoDeLicencia) : 
        base(marca, modelo, 2)
    {
        TipoDeLicencia = tipoDeLicencia;
    }
    
    public Moto(string marca, string modelo) : this(marca, modelo, "A")
    {
    }    

    public override string ToString()
    {
        return base.ToString() + " - Tipo de Licencia: " +
            TipoDeLicencia + " (Moto)";
    }
}
