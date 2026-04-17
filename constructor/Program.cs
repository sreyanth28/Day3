using System;
class Student
{
    public string name;
    public Student(string n)
    {
        name = n;
    }
}
class Program
{   
    static void Main()
    {
        Student s =new Student("Sreyanth");
        Console.WriteLine(s.name);
    }
}

