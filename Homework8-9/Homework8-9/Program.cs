namespace Homework8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            var rectangleOne = new Rectangle(26, 15);
            var rectangleTwo = new Rectangle(16, 45);
            var triangle = new Triangle(7, 12, 4);
            var circleOne = new Circle(14);
            var circleTwo = new Circle(12);
            Figure[] figuresArr = new Figure[5];
            figuresArr[0] = rectangleOne;
            figuresArr[1] = rectangleTwo;
            figuresArr[2] = triangle;
            figuresArr[3] = circleOne;
            figuresArr[4] = circleTwo;
            double Sum = 0;
            for (int i = 0; i < figuresArr.Length; i++)
            {
                Sum = Sum + figuresArr[i].Perimeter();
            }
            Console.WriteLine($"Сумма периметра всех фигур: {Sum}");
            Console.ReadKey();
            Console.WriteLine("\n");



            //Задача 2
            var director = new Director();
            director.Jt();
            var accountant = new Accountant();
            accountant.Jt();
            var worker = new Worker();
            worker.Jt();
            Console.ReadKey();
            Console.WriteLine("\n");



            //Задача 3
        }
    }
}