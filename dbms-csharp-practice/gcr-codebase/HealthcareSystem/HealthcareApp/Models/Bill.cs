using System;
using Microsoft.Identity.Client;

public class Bill
{
    public String billID {get; set;}
    public String appointmentID {get; set;}
    public String billStatus {get; set;}
    public DateTime billingDT {get; set;}
    public DateTime payingDT {get; set;}
    public double amount {get; set;}


    public Bill(String billID, String appointmentID, String billStatus, DateTime billingDT, DateTime payingDT, double amount)
    {
        this.billID = billID;
        this.appointmentID = appointmentID;
        this.billStatus = billStatus;
        this.billingDT = billingDT;
        this.payingDT = payingDT;
        this.amount = amount;
    }

    
}