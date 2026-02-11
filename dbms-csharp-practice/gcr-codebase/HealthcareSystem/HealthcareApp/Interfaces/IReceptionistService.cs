using System;

public interface IReceptionist
{
    public Task AddPatient(Patient patient);

    public Task UpdatePatient(String contact, Patient updatedPatient);
}