public class VisitService
{
    VisitDAL dal = new VisitDAL();

    public void CompleteVisit()
    {
        Console.Write("Appointment ID: ");
        int aid = int.Parse(Console.ReadLine());

        Console.Write("Diagnosis: ");
        string diagnosis = Console.ReadLine();

        Console.Write("Notes: ");
        string notes = Console.ReadLine();

        dal.CompleteVisit(aid, diagnosis, notes);
    }
    public void ViewVisits()
    {
        dal.ViewVisits();
    }
}
