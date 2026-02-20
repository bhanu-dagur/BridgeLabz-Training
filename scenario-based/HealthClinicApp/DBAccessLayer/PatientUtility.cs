using Microsoft.Data.SqlClient;
class PatientUtility
{
    static SqlConnection connection = DBConnection.GetConnection();
    public static void Add(Patient patient)
    {
        // string query="Insert into Patient(Name,DOB,Address,BloodGroup,Phone) values(@Name,@DOB,@Address,@BloodGroup,@Phone)";
        string query="Insert into Patient values(@Name,@DOB,@Address,@BloodGroup,@Phone,@Email)";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Name", patient.Name);
        command.Parameters.AddWithValue("@DOB", patient.DOB);
        command.Parameters.AddWithValue("@Address", patient.Address);
        command.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);
        command.Parameters.AddWithValue("@Phone", patient.Phone);
        command.Parameters.AddWithValue("@Email", patient.Email);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
    public static void View()
    {
        string query="Select * from Patient";
        SqlCommand command =new SqlCommand(query,connection);
        connection.Open();
        SqlDataReader reader=command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("patientId: "+reader["patientId"]+" | Name: "+reader["name"]+" | DOB: "+reader["DOB"]+" | Address: "+reader["address"]+" | BloodGroup: "+reader["bloodGroup"]+" | Phone: "+reader["phone"]+" | Email: "+reader["email"]);
        } 
        connection.Close();       
    }
    public static void Delete(int patientId)
    {
        string query="Delete from Patient where patientId=@patientId";
        SqlCommand command =new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@patientId",patientId);
        connection.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("patient deleted sucessfully");
        connection.Close();
    }
    // Update Patient
    public static void Update(Patient patient)
    {
        string query="Update Patient set Name=@Name,DOB=@DOb,Address=@Address,BloodGroup=@BloodGroup,Phone=@Phone,Email=@Email where patientId=@patientId";
        SqlCommand command=new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@Name",patient.Name);
        command.Parameters.AddWithValue("@DOB",patient.DOB);
        command.Parameters.AddWithValue("@Address",patient.Address);
        command.Parameters.AddWithValue("@BloodGroup",patient.BloodGroup);
        command.Parameters.AddWithValue("@Phone",patient.Phone);
        command.Parameters.AddWithValue("@Email",patient.Email);
        command.Parameters.AddWithValue("@patientId",patient.Id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
    public static void  Search(string name)
    {
        // SELECT patientId, name, phone, email FROM Patient WHERE name LIKE '%Rohit%';
        string query="Select * from Patient where name like '%'+@name+'%'";
        
        SqlCommand command = new SqlCommand(query,connection);
        command.Parameters.AddWithValue("@name",name);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("PatientId: "+reader["patientId"]+" | Name: "+reader["name"]+" | Phone: "+reader["phone"]+" | Email: "+reader["email"]); 
        }
        connection.Close();
    }
    
    
}