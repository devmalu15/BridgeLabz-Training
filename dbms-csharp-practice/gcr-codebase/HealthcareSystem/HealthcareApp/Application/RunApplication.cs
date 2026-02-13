using System;
using Microsoft.Data.SqlClient;

public class RunApplication
{
    public static async Task Main(String[] args)
    {
        IReceptionist receptionist = new ReceptionistService();

        ISharedService sharedService = new SharedService();

        IAdminService adminService = new AdminService();

        // Patient patient = new Patient(null, "risita", "B+", new DateOnly(2000, 8, 8), "hazratpur", "9689593996");
        // try{
        //     await receptionist.AddPatientAsync(patient);
        // }
        // catch(DuplicateUserException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // } 

        // Patient updatedPatient = new Patient(null, "Gavendra", "B+", new DateOnly(2000, 8, 27), "G.T. Road", "9689593995");

        // try
        // {
        //     await receptionist.UpdatePatientAsync("9689593999", updatedPatient);
        // }
        // catch(UserNotFoundException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // try
        // {
        //     string str =await sharedService.SearchPatientByNameAsync("lovis");
        //     Console.WriteLine(str);

        // }
        // catch(UserNotFoundException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // try
        // {
        //     String str = await sharedService.SearchPatientByNameAsync("risita");
        //     Console.WriteLine(str);
            
        // }
        // catch(UserNotFoundException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // try
        // {
        //     String str = await sharedService.SearchPatientByContactAsync("9689593995");
        //     Console.WriteLine(str);
        // }
        // catch(UserNotFoundException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // try
        // {
        //     String str = await sharedService.SearchPatientByContactAsync("2345678967");
        //     Console.WriteLine(str);
        // }
        // catch(UserNotFoundException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // try
        // {
        //     String str = await sharedService.PatientHistoryAsync("9689593995");
        //     Console.WriteLine(str);
        // }
        // catch(UserNotFoundException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        Doctor doctor = new Doctor(null, "dr.jony", "multispecialist", 100000, 10, "8688767899");

        try
        {
            await adminService.AddDoctorAsync(doctor);
        }
        catch(DuplicateUserException ex)
        {
            Console.WriteLine(ex.Message);
        } 
        

    }
}