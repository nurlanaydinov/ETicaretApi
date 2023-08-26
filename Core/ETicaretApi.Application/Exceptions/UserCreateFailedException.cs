
namespace ETicaretApi.Application.Exceptions
{
    public class UserCreateFailedException : Exception
    {
        public UserCreateFailedException() : base("Unexpected Error")
        {
        }

        public UserCreateFailedException(string message) : base(message)
        {
        }

        public UserCreateFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
