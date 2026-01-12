using System;

class MetalPipeCutting
{
    public int PipeCut(int start, int end, int[] cuts)
    {
        if (start + 1 >= end)
            return 0;

        int minCost = int.MaxValue;

        for (int i = start + 1; i < end; i++)
        {
            int cost =
                (cuts[end] - cuts[start]) +
                PipeCut(start, i, cuts) +
                PipeCut(i, end, cuts);

            minCost = Math.Min(minCost, cost);
        }

        return minCost;
    }

    //Rod length = 8
    // Cuts = {1,3,4,5}
    public void ScenarioA()
    {
        int[] cuts = { 0, 1, 3, 4, 5, 8 };
        int result = PipeCut(0, cuts.Length - 1, cuts);
        Console.WriteLine("Scenario A - Best Revenue (Min Cost): " + result);
    }

    // Custom cut added (example: 6)
    public void ScenarioB()
    {
        int[] cuts = { 0, 1, 3, 4, 5, 6, 8 };
        int result = PipeCut(0, cuts.Length - 1, cuts);
        Console.WriteLine("Scenario B - Revenue After Custom Cut: " + result);
    }

    // Non-optimized strategy (cut one by one)
    public void ScenarioC()
    {
        int[] cuts = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int result = PipeCut(0, cuts.Length - 1, cuts);
        Console.WriteLine("Scenario C - Non Optimized Revenue Loss: " + result);
    }

    static void Main()
    {
        MetalPipeCutting obj = new MetalPipeCutting();
        obj.ScenarioA();
        obj.ScenarioB();
        obj.ScenarioC();
    }
}
