namespace RailwayReservationSystem;
using System;
class ReservationsUtiltityImpl
{
    private  Passenger[] confirmSheet=new Passenger[3];

    public Passenger[] ConfirmSheet
    {
        set{confirmSheet=value;}
        get{return confirmSheet;}
    }

    private  Passenger[] seniorCitizens=new Passenger[2];

    public Passenger[] SeniorCitizens
    {
        set{seniorCitizens=value;}
        get{return seniorCitizens;}
    }
    private Passenger[] waitingList=new Passenger[10];

    public Passenger[] WaitingList
    {
        set{waitingList=value;}
        get{return waitingList;}
    }

    int ConfirmSheetCount=0;
    int SeniorCitizensCount=0;
    int WaitingListCount=0;

    public void BookTicket(Passenger passenger)
    {
        if (ConfirmSheetCount < ConfirmSheet.Length)
        {
            ConfirmSheet[ConfirmSheetCount++]=passenger;
            Console.WriteLine(passenger.ToString()+"\nYour sheet is confirmed");
            return;
        }
        else
        {
            if (passenger.Age > 60)
            {
                if (SeniorCitizensCount < SeniorCitizens.Length)
                {
                    SeniorCitizens[SeniorCitizensCount++]=passenger;
                    Console.WriteLine(passenger.ToString()+"\nYour sheet is in SeniorCitizens Waiting List");
                    return;
                }
            }
            else
            {
                if (WaitingListCount < WaitingList.Length)
                {
                    WaitingList[WaitingListCount++]=passenger;
                    Console.WriteLine(passenger.ToString()+"\nYour sheet is in waiting list");
                    return;
                }
            }
        }
        Console.WriteLine("Train is full");
    }

    public void CancelTicket(string id)
    {
        for(int i = 0; i < ConfirmSheet.Length; i++)
        {
            if(ConfirmSheet[i]!=null && ConfirmSheet[i].Id.Equals(id,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(ConfirmSheet[i].ToString()+"\nYour sheet is cancelled");
                for(int j=i; j < ConfirmSheet.Length-1; j++)
                {
                    ConfirmSheet[j]=ConfirmSheet[j+1];
                }  
                ConfirmSheet[ConfirmSheet.Length-1]=null;
                ConfirmSheetCount--;
            }
        }
        if (ConfirmSheetCount < ConfirmSheet.Length)
        {
           if(SeniorCitizensCount >0)
            {
                confirmSheet[ConfirmSheetCount++]=SeniorCitizens[0];
                Console.WriteLine(SeniorCitizens[0].ToString()+"\nYour sheet is confirmed");
                for(int i = 0; i < SeniorCitizens.Length-1; i++)
                {
                    SeniorCitizens[i]=SeniorCitizens[i+1];
                }
                SeniorCitizens[SeniorCitizens.Length-1]=null;
                SeniorCitizensCount--;
            }
            else
            {
                
                confirmSheet[ConfirmSheetCount++]=WaitingList[0];
                Console.WriteLine(WaitingList[0].ToString()+"\nYour sheet is confirmed");

                for(int i = 0; i < WaitingList.Length-1; i++)
                {
                    WaitingList[i]=WaitingList[i+1];
                }
                WaitingList[WaitingList.Length-1]=null;
                WaitingListCount--;
            }
        }
        
    }
    public void DisplayTicket()
    {
        for(int i = 0; i < ConfirmSheet.Length; i++)
        {
            if (ConfirmSheet[i] != null)
            {
                Console.WriteLine(ConfirmSheet[i].ToString()+" Sheet Confirmed");
            }
            else
            {
                break;
            }
        }
        for(int i = 0; i < SeniorCitizens.Length; i++)
        {
            if (SeniorCitizens[i] != null)
            {
                Console.WriteLine(SeniorCitizens[i].ToString()+" Sheet inSeniorCitizens List");
            }
            else
            {
                break;
            }
        }
        for(int i = 0; i < WaitingList.Length; i++)
        {
            if (WaitingList[i] != null)
            {
                Console.WriteLine(WaitingList[i].ToString()+" Sheet in Waiting List");
            }
            else
            {
                break;
            }
        }
    }
}