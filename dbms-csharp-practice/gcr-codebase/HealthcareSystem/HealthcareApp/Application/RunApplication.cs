using System;

public class RunApplication
{
    public static void Main(String[] args)
    {
        IReceptionist receptionist = new ReceptionistService();

        Patient patient = new Patient(null, "Gavendra", "B+", new DateOnly(2000, 8, 5), "G.T. Road", "9689593995");
        try{
            receptionist.AddPatient(patient);
        }
        catch(DuplicateUserException ex)
        {
            Console.WriteLine(ex.Message);
        } 

        Patient updatedPatient = new Patient(null, "Gavendra", "B+", new DateOnly(2000, 8, 18), "G.T. Road", "9689593995");

        try
        {
            receptionist.UpdatePatient("9689593995", updatedPatient);
        }
        catch(UserNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}