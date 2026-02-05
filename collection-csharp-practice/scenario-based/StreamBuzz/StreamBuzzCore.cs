using System;
using System.Collections.Generic;

class CreatorStats
{
    public string CreatorName;
    public double[] WeeklyLikes;

    public CreatorStats(string name,double [] likes)
    {
        CreatorName=name;
        WeeklyLikes=likes;
    }

    public static List<CreatorStats> EngagementBoard=new List<CreatorStats>();
}

class StreamBuzzCore
{
    public void RegistorCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
        Console.WriteLine("Creator Registed Sucessfully");
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records,double likeThreshold)
    {
        Dictionary<string,int> topCreators=new Dictionary<string,int>();
        foreach(var record in records)
        {
            int topWeakCount=0;
            foreach(double weeklyLike in record.WeeklyLikes)
            {
                if (weeklyLike >= likeThreshold)
                {
                    topWeakCount++;
                }
            }

            if (topWeakCount > 0)
            {
                topCreators.Add(record.CreatorName,topWeakCount);
            }

            
        }
        return topCreators;
    }

    public double CalculateAverageLikes()
    {
        // double totalLikes=0;
        // foreach (CreatorStats record in CreatorStats.EngagementBoard)
        // {
        //     double weeklyLikes=0;
        //     for(int i=0;i < record.WeeklyLikes.Length; i++){
        //         weeklyLikes+=record.WeeklyLikes[i];

        //     }
        //     totalLikes+=weeklyLikes;
        // }

        // return totalLikes/CreatorStats.EngagementBoard[0].WeeklyLikes.Length;

        double totalLikes=0;
        int weekCount=0;
        foreach(CreatorStats record in CreatorStats.EngagementBoard)
        {
            foreach(double like in record.WeeklyLikes)
            {
                totalLikes+=like;
                weekCount++;
            }
            
        }

        double average=totalLikes/weekCount;

        return average;
    }


    public static void Main(string [] args)
    {
        StreamBuzzCore buzz= new StreamBuzzCore();
        while (true)
        {
            Console.WriteLine("\n1. Registor Creator");
            Console.WriteLine("2. Get Top Post Counts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");

            int choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Creator Name:");
                    string name=Console.ReadLine();
                    Console.WriteLine("Enter four Weekly Likes:");
                    double[] likes=new double[4];
                    for(int i = 0; i < 4; i++)
                    {
                        likes[i]=Convert.ToDouble(Console.ReadLine());
                    } 
                    CreatorStats record=new CreatorStats(name,likes);           
                    buzz.RegistorCreator(record);
                    break;
                case 2:
                    Console.WriteLine("Enter Like Threshold:");
                    double likeThreshold=Convert.ToDouble(Console.ReadLine());
                    Dictionary<string,int> topCreators=buzz.GetTopPostCounts(CreatorStats.EngagementBoard,likeThreshold);
                    if(topCreators.Count==0){
                        Console.WriteLine("No creators found");
                        break;
                    }
                    foreach(string names in topCreators.Keys)
                    {
                        Console.WriteLine(names+" - "+topCreators[names]);
                    }
                    break;
                case 3:
                    double ans=buzz.CalculateAverageLikes();
                    Console.WriteLine("Average Likes: "+ans);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}