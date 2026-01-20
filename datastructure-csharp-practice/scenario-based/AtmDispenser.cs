using System;
class ATMDispenser
{
    static void DispenseCash(int amount, int[] notes)
    {
        int remainingAmount = amount;
        bool dispensed = false;

        Console.WriteLine("Amount to Dispense: ₹" + amount);
        Console.WriteLine("Dispensed Notes:");

        foreach (int note in notes)
        {
            if (remainingAmount >= note)
            {
                int count = remainingAmount / note;
                remainingAmount = remainingAmount % note;

                Console.WriteLine("Notes: " + note + " x " + count);
                dispensed = true;
            }
        }

        if (remainingAmount != 0)
        {
            Console.WriteLine("Exact change not possible.");
            Console.WriteLine("Remaining Amount: " + remainingAmount);
        }
        else if (!dispensed)
        {
            Console.WriteLine("No notes dispensed.");
        }
        else
        {
            Console.WriteLine(" Cash dispensed successfully.");
        }

        Console.WriteLine("----------------------------------");
    }

    static void Main()
    {
        int amount = 880;

        // Availible Notes
        int[] notesScenarioA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        Console.WriteLine("Scenario A: 500 Available");
        DispenseCash(amount, notesScenarioA);

        // Availabe Notes
        int[] notesScenarioB = { 200, 100, 50, 20, 10, 5, 2, 1 };
        Console.WriteLine("Scenario B: 500 Removed");
        DispenseCash(amount, notesScenarioB);

        // Exact change not possible
        int[] notesScenarioC = { 50, 20 };
        Console.WriteLine("Scenario C: Exact Change Not Possible");
        DispenseCash(30, notesScenarioC);
    }
}
