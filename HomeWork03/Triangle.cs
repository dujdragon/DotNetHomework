using System;
using System.Collections.Generic;
using System.Text;

namespace homework03
{
    public class Triangle : Shape
    {
        public new double a = 0;
        public new double b = 0;
        public new double c = 0;

        public Triangle(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
            checkLegal();
        }

        public override void checkLegal()
        {
            if (a + b > c && a + c > b && b + c > a) this.legal = true;
        }
    }
}
