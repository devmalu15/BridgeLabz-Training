using System;
using Microsoft.Data.SqlClient;

public class DBConnection
{
    public SqlConnection OpenConnection()
    {
        string connectionString = "Server=LAPTOP-MSP0ESL1\\SQLEXPRESS;Database=HealthCareSystemDB;Trusted_Connection=true;TrustServerCertificate=true;";

        SqlConnection connection = new SqlConnection(connectionString);

        connection.Open();

        return connection;
    }

    public void CloseConnection(SqlConnection connection)
    {
        connection.Close();
    }

    public void NonReturnQuery(String query, SqlConnection connection)
    {
        SqlCommand command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();
    }

    public int IntQuery(String query, SqlConnection connection)
    {
        SqlCommand command = new SqlCommand(query, connection);
        int result = (int)command.ExecuteScalar();
        return result;
    }

    public SqlDataReader ReturnQuery(String query, SqlConnection connection)
    {
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataReader reader = command.ExecuteReader();
        return reader;
    }
    

}
