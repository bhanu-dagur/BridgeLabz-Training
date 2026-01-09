using System;
using System.Collections.Generic;
interface ITrackable
{
    double CalculateCaloriesBurned();
    string GetWorkoutSummary();
}

class UserProfile
{
    // Encapsulation
    private int userId;
    private string userName;
    private int age;

    public UserProfile(int userId, string userName, int age)
    {
        this.userId = userId;
        this.userName = userName;
        this.age = age;
    }

    public void DisplayUser()
    {
        Console.WriteLine("User ID   : " + userId);
        Console.WriteLine("User Name : " + userName);
        Console.WriteLine("Age       : " + age);
    }
}
// Base workout class (abstract)
abstract class Workout : ITrackable
{
    protected string workoutName;
    protected int duration; 

    public Workout(string workoutName, int duration)
    {
        this.workoutName = workoutName;
        this.duration = duration;
    }

    // Abstract / Polymorphic behavior
    public abstract double CalculateCaloriesBurned();

    public string GetWorkoutSummary()
    {
        return workoutName + " for " + duration + " minutes";
    }
}

// CARDIO WORKOUT 
class CardioWorkout : Workout
{
    public CardioWorkout(int duration)
        : base("Cardio Workout", duration)
    {
    }

    public override double CalculateCaloriesBurned()
    {
        // Cardio burns more calories
        return duration * 8.5;
    }
}
// STRENGTH WORKOUT
class StrengthWorkout : Workout
{
    public StrengthWorkout(int duration)
        : base("Strength Workout", duration)
    {
    }

    public override double CalculateCaloriesBurned()
    {
        return duration * 6.0;
    }
}

class FitTrackApp
{
    static void Main()
    {
        // User
        UserProfile user = new UserProfile(101, "Bhanu Dagur", 22);
        user.DisplayUser();

        Console.WriteLine("---------------------------");

        // Polymorphism: base class reference
        List<Workout> workouts = new List<Workout>
        {
            new CardioWorkout(30),
            new StrengthWorkout(40),
            new CardioWorkout(20)
        };

        foreach (Workout workout in workouts)
        {
            Console.WriteLine(workout.GetWorkoutSummary());
            Console.WriteLine("Calories Burned: " + workout.CalculateCaloriesBurned());
            Console.WriteLine("---------------------------");
        }
    }
}
