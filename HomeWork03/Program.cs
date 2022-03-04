using System;

namespace homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Shape[] shapeList = new Shape[10];
            for (int i = 0; i < 10; i ++)
            {
                Random rd = new Random();
	//创建一个随机整数来确定创建哪一个图形
                int rm = rd.Next(1, 5);
	//创建三个随机数来确定图形，为方便起见使随机数为正数
                double rm1 = Math.Abs(rd.NextDouble());
                double rm2 = Math.Abs(rd.NextDouble());
                double rm3 = Math.Abs(rd.NextDouble());
                switch (rm)
                {
                    case 1:
                        shapeList[i] = factory.createShape("Circle", rm1);
                        break;
                    case 2:
                        shapeList[i] = factory.createShape("Rectangle", rm1, rm2);
                        break;
                    case 3:
                        shapeList[i] = factory.createShape("Square", rm1);
                        break;
                    case 4:
                        // 不能保证三角形合法
                        shapeList[i] = factory.createShape("Triangle", rm1, rm2, rm3);
                        break;
                }
            }

            //累加图形的面积
            double areaSum = 0;
            for (int i = 0; i < 10; i++)
                areaSum = areaSum + factory.getArea(shapeList[i]);

            Console.WriteLine(areaSum );

        }
    }
}
