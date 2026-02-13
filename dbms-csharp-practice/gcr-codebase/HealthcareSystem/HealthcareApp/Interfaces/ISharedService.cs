using System;
using Microsoft.Data.SqlClient;

public interface ISharedService
{

    public Task<String> SearchPatientByNameAsync(String patientName);

    public Task<String> SearchPatientByContactAsync(String patientContact);

    
}