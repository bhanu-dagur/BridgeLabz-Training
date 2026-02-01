namespace EventTracker.Models;

public class AuditLog
{
    public string Action { get; set; }
    public string Method { get; set; }
    public string Class { get; set; }
    public DateTime Timestamp { get; set; }
}
