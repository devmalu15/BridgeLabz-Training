using System;

public class Receptionist
{
    public String receptionID {get; set;}
    public String receptionPass {get; set;}
    public String receptionName {get; set;}

    public Receptionist(String receptionID, String receptionPass, String receptionName)
    {
        this.receptionID = receptionID;
        this.receptionPass = receptionPass;
        this.receptionName = receptionName;
    }
}