using System;

class Student
{
    public int Id;
    public string Name;
    public int Marks;

    public Student(int id, string name, int marks)
    {
        Id = id;
        Name= name;
        Marks=  marks;
    }
    public void Display()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Marks: "+Marks);
        Console.WriteLine("Passed: " + Pass());
    }
    public string Pass()
    {
        if(Marks>35)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
}
class Program
{
    static void Main()
    {
        Student s1 = new Student(1, "Sreyanth", 86);
        s1.Display();
    }
}