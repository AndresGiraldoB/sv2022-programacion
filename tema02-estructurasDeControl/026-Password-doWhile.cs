// Contraseña usando Do While.
// Nisi (...)

using System;

class PasswordDoWhile
{
    static void Main()
    {
        int contrasena = 1234;
        int contrasenaUsuario;
        
        do
        {
            Console.WriteLine("Introduce tu clave númerica: ");
            contrasenaUsuario = Convert.ToInt32(Console.ReadLine());
            
            if (contrasenaUsuario != contrasena )
                Console.WriteLine("No es correcta.");
        }
        while (contrasenaUsuario != contrasena);

        Console.WriteLine("Acceso concedido");
    }
    
}

    
