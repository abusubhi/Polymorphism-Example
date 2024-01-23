using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Base class to prit");
    }
}

public class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("Derived class to Print");
    }
}




public class Program
{
    public static void  Main(string[] args)
    {
        BaseClass B = new DerivedClass();
        B.Print();

        //BaseClass D = new BaseClass();
        //((BaseClass)D).Print();


    }
}