using System;

namespace Trabajo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            string respuesta;
            Console.WriteLine("Eres mayor de edad? (si/no)");
            respuesta = Console.ReadLine();
            if (respuesta == "si")
            {
                Console.WriteLine("Buenos dias señor(a)");
            }
            else
            {
                Console.WriteLine("Eres Menor de edad");
            }

        }
    }
}
