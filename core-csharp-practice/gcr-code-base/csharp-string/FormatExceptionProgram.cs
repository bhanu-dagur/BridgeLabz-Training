using System;
class FormatExceptionProgram
{
    static void  Main()
    {
        
        try{
            string s="bhanu";
            int value=int.Parse(s);
            Console.WriteLine(value);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
}