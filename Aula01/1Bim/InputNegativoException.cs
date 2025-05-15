
namespace Aula01._1Bim
{
    [Serializable]
    internal class InputNegativoException : Exception
    {
        public InputNegativoException()
        {
        }

        public InputNegativoException(string? message) : base(message)
        {
        }

        public InputNegativoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}