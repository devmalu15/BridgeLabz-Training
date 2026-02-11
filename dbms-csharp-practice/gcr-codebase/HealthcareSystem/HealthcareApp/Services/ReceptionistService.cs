using System;
using Microsoft.Data.SqlClient;

public class ReceptionistService : IReceptionist
{
    public async Task AddPatient(Patient patient)
    {

        DBConnection database = new DBConnection();

        using SqlConnection connection = database.OpenConnection();

        using SqlCommand duplicacyCommand = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE Contact = @Contact", connection);

        duplicacyCommand.Parameters.Add("@Contact", System.Data.SqlDbType.NVarChar).Value = patient.contact;

        int duplicacyChecker = (int)duplicacyCommand.ExecuteScalar();

        if (duplicacyChecker == 0)
        {
            String query = "INSERT INTO patients(PatientID, PatientName, BloodGroup, DateOfBirth, [Address], Contact) VALUES(@PatientID, @PatientName, @BloodGroup, @DateOfBirth, @Address, @Contact)";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@PatientID", System.Data.SqlDbType.NVarChar).Value = Guid.NewGuid().ToString();
            command.Parameters.Add("@PatientName", System.Data.SqlDbType.NVarChar).Value = patient.patientName;
            command.Parameters.Add("@BloodGroup", System.Data.SqlDbType.NVarChar).Value = patient.bloodGroup;
            command.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.Date).Value = patient.dob;
            command.Parameters.Add("@Address", System.Data.SqlDbType.NVarChar).Value = patient.address;
            command.Parameters.Add("@Contact", System.Data.SqlDbType.NVarChar).Value = patient.contact;

            await command.ExecuteNonQueryAsync();
            database.CloseConnection(connection);
        }
        else
        {
            database.CloseConnection(connection);
            throw new DuplicateUserException("User with this contact already exists!");
        }

    }

    public async Task UpdatePatient(String contact, Patient updatedPatient)
    {
        
        DBConnection database = new DBConnection();

        using SqlConnection connection = database.OpenConnection();

        using SqlCommand duplicacyCommand = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE Contact = @Contact", connection);

        duplicacyCommand.Parameters.Add("@Contact", System.Data.SqlDbType.NVarChar).Value = contact;

        int duplicacyChecker = (int)duplicacyCommand.ExecuteScalar();

        if(duplicacyChecker == 1)
        {
            String query = "UPDATE Patients SET PatientName = @PatientName, BloodGroup = @BloodGroup, DateOfBirth = @DateOfBirth, [Address] = @Address WHERE Contact = @contact";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@PatientName", System.Data.SqlDbType.NVarChar).Value = updatedPatient.patientName;
            command.Parameters.Add("@BloodGroup", System.Data.SqlDbType.NVarChar).Value = updatedPatient.bloodGroup;
            command.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.Date).Value = updatedPatient.dob;
            command.Parameters.Add("@Address", System.Data.SqlDbType.NVarChar).Value = updatedPatient.address;
            command.Parameters.Add("@contact", System.Data.SqlDbType.NVarChar).Value = contact;

            await command.ExecuteNonQueryAsync();
            database.CloseConnection(connection);
        }
        else
        {
            database.CloseConnection(connection);
            throw new UserNotFoundException("User with this contact does not exist!");
        }
        
    }
}