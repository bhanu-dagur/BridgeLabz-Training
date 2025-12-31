using System;
class MathOperation{
    static void Main(){
        MathOperation mo=new MathOperation();
        mo.choose();
    }
    public void choose(){
        while(true){
            Console.WriteLine("\n CHOOSE OPERATIONS:");
            Console.WriteLine("1. FACTORIAL");
            Console.WriteLine("2. CHECK PRIME");
            Console.WriteLine("3. GCD");
            Console.WriteLine("4. FIBONACCI SERIES");
            Console.WriteLine("5. EXIT");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Facotorial();
                    break;
                case 2:
                    CheckPrime();
                    break;
                case 3:
                    GCD();
                    break;
                case 4:
                    Fibonacci();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("INVALID CHOICE.");
                    break;
            }
        }
    }
    // Find the factorial of a number
    public  void Facotorial(){
        Console.WriteLine("ENTER A NUMBER TO FIND FACTORIAL:");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact=1;
        for(int i=1;i<=num;i++){
            fact*=i;
        }
        Console.WriteLine("FACTORIAL OF THE NUMBER : "+num+ " is "+fact);
        Console.WriteLine("==========================");
    }

    // Check if a number is prime
    public void CheckPrime(){
        Console.WriteLine("ENTER A NUMBER TO CHECK PRIME: ");
        int num=Convert.ToInt32(Console.ReadLine());
        bool isPrime=true;
        for(int i=2;i<=num/2;i++){
            if(num%i==0){
                isPrime=false;
                break;
            }
        }
        if(isPrime && num>1){
            Console.WriteLine(num+" Is A PRIME NUMBER");
        }else{
            Console.WriteLine(num+" IS NOT A PRIME NUMBER");
        }
        Console.WriteLine("==========================");
    
    }

    public void GCD(){
        Console.WriteLine("ENTER TWO NUMBERS TO FIND GCD:");
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        while(b!=0){
            int temp=b;
            b=a%b;
            a=temp;
        }
        Console.WriteLine("GCD IS: "+a);
        Console.WriteLine("==========================");

    }

    public  void Fibonacci(){
        Console.WriteLine("ENTER THE NUMBER OF TERMS:");
        int terms=Convert.ToInt32(Console.ReadLine());
        int a=0,b=1;
        Console.Write("FIBONACCI SERIES: ");
        for(int i=1;i<=terms;i++){
            Console.Write(a+" ");
            int next=a+b;
            a=b;
            b=next;
        }
        Console.WriteLine("\n==========================");
    }
    
}