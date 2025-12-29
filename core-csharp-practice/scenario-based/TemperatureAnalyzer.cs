using System;

class TemperatureAnalyzer
{
    // Days array
    static string[] days =
    {
        "Sunday","Monday","Tuesday","Wednesday",
        "Thursday","Friday","Saturday"
    };

    public static void Main()
    {
        TemperatureAnalyzer obj = new TemperatureAnalyzer();
        float[,] data = obj.Input();

        Console.WriteLine("Hottest Day is: " + obj.FindHottestDay(data));
        Console.WriteLine("Coldest Day is: " + obj.FindColdestDay(data));

        obj.AverageTemperature(data);
    }

    // Input temperatures
    public float[,] Input()
    {
        float[,] temeratureData = new float[7, 24];
        Random r = new Random();

        for (int day = 0; day < 7; day++)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                temeratureData[day, hour] = r.Next(1, 50);
            }
        }
        return temeratureData;
    }

    // Find hottest day (highest average temperature)
    public string FindHottestDay(float[,] temp)
    {
        int hottestDay = 0;
        float maximumTemp = 0;

        for (int day = 0; day < 7; day++)
        {
            float totalTemp = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                totalTemp += temp[day, hour];
            }

            float averageTemp = totalTemp / 24;

            if (averageTemp > maximumTemp)
            {
                maximumTemp = averageTemp;
                hottestDay = day;
            }
        }
        return days[hottestDay];
    }

    // Find coldest day (lowest average temperature)
    public string FindColdestDay(float[,] temp)
    {
        int coldDay = 0;
        float minimumTemp = float.MaxValue;

        for (int day = 0; day < 7; day++)
        {
            float totalTemp = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                totalTemp += temp[day, hour];
            }

            float averageTemp = totalTemp / 24;

            if (averageTemp < minimumTemp)
            {
                minimumTemp = averageTemp;
                coldDay = day;
            }
        }
        return days[coldDay];
    }

    // Average temperature of each day
    public void AverageTemperature(float[,] temp)
    {
        for (int day = 0; day < 7; day++)
        {
            float totalTemp = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                totalTemp += temp[day, hour];
            }

            float averageTemp = totalTemp / 24;
            Console.WriteLine("Average temperature of " + days[day] + " is " + averageTemp);
        }
    }
}
