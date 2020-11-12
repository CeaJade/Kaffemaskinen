using System;

namespace Kaffemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brewing Machine");

            Console.Write("1. Reservior \n2. Container \n3. Brew Coffee \n\n\n");

            Reservoir res = new Reservoir(12);
            
            Console.ReadKey();
        }
    }
}
