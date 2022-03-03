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
        }
    }
}
