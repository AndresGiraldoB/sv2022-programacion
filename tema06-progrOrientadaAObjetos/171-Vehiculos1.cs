/*171. Crea una clase abstracta Vehiculo, con atributos: marca, modelo, 
cantidadDeRuedas. Crea un único constructor que dé valores a los 3 atributos, y 
crea también propiedades en formato largo. También habrá un método ToString, 
devuelva la marca, el modelo y la cantidad de ruedas, separados por " - ".

Crea una clase Coche, que herede de Vehiculo. Su único constructor dará
valor a marca y modelo, y prefijará las ruedas a 4. El método ToString 
devolverá la marca, el modelo y la cantidad de ruedas, seguido de " (Coche)".

Crea una clase Moto, que herede de Vehiculo. Su único constructor dará 
valor a marca y modelo, y prefijará las ruedas a 2. El método ToString 
devolverá la marca, el modelo y la cantidad de ruedas, seguido de "(Moto)".

Crea un array de 3 vehículos, que contenga dos coches, una moto y luego
muéstralos.

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
    protected string marca;
    protected string modelo;
    protected byte cantidadDeRuedas;

    //Al ser una clase abstracta, el constructor no hace falta que sea público
    protected Vehiculo(string marca, string modelo, byte cantidadDeRuedas)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cantidadDeRuedas = cantidadDeRuedas;
    }

    public string Marca 
    {
        get
        {
            return this.marca;
        }

        set
        {
            this.marca = value;
        }
    }    
    
    public string Modelo 
    {
        get
        {
            return this.modelo;
        }

        set
        {
            this.modelo = value;
        }
    }    
    
    public byte CantidadDeRuedas 
    {
        get
        {
            return this.cantidadDeRuedas;
        }

        set
        {
            this.cantidadDeRuedas = value;
        }
    }

    public override string ToString()
    {
        return "Marca: " + marca + " - " + "Modelo: " + modelo + " - " + 
            "Cantidad de ruedas: " + cantidadDeRuedas;
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

class Moto : Vehiculo
{
    public Moto(string marca, string modelo) : 
        base(marca, modelo, 2)
    {
    }

    public override string ToString()
    {
        return base.ToString() + " (Moto)";
    }
}
