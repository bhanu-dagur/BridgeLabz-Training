using Microsoft.Data.SqlClient;

class PaymentUtility
{
    public void RecordPayment(Payment payment)
    { 
        using SqlConnection con = DBConnection.GetConnection();
        con.Open();

        SqlTransaction tx = con.BeginTransaction();

        try
        {
            // 1️5 Insert into PaymentTransactions
            SqlCommand cmd1 = new SqlCommand(
                @"INSERT INTO PaymentTransactions
                (BillId, PaymentDate, PaymentMode, AmountPaid)
                VALUES (@bid, GETDATE(), @mode, @amt)",
                con, tx);

            cmd1.Parameters.AddWithValue("@bid", payment.BillId);
            cmd1.Parameters.AddWithValue("@mode", payment.PaymentMode);
            cmd1.Parameters.AddWithValue("@amt", payment.AmountPaid);

            cmd1.ExecuteNonQuery();

            // 2️ Update Bill Status
            SqlCommand cmd2 = new SqlCommand(
                @"UPDATE Bills
                SET PaymentStatus='PAID'
                WHERE BillId=@bid",
                con, tx);

            cmd2.Parameters.AddWithValue("@bid", payment.BillId);
            cmd2.ExecuteNonQuery();

            tx.Commit();
            Console.WriteLine(" Payment Successful");
        }
        catch
        {
            tx.Rollback();
            Console.WriteLine(" Payment Failed - Rolled Back");
        }

        con.Close();
    }
    public List<string> GetOutstandingBills()
    {
        List<string> list = new();

        using SqlConnection con = DBConnection.GetConnection();
        SqlCommand cmd = new SqlCommand(
            @"SELECT b.BillId, p.Name, b.TotalAmount
            FROM Bills b
            JOIN Visits v ON b.VisitId = v.VisitId
            JOIN Appointments a ON v.AppointmentId = a.AppointmentId
            JOIN Patients p ON a.PatientId = p.PatientId
            WHERE b.PaymentStatus='UNPAID'", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
            list.Add(
            $"BillID:{dr[0]} | Patient:{dr[1]} | Amount:{dr[2]}"
            );
            
        }
        con.Close();

        return list;
    }

}