using System;
using System.Collections.Generic;
using System.Text;
namespace homework03
{
    public class Factory
    {
        public Shape createShape(string name, params double[] ps)
        {
            int count = 0;
            foreach (var n in ps) count++;
           
            switch (name)
            {
                case "Circle":
                    if (count < 1)
                        throw new MyException("params error! cannt create Circle!");
                    else
                        return new Circle(ps[0]);
                case "Triangle":
                    if (count < 3)
                        throw new MyException("params error! cannt create Triangle!");
                    else return new Triangle(ps[0], ps[1],ps[2]);
                case "Square":
                    if (count < 1)
                        throw new MyException("params error! cannt create Square!");
                    else return new Square(ps[0]);
                case "Rectangle":
                    if (count < 2)
                        throw new MyException("params error! cannt create Rectangle!");
                    else return new Rectangle(ps[0], ps[1]);
                default:
                    throw new MyException("params error! cannt create Shape!");
            }
        }

        public double getArea(Shape s)
        {
            if (s is Square)
            {
                Square sq = (Square)s;
                if (sq.legal) 
                    return  sq.width * sq.width;
                else throw new MyException("the square is not legal!");
            }else if (s is Rectangle)
            {
                Rectangle re = (Rectangle)s;
                if (re.legal) return re.width * re.height;
                else throw new MyException("the rectangle is not legal!");
            }else if (s is Circle)
            {
                Circle ci = (Circle)s;
                if (ci.legal) return ci.width * ci.width * 3.14 * 0.5;
                else throw new MyException("the circle is not legal!");
            }else if (s is Triangle)
            {
                Triangle tr = (Triangle)s;
                if (tr.legal)
                {
                    double p = (tr.a + tr.b + tr.c) * 0.5;
                    return Math.Sqrt(p * (p - tr.a) * (p - tr.b) * (p - tr.c));
                }else
                    throw new MyException("the triangle is not legal!");
            }
            throw new MyException("the shape is not define!");
        }
    }
}
