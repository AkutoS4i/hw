namespace Structure
{
    struct User
    {
        public string name;
        public int age;
        public string addres;
        public string surname;
        public string login;
        public string password;

        public User()
        {
            name = "Кирилл";
            age = 23;
            addres = "г.Минск, пр-т Независимости 168/12";
            surname = "Налетько";
            login = "12345678";
            password = "qwerty";
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Адресс: {addres}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Логин: {login}");
            Console.WriteLine($"Пароль: {password}");
        }
    }
}