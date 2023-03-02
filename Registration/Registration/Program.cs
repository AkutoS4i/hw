namespace Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                bool registrationDone = Registration.Reg("12345678","123qwerty", "123qwerty");
                if (registrationDone) Console.WriteLine("Регистрация прошла успешно");
            }
            catch (WrongLoginException ex) { Console.WriteLine(ex.Message); }
            catch (WrongPasswordException ex) { Console.WriteLine(ex.Message); }
        }
    }
}