using System;

public class RunApplication
{
    public static void Main(String[] args)
    {
        IReceptionist manager = new ReceptionistService();

        Patient patient = new Patient(null, "lovis", "B-", new DateOnly(2000, 12, 5), "Palwal", "9867578998");
        manager.AddPatient(patient);
    }
}