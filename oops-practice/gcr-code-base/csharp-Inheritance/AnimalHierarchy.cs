using System;
class Animal
{
    string name;
    int age;
    public Animal(string name, int age)
    {
        this.name=name;
        this.age=age;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }
    public override void MakeSound()
    {
        Console.WriteLine("Dog makes sound");
    }
}
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }
    public override void MakeSound()
    {
        Console.WriteLine("Cat makes sound");
    }
}  
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age)
    {
    }
    public override void MakeSound()
    {
        Console.WriteLine("Bird makes sound");
    }
}
class AnimalHierarchy
{
    public static void Main()
    {
        Animal myDog = new Dog("dog", 3);
        Animal myCat = new Cat("cat", 2);
        Animal myBird = new Bird("bird", 1);

        myDog.MakeSound();  // Output: Dog barks
        myCat.MakeSound();  // Output: Cat meows
        myBird.MakeSound(); // Output: Bird chirps
    }
} 