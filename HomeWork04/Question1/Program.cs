using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 0, sum = 0;

            // 初始化测试链表
            ArrayList<int> array = new ArrayList<int>();
            array.addNode(3); array.addNode(2); array.addNode(30); array.addNode(5);
            
            // 实现打印链表
            Action<Node<int>> actionPrint = (n => Console.WriteLine(n.data));
            Action<Node<int>> actionGetMax = (n => max = (max < n.data)? n.data : max);
            Action<Node<int>> actionGetMin = (n => min = (min > n.data)? n.data : min);
            Action<Node<int>> actionSum = (n => sum = sum + n.data);

            ForEach<int>(array, actionPrint);
            ForEach<int>(array, actionGetMax);
            ForEach<int>(array, actionGetMin);
            ForEach<int>(array, actionSum);

            Console.WriteLine("max is: {0}", max);
            Console.WriteLine("min is: {0}", min);
            Console.WriteLine("sum is: {0}", sum);
        }
        public static void ForEach<T>(ArrayList<T> array, Action<Node<T>> action)
        {
            // 遍历链表
            Node<T> n = array.Head;
            while (n != null)
            {
                action(n);
                n = n.next;
            }
        }
    }
}
