public class VisitMenu
{
    static VisitService service = new VisitService();

    public static void Show()
    {
        Console.WriteLine("1. Complete Visit");
        Console.WriteLine("2. View Visits");
        Console.WriteLine("3. Back");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                service.CompleteVisit();
                break;
            case 2:
                service.ViewVisits();
                break;
            case 3:
                MainMenu.Show();
                break;
            default :
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        
    }
}
