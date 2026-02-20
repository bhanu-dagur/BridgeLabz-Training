using Microsoft.Data.SqlClient;
using System.Data;

public class DBConnection
{
    public static SqlConnection GetConnection()
    {
        string connectionString="Server=localhost\\SQLExpress;Database=HealthClinicApp;Trusted_Connection=True;TrustServerCertificate=True";
        SqlConnection connection =new SqlConnection(connectionString);
        
        connection.Open();
        Console.WriteLine("Connection estabilished");
        connection.Close();

        return connection;
    }
}