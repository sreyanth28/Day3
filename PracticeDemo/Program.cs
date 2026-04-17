using System;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Dept {  get; set; }

    public Student(int id, string name, int age, string dept)
    {
        Id = id;
        Name = name;
        Age = age;
        Dept = dept;
    }
    public void Display()
    {
        Console.WriteLine("Id: "+Id);
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Age: "+Age);
        Console.WriteLine("Dept: "+Dept);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Sreyanth", 21, "CSE");
            Student s2 = new Student(2, "sreyi", 22, "Ai");
            s1.Display();
            s2.Display();
        }
    }
}