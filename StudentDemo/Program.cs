using System;
class StudentDemo
{
    public string Name;
    public int Id;
    public StudentDemo(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public void Display()
    {
        Console.WriteLine("Name: "+ Name);
        Console.WriteLine("Id: " + Id);
    }
    public void UpdateName(String newName)
    {
        Name = newName;
    }
    public void UpdateId(int newId)
    {
        Id = newId;
    }
}
class Program
{ 
    static void Main()
    {
        StudentDemo s1=new StudentDemo("sreyanth",1);
        StudentDemo s2 = new StudentDemo("sreyi", 2);
        s1.Display();
        s2.Display();
        s1.UpdateName("Mike");
        s1.UpdateId(3);
        s2.UpdateName("Nice");
        s2.UpdateId(4);
        Console.WriteLine("\nUpdated are: ");
        s1.Display();
        s2.Display();
    }
}

