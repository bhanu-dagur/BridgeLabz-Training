using System;
class CafeterialApp{
    static string [] menu={"Pizza","Burger","Pasta","Salad","Soda","Tea","Coffee","Juice", "Dessert", "Soup"};
    static  void Main(){
        Choose();
    }
    static  void DisplayMenu(){
        Console.WriteLine("MENU LIST");
        for(int i=0;i<menu.Length;i++){
            Console.Write(menu[i]+" ");
        }
        Console.WriteLine("\n====================================================================");

    }
    static  void GetMenuByIndex(){ 
        while(true){
            Console.WriteLine("\nPLEASE ORDERED MENU BY ENTER INDEX");
            for(int i=0;i<menu.Length;i++){
                Console.WriteLine(menu[i]+": At the index "+i);
            }
            Console.WriteLine("Exit : At the index of 10");
            int index=Convert.ToInt32(Console.ReadLine());
            if(index>=0 && index<=9){
                Console.WriteLine("YOUR ORDERED MENU IS "+menu[index]);
            }
            else if(index==10){
                break;
            }
            else{
                Console.WriteLine("YOU HAVE ENTERED INVALID INDEX");
            }
        }
    }
    static void Choose(){
        while(true){
        Console.WriteLine("PLEASE SELECT OPTION");
        Console.WriteLine("1. DISPLAY MENU");
        Console.WriteLine("2. ORDERED MENU");
        Console.WriteLine("3. EXIT MENU");
        int input=Convert.ToInt32(Console.ReadLine());
        if(input==1){
            DisplayMenu();
        }
        else if(input==2){
            GetMenuByIndex();
        }
        else if(input==3){
            Console.WriteLine("THANKS FOR VISITING");
            break;
        }
        else {
            Console.WriteLine("PLEASE INSERTED CORRECT INPUT");
        }
        }
    }
}
