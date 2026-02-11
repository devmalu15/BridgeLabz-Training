using System;

public class Appointment
{
    public String billID {get; set;}
    public String patientID {get; set;}
    public String doctorID {get; set;}
    public String appointmentStatus {get; set;}
    public String diagnosis {get; set;}
    public double appointmentCharge {get; set;}
    public DateTime appointmentDT {get; set;}

    public Appointment(String billID, String patientID, String doctorID, String appointmentStatus, String diagnosis, double appointmentCharge, DateTime appointmentDT)
    {
        this.billID = billID;
        this.patientID = patientID;
        this.doctorID = doctorID;
        this.appointmentStatus = appointmentStatus;
        this.diagnosis = diagnosis;
        this.appointmentCharge = appointmentCharge;
        this.appointmentDT = appointmentDT;
    }
}