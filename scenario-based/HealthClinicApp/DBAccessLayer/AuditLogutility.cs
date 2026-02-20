using Microsoft.Data.SqlClient;

public class AuditDAL
{
    public List<AuditLog> GetAllLogs()
    {
        List<AuditLog> list = new();

        using SqlConnection con = DBConnection.GetConnection();
        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM AuditLog ORDER BY ActionDate DESC", con);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            list.Add(new AuditLog
            {
                LogId = (int)dr["LogId"],
                TableName = dr["TableName"].ToString(),
                ActionType = dr["ActionType"].ToString(),
                RecordId = (int)dr["RecordId"],
                ActionDate = (DateTime)dr["ActionDate"]
            });
        }

        return list;
    }
}