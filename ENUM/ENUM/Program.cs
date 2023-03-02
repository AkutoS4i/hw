namespace ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case (int)DayOfTheWeek.Monday:
                        Console.WriteLine("Понедельник");
                        break;
                    case (int)DayOfTheWeek.Tuesday:
                        Console.WriteLine("Вторник");
                        break;
                    case (int)DayOfTheWeek.Wednesday:
                        Console.WriteLine("Среда");
                        break;
                    case (int)DayOfTheWeek.Thursday:
                        Console.WriteLine("Четверг");
                        break;
                    case (int)DayOfTheWeek.Friday:
                        Console.WriteLine("Пятница");
                        break;
                    case (int)DayOfTheWeek.Saturday:
                        Console.WriteLine("Суббота");
                        break;
                    case (int)DayOfTheWeek.Sunday:
                        Console.WriteLine("Воскресенье");
                        break;
                }
            }
        }
    }
}