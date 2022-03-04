using System;
using System.Collections.Generic;
using System.Text;

namespace homework03
{
    public class Shape
    {
        public bool legal = false;
        public double width = 0;
        public double height = 0;
        public double a = 0, b = 0, c = 0;

        public virtual void checkLegal() { }
    }
}
