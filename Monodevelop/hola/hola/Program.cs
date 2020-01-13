using System;

namespace hola
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);

            Console.WriteLine("Dime tu edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu edad es:" + edad);
        }
    }
}
