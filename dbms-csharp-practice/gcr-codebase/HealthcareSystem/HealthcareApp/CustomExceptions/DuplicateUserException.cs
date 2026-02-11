using System;

public class DuplicateUserException : Exception
{
    String message;

    public DuplicateUserException(String message) : base(message)
    {
        this.message = message;
    }
    
}