using System;
class CalculateArea{
    private double radius;
    public CalculateArea(double radius){
        this.radius=radius;
    }
    public void Area(){
        Console.Write("Area of circle is : ");
        double area=3.14*radius*radius;
        Console.WriteLine(area);
    }
}
class AreaOfCircle{
    public static void Main(){
        Console.WriteLine("ENTER THE RADIUS OF THE CIRCLE");
        double radius=Convert.ToDouble(Console.ReadLine());
        CalculateArea obj=new CalculateArea(radius);
        obj.Area()
    }
    
}