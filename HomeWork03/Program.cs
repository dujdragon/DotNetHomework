using System;

namespace homework03
{
    // factory 
    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new Factory();

            Shape[] shapeList = new Shape[10];
            for (int i = 0; i < 10; i ++)
            {
                Random rd = new Random();
                int r = rd.Next(1, 5);
                double r1 = Math.Abs(rd.NextDouble());
                double r2 = Math.Abs(rd.NextDouble());
                double r3 = Math.Abs(rd.NextDouble());
                switch (r)
                {
                    case 1:
                        shapeList[i] = f.createShape("Circle", r1);
                        break;
                    case 2:
                        shapeList[i] = f.createShape("Rectangle", r1, r2);
                        break;
                    case 3:
                        shapeList[i] = f.createShape("Square", r1);
                        break;
                    case 4:
                        // 不能保证三角形合法
                        shapeList[i] = f.createShape("Triangle", r1, r2, r3);
                        break;
                }
            }

            double sum = 0;
            for (int i = 0; i < 10; i++)
                sum = sum + f.getArea(shapeList[i]);

            Console.WriteLine(sum);

        }
    }
}
