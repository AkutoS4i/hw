namespace Registration
{
    class WrongLoginException : Exception 
    {
        public WrongLoginException(string message) : base(message) { }
    }
}