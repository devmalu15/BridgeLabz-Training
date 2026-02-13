using System;
using Microsoft.Data.SqlClient;

public class AdminService : IAdminService
{
    public async Task AddDoctorAsync(Doctor doctor)
    {
        DBConnection database = new DBConnection();

        using SqlConnection connection = database.OpenConnection();

        using SqlCommand duplicacyCommand = new SqlCommand("SELECT COUNT(*) FROM Doctors WHERE Contact = @Contact", connection);

        duplicacyCommand.Parameters.Add("@Contact", System.Data.SqlDbType.NVarChar).Value = doctor.contact;

        int duplicacyChecker = (int)duplicacyCommand.ExecuteScalar();

        if (duplicacyChecker == 0)
        {
            String query = "INSERT INTO Doctors(DocID, DocName, Speciality, Salary, Experience, Contact) VALUES(@DocID, @DocName, @Speciality, @Salary, @Experience, @Contact)";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@DocID", System.Data.SqlDbType.NVarChar).Value = Guid.NewGuid().ToString();
            command.Parameters.Add("@DocName", System.Data.SqlDbType.NVarChar).Value = doctor.docName;
            command.Parameters.Add("@Speciality", System.Data.SqlDbType.NVarChar).Value = doctor.speciality;
            command.Parameters.Add("@Salary", System.Data.SqlDbType.Int).Value = doctor.salary;
            command.Parameters.Add("@Experience", System.Data.SqlDbType.Decimal).Value = doctor.experience;
            command.Parameters.Add("@Contact", System.Data.SqlDbType.NVarChar).Value = doctor.contact;

            command.ExecuteNonQuery();
            database.CloseConnection(connection);
        }
        else
        {
            database.CloseConnection(connection);
            throw new DuplicateUserException("User with this contact already exists!");
        }

    }
}