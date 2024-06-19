namespace Library_Proj.Exceptions
{
    public class NoSuchBookException:Exception
    {
        private readonly string _message;
        public NoSuchBookException()
        {
            _message = "Book does not exist with this bookId";
        }
        public override string Message => _message;
    }
}
