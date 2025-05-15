
namespace Aula01._1Bim
{
    [Serializable]
    internal class InputZeroException : Exception
    {
        public InputZeroException()
        {
        }

        public InputZeroException(string? message) : base(message)
        {
        }

        public InputZeroException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}