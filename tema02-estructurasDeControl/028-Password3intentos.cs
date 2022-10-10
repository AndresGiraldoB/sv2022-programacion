// Francis (...)

/* 
 * 28. Crea una versión mejorada del ejercicio de la contraseña numérica, en 
 * la que el usuario deba introducir un login además de la contraseña, y sólo 
 * tenga 3 intentos. Si, al cabo de 3 intentos, no ha indicado el login y la 
 * contraseña correctos, se le responderá con "Acceso denegado" y terminará 
 * el programa. Si introduce ambos datos de forma correcta en 3 intentos o 
 * menos, se le dirá "Acceso concedido" y terminará el programa. Esta versión 
 * hazla sólo una vez, empleando "while" o "do-while", como consideres más 
 * razonable. Comprueba que se comporta correctamente si el usuario introduce 
 * el login correcto y la contraseña incorrecta o viceversa.
 */
 
using System;

class ejercicio28_tema2
{
    static void Main()
    {
        int loginValido = 1234, contrasenyaValida = 5678;
        int loginUsuario, contrasenyaUsuario;

        int intentosRestantes = 3;

        do
        {
            Console.WriteLine("Introduce tu login numérico: ");
            loginUsuario = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introduce tu contraseña numérica: ");
            contrasenyaUsuario = Convert.ToInt32(Console.ReadLine());

            if ((loginUsuario != loginValido) 
                || (contrasenyaUsuario != contrasenyaValida))
            {
                intentosRestantes--;
                Console.WriteLine(
                    "Incorrecto. Intentos restantes {0}",
                    intentosRestantes);
            }
        }
        while ((loginUsuario != loginValido 
            || contrasenyaUsuario != contrasenyaValida)
            && intentosRestantes > 0);

        if (intentosRestantes == 0)
            Console.WriteLine("Acceso denegado");
        else
            Console.WriteLine("Acceso concedido");
    }
}
