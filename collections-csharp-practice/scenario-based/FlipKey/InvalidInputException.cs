using System;

class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message)
    {
    }
}
