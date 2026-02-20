using System.Data.Common;
using Microsoft.Data.SqlClient;

class AppointmentUtility
{
    static SqlConnection connection=DBConnection.GetConnection();
    public static bool IsDoctorAvailable(int doctorId,DateTime date,TimeSpan time)
    {
        string query="Select * from Appointments where DoctorId=@doctorId and AppointmentDate=@date and AppointmentTime=@time";
        SqlCommand Command =new SqlCommand(query,connection);
        Command.Parameters.AddWithValue("@doctorID",doctorId);
        Command.Parameters.AddWithValue("@date",date);
        Command.Parameters.AddWithValue("@time",time);
        connection.Open();
        int count=(int)Command.ExecuteScalar();
        connection.Close();      
        if(count>0) return false ; else return true;
    }
    public static void Book(Appointment a)
    {
        // if (a == null)
        // {
        //     Console.WriteLine("❌ Appointment object is NULL");
        //     return;
        // }
        // SqlConnection connection = DBConnection.GetConnection();

        // if (connection == null)
        // {
        //     Console.WriteLine("❌ Connection is NULL"); 
        // }
        // else
        // {
        // Console.WriteLine("✅ Connection object created");
        // }

        // bool isAvailable=IsDoctorAvailable(a.DoctorId,a.AppointmentDate,a.AppointmentTime);
        // if(!isAvailable) {
        //     Console.WriteLine("Doctor is not available");   
        //     return;
        // }
        string query="Insert into Appointments values(@patientId,@doctorId,@date,@time,@status)";
        SqlCommand command = new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@patientId",a.PatientId);
        command.Parameters.AddWithValue("@doctorId",a.DoctorId);
        command.Parameters.AddWithValue("@date",a.AppointmentDate);
        command.Parameters.AddWithValue("@time",a.AppointmentTime);
        command.Parameters.AddWithValue("@status","Booked");
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
    public static void Cancel(int appointmentId)
    {
        string query="Update Appointments set Status='Cancelled' where AppointmentId=@appointmentId";
        SqlCommand command=new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@appointmentId",appointmentId);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
    public static void Reschedule(int id, DateTime date, TimeSpan time)
    {
        SqlCommand cmd = new SqlCommand(
            @"UPDATE Appointments
            SET AppointmentDate=@dt, AppointmentTime=@tm
            WHERE AppointmentId=@id", connection);

        cmd.Parameters.AddWithValue("@dt", date);
        cmd.Parameters.AddWithValue("@tm", time);
        cmd.Parameters.AddWithValue("@id", id);

        connection.Open();
        cmd.ExecuteNonQuery();
        connection.Close();
    }
    public static List<string> GetDailySchedule(DateTime date)
    {
        List<string> list = new();

    
        SqlCommand cmd = new SqlCommand(
            @"SELECT a.AppointmentId,p.name,d.doctorName,a.AppointmentTime,a.Status
            FROM Appointments a
            JOIN Patient p ON a.PatientId=p.patientId
            JOIN Doctor d ON a.DoctorId=d.doctorId
            WHERE a.AppointmentDate=@dt
            ORDER BY a.AppointmentTime", connection);

        cmd.Parameters.AddWithValue("@dt", date);

        connection.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            list.Add(
                $"ID:{dr[0]} | Patient:{dr[1]} | Doctor:{dr[2]} | Time:{dr[3]} | {dr[4]}"
            );
        }
        connection.Close();

        return list;
    }


}