namespace homework03
{
    public class Square : Shape
    {
        public new double width = 0;
        public Square(double width)
        {
            this.width = width;
            checkLegal();
        }

        public override void checkLegal()
        {
            if (width > 0) this.legal = true;
        }
    }

}
