
namespace Aula01._1Bim
{
    [Serializable]
    internal class FinalMenorInicialException : Exception
    {
        public FinalMenorInicialException()
        {
        }

        public FinalMenorInicialException(string? message) : base(message)
        {
        }

        public FinalMenorInicialException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}