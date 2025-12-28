using System;
class CampareString
{
    static void Main(String []args)
    {
        Console.WriteLine("Enter the strings");
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();

        // using .Equal() method
        Console.WriteLine("Campare using in-built method: "+ (str1.Equals(str2)));
        Console.WriteLine("Campare using method: "+(Campare(str1 ,str2)));


    }
    static bool Campare(string s1,string s2)
    {
        for(int i = 0; i < s1.Length; i++)
        {
            if (s1[i]!= s2[i])
            {
                return false;
            }
        }
        return true;
    }
}