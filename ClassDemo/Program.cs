using System;

// Class definition
class ClassDemo
{
    // Fields
    public string Name;
    public int Id;

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Id: " + Id);
    }
}

class Program
{
    static void Main()
    {
        // Creating object
        ClassDemo s1 = new ClassDemo();

        // Assigning values
        s1.Name = "John";
        s1.Id = 101;

        // Calling method
        s1.DisplayInfo();
    }
}