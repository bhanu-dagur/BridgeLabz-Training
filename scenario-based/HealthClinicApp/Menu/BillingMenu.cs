public class BillingMenu
{
    static BillService service = new BillService();

    public static void Show()
    {
        Console.WriteLine("\n--- BILL MENU ---");
        Console.WriteLine("1. Generate Bill");
        Console.WriteLine("2. View All Bills");
        Console.WriteLine("3. View Revenue");

        int ch = int.Parse(Console.ReadLine());

        switch (ch)
        {
            case 1: service.GenerateBill(); break;
            case 2: service.ViewAllBills(); break;
            case 3: service.ShowRevenue(); break;
        }
    }
}