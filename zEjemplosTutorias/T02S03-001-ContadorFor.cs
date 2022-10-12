// Tutorías T2 S3, ejemplo 1
// Del 20 al 30, luego del 30 al 20, con "for"

using System;

class T02S03a
{
    static void Main()
    {
        int i;
        
        for (i = 20; i <= 30; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        for (i = 30; i >= 20; i--)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }

}
