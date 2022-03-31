using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            Customer customerPeter = new Customer("Peter");

            Order order = new Order(customerPeter);

            OrderDetail detailApple = new OrderDetail("苹果", 10);
            OrderDetail detailPeach = new OrderDetail("桃子", 20);

            order.addOrderDetails(detailApple);
            order.addOrderDetails(detailPeach);

            Console.WriteLine(order.ToString());
        }
    }
}
