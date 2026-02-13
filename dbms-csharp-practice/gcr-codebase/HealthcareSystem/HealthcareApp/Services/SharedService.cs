using System;
using System.Data.SqlTypes;
using System.Security;
using System.Text;
using Microsoft.Data.SqlClient;

public class SharedService : ISharedService
{
    public async Task<String> SearchPatientByNameAsync(String patientName)
    {
        StringBuilder resultString = new StringBuilder();

        DBConnection database = new DBConnection();

        using SqlConnection connection = database.OpenConnection();

        String query = "SELECT * FROM Patients WHERE PatientName LIKE @patientName";

        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.Add("@patientName", System.Data.SqlDbType.NVarChar).Value = $"%{patientName}%";

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            resultString.Append(reader["PatientName"] + " ");
        }

        if(resultString.Length == 0)
        {
            database.CloseConnection(connection);
            throw new UserNotFoundException("User with this name does not exist!");
        }
        else
        {
            database.CloseConnection(connection);
            return resultString.ToString();
        }
    }

    public async Task<String> SearchPatientByContactAsync(String patientContact)
    {
        StringBuilder resultString = new StringBuilder();

        DBConnection database = new DBConnection();

        using SqlConnection connection = database.OpenConnection();

        String query = "SELECT * FROM Patients WHERE Contact = @patientContact";

        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.Add("@patientContact", System.Data.SqlDbType.NVarChar).Value = patientContact;

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            resultString.Append(reader["PatientName"] + " ");
        }

        if(resultString.Length == 0)
        {
            database.CloseConnection(connection);
            throw new UserNotFoundException("User with this number does not exist!");
        }
        else
        {
            database.CloseConnection(connection);
            return resultString.ToString();
        }
    }
}