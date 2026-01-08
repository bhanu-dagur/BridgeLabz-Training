using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;

    public int WaitingTime;
    public int TurnAroundTime;

    public ProcessNode Next;

    public ProcessNode(int pid, int burst, int priority)
    {
        ProcessId = pid;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    ProcessNode head = null;
    ProcessNode tail = null;

    // Add process at end
    public void AddProcess(int pid, int burst, int priority)
    {
        ProcessNode node = new ProcessNode(pid, burst, priority);

        if (head == null)
        {
            head = tail = node;
            node.Next = head;
        }
        else
        {
            tail.Next = node;
            tail = node;
            tail.Next = head;
        }
    }

    // Display circular list
    public void DisplayProcesses()
    {
        if (head == null) return;

        ProcessNode temp = head;
        do
        {
            Console.Write("P" + temp.ProcessId + " ");
            temp = temp.Next;
        }
        while (temp != head);

        Console.WriteLine("(Back to Head)");
    }

    // Round Robin Simulation
    public void Execute(int timeQuantum)
    {
        if (head == null) return;

        int currentTime = 0;
        int completed = 0;
        int totalProcesses = CountProcesses();

        ProcessNode current = head;

        Console.WriteLine("\n--- Round Robin Execution ---");

        while (completed < totalProcesses)
        {
            if (current.RemainingTime > 0)
            {
                Console.WriteLine("\nCurrent Time: " + currentTime);

                if (current.RemainingTime > timeQuantum)
                {
                    currentTime += timeQuantum;
                    current.RemainingTime -= timeQuantum;
                }
                else
                {
                    currentTime += current.RemainingTime;
                    current.RemainingTime = 0;

                    current.TurnAroundTime = currentTime;
                    current.WaitingTime = current.TurnAroundTime - current.BurstTime;
                    completed++;
                }

                DisplayProcesses();
            }

            current = current.Next;
        }

        CalculateAverageTimes();
    }

    // Count total processes
    int CountProcesses()
    {
        int count = 0;
        ProcessNode temp = head;

        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        return count;
    }

    // Average Waiting & Turnaround Time
    void CalculateAverageTimes()
    {
        double totalWT = 0, totalTAT = 0;
        ProcessNode temp = head;

        Console.WriteLine("\n--- Final Process Details ---");

        do
        {
            Console.WriteLine("\nP" + temp.ProcessId + " - Waiting Time: " + temp.WaitingTime + " Turnaround Time: " + temp.TurnAroundTime);
            totalWT += temp.WaitingTime;
            totalTAT += temp.TurnAroundTime;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("\nAverage Waiting Time = " + totalWT / CountProcesses());
        Console.WriteLine("Average Turnaround Time = " + totalTAT / CountProcesses());
    }
}

class RoundRobin
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();

        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);

        Console.WriteLine("Initial Process Queue:");
        scheduler.DisplayProcesses();

        int timeQuantum = 3;
        scheduler.Execute(timeQuantum);
    }
}
