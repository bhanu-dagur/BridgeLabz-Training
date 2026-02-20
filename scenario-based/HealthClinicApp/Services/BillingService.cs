// public class BillingService
// {
//     BillingUtility dal = new BillingUtility();

//     public void GenerateBill()
//     {
//         Console.Write("Enter Visit ID: ");
//         int visitId = int.Parse(Console.ReadLine());

//         dal.GenerateBillFromVisit(visitId);
//     }
// }
public class BillService
{
    BillingUtility dal = new BillingUtility();

    public void GenerateBill()
    {
        Console.Write("Enter Visit ID: ");
        int VisitId = int.Parse(Console.ReadLine());

        dal.GenerateBillFromVisit(VisitId);

        Console.WriteLine("✅ Bill Generated Successfully");
    }

    public void ViewAllBills()
    {
        var bills = dal.GetAllBills();

        foreach (var b in bills)
        {
            Console.WriteLine(
              $"BillID:{b.BillId} | Visit:{b.VisitId} | Total:{b.TotalAmount} | {b.PaymentStatus} | Date:{b.BillDate}"
            );
        }
    }

    public void ShowRevenue()
    {
        decimal total = dal.GetTotalRevenue();
        Console.WriteLine($"💰 Total Revenue: {total}");
    }
}