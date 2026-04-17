using System;
class Car
{
    public string brand;
}
class Program
{
    static void Main()
    {
        Car c1 = new Car();
        c1.brand = "Tata";
        Console.WriteLine(c1.brand);
    }
}