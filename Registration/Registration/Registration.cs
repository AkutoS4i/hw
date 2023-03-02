namespace Registration
{
    class Registration
    {
        public static bool Reg(string login, string password, string confirmPassword)
        {
            bool succses = true;
            var Arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (login.Length > 20) throw new WrongLoginException("Логин не может превышать 20 символов");
            if (password.Length > 20) throw new WrongPasswordException("Пароль не может превышать 20 символов");
            if (login.Contains(' ')) throw new WrongLoginException("Логин не может содержать пробелы");
            if (password.Contains(' ')) throw new WrongPasswordException("Пароль не может содержать пробелы");
            if (password.LastIndexOfAny(Arr) == -1) throw new WrongPasswordException("Пароль должен содержить хотя бы 1 цифру");
            if (!password.Equals(confirmPassword)) throw new WrongPasswordException("Пароли не совпадают");
            return succses;

        }
    }
}