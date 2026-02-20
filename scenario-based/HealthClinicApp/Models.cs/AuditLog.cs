public class AuditLog
{
    public int LogId { get; set; }
    public string TableName { get; set; }
    public string ActionType { get; set; }
    public int RecordId { get; set; }
    public DateTime ActionDate { get; set; }
}