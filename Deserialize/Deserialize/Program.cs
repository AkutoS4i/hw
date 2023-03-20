using System.Text.Json;

namespace Deserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var fs = new FileStream("SuperHero.json", FileMode.OpenOrCreate))
            {
                var squad = JsonSerializer.Deserialize<SuperHero>(fs);
            }
        }
    }
}