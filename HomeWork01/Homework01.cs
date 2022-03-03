using System;
using System.IO;

namespace homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                char c = (char)Console.Read();

                switch (c)
                {
                    case '+':
                        Console.WriteLine(a + b);
                        break;
                    case '-':
                        Console.WriteLine(a - b);
                        break;
                    case '/':
                        Console.WriteLine(a / b);
                        break;
                    case '*':
                        Console.WriteLine(a * b);
                        break;
                    default:
                        Console.WriteLine("Input error!");
                        break;
                }
            } catch (FormatException e) {
                Console.WriteLine("Input exception!");
            }

            Console.ReadLine();
        }
    }
}
