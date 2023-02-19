/*172. Crea una nueva versión de la clase Vehículo y derivadas (ej. 171),
 * en la que uses propiedades en formato compacto. Además, en la clase 
 * moto habrá un atributo adicional, el "tipo de licencia" necesario 
 * para conducirla. Habrá un nuevo constructor que permita dar valor a 
 * la marca, el modelo y la licencia. El constructor inicial pasará a 
 * apoyarse en éste, prefijando la licencia a "A". La clase Moto será
 * "sellada".
 
 Radha */

using System;

class PruebaDeVehiculo
{
    static void Main()
    {
        Vehiculo[] vehiculos = new Vehiculo[3];

        vehiculos[0] = new Coche("Toyota", "B3");
        vehiculos[1] = new Coche("Seat", "Altea");
        vehiculos[2] = new Moto("Yamaha", "C4");

        foreach(Vehiculo v in vehiculos)
        {
            Console.WriteLine(v);
        }

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
