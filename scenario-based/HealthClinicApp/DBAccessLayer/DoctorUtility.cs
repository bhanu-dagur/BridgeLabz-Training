using Microsoft.Data.SqlClient;

class DoctorUtility
{
    static SqlConnection connection= DBConnection.GetConnection();

    public static void Add(Doctor d)
    {
        /*
        create table Doctor(doctorId int identity(1,1) primary key,
                    doctorName varchar(50) not null,
					specialtyId int,
					contact varchar(50),
					consultationFee decimal(10,2),
					is_active bit default 1,
					constraint fk_specialty
					    foreign key (specialtyId)
						references Specialties(specialtyId)
					);

        */
        string query="Insert into Doctor(doctorName,specialtyId,contact,consultationFee) values(@doctorName,@specialtyId,@contact,@consultationFee)";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@doctorName", d.doctorName);
        command.Parameters.AddWithValue("@specialtyId", d.specialtyId);
        command.Parameters.AddWithValue("@contact", d.contact);
        command.Parameters.AddWithValue("@consultationFee", d.consultationFee);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
    public static void View()
    {
        string query="Select * from Doctor";
        SqlCommand command = new SqlCommand(query,connection);
        connection.Open();
        SqlDataReader reader=command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine("doctorId: "+reader["doctorId"]+" | doctorName: "
                +reader["doctorName"]+" | specialtyId: "+reader["specialtyId"]
                +" | contact: "+reader["contact"]+" | consultationFee: "
                +reader["consultationFee"]);
        }
        connection.Close();
    }
    public static void Delete(int doctorId)
    {
        string query="Delete from Doctor where doctorId=@doctorId";
        SqlCommand command = new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@doctorId",doctorId);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
    public static void Update(Doctor d)
    {
        string query="Update Doctor set doctorName=@doctorName,specialtyId=@specialtyId,contact=@contact,consultationFee=@consultationFee where doctorId=@doctorId ";
        SqlCommand command = new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@doctorId",d.doctorId);
        command.Parameters.AddWithValue("@doctorName",d.doctorName);
        command.Parameters.AddWithValue("@specialtyId",d.specialtyId);
        command.Parameters.AddWithValue("@contact",d.contact);
        command.Parameters.AddWithValue("@consultationFee",d.consultationFee);
        connection.Open();
        command.ExecuteScalar();
        connection.Close();
    }
    public static void Search(string name)
    {
        string query="Select * from Doctor where doctorName like '%'+@name+'%'";
        SqlCommand command = new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@name",name);
        connection.Open();
        SqlDataReader reader=command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("doctorId: "+reader["doctorId"]+" | doctorName: "
                +reader["doctorName"]+" | specialtyId: "+reader["specialtyId"]
                +" | contact: "+reader["contact"]+" | consultationFee: "
                +reader["consultationFee"]);
        }
        connection.Close();
    }
}