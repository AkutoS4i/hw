namespace Homework8_9
{
    public class Circle : Figure
    {
        double Radius;
        public Circle(double Radius) => this.Radius = Radius;
        public override double Perimeter() => 2 * 3.14 * Radius;
        public override double Square() => 3.14 * (Radius * Radius);
    }
}