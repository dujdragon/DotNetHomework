using System;
using System.Collections.Generic;
using System.Text;

namespace homework03
{
    public class Circle : Shape
    {
        public new double width = 0;

        public Circle(double r)
        {
            width = r;
            checkLegal();
        }
        public override void checkLegal()
        {
            if (width > 0) this.legal = true;
        }
    }
}
