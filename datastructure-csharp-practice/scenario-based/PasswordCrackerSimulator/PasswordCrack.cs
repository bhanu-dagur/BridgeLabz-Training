using System;

class PasswordCrack
{
    public static void Main()
    {
        ScenarioA obj=new ScenarioA();
        obj.scenarioA();

        ScenarioB obj1=new ScenarioB();
        obj1.scenarioB();

        ScenarioC obj2=new ScenarioC();
        obj2.RunScenarioC();
    }
    

}
class ScenarioA
{
    private char [] charSet={'a','b','c','d'};
    public void scenarioA()
    {
        Console.WriteLine("Scenario A: Generate all strings of length n.");
        Console.WriteLine("Enter the length of the string:");
        int n=int.Parse(Console.ReadLine());
        GenerateAllString("",n);
    }
    public void GenerateAllString(string current,int n)
    {
        if (current.Length == n)
        {
            Console.WriteLine(current);
            return;
        }

        foreach (char c in charSet)
        {
            GenerateAllString(current+c,n);
        }
        
    }
}

class ScenarioB
{
    char [] charSet={'a','b','c','d'};
    bool found=false;
    public void scenarioB()
    {
        Console.WriteLine("Scenario B: Stop if password is matched.");
        Console.WriteLine("Enter the password made from (a,b,c,d):");
        string password=Console.ReadLine();

        int n=password.Length;
        
        GenerateString("",n,password);
    }

    public void GenerateString(string current,int n,string password)
    {
        if(found) return;
        if (current.Length == n)
        {
            Console.WriteLine("Trying Password: "+current);
            if (current.Equals(password,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Password cracked sucessfully");
                Console.WriteLine("Cracked Password: "+current);
                found=true;
            }
            return;
        }

        for(int i = 0; i < charSet.Length; i++)
        {
            GenerateString(current+charSet[i],n,password);
        }
    }
}

class ScenarioC
{
    private char[] charSet = { 'a', 'b', 'c', 'd' };
    private int attempts = 0;
    private int maxDepth = 0;

    public void RunScenarioC()
    {
        Console.WriteLine("\nScenario C: Time & Space Complexity Visualization");
        Console.Write("Enter password length n: ");
        int n = int.Parse(Console.ReadLine());

        Generate("", n, 0);

        Console.WriteLine("\nComplexity Report ");
        Console.WriteLine("Total Attempts (Time Complexity): " + attempts);
        Console.WriteLine("Maximum Recursion Depth (Space Complexity): " + maxDepth);
        Console.WriteLine("Theoretical Time Complexity: O(k^n)");
        Console.WriteLine("Theoretical Space Complexity: O(n)");
    }

    private void Generate(string current, int n, int depth)
    {
        // Track max recursion depth
        if (depth > maxDepth)
            maxDepth = depth;

        if (current.Length == n)
        {
            attempts++;   // one valid combination tried
            return;
        }

        foreach (char c in charSet)
        {
            Generate(current + c, n, depth + 1);
        }
    }
}
