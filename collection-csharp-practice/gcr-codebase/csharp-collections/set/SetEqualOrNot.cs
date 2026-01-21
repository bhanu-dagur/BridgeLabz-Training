using System;
using System.Collections.Generic;

class SetEqualOrNot
{
    public static void Main()
    {
        HashSet<int> set1=new HashSet<int>(){1,2,3,4,5};
        HashSet<int> set2=new HashSet<int>(){1,2,3,4,5};

        if(set1.SetEquals(set2))
        {
            Console.WriteLine("The sets are equal");
        }
        else
        {
            Console.WriteLine("The sets are not equal");
        }
    }
}
