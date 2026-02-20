public class PaymentService
{
    PaymentUtility dal = new PaymentUtility();

    public void MakePayment()
    {
        Payment payment = new Payment();

        Console.Write("Bill ID: ");
        payment.BillId = int.Parse(Console.ReadLine());

        Console.Write("Amount Paid: ");
        payment.AmountPaid = decimal.Parse(Console.ReadLine());

        Console.Write("Payment Mode (Cash/Card/UPI): ");
        payment.PaymentMode = Console.ReadLine();

        dal.RecordPayment(payment);
    }

    public void ShowOutstanding()
    {
        var list = dal.GetOutstandingBills();
        foreach (var item in list)
            Console.WriteLine(item);
    }
}