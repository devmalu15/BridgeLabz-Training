using System;
using System.Net.Sockets;

public class Patient
{
    public String patientID {get; set;}
    public String patientName {get; set;}
    public String bloodGroup {get; set;}
    public DateOnly dob {get; set;}
    public String address {get; set;}
    public String contact {get; set;}

    public Patient(String patientID, String patientName, String bloodGroup, DateOnly dob, String address, String contact)
    {
        this.patientID = patientID;
        this.patientName = patientName;
        this.bloodGroup = bloodGroup;
        this.dob = dob;
        this.address = address;
        this.contact = contact;
    }


}