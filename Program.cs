using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication34
{
    class Program
    {
        class Drob
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter coordinate x of dot A: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate y of dot A: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter coordinate x of dot B: ");
                double num3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate y of dot B: ");
                double num4 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter coordinate x of dot C: ");
                double num5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate x of dot C: ");
                double num6 = double.Parse(Console.ReadLine());

                // Side length  
                double a = Math.Sqrt(Math.Pow(num2 - num1, 2) + Math.Pow(num3 - num4, 2));
                double b = Math.Sqrt(Math.Pow(num4 - num3, 2) + Math.Pow(num5 - num6, 2));
                double c = Math.Sqrt(Math.Pow(num6 - num5, 2) + Math.Pow(num1 - num2, 2));

                System.Console.WriteLine("Lenght of AB is:{0,2:f3}\nLenght of BC is: {1,1:f3}\nLenght of AC is: {2,2:f3}\n", a, b, c);

                // Type triangle
                if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                {
                    Console.WriteLine("This triangle is right");
                }
                else
                {
                    Console.WriteLine("This triangle is not right");
                }
                if ((a == b) || (a == c) || (b == c))
                {
                    Console.WriteLine("This triangle is isosceles");
                }
                else
                {
                    Console.WriteLine("This triangle is not isosceles");
                }
                if ((a == b) && (a == c) && (b == c))
                {
                    Console.WriteLine("This triangle is equilateral");
                }
                else
                {
                    Console.WriteLine("This triangle is not equilateral");
                }
                // Perimetr
                double P = a + b + c;
                System.Console.WriteLine("Perimetr = {3,3:f3}", a, b, c, P);

                for (int i = 2; i < P; i++)
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}


