namespace Homework8_9
{
    public class Triangle : Figure
    {
        double sideA;
        double sideB;
        double sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public override double Perimeter() => sideA + sideB + sideC;
        public override double Square()
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }
    }
}