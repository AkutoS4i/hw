namespace Homework8_9
{
    public class Director : IJobTitle
    {
        string profession { get; set; } = "Директор";
        public void Jt() 
        {
            Console.WriteLine($"Название должности сотрудника: {profession}");
        }
    }
}