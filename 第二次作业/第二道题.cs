using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] list = new int[3, 3]{ 
                { 1, 2, 3 }, 
                { 4, 1, 2 }, 
                { 5, 4, 1 } 

            };

            Console.WriteLine("\n{0}", judgeToeplitz(list, 3, 3));
            Console.ReadLine();
        }
    }
}
