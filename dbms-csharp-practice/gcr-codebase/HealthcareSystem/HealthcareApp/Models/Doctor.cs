using System;

public class Doctor
{
    public String docID {get; set;}
    public String docName {get; set;}
    public String speciality {get; set;}
    public int salary {get; set;}
    public double experience {get; set;}


    public Doctor(String docID, String docName, String speciality, int salary, double experience)
    {
        this.docID = docID;
        this.docName = docName;
        this.speciality = speciality;
        this.salary = salary;
        this.experience = experience;
    }

}