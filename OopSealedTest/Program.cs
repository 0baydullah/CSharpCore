using System;

public sealed class Cat
{

}

public class PetCat : Cat // compile time error
{

}
public class Animal
{
    public  virtual void eat() { Console.WriteLine("eating..."); }
    public virtual void run() { Console.WriteLine("running..."); }

}
public class Dog : Animal
{
    public override void eat() { Console.WriteLine("eating bread..."); }
    public sealed override void run()
    {
        Console.WriteLine("running very fast...");
    }
}
public class BabyDog : Dog
{
    public override void eat() { Console.WriteLine("eating biscuits..."); }
    public override void run() { Console.WriteLine("running slowly..."); } // compile time error 
}
public class TestSealed
{
    public static void Main()
    {
        BabyDog d = new BabyDog();
        d.eat();
        d.run();
    }
}