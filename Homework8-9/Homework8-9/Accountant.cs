namespace Homework8_9
{
    public class Accountant : IJobTitle
    {
        string profession { get; set; } = "Бухгалтер";
        public void Jt() 
        {
            Console.WriteLine($"Название должности сотрудника: {profession}");
        }
    }
}