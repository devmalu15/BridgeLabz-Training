using System;
using Microsoft.Data.SqlClient;

public class ReceptionistService : IReceptionist
{
    public void AddPatient(Patient patient)
    {
        String query = "INSERT INTO patients(PatientID, PatientName, BloodGroup, DateOfBirth, [Address], Contact) VALUES(@PatientID, @PatientName, @BloodGroup, @DateOfBirth, @Address, @Contact)";

        DBConnection database = new DBConnection();

        SqlConnection connection = database.OpenConnection();

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.Add("@PatientID", System.Data.SqlDbType.NVarChar).Value = Guid.NewGuid().ToString();
        command.Parameters.Add("@PatientName", System.Data.SqlDbType.NVarChar).Value = patient.patientName;
        command.Parameters.Add("@BloodGroup", System.Data.SqlDbType.NVarChar).Value = patient.bloodGroup;
        command.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.Date).Value = patient.dob;
        command.Parameters.Add("@Address", System.Data.SqlDbType.NVarChar).Value = patient.address;
        command.Parameters.Add("@Contact", System.Data.SqlDbType.NVarChar).Value = patient.contact;

        command.ExecuteNonQuery();
        database.CloseConnection(connection);
    }
}