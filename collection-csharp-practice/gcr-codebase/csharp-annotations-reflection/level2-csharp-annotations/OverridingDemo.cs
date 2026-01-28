using System;

class Animal
{
    // Step 1: Virtual method in parent class
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // Step 2: Override method in child class
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class OverridingDemo
{
    static void Main()
    {
        // Step 3: Create Dog object
        Dog dog = new Dog();

        // Step 4: Call overridden method
        dog.MakeSound();
    }
}
