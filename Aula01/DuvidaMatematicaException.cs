// See https://aka.ms/new-console-template for more information

[Serializable]
internal class DuvidaMatematicaException : Exception
{
    public DuvidaMatematicaException()
    {
    }

    public DuvidaMatematicaException(string? message) : base(message)
    {
    }

    public DuvidaMatematicaException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}