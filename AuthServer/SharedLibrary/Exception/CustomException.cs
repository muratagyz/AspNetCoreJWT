namespace SharedLibrary.Exception
{
    public class CustomException : System.Exception
    {
        public CustomException() : base()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
