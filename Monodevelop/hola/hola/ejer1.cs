using System;
namespace hola
{
    class ejer1
    {
        public static void Suma(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: " + (num1+num2));
        }
    }
}
