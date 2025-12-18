class Powercalculation
{
    static void Main()
    {
        double baseval, power,result;

        Console.Write("Enter baseval number: ");
        baseval = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter power: ");
        power = Convert.ToDouble(Console.ReadLine());

        result = Math.Pow(baseval, power);

        Console.WriteLine("Result = " + result);
    }
}
