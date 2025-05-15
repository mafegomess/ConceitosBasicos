
namespace Aula01._1Bim
{
    [Serializable]
    internal class IntervaloInvalidoException : Exception
    {
        public IntervaloInvalidoException()
        {
        }

        public IntervaloInvalidoException(string? message) : base(message)
        {
        }

        public IntervaloInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}