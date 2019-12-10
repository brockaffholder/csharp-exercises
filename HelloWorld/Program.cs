using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a length: ");
            int length = int.Parse(Console.ReadLine());

            int area = width * length;
            Console.WriteLine("The area of the rectangle is " + area);

            double fahrenheit;
            double celsius;
            string input;

            Console.WriteLine("Temperature in F:");
            input = Console.ReadLine();
            fahrenheit = double.Parse(input);

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Temperature in C is: " + celsius);
            Console.ReadLine();
        }
    }
}
