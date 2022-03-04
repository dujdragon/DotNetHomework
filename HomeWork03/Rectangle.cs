namespace homework03
{
    public class Rectangle : Shape
    {
        public new double width = 0;
        public new double height = 0;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            checkLegal();
        }
        public override void checkLegal()
        {
            if (width > 0 && height > 0) this.legal = true;
        }
    }
}
