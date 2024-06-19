namespace Library_Proj.Exceptions
{
    public class NoSuchUserException:Exception
    {
        private readonly string _message;
        public NoSuchUserException()
        {
            _message = "No User exist this username";
        }
        public override string Message => _message;
    }
}
