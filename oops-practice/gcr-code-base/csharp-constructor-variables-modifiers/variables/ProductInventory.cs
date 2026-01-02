using System;
class Product{
    string productName;
    int price;
    static int totalProduct=0;
    public Product(string productName,int price){
        this.productName=productName;
        this.price=price;
        totalProduct++; 
    }   
    public void DisplayProductDetails(){
        Console.WriteLine("PRODUCT NAME : "+productName);
        Console.WriteLine("PRICE : "+price);
        Console.WriteLine("-----------------------");
    }
    public static void TotalProduct(){
        Console.WriteLine("TOTAL PRODUCT : "+totalProduct);
    }
}
class ProductInventry{
    public static void Main(){
        while(true){
            Console.WriteLine("ENTER 1 FOR ADD PRODUCT");
            Console.WriteLine("ENTER 0 For EXITING THE PROGRAM");
            int choose=Convert.ToInt32(Console.ReadLine());

            if(choose ==0){
                Console.WriteLine("PROGRAM HAS BEEN EXITED");
                break;
            }

            Console.WriteLine("ENTER THE PRODUCT DETAILS ");
        
            Console.WriteLine("ENTER THE PRODUCT NAME");
            string name=Console.ReadLine();

            Console.WriteLine("ENTER THE PRICE OF THE PRODUCTE");
            int price=Convert.ToInt32(Console.ReadLine());

            Product product=new Product(name,price);
            product.DisplayProductDetails();

            
        }

        // Product.TotalProduct();


        



    }
}