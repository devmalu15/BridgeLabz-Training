using System;

public interface IReceptionist
{
    public Task AddPatientAsync(Patient patient);

    public Task UpdatePatientAsync(String contact, Patient updatedPatient);

    
}