using System;

public class Admin
{
    public String adminID {get; set;}
    public String adminPass {get; set;}
    public String adminName {get; set;}

    public Admin(String adminID, String adminPass, String adminName)
    {
        this.adminID = adminID;
        this.adminPass = adminPass;
        this.adminName = adminName;
    }
}