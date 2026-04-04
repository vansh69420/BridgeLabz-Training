using System;

class InvalidWordException : ApplicationException
{
    public InvalidWordException(string message) : base(message)
    {
    }
}
