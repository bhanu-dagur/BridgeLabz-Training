class Areaofrectangle
{
    public static void Main()
    {
        double length,width,area;

        Console.Write("Enter length of rect: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of rect: ");
        width = Convert.ToDouble(Console.ReadLine());

        area= (length + width)*2;

        Console.WriteLine("Area of rect : " + area);
    }
}
