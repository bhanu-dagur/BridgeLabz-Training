using Azure.Core.Pipeline;
using Microsoft.Data.SqlClient;
public class BillingUtility
{
    public void GenerateBillFromVisit(int visitId)
    {
        using SqlConnection con = DBConnection.GetConnection();
        con.Open();

        try
        {
            //check appointment status
            SqlCommand statusCmd=new SqlCommand(
                @"SELECT a.Status
                  FROM Visits v
                  JOIN Appointments a ON v.AppointmentId = a.AppointmentId
                  WHERE v.VisitId = @vid", con);

            statusCmd.Parameters.AddWithValue("@vid", visitId);

            string? status = statusCmd.ExecuteScalar() as string;  

            if (status != "COMPLETED")
            {
                Console.WriteLine(" Visit is not completed");
                return;
            }  
            
            // 1 Get doctor consultation fee
            SqlCommand feeCmd = new SqlCommand(
                @"SELECT d.ConsultationFee
                  FROM Visits v
                  JOIN Appointments a ON v.AppointmentId = a.AppointmentId
                  JOIN Doctor d ON a.DoctorId = d.doctorId
                  WHERE v.VisitId = @vid", con);

            feeCmd.Parameters.AddWithValue("@vid", visitId);

            object result = feeCmd.ExecuteScalar ();

            if (result == null)
            {
                Console.WriteLine(" Invalid Visit ID");
                return;
            }

            decimal fee = Convert.ToDecimal(result);

            // 2️ Insert bill
            SqlCommand billCmd = new SqlCommand(
                @"INSERT INTO Bills
                  (VisitId, TotalAmount, PaymentStatus)
                  VALUES (@vid, @amt, 'UNPAID')", con);

            billCmd.Parameters.AddWithValue("@vid", visitId);
            billCmd.Parameters.AddWithValue("@amt", fee);

            billCmd.ExecuteNonQuery();


            Console.WriteLine($" Bill generated successfully. Amount = {fee}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(" Error: " + ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    public List<Bill> GetAllBills()
    {
        List<Bill> list = new();

        using SqlConnection con = DBConnection.GetConnection();
        SqlCommand cmd = new SqlCommand("SELECT * FROM Bills", con);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            list.Add(new Bill
            {
                BillId = (int)dr["BillId"],
                VisitId = (int)dr["VisitId"],
                TotalAmount = (decimal)dr["TotalAmount"],
                PaymentStatus = dr["PaymentStatus"].ToString(),
                BillDate = (DateTime)dr["BillDate"]
            });
        }

        return list;
    }
    public decimal GetTotalRevenue()
    {
        using SqlConnection con = DBConnection.GetConnection();

        SqlCommand cmd = new SqlCommand(
            "SELECT SUM(TotalAmount) FROM Bills WHERE PaymentStatus='PAID'", con);

        con.Open();

        object result = cmd.ExecuteScalar();

        return result == DBNull.Value ? 0 : (decimal)result;
    }
}
