public class AuditService
{
    AuditDAL dal = new AuditDAL();

    public void DisplayLogs()
    {
        var logs = dal.GetAllLogs();

        foreach (var log in logs)
        {
            Console.WriteLine(
              $"[{log.ActionDate}] {log.TableName} - {log.ActionType} - ID:{log.RecordId}"
            );
        }
    }
}