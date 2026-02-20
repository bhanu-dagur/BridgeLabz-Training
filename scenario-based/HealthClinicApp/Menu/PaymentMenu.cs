public class PaymentMenu
{
    static PaymentService service = new PaymentService();

    public static void Show()
    {
        Console.WriteLine("\n--- PAYMENT MENU ---");
        Console.WriteLine("1. Make Payment");
        Console.WriteLine("2. View Outstanding Bills");

        int ch = int.Parse(Console.ReadLine());

        switch (ch)
        {
            case 1: service.MakePayment(); break;
            case 2: service.ShowOutstanding(); break;
        }
    }
}