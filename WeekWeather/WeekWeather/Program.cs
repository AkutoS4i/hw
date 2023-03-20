namespace WeekWeather
{
    delegate string WeekWeather();
    class Program
    {
        static void Main()
        {
            string Weather()
            {
                string[] weather = new string[] { "Дождь", "Облачно", "Ясно", "Пасмурно", "Сильный ветер", "Переменная облачность", "Снег" };
                var rnd = new Random();
                var i = rnd.Next(0, 6);
                return weather[i];
            }
            WeekWeather dayOfTheWeek;
            int day = -1;
            dayOfTheWeek = delegate ()
            {
                string[] Days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
                return Days[++day % 7];
            };
            for (int i = 1; i < 25; i++)
            {
                Console.WriteLine(dayOfTheWeek() + "-" + Weather());
            }
            Console.ReadKey();
        }
    }
}