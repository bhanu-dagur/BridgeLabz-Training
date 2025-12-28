 using System;
 class NullReferenceProgram
{
      static void Main(String[] args)
    {
        string s=null;
        CheckNullReference(s);

    }
    static void CheckNullReference(string s)
    {
         try
        {
            // null exception because string is empty;
            int length=s.Length;
            Console.WriteLine("String length is :"+length);
        }
        //The catch block is used to handle runtime exceptions.
        //It executes when an exception occurs in the try block and 
        // prevents the program from crashing by providing an alternative flow.

        // e is the object that give the information of the error like error type, message,line etc
        // general catch catch{}
        
        catch(NullReferenceException e)

        {
            Console.WriteLine("null reference exception ocurred");
            Console.WriteLine(e.Message);
            
        }
    }
}