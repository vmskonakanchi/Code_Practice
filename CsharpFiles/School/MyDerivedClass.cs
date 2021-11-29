using System;
using School;
public class MyDerivedClass : MyClass
{
    // public static void Main(string[] args)
    // {
    //     MyDerivedClass myDerivedClass = new MyDerivedClass();
    //     Console.WriteLine(myDerivedClass.GetString());
    // }
    protected override string GetString()
    {
        return Containedstring + "  output from derived class";
    }
}