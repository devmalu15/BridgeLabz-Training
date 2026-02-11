using System;

public class UserNotFoundException : Exception
{
    String message;
    public UserNotFoundException(String message) : base(message)
    {
        this.message = message;
    }
}