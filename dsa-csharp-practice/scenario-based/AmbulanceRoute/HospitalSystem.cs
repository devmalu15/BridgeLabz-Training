using System;

public class HospitalSystem
{
    public static void Main(string[] args)
    {
        IHospitalNavigation ambulanceRoute = new AmbulanceRouteManager();

        
        ambulanceRoute.AddUnit("Emergency (Dr. Lovis)");
        ambulanceRoute.AddUnit("Radiology (Dr. Risita)");
        ambulanceRoute.AddUnit("Surgery (Dr. Ramaa)");
        ambulanceRoute.AddUnit("ICU (Dr. Priyansu)");

        ambulanceRoute.DisplayRoute();
        Console.WriteLine();

        
        Console.WriteLine("--- Emergency Scenario ---");
        ambulanceRoute.SetAvailability("Emergency (Dr. Lovis)", false);
        ambulanceRoute.SetAvailability("Radiology (Dr. Risita)", false);

        string destination = ambulanceRoute.FindNextAvailable("Emergency (Dr. Lovis)");
        Console.WriteLine(destination);
        Console.WriteLine();

        
        ambulanceRoute.RemoveUnit("Surgery (Dr. Ramaa)");
        ambulanceRoute.DisplayRoute();

        
        Console.WriteLine("\nAmbulance checking again...");
        Console.WriteLine(ambulanceRoute.FindNextAvailable("Emergency (Dr. Lovis)"));
    }
}