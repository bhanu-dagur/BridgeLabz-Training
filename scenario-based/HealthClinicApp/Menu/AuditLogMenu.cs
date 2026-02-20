public class AuditMenu
{
    static AuditService service = new AuditService();

    public static void Show()
    {
        Console.WriteLine("\n--- AUDIT LOG MENU ---");
        Console.WriteLine("1. View All Logs");

        if (int.Parse(Console.ReadLine()) == 1)
            service.DisplayLogs();
    }
}