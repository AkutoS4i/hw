namespace Homework8_9
{
    public class Worker : IJobTitle
    {
        string profession { get; set; } = "Рабочий";
        public void Jt() 
        {
            Console.WriteLine($"Название должности сотрудника: {profession}");
        }
    }
}