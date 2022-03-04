using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    class Program
    {
        private static bool judgeToeplitz(int[,] list, int m, int n)
        {
            for (int i = 1; i < m; i ++ )
                for (int j = 1; j < n; j ++ )
                    if (list[i, j] != list[i - 1, j - 1]) return false;
            return true;
        }
        static void Main(string[] args)
        {
            /**
            for (int i = 2; i <= 100; i ++ )
            {
                int num = i;
                bool isPrime = true;
                for (int j = 2; j < num; j++)
                    if (j * j > num) break;
                    else
                    {
                        isPrime = num % j != 0;
                        if (!isPrime) break;
                    }
                if (isPrime) Console.Write("{0} ", i);
            }
            */
            int[] nums = new int[100];
            for (int i = 2; i <= 10 && nums[i] != -1; i ++ )
            {
                int count = i;
                for (int num = i * i; num < 100; count ++ )
                {
                    nums[num] = -1;
                    num = i * count;
                }
            }
            for (int i = 2; i < 100; i ++ )
                if (nums[i] != -1) Console.Write("{0} ", i);



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
