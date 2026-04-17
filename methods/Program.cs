using System;
class Car
{
    public string brand;
    public void show()
    {
        Console.WriteLine("Name: " + brand);
    }
}
class Program
{   
    static void Main(string[] args)
    {
        Car c1=new Car();
        c1.brand = "Tata";
        c1.show();
    }
}

