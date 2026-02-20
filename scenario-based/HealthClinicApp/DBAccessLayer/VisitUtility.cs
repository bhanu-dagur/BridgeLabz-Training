using Microsoft.Data.SqlClient;
public class VisitDAL
{
    public void CompleteVisit(int appointmentId, string diagnosis, string notes)
    {
        using SqlConnection con = DBConnection.GetConnection();
        con.Open();

        SqlTransaction tx = con.BeginTransaction();

        try
        {
            //  Update Appointment
            SqlCommand cmd1 = new SqlCommand(
                "UPDATE Appointments SET Status='COMPLETED' WHERE AppointmentId=@id",
                con, tx);

            cmd1.Parameters.AddWithValue("@id", appointmentId);
            cmd1.ExecuteNonQuery();

            // Insert Visit
            SqlCommand cmd2 = new SqlCommand(
                @"INSERT INTO Visits
                  (AppointmentId,Diagnosis,Notes,VisitDate)
                  VALUES(@id,@d,@n,GETDATE())",
                con, tx);

            cmd2.Parameters.AddWithValue("@id", appointmentId);
            cmd2.Parameters.AddWithValue("@d", diagnosis);
            cmd2.Parameters.AddWithValue("@n", notes);
            cmd2.ExecuteNonQuery();

            tx.Commit();
            Console.WriteLine(" Visit completed");
        }
        catch
        {
            tx.Rollback();
            Console.WriteLine(" Visit failed, rollback done");
        }
    }
    public void  ViewVisits()
    {
        using SqlConnection con = DBConnection.GetConnection();
        con.Open();

        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Visits", con);
        
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine($"VisitId: {dr[0]} | Diagnosis: {dr[1]} | Notes: {dr[2]} | VisitDate: {dr[3]}"); 
        }

    }
}
