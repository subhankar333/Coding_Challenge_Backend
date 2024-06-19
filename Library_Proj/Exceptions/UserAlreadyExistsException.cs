namespace Library_Proj.Exceptions
{
    public class UserAlreadyExistsException:Exception
    {
        private readonly string _message;
        public UserAlreadyExistsException()
        {
            _message = "User alraedy exists with this username";
        }
        public override string Message => _message;
    }
}
