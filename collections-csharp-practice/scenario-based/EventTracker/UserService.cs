using System;

public class UserService
{
    [AuditTrail("User Login")]
    public void Login() { }

    [AuditTrail("File Deletion")]
    public void DeleteFile() { }

    public void UpdateProfile() { }
}